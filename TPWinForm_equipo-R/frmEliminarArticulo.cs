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
    public partial class frmEliminarArticulo : Form
    {
        public frmEliminarArticulo()
        {
            InitializeComponent();
        }

        private void btnConfirmarEliminar_Click(object sender, EventArgs e)
        {
            int aux;

            try
            {
                if (int.TryParse(txtidEliminar.Text, out int numero))
                {
                    aux = numero;
                }
                else
                {
                    MessageBox.Show("ingrese solo numeros");
                    return;
                }

                ArticuloNegocio artN = new ArticuloNegocio();
                Articulo art = artN.BuscarId(aux);

                if (art != null)
                {

                    // se pude poner en una clase util
                    
                }
                else
                {
                    MessageBox.Show("el id ingresado es incorrecto o no existe");
                    txtidEliminar.Text = "";

                }


            }
            catch (Exception)
            {

                throw;
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

    }
}
