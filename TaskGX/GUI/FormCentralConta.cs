using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskGX.GUI
{
    public partial class FormCentralConta : Form
    {
        private int UtilizadorID;
        private string NomeUtilizador;
        public FormCentralConta(int utilizadorID, string nomeUtilizador)
        {
            InitializeComponent();
            UtilizadorID = utilizadorID;
            NomeUtilizador = nomeUtilizador;
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminarSessao_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        

        private void Perfil_Enter(object sender, EventArgs e)
        {

        }

        private void FormCentralConta_Load(object sender, EventArgs e)
        {

        }

        private void MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MostrarSenha_Click(object sender, EventArgs e)
        {
            
        }

        private void BotaoVerSenha_Click(object sender, EventArgs e)
        {
            if (this.SenhaAtual.PasswordChar != '*'/* && NovaSenha.PasswordChar != '*' && ConfirmarNova.PasswordChar != '*'*/)
            {
                this.SenhaAtual.PasswordChar = '*';
                this.NovaSenha.PasswordChar = '*';
                this.ConfirmarNova.PasswordChar = '*';
            }
            else
            {
                this.SenhaAtual.PasswordChar = '\0';
                this.NovaSenha.PasswordChar = '\0';
                this.ConfirmarNova.PasswordChar = '\0';
            }
        }
    }
}
