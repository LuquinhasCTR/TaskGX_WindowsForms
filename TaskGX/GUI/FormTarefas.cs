using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskGX.GUI
{
    public partial class FormTarefas : Form
    {
        // Armazena o ID e nome do utilizador autenticado
        private int UtilizadorID;
        private string NomeUtilizador;

        /// <summary>
        /// Forma de gestão de tarefas
        /// </summary>
        /// <param name="utilizadorID"></param>
        /// <param name="nomeUtilizador"></param>
        public FormTarefas(int utilizadorID, string nomeUtilizador)
        {
            InitializeComponent();
            UtilizadorID = utilizadorID;
            NomeUtilizador = nomeUtilizador;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CancelButton = BotaoSair;
        }

        /// <summary>
        /// Carrega os dados do utilizador e inicializa a interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTarefas_Load(object sender, EventArgs e)
        {
            this.Text = $"Gestão de Tarefas - {NomeUtilizador}";
            CarregarDados();
            this.AcceptButton = BotaoAdicionar;
            this.CancelButton = BotaoSair;
        }

        /// <summary>
        /// Evento de clique para adicionar uma nova tarefa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            string nome = TextTituloTarefa.Text.Trim();
            string descricao = TextDescricaoTarefa.Text.Trim();
            DateTime data = DateData.Value.Date;

            // Validação básica
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O nome da tarefa é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();

                    string query = "INSERT INTO Tarefa (Nome, Descricao, `Data`, UtilizadorID) VALUES (@nome, @descricao, @data, @uid)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@uid", UtilizadorID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tarefa adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextTituloTarefa.Clear();
                TextDescricaoTarefa.Clear();
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botão para editar uma tarefa selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            // Verifica se uma linha está selecionada
            if (GridViewTarefa.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma tarefa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém os dados da tarefa selecionada
            int id = Convert.ToInt32(GridViewTarefa.CurrentRow.Cells["ID"].Value);
            string nome = TextTituloTarefa.Text.Trim();
            string descricao = TextDescricaoTarefa.Text.Trim();
            DateTime data = DateData.Value.Date;

            // Validação básica
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O nome da tarefa é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();
                    string query = "UPDATE Tarefa SET Nome=@nome, Descricao=@descricao, `Data`=@data WHERE ID=@id AND UtilizadorID=@uid";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@uid", UtilizadorID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tarefa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botão para excluir a tarefa selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se uma linha está selecionada
            if (GridViewTarefa.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma tarefa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID da tarefa selecionada
            int id = Convert.ToInt32(GridViewTarefa.CurrentRow.Cells["ID"].Value);

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir esta tarefa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o utilizador confirmar, prossegue com a exclusão
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                    {
                        conexao.Open();
                        string query = "DELETE FROM Tarefa WHERE ID=@id AND UtilizadorID=@uid";
                        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@uid", UtilizadorID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Tarefa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextTituloTarefa.Clear();
                    TextDescricaoTarefa.Clear();
                    DateData.Value = DateTime.Today;
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Função para carregar as tarefas do utilizador na grelha
        /// </summary>
        private void CarregarDados()
        {
            // Limpa a grelha antes de carregar os dados
            try
            {
                // Configura a grelha
                using (MySqlConnection conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();
                    string query = "SELECT ID, Nome, Descricao, Data FROM Tarefa WHERE UtilizadorID = @uid";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@uid", UtilizadorID);
                        DataTable tabela = new DataTable();
                        adaptador.Fill(tabela);
                        GridViewTarefa.DataSource = tabela;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gerir o clique na grelha para preencher os campos de edição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridViewTarefa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se uma linha está selecionada
            if (GridViewTarefa.CurrentRow != null)
            {
                TextTituloTarefa.Text = GridViewTarefa.CurrentRow.Cells["Nome"].Value.ToString();
                TextDescricaoTarefa.Text = GridViewTarefa.CurrentRow.Cells["Descricao"].Value.ToString();
                DateData.Value = Convert.ToDateTime(GridViewTarefa.CurrentRow.Cells["Data"].Value);
            }
        }

        /// <summary>
        /// Botão para sair da aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotaoSair_Click(object sender, EventArgs e)
        {
            EncerrarSessao();
        }

        /// <summary>
        /// Função para encerrar a sessão e voltar ao ecrã de login
        /// </summary>
        private void EncerrarSessao()
        {
            // Fecha o formulário de gestão de conta se estiver aberto
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormCentralConta)
                {
                    form.Close();
                    break;
                }
            }

            // Volta ao formulário de login
            var formLogin = Application.OpenForms["Form1"] as Form1;

            // Se o formulário de login já estiver aberto, apenas trazê-lo para frente
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
            // Caso contrário, criar uma nova instância do formulário de login
            else
            {
                new Form1().Show();
            }

            this.Hide();
        }

        private void FormTarefas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Serve para abrir o formulário de gestão de conta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gerirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCentralConta formCentralConta = new FormCentralConta(UtilizadorID,NomeUtilizador);
            formCentralConta.Show();
        }
    }
}
