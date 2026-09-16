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
    public partial class frmFormuEliminarCate : Form
    {
        public frmFormuEliminarCate()
        {
            InitializeComponent();
        }

        private void btnConfirmarEli_Click(object sender, EventArgs e)
        {
            int idTxt = 0;
            if (int.TryParse(txtid.Text, out int numero))
            {
                
                idTxt = numero;

            }
            else
            {
                lbMensajes.ForeColor = Color.Red;
                lbMensajes.Text = "Por favor, ingrese un número de ID válido.";
                return;
            }

            CategoriaNegocio cate = new CategoriaNegocio();
            Categoria ct = cate.buscarIdCategoria(idTxt);
            if (ct==null) {

                lbMensajes.ForeColor = Color.Red;
                lbMensajes.Text = "El ID ingresado no existe.";
                return;


            }

            try
            {


               cate.eliminarCategoria(idTxt);


                lbMensajes.ForeColor = Color.Green;
                lbMensajes.Text = "Eliminado Correctamente";


            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
