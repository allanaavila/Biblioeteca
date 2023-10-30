namespace Biblioteca
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorGeneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(27, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarPorGeneroToolStripMenuItem,
            this.pesquisarPorAnoToolStripMenuItem,
            this.pesquisarPorTituloToolStripMenuItem,
            this.pesquisarPorAutorToolStripMenuItem});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // pesquisarPorGeneroToolStripMenuItem
            // 
            this.pesquisarPorGeneroToolStripMenuItem.Name = "pesquisarPorGeneroToolStripMenuItem";
            this.pesquisarPorGeneroToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.pesquisarPorGeneroToolStripMenuItem.Text = "Pesquisar por Genero";
            this.pesquisarPorGeneroToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorGeneroToolStripMenuItem_Click);
            // 
            // pesquisarPorAnoToolStripMenuItem
            // 
            this.pesquisarPorAnoToolStripMenuItem.Name = "pesquisarPorAnoToolStripMenuItem";
            this.pesquisarPorAnoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.pesquisarPorAnoToolStripMenuItem.Text = "Pesquisar por Ano";
            this.pesquisarPorAnoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorAnoToolStripMenuItem_Click);
            // 
            // pesquisarPorTituloToolStripMenuItem
            // 
            this.pesquisarPorTituloToolStripMenuItem.Name = "pesquisarPorTituloToolStripMenuItem";
            this.pesquisarPorTituloToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.pesquisarPorTituloToolStripMenuItem.Text = "Pesquisar por Titulo";
            this.pesquisarPorTituloToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorTituloToolStripMenuItem_Click);
            // 
            // pesquisarPorAutorToolStripMenuItem
            // 
            this.pesquisarPorAutorToolStripMenuItem.Name = "pesquisarPorAutorToolStripMenuItem";
            this.pesquisarPorAutorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.pesquisarPorAutorToolStripMenuItem.Text = "Pesquisar por Autor";
            this.pesquisarPorAutorToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorAutorToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorGeneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorAnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorAutorToolStripMenuItem;
    }
}

