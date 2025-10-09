namespace TaskGX
{
    partial class FormCriarConta
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriarConta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.BotaoRegistrar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Senha";
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.LightGray;
            this.Usuario.Location = new System.Drawing.Point(150, 27);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(200, 20);
            this.Usuario.TabIndex = 3;
            // 
            // Senha
            // 
            this.Senha.BackColor = System.Drawing.Color.LightGray;
            this.Senha.Location = new System.Drawing.Point(150, 77);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(200, 20);
            this.Senha.TabIndex = 4;
            // 
            // ConfirmarSenha
            // 
            this.ConfirmarSenha.BackColor = System.Drawing.Color.LightGray;
            this.ConfirmarSenha.Location = new System.Drawing.Point(150, 127);
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.PasswordChar = '*';
            this.ConfirmarSenha.Size = new System.Drawing.Size(200, 20);
            this.ConfirmarSenha.TabIndex = 5;
            // 
            // BotaoRegistrar
            // 
            this.BotaoRegistrar.BackColor = System.Drawing.Color.DimGray;
            this.BotaoRegistrar.FlatAppearance.BorderSize = 0;
            this.BotaoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRegistrar.Location = new System.Drawing.Point(150, 180);
            this.BotaoRegistrar.Name = "BotaoRegistrar";
            this.BotaoRegistrar.Size = new System.Drawing.Size(95, 30);
            this.BotaoRegistrar.TabIndex = 6;
            this.BotaoRegistrar.Text = "Registrar";
            this.BotaoRegistrar.UseVisualStyleBackColor = false;
            this.BotaoRegistrar.Click += new System.EventHandler(this.BotaoRegistrar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.BackColor = System.Drawing.Color.DimGray;
            this.BotaoCancelar.FlatAppearance.BorderSize = 0;
            this.BotaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoCancelar.Location = new System.Drawing.Point(255, 180);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(95, 30);
            this.BotaoCancelar.TabIndex = 7;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = false;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // FormCriarConta
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.BotaoRegistrar);
            this.Controls.Add(this.BotaoCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCriarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta";
            this.Load += new System.EventHandler(this.FormCriarConta_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox ConfirmarSenha;
        private System.Windows.Forms.Button BotaoRegistrar;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}