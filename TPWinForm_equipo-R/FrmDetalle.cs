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
    public partial class FrmDetalle : Form
    {
        private Articulo arti=null;
        private Imagen image=null;

        public FrmDetalle()
        {
            InitializeComponent();
           
        }



        public FrmDetalle(Articulo art,Imagen ima)
        {
            InitializeComponent();
            arti = art;
            image = ima;
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            ImagenNegocio im = new ImagenNegocio();


            
                cargarImagen(image.Url_Imagen);

                lblMarca.Text = arti.Marca_Articulo.Descripcion_Marca;
                lblDescripcion.Text = arti.Categoria_Articulo.Descripcion_Categoria;
                lblNombre.Text = arti.Nombre_Articulo;
                lblPrecio.Text = arti.Precio_Articulo.ToString();
                lblCodArti.Text = arti.Codigo_Articulo;
            


        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbImagen.Load("https://i.pinimg.com/736x/42/65/d9/4265d9b9ee10196f62e9ac38cafc1a24.jpg");

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }





}
