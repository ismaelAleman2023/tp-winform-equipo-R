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
    public partial class frmFormuModificarMarca : Form
    {
        private Marca marcaActual;

        public frmFormuModificarMarca()
        {
            InitializeComponent();
        }

        private void frmFormuModificarMarca_Load(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtid.Text, out int id))
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, ingrese un número de ID válido.";
                return;
            }

            MarcaNegocio marcaNego = new MarcaNegocio();
            Marca m = marcaNego.buscarId(id);

            if (m == null || m.Descripcion_Marca == null)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El ID ingresado no existe.";
                txtDescripcion.Text = "";
                txtDescripcion.Enabled = false;
                btnConfirmar.Enabled = false;
                return;
            }

            marcaActual = m;
            txtDescripcion.Text = m.Descripcion_Marca;
            txtDescripcion.Enabled = true;
            btnConfirmar.Enabled = true;
            lblMensaje.ForeColor = Color.Black;
            lblMensaje.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (marcaActual == null)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Primero busque una marca por ID.";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El campo no puede estar vacío.";
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

            MarcaNegocio marcaNego = new MarcaNegocio();

            try
            {
                marcaActual.Descripcion_Marca = txtDescripcion.Text;
                marcaNego.modificarMarca(marcaActual);

                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Modificado correctamente.";
                MessageBox.Show("Marca modificada correctamente.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}