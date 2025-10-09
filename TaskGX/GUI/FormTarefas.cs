using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TaskGX.GUI
{
    public partial class FormTarefas : Form
    {
        public FormTarefas()
        {
            InitializeComponent();
            CarregarDados();
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

                    string query = "UPDATE Tarefa SET Nome=@nome, Descricao=@descricao, `Data`=@data WHERE ID=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tarefa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza GridView
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

                        string query = "DELETE FROM Tarefa WHERE ID=@id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Tarefa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar campos
                    TituloTarefa.Clear();
                    DescricaoTarefa.Clear();
                    dateData.Value = DateTime.Today;

                    // Atualizar GridView
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

                    string query = "INSERT INTO Tarefa (Nome, Descricao, `Data`) VALUES (@nome, @descricao, @data)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@data", data);

                        cmd.ExecuteNonQuery();
                    }
                }
    
                MessageBox.Show("Tarefa adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos
                TituloTarefa.Clear();
                DescricaoTarefa.Clear();

                CarregarDados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CarregarDados()
        {
            try
            {
                // Usa a connection string da tua classe LigacaoDB
                using (MySqlConnection conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();

                    string query = "SELECT ID, nome AS Nome, descricao AS Descricao, data AS Data FROM tarefa";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable tabela = new DataTable();
                        adaptador.Fill(tabela);
                        GridViewTarefa.DataSource = tabela;
                        TituloTarefa.Text = "";
                        DescricaoTarefa.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BindAluno(int v) => throw new NotImplementedException();

        private void FormTarefas_Load(object sender, EventArgs e)
        {

        }
        
        private void TituloTarefa_TextChanged(object sender, EventArgs e)
        {
            // Serve pra garantir que os campos ficam preenchidos
            if (GridViewTarefa.CurrentRow != null && !TituloTarefa.Focused)
            {
                TituloTarefa.Text = GridViewTarefa.CurrentRow.Cells["Nome"].Value.ToString();
                DescricaoTarefa.Text = GridViewTarefa.CurrentRow.Cells["Descricao"].Value.ToString();
                dateData.Value = Convert.ToDateTime(GridViewTarefa.CurrentRow.Cells["Data"].Value);
            }
        }

        private void GridViewTarefa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTarefas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
