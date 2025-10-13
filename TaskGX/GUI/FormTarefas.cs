using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskGX.GUI
{
    public partial class FormTarefas : Form
    {
        private int UtilizadorID;
        private string NomeUtilizador;

        public FormTarefas(int utilizadorID, string nomeUtilizador)
        {
            InitializeComponent();
            UtilizadorID = utilizadorID;
            NomeUtilizador = nomeUtilizador;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CancelButton = BotaoSair;
        }

        private void FormTarefas_Load(object sender, EventArgs e)
        {
            this.Text = $"Gestão de Tarefas - {NomeUtilizador}";
            CarregarDados();
            this.AcceptButton = BotaoAdicionar;
            this.CancelButton = BotaoSair;
        }

        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            string nome = TituloTarefa.Text.Trim();
            string descricao = DescricaoTarefa.Text.Trim();
            DateTime data = dateData.Value.Date;

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
                TituloTarefa.Clear();
                DescricaoTarefa.Clear();
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            if (GridViewTarefa.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma tarefa para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(GridViewTarefa.CurrentRow.Cells["ID"].Value);
            string nome = TituloTarefa.Text.Trim();
            string descricao = DescricaoTarefa.Text.Trim();
            DateTime data = dateData.Value.Date;

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

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            if (GridViewTarefa.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma tarefa para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(GridViewTarefa.CurrentRow.Cells["ID"].Value);

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir esta tarefa?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

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
                    TituloTarefa.Clear();
                    DescricaoTarefa.Clear();
                    dateData.Value = DateTime.Today;
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarDados()
        {
            try
            {
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

        private void GridViewTarefa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewTarefa.CurrentRow != null)
            {
                TituloTarefa.Text = GridViewTarefa.CurrentRow.Cells["Nome"].Value.ToString();
                DescricaoTarefa.Text = GridViewTarefa.CurrentRow.Cells["Descricao"].Value.ToString();
                dateData.Value = Convert.ToDateTime(GridViewTarefa.CurrentRow.Cells["Data"].Value);
            }
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            EncerrarSessao();
        }
        private void EncerrarSessao()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormCentralConta)
                {
                    form.Close();
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
        private void FormTarefas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void escluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCentralConta formCentralConta = new FormCentralConta(UtilizadorID,NomeUtilizador);
            formCentralConta.Show();
        }
    }
}
