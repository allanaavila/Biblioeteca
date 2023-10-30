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
    public partial class FrmPesquisarPorAno : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisarPorAno()
        {
            InitializeComponent();
        }
        Dados dados = new Dados();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarAno.Text, out int ano))
            {
                dados.AnoPublicacao = ano;
                dataGridView1.DataSource = dados.buscarAnoPublicacao().Tables[0];
            }
        }
    }
}
