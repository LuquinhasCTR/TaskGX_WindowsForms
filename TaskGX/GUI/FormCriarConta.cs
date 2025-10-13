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
        public FormCriarConta()
        {
            InitializeComponent();
        }

        private void FormCriarConta_Load(object sender, EventArgs e)
        {

        }

        

        

        private void FormCriarConta_Load_1(object sender, EventArgs e)
        {
            this.AcceptButton = BotaoRegistrar;
            this.CancelButton = BotaoCancelar;
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = TextUtilizador.Text.Trim();
            string senha = TextSenha.Text;               
            string confirma = TextConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrEmpty(senha) ||
                string.IsNullOrEmpty(confirma))
            {
                MessageBox.Show("Preencha usuário, senha e confirmação.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9_]{3,32}$"))
            {
                MessageBox.Show("Usuário inválido. Use 3–32 caracteres (letras, números e _).", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha != confirma)
            {
                MessageBox.Show("As senhas não coincidem.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senha.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) SQL: checar existência e inserir com SHA2 no próprio MySQL
            const string sqlCheck = @"SELECT COUNT(*) FROM Utilizadores WHERE Nome = @u;";
            const string sqlInsert = @"INSERT INTO Utilizadores (Nome, Senha)
                               VALUES (@u, SHA2(@s, 256));";

            try
            {
                using (var con = new MySqlConnection(LigacaoDB.GetConnectionString()))
                using (var checkCmd = new MySqlCommand(sqlCheck, con))
                {
                    checkCmd.Parameters.AddWithValue("@u", usuario);

                    con.Open();

                    var exists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    if (exists)
                    {
                        MessageBox.Show("Esse nome de usuário já está em uso.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var insertCmd = new MySqlCommand(sqlInsert, con))
                    {
                        insertCmd.Parameters.AddWithValue("@u", usuario);
                        insertCmd.Parameters.AddWithValue("@s", senha);

                        int linhas = insertCmd.ExecuteNonQuery();
                        if (linhas > 0)
                        {
                            MessageBox.Show("Conta criada com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível criar a conta.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro de base de dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
