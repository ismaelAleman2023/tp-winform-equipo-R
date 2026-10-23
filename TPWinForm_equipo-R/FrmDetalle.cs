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
        //private Imagen image=null;
        private frmPrincipal frmP;
        private List<Imagen> listImgDetalle = new List<Imagen>();
        private int cantidadImagenes = 0 ;
        private int actu =0;

        public FrmDetalle()
        {
            InitializeComponent();
           
        }



        public FrmDetalle(Articulo art,List<Imagen> ima, frmPrincipal dataGrid)
        {
            InitializeComponent();
            arti = art;
            listImgDetalle = ima;
            frmP = dataGrid;

            cantidadImagenes = listImgDetalle.Count;           

            lblimgActual.Text = (1 + actu).ToString();
            cargarImagen(listImgDetalle[actu].Url_Imagen);           

        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                        
            lblMarca.Text = arti.Marca_Articulo.ToString();
            lblCategoria.Text = arti.Categoria_Articulo.ToString();
            lblDescripcion.Text = arti.Descripcion_Articulo;
            
            lblNombre.Text = arti.Nombre_Articulo;
            lblPrecio.Text = arti.Precio_Articulo.ToString();
            lblCodArti.Text = arti.Codigo_Articulo;
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("=== ERROR AL CARGAR EL DETALLE DEL ARTÍCULO ===");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

              
                MessageBox.Show("Ocurrió un error al mostrar los detalles del artículo.",
                                "Error del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            
            
            

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
            frmP.dtgListar.Focus();
            Close();
            
        }

      

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Imagen img = new Imagen();
            if (actu - 1 >= 0)
            {
                actu--;
                lblimgActual.Text = (1 + actu).ToString();
                img = listImgDetalle[actu];
                cargarImagen(img.Url_Imagen);
            }
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            Imagen img = new Imagen();
            if (actu + 1 <= cantidadImagenes - 1)
            {
                actu++;
                lblimgActual.Text = (1 + actu).ToString();
                img = listImgDetalle[actu];
                
                cargarImagen(img.Url_Imagen);
            }
        }
    }





}
