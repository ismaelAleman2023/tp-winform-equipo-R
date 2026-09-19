using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_R
{
    public partial class frmModificarIdArt : Form
    {
        private frmAdminArticulo contenedorOriginal;
        public frmModificarIdArt()
        {
            InitializeComponent();
        }

        public frmModificarIdArt(frmAdminArticulo contenedor)
        {
            InitializeComponent();
            this.contenedorOriginal = contenedor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAeptar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio artN = new ArticuloNegocio();

                if (!int.TryParse(txtArtModifid.Text, out int resultado))
                {
                    lblMensaje.Text = "Ingrese un número válido";
                    await Task.Delay(3000);
                    lblMensaje.Text = "";
                    return;
                }


                Articulo art = artN.BuscarId(resultado);


                if (art == null)
                {
                    lblMensaje.Text = "El id ingresado es incorrecto";

                    await Task.Delay(3000);
                    txtArtModifid.Text = "";
                    lblMensaje.Text = "";
                    return;
                }
                ImagenNegocio imgN = new ImagenNegocio();

                Imagen img = imgN.BuscarImagenId(art.Id_Articulo);


                frmArticulo pantaArt = new frmArticulo(art, img);

                pantaArt.TopLevel = false;
                pantaArt.FormBorderStyle = FormBorderStyle.None;
                pantaArt.Dock = DockStyle.Fill;

                contenedorOriginal.pnlconteArti.Controls.Clear();
                contenedorOriginal.pnlconteArti.Controls.Add(pantaArt);
                pantaArt.Show();
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }


        }
    }
}
