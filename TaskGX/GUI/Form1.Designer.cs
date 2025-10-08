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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.botaoEntrar = new System.Windows.Forms.Button();
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
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LabelUsuario.Location = new System.Drawing.Point(35, 89);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(59, 19);
            this.LabelUsuario.TabIndex = 1;
            this.LabelUsuario.Text = "Usuário:";
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.Color.LightGray;
            this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textUsuario.Location = new System.Drawing.Point(110, 87);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(180, 25);
            this.textUsuario.TabIndex = 2;
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
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.LightGray;
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textSenha.Location = new System.Drawing.Point(110, 137);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(180, 25);
            this.textSenha.TabIndex = 4;
            // 
            // botaoEntrar
            // 
            this.botaoEntrar.BackColor = System.Drawing.Color.DimGray;
            this.botaoEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEntrar.FlatAppearance.BorderSize = 0;
            this.botaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEntrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.botaoEntrar.ForeColor = System.Drawing.Color.Black;
            this.botaoEntrar.Location = new System.Drawing.Point(110, 190);
            this.botaoEntrar.Name = "botaoEntrar";
            this.botaoEntrar.Size = new System.Drawing.Size(180, 35);
            this.botaoEntrar.TabIndex = 5;
            this.botaoEntrar.Text = "Entrar";
            this.botaoEntrar.UseVisualStyleBackColor = false;
            this.botaoEntrar.Click += new System.EventHandler(this.botaoEntrar_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(368, 300);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.botaoEntrar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximumSize = new System.Drawing.Size(384, 339);
            this.MinimumSize = new System.Drawing.Size(384, 339);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskGX - Login";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button botaoEntrar;
        #endregion
    }
}
