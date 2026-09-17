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
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;
        private Imagen imagen = null;
        public frmArticulo()
        {
            InitializeComponent();
            
        }

        public frmArticulo(Articulo art, Imagen img)
        {
            InitializeComponent();
            this.articulo = art;
            this.imagen = img;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio artN = new ArticuloNegocio();
                ImagenNegocio imgN = new ImagenNegocio();
                Articulo arti = new Articulo();
                Imagen img = new Imagen();
                
                if (articulo == null)
                {
                    arti.Codigo_Articulo = txtCodArt.Text;
                    arti.Nombre_Articulo = txtNombre.Text;
                    arti.Precio_Articulo = Convert.ToDecimal(txtPrecio.Text);
                    arti.Descripcion_Articulo = txtDescripcion.Text;

                    arti.Categoria_Articulo=(Categoria) comboCategoria.SelectedItem;
              
                    arti.Marca_Articulo = (Marca)comboMarca.SelectedItem;

                    artN.agregar(arti);

                    int aux = artN.ultimoId();
               

                   img.Url_Imagen = txtImagen.Text;
                   img.IdArticulo_Imagen = aux;

                   imgN.agregarImagen(img);
                   MessageBox.Show("agregado correctamente");

                }
                else
                {
                    arti.Id_Articulo = articulo.Id_Articulo;
                    arti.Codigo_Articulo = txtCodArt.Text;
                    arti.Nombre_Articulo = txtNombre.Text;
                    arti.Precio_Articulo = Convert.ToDecimal(txtPrecio.Text);
                    arti.Descripcion_Articulo = txtDescripcion.Text;

                    arti.Categoria_Articulo = (Categoria)comboCategoria.SelectedItem;

                    arti.Marca_Articulo = (Marca)comboMarca.SelectedItem;

                    artN.modificar(arti);

                    
                    string url = txtImagen.Text;
                    imgN.modificarImagen(url, articulo.Id_Articulo);
                    MessageBox.Show("Modificado correctamente");

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

          

            Close();

        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            cargarCategoria();
            cargarMarca();

            if (articulo != null)
            {
                txtIdArt.Text = articulo.Id_Articulo.ToString();
                txtIdArt.ReadOnly = true;
                txtIdArt.Enabled = false;
                txtCodArt.Text= articulo.Codigo_Articulo;
                txtNombre.Text=articulo.Nombre_Articulo;
                txtDescripcion.Text=articulo.Descripcion_Articulo;
                txtPrecio.Text = articulo.Precio_Articulo.ToString();

                if (imagen != null)
                {
                    txtImagen.Text = imagen.Url_Imagen;
                    cargarImagen(imagen.Url_Imagen);
                }

                comboCategoria.SelectedValue = articulo.Categoria_Articulo.Id_Categoria;
                comboMarca.SelectedValue = articulo.Marca_Articulo.Id_Marca;
                txtCodArt.Focus();
            }
            else
            {
                txtIdArt.Text = "El id se genera solo";
                txtIdArt.ReadOnly = true;
                txtIdArt.Enabled = false;

                comboCategoria.SelectedIndex = -1;
                comboCategoria.Text = "Seleccione una opción...";

                comboMarca.SelectedIndex = -1;
                comboMarca.Text = "Seleccione una opción...";
                txtCodArt.Focus();

            }

          
        }


        private void cargarCategoria()
        {
            CategoriaNegocio catN=new CategoriaNegocio();
            
            comboCategoria.DataSource=catN.lista();
            comboCategoria.ValueMember = "Id_Categoria"; 
            comboCategoria.DisplayMember = "Descripcion_categoria";

        }

        private void cargarMarca()
        {
            MarcaNegocio marcaN= new MarcaNegocio();
            comboMarca.DataSource = marcaN.listarMarcas();
            comboMarca.ValueMember = "Id_Marca";     
            comboMarca.DisplayMember = "Descripcion_Marca";
           
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                ptBImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                ptBImagen.Load("https://i.pinimg.com/736x/42/65/d9/4265d9b9ee10196f62e9ac38cafc1a24.jpg");
                
            }
        }

        private void limpiarCeldas()
        {
            txtCodArt.Text = "";
            txtDescripcion.Text = "";
            txtImagen.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";



        }

      
    }
}
