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
    public partial class frmFormuEliminarMarca : Form
    {
        public frmFormuEliminarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            MarcaNegocio marcaNego = new MarcaNegocio();
            Marca m = marcaNego.buscarId(idTxt);
            if (m == null || m.Descripcion_Marca == null)
            {
                lbMensajes.ForeColor = Color.Red;
                lbMensajes.Text = "El ID ingresado no existe.";
                return;
            }

            try
            {

                // se pude poner en una clase util
                DialogResult respuesta = MessageBox.Show(

                    "¿Esta Marca esta Asociada a varios Articulos!!",
                    "¿Está seguro de eliminar esta Marca?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                 );
                if (respuesta == DialogResult.Yes)
                {
                    marcaNego.eliminarMarca(idTxt);


                    lbMensajes.ForeColor = Color.Green;
                    lbMensajes.Text = "Eliminado Correctamente";
                }
                else
                {

                    MessageBox.Show("Eliminacion Cancelada");


                }



            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}