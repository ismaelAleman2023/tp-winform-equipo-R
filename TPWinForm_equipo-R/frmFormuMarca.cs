using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_R
{
    public partial class frmFormuMarca : Form
    {
        public frmFormuMarca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El Campo no puede estar vacio";
                txtDescripcion.Focus();
                return;
            }

            if (txtDescripcion.Text.Any(char.IsDigit))
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El nombre no puede contener números.";
                txtDescripcion.Focus();
                return;
            }

            Marca marca = new Marca();
            MarcaNegocio marcaNego = new MarcaNegocio();

            try
            {
                string descrip = txtDescripcion.Text;
                marca.Descripcion_Marca = descrip;
                marcaNego.agregarMarca(marca);
                lblMensaje.Text = "";
                MessageBox.Show("Marca agregada correctamente. El ID fue asignado automáticamente.");
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}