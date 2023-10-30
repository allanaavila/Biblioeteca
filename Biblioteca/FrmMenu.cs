using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmMenu : MetroFramework.Forms.MetroForm
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncluir frmIncluir = new FrmIncluir();
            frmIncluir.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterar frmAlterar = new FrmAlterar();
            frmAlterar.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluir frmExcluir = new FrmExcluir();
            frmExcluir.ShowDialog();
        }

        private void pesquisarPorGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaPorGenero frm = new FrmPesquisaPorGenero();
            frm.ShowDialog();
        }

        private void pesquisarPorAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisarPorAno frm = new FrmPesquisarPorAno();
            frm.ShowDialog();
        }

        private void pesquisarPorTituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisarPorTitulo frm  = new FrmPesquisarPorTitulo();
            frm.ShowDialog();
        }

        private void pesquisarPorAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisarPorAutor frm = new FrmPesquisarPorAutor();
            frm.ShowDialog();
        }
    }
}
