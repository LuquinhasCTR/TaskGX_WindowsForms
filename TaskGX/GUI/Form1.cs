using System;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace TaskGX
{
    public partial class Form1 : Form
    {
        // Serve para verificar se o usuário está autenticado
        private bool Autenticado = false;

        /// <summary>
        /// Inicializa o formulário de login
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = BotaoEntrar;
        }

        /// <summary>
        /// Carrega as configurações iniciais do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = "Autenticação";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Evento do botão para mostrar ou esconder a senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoVerSenha_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar e esconder a senha
            if (TextSenha.PasswordChar != '*')
            {
                this.TextSenha.PasswordChar = '*';
            }
            else
            {
                this.TextSenha.PasswordChar = '\0';
            }
        }

        /// <summary>
        /// Evento do botão para abrir o formulário de criação de conta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            FormCriarConta formCriarConta = new FormCriarConta();
            formCriarConta.Show();
        }

        /// <summary>
        /// Evento disparado ao fechar o formulário, garantindo que a aplicação seja encerrada corretamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Evento do botão para autenticar o utilizador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(TextUtilizador.Text) || string.IsNullOrWhiteSpace(TextSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Tenta conectar e autenticar o usuário
            try
            {
                // 1) Conexão
                using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    connection.Open();
                    // 2) Consulta
                    string query = "SELECT ID, Nome FROM Utilizadores WHERE Nome=@Nome AND Senha=SHA2(@Senha, 256)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nome", TextUtilizador.Text);
                        cmd.Parameters.AddWithValue("@Senha", TextSenha.Text);

                        // 3) Leitura
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4) Verificação
                            if (reader.Read())
                            {
                                int utilizadorID = reader.GetInt32("ID");
                                string nome = reader.GetString("Nome");

                                var formTarefas = new GUI.FormTarefas(utilizadorID, nome);
                                formTarefas.Show();
                                this.Hide();
                            }
                            // 5) Se falhar na autenticação
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            // 6) Tratamento de erros
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar à base de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
