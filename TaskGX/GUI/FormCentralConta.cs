using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;

namespace TaskGX.GUI
{
    public partial class FormCentralConta : Form
    {
        private int UtilizadorID;
        private string NomeUtilizador;
        public FormCentralConta(int utilizadorID, string nomeUtilizador)
        {
            InitializeComponent();
            UtilizadorID = utilizadorID;
            NomeUtilizador = nomeUtilizador;
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormCentralConta_Load(object sender, EventArgs e)
        {
            this.Text = $"Gestão da Conta - {NomeUtilizador}";
            CarregarDadosUtilizador();
        }
        private void CarregarDadosUtilizador()
        {
            try
            {
                using (var conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();

                    string query = "SELECT ID, Nome FROM Utilizadores WHERE ID = @id";
                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", UtilizadorID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblIdValor.Text = reader["ID"].ToString();
                                lblNomeValor.Text = reader["Nome"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Utilizador não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do utilizador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoVerSenha_Click(object sender, EventArgs e)
        {
            if (this.SenhaAtual.PasswordChar != '*')
            {
                this.SenhaAtual.PasswordChar = '*';
                this.NovaSenha.PasswordChar = '*';
                this.ConfirmarNova.PasswordChar = '*';
            }
            else
            {
                this.SenhaAtual.PasswordChar = '\0';
                this.NovaSenha.PasswordChar = '\0';
                this.ConfirmarNova.PasswordChar = '\0';
            }
        }

        private void BotaoTerminarSessao_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Tem a certeza de que deseja terminar a sessão?", "Terminar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            foreach (Form form in Application.OpenForms)
            {
                if (form is FormTarefas)
                {
                    form.Hide();
                    break;
                }
            }

            var formLogin = Application.OpenForms["Form1"] as Form1;
            if (formLogin != null)
            {
                formLogin.Show();
                formLogin.BringToFront();
                formLogin.WindowState = FormWindowState.Normal;
                try
                {
                    formLogin.Controls["textUsuario"].Text = "";
                    formLogin.Controls["textSenha"].Text = "";
                }
                catch { }
            }
            else
            {
                new Form1().Show();
            }

            this.Hide();
        }

        private void BotaoAlterarSenha_Click(object sender, EventArgs e)
        {
            string senhaAtual = SenhaAtual.Text.Trim();
            string novaSenha = NovaSenha.Text.Trim();
            string confirmarNova = ConfirmarNova.Text.Trim();

            // Validações básicas
            if (string.IsNullOrEmpty(senhaAtual) || string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarNova))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmarNova)
            {
                MessageBox.Show("As novas senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();

                    // Verifica se a senha atual está correta
                    string queryVerificar = "SELECT COUNT(*) FROM Utilizadores WHERE ID=@id AND Senha=SHA2(@senhaAtual, 256)";
                    using (var cmdVerificar = new MySqlCommand(queryVerificar, conexao))
                    {
                        cmdVerificar.Parameters.AddWithValue("@id", UtilizadorID);
                        cmdVerificar.Parameters.AddWithValue("@senhaAtual", senhaAtual);

                        int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                        if (existe == 0)
                        {
                            MessageBox.Show("A senha atual está incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Atualiza a senha com criptografia
                    string queryAtualizar = "UPDATE Utilizadores SET Senha = SHA2(@novaSenha, 256) WHERE ID=@id";
                    using (var cmdAtualizar = new MySqlCommand(queryAtualizar, conexao))
                    {
                        cmdAtualizar.Parameters.AddWithValue("@novaSenha", novaSenha);
                        cmdAtualizar.Parameters.AddWithValue("@id", UtilizadorID);
                        cmdAtualizar.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos de senha
                SenhaAtual.Clear();
                NovaSenha.Clear();
                ConfirmarNova.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
