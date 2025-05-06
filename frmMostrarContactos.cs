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
    public partial class frmMostrarContactos : Form
    {
        public frmMostrarContactos()
        {
            InitializeComponent();
        }
        clsContactos clsContactos = new clsContactos();
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            clsContactos.Mostrar(dgvContactos);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "") 
            {
                MessageBox.Show("Complete el " + lblNombre.Text);
                txtNombre.Focus();
                txtNombre.BackColor = Color.Red;
            }
            else 
            { 
                if(txtApellido.Text == "") 
                {
                    MessageBox.Show("Complete el " + lblApellido.Text);
                    txtApellido.Focus();
                    txtApellido.BackColor = Color.Red;
                }
                else 
                { 
                    if(txtTel.Text == "") 
                    {
                        MessageBox.Show("Complete el " + lblTel.Text);
                        txtTel.Focus();
                        txtTel.BackColor = Color.Red;
                    }
                    else 
                    { 
                        if(txtCorreo.Text == "") 
                        {
                            MessageBox.Show("Complete el " + lblCorreo.Text);
                            txtCorreo.Focus();
                            txtCorreo.BackColor = Color.Red;
                        }
                        else 
                        {
                            clsContactos.Agregar(txtNombre.Text, txtApellido.Text, txtTel.Text, txtCorreo.Text);
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtNombreE.Text == "") 
            {

                MessageBox.Show("Complete el " + lblNombreE.Text);
                txtNombreE.Focus();
                txtNombreE.BackColor = Color.Red;
            }
            else 
            {
                clsContactos.Eliminar(txtNombreE.Text);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmContactos f = new frmContactos();
            f.Show();
            this.Close();
        }
    }
}
