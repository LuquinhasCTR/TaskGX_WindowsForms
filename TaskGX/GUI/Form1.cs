using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TaskGX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            var FormTarefas = new GUI.FormTarefas();
            FormTarefas.Show();
            this.Hide();
        }
    }
}
