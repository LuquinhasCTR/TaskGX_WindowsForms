using System.Windows.Forms;

namespace TaskGX.GUI
{
    partial class FormCentralConta
    {
        private System.Windows.Forms.Label LabelTitulo;

        private System.Windows.Forms.GroupBox Perfil;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelValorID;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelValorNome;

        private System.Windows.Forms.GroupBox Seguranca;
        private System.Windows.Forms.Label LabelSenhaAtual;
        private System.Windows.Forms.TextBox TextSenhaAtual;
        private System.Windows.Forms.Label LabelNovaSenha;
        private System.Windows.Forms.TextBox TextNovaSenha;
        private System.Windows.Forms.Label LabelConfirmar;
        private System.Windows.Forms.TextBox TextConfirmarNova;
        private System.Windows.Forms.Button BotaoAlterarSenha;

        private System.Windows.Forms.GroupBox Sessao;
        private System.Windows.Forms.Button BotaoTerminarSessao;

        private System.Windows.Forms.Button BotaoFechar;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCentralConta));
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.Perfil = new System.Windows.Forms.GroupBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelValorID = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelValorNome = new System.Windows.Forms.Label();
            this.Seguranca = new System.Windows.Forms.GroupBox();
            this.LabelVerSenha = new System.Windows.Forms.Label();
            this.BotaoVerSenha = new System.Windows.Forms.Button();
            this.LabelSenhaAtual = new System.Windows.Forms.Label();
            this.TextSenhaAtual = new System.Windows.Forms.TextBox();
            this.LabelNovaSenha = new System.Windows.Forms.Label();
            this.TextNovaSenha = new System.Windows.Forms.TextBox();
            this.LabelConfirmar = new System.Windows.Forms.Label();
            this.TextConfirmarNova = new System.Windows.Forms.TextBox();
            this.BotaoAlterarSenha = new System.Windows.Forms.Button();
            this.Sessao = new System.Windows.Forms.GroupBox();
            this.BotaoTerminarSessao = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Perfil.SuspendLayout();
            this.Seguranca.SuspendLayout();
            this.Sessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.LabelTitulo.Location = new System.Drawing.Point(16, 12);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(156, 25);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Central da Conta";
            // 
            // Perfil
            // 
            this.Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Perfil.Controls.Add(this.LabelID);
            this.Perfil.Controls.Add(this.LabelValorID);
            this.Perfil.Controls.Add(this.LabelNome);
            this.Perfil.Controls.Add(this.LabelValorNome);
            this.Perfil.Location = new System.Drawing.Point(16, 62);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(608, 88);
            this.Perfil.TabIndex = 2;
            this.Perfil.TabStop = false;
            this.Perfil.Text = "Perfil";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(16, 28);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(21, 15);
            this.LabelID.TabIndex = 0;
            this.LabelID.Text = "ID:";
            // 
            // LabelValorID
            // 
            this.LabelValorID.AutoSize = true;
            this.LabelValorID.Location = new System.Drawing.Point(80, 28);
            this.LabelValorID.Name = "LabelValorID";
            this.LabelValorID.Size = new System.Drawing.Size(19, 15);
            this.LabelValorID.TabIndex = 1;
            this.LabelValorID.Text = "—";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(16, 52);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(43, 15);
            this.LabelNome.TabIndex = 2;
            this.LabelNome.Text = "Nome:";
            // 
            // LabelValorNome
            // 
            this.LabelValorNome.AutoSize = true;
            this.LabelValorNome.Location = new System.Drawing.Point(80, 52);
            this.LabelValorNome.Name = "LabelValorNome";
            this.LabelValorNome.Size = new System.Drawing.Size(19, 15);
            this.LabelValorNome.TabIndex = 3;
            this.LabelValorNome.Text = "—";
            // 
            // Seguranca
            // 
            this.Seguranca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seguranca.Controls.Add(this.LabelVerSenha);
            this.Seguranca.Controls.Add(this.BotaoVerSenha);
            this.Seguranca.Controls.Add(this.LabelSenhaAtual);
            this.Seguranca.Controls.Add(this.TextSenhaAtual);
            this.Seguranca.Controls.Add(this.LabelNovaSenha);
            this.Seguranca.Controls.Add(this.TextNovaSenha);
            this.Seguranca.Controls.Add(this.LabelConfirmar);
            this.Seguranca.Controls.Add(this.TextConfirmarNova);
            this.Seguranca.Controls.Add(this.BotaoAlterarSenha);
            this.Seguranca.Location = new System.Drawing.Point(16, 172);
            this.Seguranca.Name = "Seguranca";
            this.Seguranca.Size = new System.Drawing.Size(608, 200);
            this.Seguranca.TabIndex = 3;
            this.Seguranca.TabStop = false;
            this.Seguranca.Text = "Seguranca";
            // 
            // LabelVerSenha
            // 
            this.LabelVerSenha.AutoSize = true;
            this.LabelVerSenha.Location = new System.Drawing.Point(200, 166);
            this.LabelVerSenha.Name = "LabelVerSenha";
            this.LabelVerSenha.Size = new System.Drawing.Size(62, 15);
            this.LabelVerSenha.TabIndex = 9;
            this.LabelVerSenha.Text = "Ver senhas";
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
            // LabelSenhaAtual
            // 
            this.LabelSenhaAtual.AutoSize = true;
            this.LabelSenhaAtual.Location = new System.Drawing.Point(16, 32);
            this.LabelSenhaAtual.Name = "LabelSenhaAtual";
            this.LabelSenhaAtual.Size = new System.Drawing.Size(68, 15);
            this.LabelSenhaAtual.TabIndex = 0;
            this.LabelSenhaAtual.Text = "Senha atual";
            // 
            // TextSenhaAtual
            // 
            this.TextSenhaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSenhaAtual.BackColor = System.Drawing.Color.Gainsboro;
            this.TextSenhaAtual.Location = new System.Drawing.Point(180, 28);
            this.TextSenhaAtual.Name = "TextSenhaAtual";
            this.TextSenhaAtual.PasswordChar = '*';
            this.TextSenhaAtual.Size = new System.Drawing.Size(360, 23);
            this.TextSenhaAtual.TabIndex = 1;
            // 
            // LabelNovaSenha
            // 
            this.LabelNovaSenha.AutoSize = true;
            this.LabelNovaSenha.Location = new System.Drawing.Point(16, 76);
            this.LabelNovaSenha.Name = "LabelNovaSenha";
            this.LabelNovaSenha.Size = new System.Drawing.Size(69, 15);
            this.LabelNovaSenha.TabIndex = 2;
            this.LabelNovaSenha.Text = "Nova senha";
            // 
            // TextNovaSenha
            // 
            this.TextNovaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextNovaSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.TextNovaSenha.Location = new System.Drawing.Point(180, 72);
            this.TextNovaSenha.Name = "TextNovaSenha";
            this.TextNovaSenha.PasswordChar = '*';
            this.TextNovaSenha.Size = new System.Drawing.Size(360, 23);
            this.TextNovaSenha.TabIndex = 3;
            // 
            // LabelConfirmar
            // 
            this.LabelConfirmar.AutoSize = true;
            this.LabelConfirmar.Location = new System.Drawing.Point(16, 120);
            this.LabelConfirmar.Name = "LabelConfirmar";
            this.LabelConfirmar.Size = new System.Drawing.Size(124, 15);
            this.LabelConfirmar.TabIndex = 4;
            this.LabelConfirmar.Text = "Confirmar nova senha";
            // 
            // TextConfirmarNova
            // 
            this.TextConfirmarNova.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextConfirmarNova.BackColor = System.Drawing.Color.Gainsboro;
            this.TextConfirmarNova.Location = new System.Drawing.Point(180, 116);
            this.TextConfirmarNova.Name = "TextConfirmarNova";
            this.TextConfirmarNova.PasswordChar = '*';
            this.TextConfirmarNova.Size = new System.Drawing.Size(360, 23);
            this.TextConfirmarNova.TabIndex = 5;
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
            this.BotaoAlterarSenha.Click += new System.EventHandler(this.BotaoAlterarSenha_Click);
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
            this.BotaoTerminarSessao.Click += new System.EventHandler(this.BotaoTerminarSessao_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoFechar.BackColor = System.Drawing.Color.DimGray;
            this.BotaoFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Location = new System.Drawing.Point(528, 512);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(96, 36);
            this.BotaoFechar.TabIndex = 5;
            this.BotaoFechar.Text = "Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = false;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
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
            this.CancelButton = this.BotaoFechar;
            this.ClientSize = new System.Drawing.Size(640, 560);
            this.Controls.Add(this.Seguranca);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.Sessao);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private Label LabelVerSenha;
    }
}