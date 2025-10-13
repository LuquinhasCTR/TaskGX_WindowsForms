namespace TaskGX.GUI
{
    partial class FormTarefas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Panel panelInserir;
        private System.Windows.Forms.TextBox TextTituloTarefa;
        private System.Windows.Forms.TextBox TextDescricaoTarefa;
        private System.Windows.Forms.Button BotaoAdicionar;
        private System.Windows.Forms.DataGridView GridViewTarefa;
        private System.Windows.Forms.GroupBox Acoes;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoExcluir;
        private System.Windows.Forms.Button BotaoSair;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarefas));
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.panelInserir = new System.Windows.Forms.Panel();
            this.DateData = new System.Windows.Forms.DateTimePicker();
            this.TextTituloTarefa = new System.Windows.Forms.TextBox();
            this.TextDescricaoTarefa = new System.Windows.Forms.TextBox();
            this.BotaoAdicionar = new System.Windows.Forms.Button();
            this.GridViewTarefa = new System.Windows.Forms.DataGridView();
            this.Acoes = new System.Windows.Forms.GroupBox();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.BotaoSair = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInserir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTarefa)).BeginInit();
            this.Acoes.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.BackColor = System.Drawing.Color.DimGray;
            this.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LabelTitulo.ForeColor = System.Drawing.Color.Black;
            this.LabelTitulo.Location = new System.Drawing.Point(0, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(784, 73);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "📝 Minhas Tarefas";
            this.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInserir
            // 
            this.panelInserir.BackColor = System.Drawing.Color.DarkGray;
            this.panelInserir.Controls.Add(this.DateData);
            this.panelInserir.Controls.Add(this.TextTituloTarefa);
            this.panelInserir.Controls.Add(this.TextDescricaoTarefa);
            this.panelInserir.Controls.Add(this.BotaoAdicionar);
            this.panelInserir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInserir.Location = new System.Drawing.Point(0, 73);
            this.panelInserir.Name = "panelInserir";
            this.panelInserir.Padding = new System.Windows.Forms.Padding(20);
            this.panelInserir.Size = new System.Drawing.Size(784, 120);
            this.panelInserir.TabIndex = 1;
            // 
            // DateData
            // 
            this.DateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateData.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.DateData.Location = new System.Drawing.Point(20, 93);
            this.DateData.Name = "DateData";
            this.DateData.Size = new System.Drawing.Size(740, 20);
            this.DateData.TabIndex = 4;
            // 
            // TextTituloTarefa
            // 
            this.TextTituloTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTituloTarefa.BackColor = System.Drawing.Color.Gainsboro;
            this.TextTituloTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextTituloTarefa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextTituloTarefa.Location = new System.Drawing.Point(21, 6);
            this.TextTituloTarefa.Name = "TextTituloTarefa";
            this.TextTituloTarefa.Size = new System.Drawing.Size(697, 25);
            this.TextTituloTarefa.TabIndex = 0;
            // 
            // TextDescricaoTarefa
            // 
            this.TextDescricaoTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDescricaoTarefa.BackColor = System.Drawing.Color.Gainsboro;
            this.TextDescricaoTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDescricaoTarefa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextDescricaoTarefa.Location = new System.Drawing.Point(21, 37);
            this.TextDescricaoTarefa.Multiline = true;
            this.TextDescricaoTarefa.Name = "TextDescricaoTarefa";
            this.TextDescricaoTarefa.Size = new System.Drawing.Size(740, 50);
            this.TextDescricaoTarefa.TabIndex = 2;
            // 
            // BotaoAdicionar
            // 
            this.BotaoAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.BotaoAdicionar.FlatAppearance.BorderSize = 0;
            this.BotaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoAdicionar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.BotaoAdicionar.ForeColor = System.Drawing.Color.White;
            this.BotaoAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotaoAdicionar.Location = new System.Drawing.Point(724, 6);
            this.BotaoAdicionar.Name = "BotaoAdicionar";
            this.BotaoAdicionar.Size = new System.Drawing.Size(36, 25);
            this.BotaoAdicionar.TabIndex = 1;
            this.BotaoAdicionar.Text = "+";
            this.BotaoAdicionar.UseVisualStyleBackColor = false;
            this.BotaoAdicionar.Click += new System.EventHandler(this.BotaoAdicionar_Click);
            // 
            // GridViewTarefa
            // 
            this.GridViewTarefa.AllowUserToAddRows = false;
            this.GridViewTarefa.AllowUserToDeleteRows = false;
            this.GridViewTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewTarefa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewTarefa.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewTarefa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewTarefa.EnableHeadersVisualStyles = false;
            this.GridViewTarefa.Location = new System.Drawing.Point(20, 200);
            this.GridViewTarefa.Name = "GridViewTarefa";
            this.GridViewTarefa.ReadOnly = true;
            this.GridViewTarefa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewTarefa.Size = new System.Drawing.Size(740, 280);
            this.GridViewTarefa.TabIndex = 2;
            // 
            // Acoes
            // 
            this.Acoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Acoes.Controls.Add(this.BotaoEditar);
            this.Acoes.Controls.Add(this.BotaoExcluir);
            this.Acoes.Controls.Add(this.BotaoSair);
            this.Acoes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Acoes.Location = new System.Drawing.Point(20, 490);
            this.Acoes.Name = "Acoes";
            this.Acoes.Size = new System.Drawing.Size(740, 80);
            this.Acoes.TabIndex = 3;
            this.Acoes.TabStop = false;
            this.Acoes.Text = "Ações";
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(115)))), ((int)(((byte)(220)))));
            this.BotaoEditar.FlatAppearance.BorderSize = 0;
            this.BotaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoEditar.ForeColor = System.Drawing.Color.White;
            this.BotaoEditar.Location = new System.Drawing.Point(30, 30);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(100, 35);
            this.BotaoEditar.TabIndex = 0;
            this.BotaoEditar.Text = "Editar";
            this.BotaoEditar.UseVisualStyleBackColor = false;
            this.BotaoEditar.Click += new System.EventHandler(this.BotaoEditar_Click);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotaoExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BotaoExcluir.FlatAppearance.BorderSize = 0;
            this.BotaoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoExcluir.ForeColor = System.Drawing.Color.White;
            this.BotaoExcluir.Location = new System.Drawing.Point(150, 30);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(100, 35);
            this.BotaoExcluir.TabIndex = 1;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = false;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // BotaoSair
            // 
            this.BotaoSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoSair.BackColor = System.Drawing.Color.Gray;
            this.BotaoSair.FlatAppearance.BorderSize = 0;
            this.BotaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoSair.ForeColor = System.Drawing.Color.White;
            this.BotaoSair.Location = new System.Drawing.Point(600, 30);
            this.BotaoSair.Name = "BotaoSair";
            this.BotaoSair.Size = new System.Drawing.Size(100, 35);
            this.BotaoSair.TabIndex = 2;
            this.BotaoSair.Text = "Sair";
            this.BotaoSair.UseVisualStyleBackColor = false;
            this.BotaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(59, 24);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirContaToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            this.contaToolStripMenuItem.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // gerirContaToolStripMenuItem
            // 
            this.gerirContaToolStripMenuItem.Name = "gerirContaToolStripMenuItem";
            this.gerirContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerirContaToolStripMenuItem.Text = "Gerir Conta";
            this.gerirContaToolStripMenuItem.Click += new System.EventHandler(this.gerirContaToolStripMenuItem_Click);
            // 
            // FormTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Acoes);
            this.Controls.Add(this.GridViewTarefa);
            this.Controls.Add(this.panelInserir);
            this.Controls.Add(this.LabelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(470, 600);
            this.Name = "FormTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minhas Tarefas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTarefas_FormClosing);
            this.Load += new System.EventHandler(this.FormTarefas_Load);
            this.panelInserir.ResumeLayout(false);
            this.panelInserir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTarefa)).EndInit();
            this.Acoes.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateData;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirContaToolStripMenuItem;
    }
}