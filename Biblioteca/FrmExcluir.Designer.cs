namespace Biblioteca
{
    partial class FrmExcluir
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
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.cmbTitulo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(206, 339);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(247, 22);
            this.txtAno.TabIndex = 34;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(404, 457);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(268, 54);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(73, 341);
            this.lbAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(125, 20);
            this.lbAno.TabIndex = 28;
            this.lbAno.Text = "Ano Publicação";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(76, 272);
            this.lbGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(64, 20);
            this.lbGenero.TabIndex = 27;
            this.lbGenero.Text = "Gênero";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(76, 214);
            this.lbAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(49, 20);
            this.lbAutor.TabIndex = 26;
            this.lbAutor.Text = "Autor";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(75, 154);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(50, 20);
            this.lbTitulo.TabIndex = 25;
            this.lbTitulo.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(850, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Biblioteca Ávila";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(193, 270);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(479, 22);
            this.txtGenero.TabIndex = 33;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(193, 214);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(479, 22);
            this.txtAutor.TabIndex = 32;
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.FormattingEnabled = true;
            this.cmbTitulo.Location = new System.Drawing.Point(193, 154);
            this.cmbTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.Size = new System.Drawing.Size(479, 24);
            this.cmbTitulo.TabIndex = 35;
            this.cmbTitulo.SelectedIndexChanged += new System.EventHandler(this.cmbTitulo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.perfil1;
            this.pictureBox1.Location = new System.Drawing.Point(751, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FrmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTitulo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExcluir";
            this.Text = "Excluir Cadastro";
            this.Load += new System.EventHandler(this.FrmExcluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ComboBox cmbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}