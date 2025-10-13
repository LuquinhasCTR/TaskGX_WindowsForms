using System;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace TaskGX
{
    public partial class Form1 : Form
    {
        private bool Autenticado = false;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = BotaoEntrar;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Autenticação";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void BotaoVerSenha_Click(object sender, EventArgs e)
        {
            if (TextSenha.PasswordChar != '*')
            {
                this.TextSenha.PasswordChar = '*';
            }
            else
            {
                this.TextSenha.PasswordChar = '\0';
            }
        }

        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            FormCriarConta formCriarConta = new FormCriarConta();
            formCriarConta.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextUtilizador.Text) || string.IsNullOrWhiteSpace(TextSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT ID, Nome FROM Utilizadores WHERE Nome=@Nome AND Senha=SHA2(@Senha, 256)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nome", TextUtilizador.Text);
                        cmd.Parameters.AddWithValue("@Senha", TextSenha.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int utilizadorID = reader.GetInt32("ID");
                                string nome = reader.GetString("Nome");

                                var formTarefas = new GUI.FormTarefas(utilizadorID, nome);
                                formTarefas.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar à base de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
