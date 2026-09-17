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
    public partial class frmIdModificar : Form
    {
        private fmAdmiCategoria frmContePrinci;

        public frmIdModificar(fmAdmiCategoria contenedor)
        {
            InitializeComponent();
            frmContePrinci = contenedor;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfi_Click(object sender, EventArgs e)
        {

            int idTxt = 0;
            if (int.TryParse(txtIdModi.Text, out int numero))
            {

                idTxt = numero;

            }
            else
            {
                lblMensajes.ForeColor = Color.Red;
                lblMensajes.Text = "Por favor, ingrese un número de ID válido.";
                return;
            }

            CategoriaNegocio cat = new CategoriaNegocio();
            Categoria cate = cat.buscarIdCategoria(idTxt);

            if (cate == null) {
                lblMensajes.ForeColor = Color.Red;
                lblMensajes.Text = "El ID ingresado no existe.";
                return;

            }
           


            try
            {
                frmFormuCategoria modificar = new frmFormuCategoria(cate);
                modificar.TopLevel = false;
                modificar.Dock = DockStyle.Fill;

               


                if (frmContePrinci != null)
                {


                    frmContePrinci.pnlContenedorCate.Controls.Clear();
                    frmContePrinci.pnlContenedorCate.Controls.Add(modificar);
                    modificar.BringToFront();
                    modificar.Show();
                }

            }
            catch (Exception EX)
            {

                throw EX;
            }
           




        }

       
    }
}
