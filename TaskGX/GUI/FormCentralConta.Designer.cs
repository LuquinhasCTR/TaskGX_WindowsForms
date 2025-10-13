using System.Windows.Forms;

namespace TaskGX.GUI
{
    partial class FormCentralConta
    {
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;

        private System.Windows.Forms.GroupBox Perfil;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeValor;

        private System.Windows.Forms.GroupBox Seguranca;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.TextBox SenhaAtual;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox NovaSenha;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox ConfirmarNova;
        private System.Windows.Forms.Button BotaoAlterarSenha;

        private System.Windows.Forms.GroupBox Sessao;
        private System.Windows.Forms.Button BotaoTerminarSessao;

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblStatus;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.Perfil = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.Seguranca = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoVerSenha = new System.Windows.Forms.Button();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.SenhaAtual = new System.Windows.Forms.TextBox();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.NovaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.ConfirmarNova = new System.Windows.Forms.TextBox();
            this.BotaoAlterarSenha = new System.Windows.Forms.Button();
            this.Sessao = new System.Windows.Forms.GroupBox();
            this.BotaoTerminarSessao = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Perfil.SuspendLayout();
            this.Seguranca.SuspendLayout();
            this.Sessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Central da Conta";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(18, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Utilizador: —";
            // 
            // Perfil
            // 
            this.Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Perfil.Controls.Add(this.lblId);
            this.Perfil.Controls.Add(this.lblIdValor);
            this.Perfil.Controls.Add(this.lblNome);
            this.Perfil.Controls.Add(this.lblNomeValor);
            this.Perfil.Location = new System.Drawing.Point(16, 72);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(608, 88);
            this.Perfil.TabIndex = 2;
            this.Perfil.TabStop = false;
            this.Perfil.Text = "Perfil";
            this.Perfil.Enter += new System.EventHandler(this.Perfil_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Location = new System.Drawing.Point(80, 28);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(19, 15);
            this.lblIdValor.TabIndex = 1;
            this.lblIdValor.Text = "—";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Location = new System.Drawing.Point(80, 52);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(19, 15);
            this.lblNomeValor.TabIndex = 3;
            this.lblNomeValor.Text = "—";
            // 
            // Seguranca
            // 
            this.Seguranca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seguranca.Controls.Add(this.label1);
            this.Seguranca.Controls.Add(this.BotaoVerSenha);
            this.Seguranca.Controls.Add(this.lblSenhaAtual);
            this.Seguranca.Controls.Add(this.SenhaAtual);
            this.Seguranca.Controls.Add(this.lblNovaSenha);
            this.Seguranca.Controls.Add(this.NovaSenha);
            this.Seguranca.Controls.Add(this.lblConfirmar);
            this.Seguranca.Controls.Add(this.ConfirmarNova);
            this.Seguranca.Controls.Add(this.BotaoAlterarSenha);
            this.Seguranca.Location = new System.Drawing.Point(16, 172);
            this.Seguranca.Name = "Seguranca";
            this.Seguranca.Size = new System.Drawing.Size(608, 200);
            this.Seguranca.TabIndex = 3;
            this.Seguranca.TabStop = false;
            this.Seguranca.Text = "Segurança";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ver senhas";
            // 
            // BotaoVerSenha
            // 
            this.BotaoVerSenha.Location = new System.Drawing.Point(180, 166);
            this.BotaoVerSenha.Name = "BotaoVerSenha";
            this.BotaoVerSenha.Size = new System.Drawing.Size(14, 15);
            this.BotaoVerSenha.TabIndex = 8;
            this.BotaoVerSenha.UseVisualStyleBackColor = true;
            this.BotaoVerSenha.Click += new System.EventHandler(this.BotaoVerSenha_Click);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(16, 32);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(68, 15);
            this.lblSenhaAtual.TabIndex = 0;
            this.lblSenhaAtual.Text = "Senha atual";
            // 
            // SenhaAtual
            // 
            this.SenhaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenhaAtual.BackColor = System.Drawing.Color.Gainsboro;
            this.SenhaAtual.Location = new System.Drawing.Point(180, 28);
            this.SenhaAtual.Name = "SenhaAtual";
            this.SenhaAtual.PasswordChar = '*';
            this.SenhaAtual.Size = new System.Drawing.Size(360, 23);
            this.SenhaAtual.TabIndex = 1;
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Location = new System.Drawing.Point(16, 76);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(69, 15);
            this.lblNovaSenha.TabIndex = 2;
            this.lblNovaSenha.Text = "Nova senha";
            // 
            // NovaSenha
            // 
            this.NovaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NovaSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.NovaSenha.Location = new System.Drawing.Point(180, 72);
            this.NovaSenha.Name = "NovaSenha";
            this.NovaSenha.PasswordChar = '*';
            this.NovaSenha.Size = new System.Drawing.Size(360, 23);
            this.NovaSenha.TabIndex = 3;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(16, 120);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(124, 15);
            this.lblConfirmar.TabIndex = 4;
            this.lblConfirmar.Text = "Confirmar nova senha";
            // 
            // ConfirmarNova
            // 
            this.ConfirmarNova.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmarNova.BackColor = System.Drawing.Color.Gainsboro;
            this.ConfirmarNova.Location = new System.Drawing.Point(180, 116);
            this.ConfirmarNova.Name = "ConfirmarNova";
            this.ConfirmarNova.Size = new System.Drawing.Size(360, 23);
            this.ConfirmarNova.TabIndex = 5;
            // 
            // BotaoAlterarSenha
            // 
            this.BotaoAlterarSenha.BackColor = System.Drawing.Color.DimGray;
            this.BotaoAlterarSenha.FlatAppearance.BorderSize = 0;
            this.BotaoAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoAlterarSenha.Location = new System.Drawing.Point(400, 166);
            this.BotaoAlterarSenha.Name = "BotaoAlterarSenha";
            this.BotaoAlterarSenha.Size = new System.Drawing.Size(140, 28);
            this.BotaoAlterarSenha.TabIndex = 7;
            this.BotaoAlterarSenha.Text = "Alterar senha";
            this.BotaoAlterarSenha.UseVisualStyleBackColor = false;
            this.BotaoAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // Sessao
            // 
            this.Sessao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sessao.Controls.Add(this.BotaoTerminarSessao);
            this.Sessao.Location = new System.Drawing.Point(16, 380);
            this.Sessao.Name = "Sessao";
            this.Sessao.Size = new System.Drawing.Size(608, 84);
            this.Sessao.TabIndex = 4;
            this.Sessao.TabStop = false;
            this.Sessao.Text = "Sessão";
            // 
            // BotaoTerminarSessao
            // 
            this.BotaoTerminarSessao.BackColor = System.Drawing.Color.DimGray;
            this.BotaoTerminarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoTerminarSessao.Location = new System.Drawing.Point(20, 34);
            this.BotaoTerminarSessao.Name = "BotaoTerminarSessao";
            this.BotaoTerminarSessao.Size = new System.Drawing.Size(75, 23);
            this.BotaoTerminarSessao.TabIndex = 0;
            this.BotaoTerminarSessao.Text = "Terminar sessão";
            this.BotaoTerminarSessao.UseVisualStyleBackColor = false;
            this.BotaoTerminarSessao.Click += new System.EventHandler(this.btnTerminarSessao_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.DimGray;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(528, 512);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 36);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCentralConta
            // 
            this.AcceptButton = this.BotaoAlterarSenha;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(640, 560);
            this.Controls.Add(this.Seguranca);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.Sessao);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(560, 520);
            this.Name = "FormCentralConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Central da Conta";
            this.Load += new System.EventHandler(this.FormCentralConta_Load);
            this.Perfil.ResumeLayout(false);
            this.Perfil.PerformLayout();
            this.Seguranca.ResumeLayout(false);
            this.Seguranca.PerformLayout();
            this.Sessao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotaoVerSenha;
        private Label label1;
    }
}