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
    public partial class FrmPesquisarPorTitulo : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisarPorTitulo()
        {
            InitializeComponent();
        }
        Dados dados = new Dados();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dados.Titulo = txtBuscarTitulo.Text;
            dataGridView1.DataSource = dados.buscarTitulo().Tables[0];
        }
    }
}
