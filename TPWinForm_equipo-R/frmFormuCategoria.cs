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
            

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Categoria cate=new Categoria();
            CategoriaNegocio catenego=new CategoriaNegocio();
            
            try
            {

            string descrip=txtDescripcion.Text;
            cate.Descripcion_Categoria=descrip;
                catenego.agregarCategoria(cate);
                MessageBox.Show("Agregado Correctamente");
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
