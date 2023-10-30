namespace Biblioteca
{
    partial class FrmAlterar
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
            this.cmbTitulo = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDisponivel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDisponibilidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitulo.FormattingEnabled = true;
            this.cmbTitulo.Location = new System.Drawing.Point(140, 84);
            this.cmbTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.Size = new System.Drawing.Size(290, 24);
            this.cmbTitulo.TabIndex = 45;
            this.cmbTitulo.SelectedIndexChanged += new System.EventHandler(this.cmbTitulo_SelectedIndexChanged);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(183, 271);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(247, 22);
            this.txtAno.TabIndex = 44;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(140, 206);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(290, 22);
            this.txtGenero.TabIndex = 43;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(140, 148);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(290, 22);
            this.txtAutor.TabIndex = 42;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(521, 372);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(229, 54);
            this.btnAlterar.TabIndex = 41;
            this.btnAlterar.Text = "Alterar Cadastro";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(39, 273);
            this.lbAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(125, 20);
            this.lbAno.TabIndex = 40;
            this.lbAno.Text = "Ano Publicação";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(40, 206);
            this.lbGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(64, 20);
            this.lbGenero.TabIndex = 39;
            this.lbGenero.Text = "Gênero";
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(40, 148);
            this.lbAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(49, 20);
            this.lbAutor.TabIndex = 38;
            this.lbAutor.Text = "Autor";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(39, 88);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(50, 20);
            this.lbTitulo.TabIndex = 37;
            this.lbTitulo.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Biblioteca Ávila";
            // 
            // lbDisponivel
            // 
            this.lbDisponivel.AutoSize = true;
            this.lbDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisponivel.Location = new System.Drawing.Point(40, 333);
            this.lbDisponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisponivel.Name = "lbDisponivel";
            this.lbDisponivel.Size = new System.Drawing.Size(123, 20);
            this.lbDisponivel.TabIndex = 46;
            this.lbDisponivel.Text = "Disponibilidade";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.perfil1;
            this.pictureBox1.Location = new System.Drawing.Point(521, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Location = new System.Drawing.Point(521, 330);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(229, 23);
            this.btnAlterarFoto.TabIndex = 49;
            this.btnAlterarFoto.Text = "Alterar foto do livro";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            this.btnAlterarFoto.Click += new System.EventHandler(this.btnAlterarFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDisponibilidade
            // 
            this.txtDisponibilidade.Location = new System.Drawing.Point(183, 331);
            this.txtDisponibilidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisponibilidade.Name = "txtDisponibilidade";
            this.txtDisponibilidade.Size = new System.Drawing.Size(247, 22);
            this.txtDisponibilidade.TabIndex = 50;
            // 
            // FrmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisponibilidade);
            this.Controls.Add(this.btnAlterarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDisponivel);
            this.Controls.Add(this.cmbTitulo);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlterar";
            this.Text = "Alterar Cadastro";
            this.Load += new System.EventHandler(this.FrmAlterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTitulo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDisponivel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDisponibilidade;
    }
}