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
    public partial class FrmConvidados : Form
    {
        // Para saber se o usuário quer editar ou cadastrar um novo convidado.
        bool editar = false;
        int codigoConvidado;

        public FrmConvidados(Convidado convidado)
        {
            InitializeComponent();

            if (convidado == null)
            {
                // Não carrega dados do convidado, porque vai cadastrar um novo.
                LblTitulo.Text = "Cadastro de Convidado";
                btnSalvar.Text = "Novo";
            }
            else
            {
                // Vai carregar os dados do convidado na tela.
                LblTitulo.Text = "Detalhes do Convidado";
                btnSalvar.Text = "Editar";
                editar = true;

                codigoConvidado = convidado.Codigo;
                txtNome.Text = convidado.Nome;
                txtEmail.Text = convidado.Email;
                nudQuantidade.Value = convidado.QtdeAgregados;
                mktCelular.Text = convidado.Celular;
                rctObservacoes.Text = convidado.Observacoes;

                if (convidado.PresencaConfirmada == "SIM")
                    rdbSim.Checked = true;
                else
                    rdbNao.Checked = true;
            }
        }

        // String de conexão com o banco de dados.
        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-MCQJPQB;Initial Catalog=dbCurrasco;User ID=sa;Password=1234");

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           if(editar == true)
            {
                //Chamar o método de editar
                Editar();
            }
            else
            {
                Cadastrar();
            }
        }

        void Cadastrar()
        {
            if (btnSalvar.Text == "Novo")
            {
                btnSalvar.Text = "Salvar";
                pnlDados.Enabled = true;
                txtNome.Focus();
            }
            else
            {
                if (CamposValido())
                {
                    // Após validar, armazenamos no objeto convidado as informações.
                    Convidado convidado = new Convidado();
                    convidado.Nome = txtNome.Text;
                    convidado.QtdeAgregados = (int)nudQuantidade.Value;
                    convidado.Celular = mktCelular.Text;
                    convidado.Email = txtEmail.Text;
                    convidado.Observacoes = rctObservacoes.Text;

                    // Verifica se o RadionButton SIM está marcado.
                    if (rdbSim.Checked)
                        convidado.PresencaConfirmada = "SIM";
                    else
                        convidado.PresencaConfirmada = "NÃO";

                    // Nesta etapa, os dados do convidado está pronto para ir ao banco de dados.
                    try
                    {
                        string instrucao = "INSERT INTO tbconvidados (nome, qtde_agregados, celular, email, observacoes, presenca_confirmada) VALUES (@nome, @qtde_agregados, @celular, @email, @observacoes, @presenca_confirmada)";

                        SqlCommand command = new SqlCommand(instrucao, conexao);
                        command.Parameters.AddWithValue("@nome", convidado.Nome);
                        command.Parameters.AddWithValue("@qtde_agregados", convidado.QtdeAgregados);
                        command.Parameters.AddWithValue("@celular", convidado.Celular);
                        command.Parameters.AddWithValue("@email", convidado.Email);
                        command.Parameters.AddWithValue("@observacoes", convidado.Observacoes);
                        command.Parameters.AddWithValue("@presenca_confirmada", convidado.PresencaConfirmada);
                        command.CommandType = CommandType.Text;

                        conexao.Open();
                        int retorno = command.ExecuteNonQuery();

                        if (retorno > 0)
                            MessageBox.Show(convidado.Nome.ToUpper() + " incluído (a) na lista de convidados com sucesso!");

                        // Retorna a tela para o padrão de abertura.
                        LimparCampos();

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


        void Editar()
        {
            if (btnSalvar.Text == "Editar")
            {
                btnSalvar.Text = "Salvar";
                pnlDados.Enabled = true;
                txtNome.Focus();
            }
            else
            {
                if (CamposValido())
                {
                    // Após validar, armazenamos no objeto convidado as informações.
                    Convidado convidado = new Convidado();
                    convidado.Nome = txtNome.Text;
                    convidado.QtdeAgregados = (int)nudQuantidade.Value;
                    convidado.Celular = mktCelular.Text;
                    convidado.Email = txtEmail.Text;
                    convidado.Observacoes = rctObservacoes.Text;

                    // Verifica se o RadionButton SIM está marcado.
                    if (rdbSim.Checked)
                        convidado.PresencaConfirmada = "SIM";
                    else
                        convidado.PresencaConfirmada = "NÃO";

                    // Nesta etapa, os dados do convidado está pronto para ir ao banco de dados.
                    try
                    {
                        string instrucao = "UPDATE tbconvidados SET nome = @nome, qtde_agregados = @qtde_agregados, celular = @celular, email = @email, observacoes = @observacoes, presenca_confirmada = @presenca_confirmada WHERE codigo = @codigo";

                        SqlCommand command = new SqlCommand(instrucao, conexao);
                        command.Parameters.AddWithValue("@codigo", codigoConvidado);
                        command.Parameters.AddWithValue("@nome", convidado.Nome);
                        command.Parameters.AddWithValue("@qtde_agregados", convidado.QtdeAgregados);
                        command.Parameters.AddWithValue("@celular", convidado.Celular);
                        command.Parameters.AddWithValue("@email", convidado.Email);
                        command.Parameters.AddWithValue("@observacoes", convidado.Observacoes);
                        command.Parameters.AddWithValue("@presenca_confirmada", convidado.PresencaConfirmada);
                        command.CommandType = CommandType.Text;

                        conexao.Open();
                        int retorno = command.ExecuteNonQuery();

                        if (retorno > 0)
                            MessageBox.Show(convidado.Nome.ToUpper() + " atualizado (a) na lista de convidados com sucesso!");

                        Close();

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

        bool CamposValido()
        {
            // Limpa tirando os ícones de erro da tela casou houver.
            errorProviderValidacao.Clear();

            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProviderValidacao.SetError(txtNome, "Informe o nome do convidado");
                // Posiciona o ícone de erro dentro do controle.
                errorProviderValidacao.SetIconPadding(txtNome, -20);
                
                // Posiciona o cursor neste campo para o usuário preencher.
                txtNome.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(mktCelular.Text.Replace("-","").Replace("_","").Replace("(","").Replace(")","")))
            {
                errorProviderValidacao.SetError(mktCelular, "Informe o celular do convidado");
                // Posiciona o ícone de erro dentro do controle.
                errorProviderValidacao.SetIconPadding(mktCelular, -20);

                // Posiciona o cursor neste campo para o usuário preencher.
                mktCelular.Focus();
                return false;
            }

            if(mktCelular.Text.Length < 15)
            {
                errorProviderValidacao.SetError(mktCelular, "Número do celular inválido");
                // Posiciona o ícone de erro dentro do controle.
                errorProviderValidacao.SetIconPadding(mktCelular, -20);

                // Posiciona o cursor neste campo para o usuário preencher.
                mktCelular.Focus();
                return false;

            }

            return true;
        }

        private void rctObservacoes_TextChanged(object sender, EventArgs e)
        {
            lblQtdeCaracteres.Text = rctObservacoes.TextLength + "/200 caracteres";

            if (rctObservacoes.TextLength == 200)
               lblQtdeCaracteres.ForeColor = Color.Red;
            else
               lblQtdeCaracteres.ForeColor = Color.Black;                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        void LimparCampos()
        {
            btnSalvar.Text = "Novo";
            pnlDados.Enabled = false;
            txtNome.Text = "";
            nudQuantidade.Value = 1;
            mktCelular.Text = "";
            txtEmail.Text = "";
            rctObservacoes.Clear();
            rdbNao.Checked = true;
        }
    }
}
