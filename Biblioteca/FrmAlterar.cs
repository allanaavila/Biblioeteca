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
    public partial class FrmAlterar : MetroFramework.Forms.MetroForm
    {
        public FrmAlterar()
        {
            InitializeComponent();
        }

        private int codigo;
        Dados dados = new Dados();

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dados.Autor = txtAutor.Text;
            dados.Genero = txtGenero.Text;

            if (int.TryParse(txtAno.Text, out int ano))
            {
                dados.AnoPublicacao = ano;
            }
            dados.Disponibilidade = txtDisponibilidade.Text;

            dados.IdLivros = codigo;
            ConverteFoto();

            dados.alterarDados();

            MessageBox.Show("Cadastro livro alterado com sucesso");

            txtAutor.Clear();
            txtGenero.Clear();
            txtAno.Clear();
            txtDisponibilidade.Clear();
        }

        private void FrmAlterar_Load(object sender, EventArgs e)
        {
            cmbTitulo.DisplayMember = "Titulo";
            cmbTitulo.ValueMember = "idLivro";
            cmbTitulo.DataSource = dados.pesquisarDados().Tables[0];
        }

        private void cmbTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo = int.Parse(cmbTitulo.SelectedValue.ToString());
            dados.IdLivros = codigo;

            dados.pesquisarPorID();

            txtAutor.Text = dados.Autor;
            txtGenero.Text = dados.Genero;
            txtAno.Text = dados.AnoPublicacao.ToString();
            txtDisponibilidade.Text = dados.Disponibilidade;

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

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
