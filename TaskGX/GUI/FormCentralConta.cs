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
        // ID e Nome do utilizador logado
        private int UtilizadorID;
        private string NomeUtilizador;

        /// <summary>
        /// Inicializa uma nova instância do formulário de gestão da conta.
        /// </summary>
        /// <param UtilizadorID="utilizadorID"></param>
        /// <param NomeUtilziador="nomeUtilizador"></param>
        public FormCentralConta(int utilizadorID, string nomeUtilizador)
        {
            InitializeComponent();
            UtilizadorID = utilizadorID;
            NomeUtilizador = nomeUtilizador;
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Carrega os dados do utilizador ao abrir o formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCentralConta_Load(object sender, EventArgs e)
        {
            this.Text = $"Gestão da Conta - {NomeUtilizador}";
            CarregarDadosUtilizador();
            this.CancelButton = BotaoFechar;
        }

        /// <summary>
        /// Função para carregar os dados do utilizador a partir da base de dados.
        /// </summary>
        private void CarregarDadosUtilizador()
        {
            // Conecta à base de dados e obtém os dados do utilizador
            try
            {
                // 1) Conexão
                using (var conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();

                    // 2) Consulta
                    string query = "SELECT ID, Nome FROM Utilizadores WHERE ID = @id";
                    using (var cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", UtilizadorID);
                        // 3) Leitura
                        using (var reader = cmd.ExecuteReader())
                        {
                            // 4) Verificação
                            if (reader.Read())
                            {
                                LabelValorID.Text = reader["ID"].ToString();
                                LabelValorNome.Text = reader["Nome"].ToString();
                            }
                            // 5) Se o utilizador não for encontrado (o que não deve acontecer)
                            else
                            {
                                MessageBox.Show("Utilizador não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            // 6) Tratamento de erros
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do utilizador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento do botão para mostrar/ocultar as senhas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoVerSenha_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar e esconder a senha
            if (this.TextSenhaAtual.PasswordChar != '*')
            {
                this.TextSenhaAtual.PasswordChar = '*';
                this.TextNovaSenha.PasswordChar = '*';
                this.TextConfirmarNova.PasswordChar = '*';
            }
            else
            {
                this.TextSenhaAtual.PasswordChar = '\0';
                this.TextNovaSenha.PasswordChar = '\0';
                this.TextConfirmarNova.PasswordChar = '\0';
            }
        }

        /// <summary>
        /// Evento do botão para terminar a sessão do utilizador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoTerminarSessao_Click(object sender, EventArgs e)
        {
            // Confirmação
            var confirmar = MessageBox.Show("Tem a certeza de que deseja terminar a sessão?", "Terminar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o utilizador escolher "Não", cancela a ação
            if (confirmar != DialogResult.Yes)
                return;

            // Fecha o formulário de tarefas se estiver aberto
            foreach (Form form in Application.OpenForms)
            {
                // Procura o formulário de tarefas
                if (form is FormTarefas)
                {
                    form.Hide();
                    break;
                }
            }
            // Mostra o formulário de login
            var formLogin = Application.OpenForms["Form1"] as Form1;
            if (formLogin != null)
            {
                // Se o formulário de login já estiver aberto, apenas trazê-lo para frente
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
            // Se não estiver aberto, cria uma nova instância
            else
            {
                new Form1().Show();
            }

            this.Hide();
        }

        /// <summary>
        /// Evento do botão para alterar a senha do utilizador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoAlterarSenha_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos campos de senha
            string senhaAtual = TextSenhaAtual.Text.Trim();
            string novaSenha = TextNovaSenha.Text.Trim();
            string confirmarNova = TextConfirmarNova.Text.Trim();

            // Validações básicas
            if (string.IsNullOrEmpty(senhaAtual) || string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarNova))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se a nova senha tem pelo menos 8 caracteres
            if (novaSenha != confirmarNova)
            {
                MessageBox.Show("As novas senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novaSenha.Length < 8)
            {
                MessageBox.Show("A nova senha deve ter pelo menos 8 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se a nova senha tem pelo menos 8 caracteres
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

                        // Executa a consulta e obtém o resultado
                        int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                        // Se a senha atual não estiver correta, mostra uma mensagem de erro
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
                        // Parâmetros
                        cmdAtualizar.Parameters.AddWithValue("@novaSenha", novaSenha);
                        cmdAtualizar.Parameters.AddWithValue("@id", UtilizadorID);
                        cmdAtualizar.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos de senha
                TextSenhaAtual.Clear();
                TextNovaSenha.Clear();
                TextConfirmarNova.Clear();
            }
            // Tratamento de erros
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botão para fechar o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
