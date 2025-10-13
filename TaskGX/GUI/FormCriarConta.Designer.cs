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
            this.LabelUtilizador = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelConfirmarSenha = new System.Windows.Forms.Label();
            this.TextUtilizador = new System.Windows.Forms.TextBox();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.TextConfirmarSenha = new System.Windows.Forms.TextBox();
            this.BotaoRegistrar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUtilizador
            // 
            this.LabelUtilizador.AutoSize = true;
            this.LabelUtilizador.Location = new System.Drawing.Point(30, 30);
            this.LabelUtilizador.Name = "LabelUtilizador";
            this.LabelUtilizador.Size = new System.Drawing.Size(50, 13);
            this.LabelUtilizador.TabIndex = 0;
            this.LabelUtilizador.Text = "Utilizador";
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Location = new System.Drawing.Point(30, 80);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(38, 13);
            this.LabelSenha.TabIndex = 2;
            this.LabelSenha.Text = "Senha";
            // 
            // LabelConfirmarSenha
            // 
            this.LabelConfirmarSenha.AutoSize = true;
            this.LabelConfirmarSenha.Location = new System.Drawing.Point(30, 130);
            this.LabelConfirmarSenha.Name = "LabelConfirmarSenha";
            this.LabelConfirmarSenha.Size = new System.Drawing.Size(85, 13);
            this.LabelConfirmarSenha.TabIndex = 4;
            this.LabelConfirmarSenha.Text = "Confirmar Senha";
            // 
            // TextUtilizador
            // 
            this.TextUtilizador.BackColor = System.Drawing.Color.LightGray;
            this.TextUtilizador.Location = new System.Drawing.Point(150, 27);
            this.TextUtilizador.Name = "TextUtilizador";
            this.TextUtilizador.Size = new System.Drawing.Size(200, 20);
            this.TextUtilizador.TabIndex = 1;
            // 
            // TextSenha
            // 
            this.TextSenha.BackColor = System.Drawing.Color.LightGray;
            this.TextSenha.Location = new System.Drawing.Point(150, 77);
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.Size = new System.Drawing.Size(200, 20);
            this.TextSenha.TabIndex = 3;
            // 
            // TextConfirmarSenha
            // 
            this.TextConfirmarSenha.BackColor = System.Drawing.Color.LightGray;
            this.TextConfirmarSenha.Location = new System.Drawing.Point(150, 127);
            this.TextConfirmarSenha.Name = "TextConfirmarSenha";
            this.TextConfirmarSenha.PasswordChar = '*';
            this.TextConfirmarSenha.Size = new System.Drawing.Size(200, 20);
            this.TextConfirmarSenha.TabIndex = 5;
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
            this.Controls.Add(this.LabelUtilizador);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelConfirmarSenha);
            this.Controls.Add(this.TextUtilizador);
            this.Controls.Add(this.TextSenha);
            this.Controls.Add(this.TextConfirmarSenha);
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
        private System.Windows.Forms.Label LabelUtilizador;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelConfirmarSenha;
        private System.Windows.Forms.TextBox TextUtilizador;
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.TextBox TextConfirmarSenha;
        private System.Windows.Forms.Button BotaoRegistrar;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}