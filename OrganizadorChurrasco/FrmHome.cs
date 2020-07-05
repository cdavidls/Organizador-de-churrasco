using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace OrganizadorChurrasco
{
    public partial class FrmHome : Form
    {
        // Variaveis de Escopo Global.
        decimal valorTotal = 0;
        int qtdeItensPedentes = 0;
        int diasRestantesChurrasco = 0;

        // String de conexão com o banco de dados.
        SqlConnection conexao = new SqlConnection(@"Data Source=BEB0560097W10-1\SQLEXPRESS;Initial Catalog=bdorganizadorchurrasco;User ID=sa;Password=sa");


        public FrmHome()
        {
            InitializeComponent();

            // Muda o visual do Tooltip.
            TltMensagem.ToolTipIcon = ToolTipIcon.Info;
            TltMensagem.IsBalloon = true;


            // Carrega os produtos da tabela caso tiver.
            CarregaProdutos();              
        }

        void CarregaProdutos()
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM tbproduto", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        // Adiciona na grid os produtos cadastrados no banco de dados.
                        DgvItems.Rows.Add(item["codigo"].ToString(), item["descricao"].ToString(), item["unidademedida"].ToString(), item["quantidade"].ToString(), item["preco"].ToString(), item["total"].ToString(), item["status"].ToString());

                        valorTotal += Convert.ToDecimal(item["total"]);

                        // Verifica se o status é pendente para não contar comprado como total de itens pendente.
                        if (item["status"].ToString() == "pendente")
                        {
                            qtdeItensPedentes++;
                        }                    
                    }
                    TxtValorTotal.Text = valorTotal.ToString("C");                    
                    LblQtdeItensPendentes.Text = qtdeItensPedentes + " itens pendentes";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }    
        }

        private void BtnAdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarItem();
        }

        void AdicionarItem()
        {
            decimal preco = 0;

            if (string.IsNullOrWhiteSpace(TxtItem.Text))
            {
                MessageBox.Show("Você precisa informar o NOME do item!", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtItem.Focus();
            }
            else if (CmbUnidMedida.SelectedIndex < 0)
            {
                MessageBox.Show("Você precisa selecionar uma UNIDADE DE MEDIDA do item!", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbUnidMedida.Focus();
            }
            else if (string.IsNullOrWhiteSpace(TxtPreco.Text))
            {
                MessageBox.Show("Você precisa informar o PREÇO do item!", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPreco.Focus();
            }
            else if (!decimal.TryParse(TxtPreco.Text, out preco))
            {
                MessageBox.Show("Você precisa informar um PREÇO válido!", "Op's!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPreco.Text = "";
                TxtPreco.Focus();
            }
            else
            {                

                // Montando o nosso objeto produto.
                Produto produto = new Produto();
                produto.descricao = TxtItem.Text;
                produto.unidadeMedida = CmbUnidMedida.SelectedItem.ToString();
                produto.quantidade = (int)NudQuantidade.Value;
                produto.preco = preco;
                produto.total = preco * produto.quantidade;
                
                // Atualiza o Valor Total da Lista.
                this.valorTotal += produto.total;
                TxtValorTotal.Text = this.valorTotal.ToString("C");

                // Atualiza a quantidade de items pendentes
                this.qtdeItensPedentes++;
                LblQtdeItensPendentes.Text = this.qtdeItensPedentes + " itens pendentes";

              
                // Limpa campos e volta para o campo item.
                TxtItem.Text = "";
                CmbUnidMedida.SelectedIndex = -1;
                NudQuantidade.Value = 1;
                TxtPreco.Text = "";
                TxtItem.Focus();
                try
                {
                    // Adiciona o item no banco de dados.
                    string instrucao = "INSERT INTO tbproduto (descricao, unidademedida, quantidade, preco, total, status) VALUES ('" + produto.descricao + "','" + produto.unidadeMedida + "','" + produto.quantidade + "','" + produto.preco.ToString().Replace(",",".") + "','" + produto.total.ToString().Replace(",",".") + "','pendente'); SELECT SCOPE_IDENTITY();";

                    SqlCommand comando = new SqlCommand(instrucao, conexao);

                    //Abre a conexão com o banco.
                    conexao.Open();
                    
                    //Executa o comando no banco de dados.
                    int codigo = Convert.ToInt32(comando.ExecuteScalar());

                    // Adiciona o item na lista.
                    DgvItems.Rows.Add(codigo.ToString(), produto.descricao, produto.unidadeMedida, produto.quantidade,
                       produto.preco.ToString("C"), produto.total.ToString("C"), "pendente");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            RemoverItem();  
        }

        void RemoverItem()
        {
            if (DgvItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Você precisa selecionar um ITEM para remover da lista!", "Op's!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Atualiza valor total.
                decimal valorDescontado = Convert.ToDecimal(DgvItems.CurrentRow.Cells["total"].Value.ToString().Replace("R$ ", ""));
                this.valorTotal -= valorDescontado;
                TxtValorTotal.Text = this.valorTotal.ToString("C");

                // Capturando o código do item
                int codigo = Convert.ToInt32(DgvItems.CurrentRow.Cells["codigo"].Value);

                // Atualiza quantidade de itens pendentes.
               this.qtdeItensPedentes--;
                LblQtdeItensPendentes.Text = this.qtdeItensPedentes + " itens pendentes";

                // Remove o item da lista.
                DgvItems.Rows.Remove(DgvItems.CurrentRow);

                // Excluir o item na tabela do banco de dados.
                string instrucao = "DELETE FROM tbproduto WHERE codigo = " + codigo;
                try
                {
                    conexao.Open();
                    SqlCommand comando = new SqlCommand(instrucao, conexao);
                    comando.ExecuteScalar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void DgvItems_DoubleClick(object sender, EventArgs e)
        {
            int indexLinhaSelecionada = DgvItems.SelectedCells[0].RowIndex;
            string status = DgvItems.Rows[indexLinhaSelecionada].Cells["status"].Value.ToString();
            string item = DgvItems.Rows[indexLinhaSelecionada].Cells["item"].Value.ToString();

            int codigo = Convert.ToInt32(DgvItems.Rows[indexLinhaSelecionada].Cells["codigo"].Value);

            if (status == "pendente")
            {
                status = "comprado";
                this.qtdeItensPedentes--;
            }
            else
            {
                status = "pendente";
                this.qtdeItensPedentes++;
            }


            string mensagem = "Mudar o status do produto " + item.ToUpper() + " para " + status.ToUpper() + "? ";

            DialogResult escolha = MessageBox.Show(mensagem, "STATUS DO ITEM", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (escolha == DialogResult.Yes)
            {
                DgvItems.CurrentRow.Cells["status"].Value = status;                
                LblQtdeItensPendentes.Text = this.qtdeItensPedentes + " itens pendentes";

                // Atualiza no banco de dados.
                string instrucao = "UPDATE tbproduto SET status = '" + status + "' WHERE codigo = " + codigo;
                SqlCommand comando = new SqlCommand(instrucao, conexao);
                try
                {
                    conexao.Open();
                    comando.ExecuteScalar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void MtcData_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Captura a data de atual.
            DateTime hoje = DateTime.Today;

            // Captura no calendário o dia do churrasco.
            DateTime diaChurrasco = MtcData.SelectionRange.Start.Date;

            diasRestantesChurrasco = Convert.ToInt32((diaChurrasco - hoje).TotalDays);

            LblDiasRestantes.Text = "Faltam " + diasRestantesChurrasco + " dias";
        }

        private void TxtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                AdicionarItem();
            }
        }

        private void DgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                RemoverItem();
            }
        }

        private void miSairSistema_Click(object sender, EventArgs e)
        {
            //Fecha todas as janelas abertas do nosso sistema.
            Application.Exit();
        }

        private void miCalculadora_Click(object sender, EventArgs e)
        {
            // Abre calculadora do windows
            System.Diagnostics.Process.Start("calc");
        }

        private void miDiasChurrasco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faltam " + diasRestantesChurrasco + " dias para o grande dia do CHURRASCO!", "CONTAGEM REGRESSIVA PARA O CHURRASCO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miCadastrarConvidado_Click(object sender, EventArgs e)
        {
            FrmConvidados frmConvidados = new FrmConvidados(null);
            frmConvidados.ShowDialog();
        }

        private void miPesquisarConvidados_Click(object sender, EventArgs e)
        {
            FrmConvidadoPesquisar frmConvidadoPesquisar = new FrmConvidadoPesquisar();
            this.Hide();
            frmConvidadoPesquisar.ShowDialog();
            this.Show();
        }

        private void miQtdeConvidados_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM tbconvidados", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Quantidade total de convidados: " + dt.Rows.Count);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            
        }

        private void miQuantidadeDeConvidadosConfirmadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM tbconvidados WHERE presenca_confirmada = 'SIM'", conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Quantidade total de convidados confirmados: " + dt.Rows.Count);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
