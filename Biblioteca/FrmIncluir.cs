using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmIncluir : MetroFramework.Forms.MetroForm
    {
        public FrmIncluir()
        {
            InitializeComponent();
        }
        Dados dados = new Dados();

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dados.Titulo = txtTitulo.Text;
            dados.Autor  = txtAutor.Text;
            dados.Genero = txtGenero.Text;
            dados.AnoPublicacao = int.Parse(txtAno.Text);
            dados.Disponibilidade = txtDisponibilidade.Text;
            ConverteFoto();


            dados.incluirDados();

            MessageBox.Show("Cadastro Livro incluido com sucesso!");

            txtTitulo.Clear();
            txtAutor.Clear();
            txtGenero.Clear();
            txtAno.Clear();
            txtDisponibilidade.Clear();
        }

        private void ConverteFoto()
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] foto_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(foto_array, 0, foto_array.Length);
                dados.Foto = foto_array;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
