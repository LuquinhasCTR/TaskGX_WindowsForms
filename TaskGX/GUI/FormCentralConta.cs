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


        private void btnFechar_Click(object sender, EventArgs e)
        {

        }



        private void Perfil_Enter(object sender, EventArgs e)
        {

        }

        private void FormCentralConta_Load(object sender, EventArgs e)
        {

        }




        private void BotaoVerSenha_Click(object sender, EventArgs e)
        {
            if (this.SenhaAtual.PasswordChar != '*')
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

        private void BotaoTerminarSessao_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show(
       "Tem a certeza de que deseja terminar a sessão?",
       "Terminar Sessão",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
                return;

            foreach (Form form in Application.OpenForms)
            {
                if (form is FormTarefas)
                {
                    form.Hide();
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
    }
}
