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
    public partial class FrmExcluir : MetroFramework.Forms.MetroForm
    {
        public FrmExcluir()
        {
            InitializeComponent();
        }
        private int idLivros;
        Dados dados = new Dados();

        private void FrmExcluir_Load(object sender, EventArgs e)
        {
            cmbTitulo.DisplayMember = "Titulo";
            cmbTitulo.ValueMember = "idLivro";
            cmbTitulo.DataSource = dados.pesquisarDados().Tables[0];
        }

        private void cmbTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idLivros = int.Parse(cmbTitulo.SelectedValue.ToString());
            dados.IdLivros = idLivros;
            dados.pesquisarPorID();

            txtAutor.Text = dados.Autor;
            txtGenero.Text = dados.Genero;
            txtAno.Text = dados.AnoPublicacao.ToString();

            if (!(dados.Foto is null))
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(dados.Foto, 0, dados.Foto.Length);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.perfil1;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dados.IdLivros = idLivros;
            ConverteFoto();
            dados.excluirDados();

            MessageBox.Show("Livro cadastrado excluido com sucesso");

            cmbTitulo.DisplayMember = "Titulo";
            cmbTitulo.ValueMember = "idLivro";
            cmbTitulo.DataSource = dados.pesquisarDados().Tables[0];

            txtAutor.Clear();
            txtGenero.Clear();
            txtAno.Clear();
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
    }
}
