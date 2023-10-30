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
    public partial class FrmPesquisaPorGenero : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisaPorGenero()
        {
            InitializeComponent();
        }

        Dados dados = new Dados();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dados.Genero = txtBuscarGenero.Text;
            dataGridView1.DataSource = dados.buscarGenero().Tables[0];
        }
    }
}
