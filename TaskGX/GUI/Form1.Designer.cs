namespace TaskGX
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelUtilizador = new System.Windows.Forms.Label();
            this.TextUtilizador = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.BotaoEntrar = new System.Windows.Forms.Button();
            this.BotaoVerSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoCriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.ForeColor = System.Drawing.Color.Black;
            this.LabelTitulo.Location = new System.Drawing.Point(156, 26);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(88, 30);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "TaskGX";
            // 
            // LabelUtilizador
            // 
            this.LabelUtilizador.AutoSize = true;
            this.LabelUtilizador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelUtilizador.Location = new System.Drawing.Point(35, 89);
            this.LabelUtilizador.Name = "LabelUtilizador";
            this.LabelUtilizador.Size = new System.Drawing.Size(59, 19);
            this.LabelUtilizador.TabIndex = 1;
            this.LabelUtilizador.Text = "Usuário:";
            // 
            // TextUtilizador
            // 
            this.TextUtilizador.BackColor = System.Drawing.Color.LightGray;
            this.TextUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextUtilizador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextUtilizador.Location = new System.Drawing.Point(110, 87);
            this.TextUtilizador.Name = "TextUtilizador";
            this.TextUtilizador.Size = new System.Drawing.Size(180, 25);
            this.TextUtilizador.TabIndex = 2;
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelSenha.Location = new System.Drawing.Point(35, 139);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(49, 19);
            this.LabelSenha.TabIndex = 3;
            this.LabelSenha.Text = "Senha:";
            // 
            // TextSenha
            // 
            this.TextSenha.BackColor = System.Drawing.Color.LightGray;
            this.TextSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextSenha.Location = new System.Drawing.Point(110, 137);
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.Size = new System.Drawing.Size(180, 25);
            this.TextSenha.TabIndex = 4;
            // 
            // BotaoEntrar
            // 
            this.BotaoEntrar.BackColor = System.Drawing.Color.DimGray;
            this.BotaoEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoEntrar.FlatAppearance.BorderSize = 0;
            this.BotaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoEntrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BotaoEntrar.ForeColor = System.Drawing.Color.Black;
            this.BotaoEntrar.Location = new System.Drawing.Point(110, 190);
            this.BotaoEntrar.Name = "BotaoEntrar";
            this.BotaoEntrar.Size = new System.Drawing.Size(180, 35);
            this.BotaoEntrar.TabIndex = 5;
            this.BotaoEntrar.Text = "Entrar";
            this.BotaoEntrar.UseVisualStyleBackColor = false;
            this.BotaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // BotaoVerSenha
            // 
            this.BotaoVerSenha.BackColor = System.Drawing.Color.DimGray;
            this.BotaoVerSenha.Location = new System.Drawing.Point(293, 139);
            this.BotaoVerSenha.Name = "BotaoVerSenha";
            this.BotaoVerSenha.Size = new System.Drawing.Size(18, 19);
            this.BotaoVerSenha.TabIndex = 6;
            this.BotaoVerSenha.UseVisualStyleBackColor = false;
            this.BotaoVerSenha.Click += new System.EventHandler(this.BotaoVerSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ver senha";
            // 
            // BotaoCriar
            // 
            this.BotaoCriar.BackColor = System.Drawing.Color.DimGray;
            this.BotaoCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoCriar.FlatAppearance.BorderSize = 0;
            this.BotaoCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoCriar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCriar.ForeColor = System.Drawing.Color.Black;
            this.BotaoCriar.Location = new System.Drawing.Point(110, 231);
            this.BotaoCriar.Name = "BotaoCriar";
            this.BotaoCriar.Size = new System.Drawing.Size(180, 35);
            this.BotaoCriar.TabIndex = 8;
            this.BotaoCriar.Text = "Criar conta";
            this.BotaoCriar.UseVisualStyleBackColor = false;
            this.BotaoCriar.Click += new System.EventHandler(this.BotaoCriar_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(368, 300);
            this.Controls.Add(this.BotaoCriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoVerSenha);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.LabelUtilizador);
            this.Controls.Add(this.TextUtilizador);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.TextSenha);
            this.Controls.Add(this.BotaoEntrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(384, 339);
            this.MinimumSize = new System.Drawing.Size(384, 339);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskGX - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelUtilizador;
        private System.Windows.Forms.TextBox TextUtilizador;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.TextBox TextSenha;
        private System.Windows.Forms.Button BotaoEntrar;
        #endregion

        private System.Windows.Forms.Button BotaoVerSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoCriar;
    }
}
