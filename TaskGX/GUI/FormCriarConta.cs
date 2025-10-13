using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TaskGX
{
    public partial class FormCriarConta : Form
    {
        /// <summary>
        /// inicializa uma nova instância do formulário de criação de conta.
        /// </summary>
        public FormCriarConta()
        {
            InitializeComponent();
        }

        private void FormCriarConta_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento disparado ao carregar o formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCriarConta_Load_1(object sender, EventArgs e)
        {
            this.AcceptButton = BotaoRegistrar;
            this.CancelButton = BotaoCancelar;
        }

        /// <summary>
        /// Evento do botão para cancelar a criação da conta e fechar o formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento do botão para registrar uma nova conta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            // 1) Validação dos dados
            string usuario = TextUtilizador.Text.Trim();
            string senha = TextSenha.Text;               
            string confirma = TextConfirmarSenha.Text;

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirma))
            {
                MessageBox.Show("Preencha usuário, senha e confirmação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida o nome de usuário (3-32 chars, letras, números, _)
            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9_]{3,32}$"))
            {
                MessageBox.Show("Usuário inválido. Use 3–32 caracteres (letras, números e _).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se as senhas coincidem e têm pelo menos 8 caracteres
            if (senha != confirma)
            {
                MessageBox.Show("As senhas não coincidem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica o tamanho mínimo da senha
            if (senha.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) SQL: checar existência e inserir com SHA2 no próprio MySQL
            const string sqlCheck = @"SELECT COUNT(*) FROM Utilizadores WHERE Nome = @u;";
            const string sqlInsert = @"INSERT INTO Utilizadores (Nome, Senha)
                               VALUES (@u, SHA2(@s, 256));";

            // 3) Conexão e execução
            try
            {
                // Usando "using" para garantir o descarte correto dos recursos
                using (var con = new MySqlConnection(LigacaoDB.GetConnectionString()))
                using (var checkCmd = new MySqlCommand(sqlCheck, con))
                {
                    checkCmd.Parameters.AddWithValue("@u", usuario);

                    con.Open();

                    // Verifica se o usuário já existe
                    var exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    if (exists)
                    {
                        MessageBox.Show("Esse nome de usuário já está em uso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insere o novo usuário
                    using (var insertCmd = new MySqlCommand(sqlInsert, con))
                    {
                        insertCmd.Parameters.AddWithValue("@u", usuario);
                        insertCmd.Parameters.AddWithValue("@s", senha);

                        int linhas = insertCmd.ExecuteNonQuery();
                        if (linhas > 0)
                        {
                            MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível criar a conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            // 4) Tratamento de erros
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro de base de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 5) Erro genérico
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
