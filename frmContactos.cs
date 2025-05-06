using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryConexionBDcontactos
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarContactos frm = new frmMostrarContactos();
            frm.ShowDialog();
        }
    }
}
