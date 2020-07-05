using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizadorChurrasco
{
    public partial class FrmConvidadoPesquisar : Form
    {
        // String de conexão com o banco de dados.
        SqlConnection conexao = new SqlConnection(@"Data Source=BEB0560097W10-1\SQLEXPRESS;Initial Catalog=bdorganizadorchurrasco;User ID=sa;Password=sa");

        public FrmConvidadoPesquisar()
        {
            InitializeComponent();

            // Ao abrir a tela, carrega o filtro "todas" por padrão.
            CmbFiltro.SelectedIndex = 0;

            CarregaConvidados();
        }

        void CarregaConvidados()
        {
            try
            {
                conexao.Open();
                string instrucao;

                if (CmbFiltro.SelectedItem.ToString() == "todas")
                {
                    instrucao = "SELECT * FROM tbconvidados WHERE nome LIKE '%" + TxtPesquisa.Text + "%'";
                }
                else if (CmbFiltro.SelectedItem.ToString() == "confirmada")
                {
                    instrucao = "SELECT * FROM tbconvidados WHERE nome LIKE '%" +  TxtPesquisa.Text + "%' AND presenca_confirmada = 'SIM'";
                }
                else
                {
                    instrucao = "SELECT * FROM tbconvidados WHERE nome LIKE '%" +   TxtPesquisa.Text + "%' AND presenca_confirmada = 'NÃO'";
                }

                SqlCommand comando = new SqlCommand(instrucao, conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvConvidados.DataSource = dt;
                // Conta a quantidade de linhas no DataGridView.
                lblQtdeConvidados.Text = DgvConvidados.RowCount + " convidados listados pela consulta";

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

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaConvidados();
        }

        private void CmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregaConvidados();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            if (DgvConvidados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Você precisa selecionar um CONVIDADO da lista!", "Op's!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Montando o objeto com os dados do convidado selecionado para passar para a outra tela.
                Convidado convidado = new Convidado();

    convidado.Codigo = Convert.ToInt32(DgvConvidados.CurrentRow.Cells["codigo"].Value);
    convidado.Nome = DgvConvidados.CurrentRow.Cells["nome"].Value.ToString();
    convidado.QtdeAgregados = Convert.ToInt32(DgvConvidados.CurrentRow.Cells["qtdeagregados"].Value);
    convidado.Celular = DgvConvidados.CurrentRow.Cells["celular"].Value.ToString();
    convidado.Email = DgvConvidados.CurrentRow.Cells["email"].Value.ToString();
    convidado.Observacoes = DgvConvidados.CurrentRow.Cells["observacoes"].Value.ToString();
    convidado.PresencaConfirmada = DgvConvidados.CurrentRow.Cells["presenca"].Value.ToString();

                FrmConvidados frmConvidados = new FrmConvidados(convidado);
                frmConvidados.ShowDialog();
            }
        }

        private void FrmConvidadoPesquisar_Activated(object sender, EventArgs e)
        {
            CarregaConvidados();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FrmConvidados frmConvidados = new FrmConvidados(null);
            frmConvidados.ShowDialog();
        }
    }
}
