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
    public partial class frmFormuCategoria : Form
    {
        public frmFormuCategoria()
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

        private void frmFormuCategoria_Load(object sender, EventArgs e)
        {
            txtId.Text = "Id Asignado Automanticamente";
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) {

                lblMensajes.ForeColor = Color.Red;
                lblMensajes.Text = "El Campo no puede esta vacio";
                txtDescripcion.Focus();
                return;
            }

            if (txtDescripcion.Text.Any(char.IsDigit))
            {
                lblMensajes.ForeColor = Color.Red;
                lblMensajes.Text = "El nombre no puede contener números.";
                txtDescripcion.Focus();
                return;
            }
            

            Categoria cate=new Categoria();
            CategoriaNegocio catenego=new CategoriaNegocio();
            
            try
            {

            string descrip=txtDescripcion.Text;
            cate.Descripcion_Categoria=descrip;
                catenego.agregarCategoria(cate);
                lblMensajes.Text = "";
                MessageBox.Show("Agregado Correctamente");
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
