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

        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {

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
                //dateData.Value = DateTime.Today;

                // Atualiza o GridView
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar a tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// O utilizador clicou num item na lista de alunos.
        /// </summary>
        private void CarregarDados()
        {
            try
            {
                // Usa a connection string da tua classe LigacaoDB
                using (MySqlConnection conexao = new MySqlConnection(LigacaoDB.GetConnectionString()))
                {
                    conexao.Open();

                    string query = "SELECT nome AS Nome, descricao AS Descricao, data AS Data FROM tarefa";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao))
                    {
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
        private void BindAluno(int v) => throw new NotImplementedException();

        private void FormTarefas_Load(object sender, EventArgs e)
        {

        }

        private void TituloTarefa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
