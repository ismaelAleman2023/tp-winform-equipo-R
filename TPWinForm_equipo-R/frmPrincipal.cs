using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_R
{
    public partial class frmPrincipal : Form
    {


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            FrmAdminPrincipal frmadministrar = new FrmAdminPrincipal();
            frmadministrar.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio artN = new ArticuloNegocio();

            rbtnTodos.Checked = true;
            cargarDataGrid(artN.Listar());


            dtgListar.CurrentCell = dtgListar.Rows[0].Cells[1];
        }



        private void cargarDataGrid(List<Articulo> lista)
        {
            dtgListar.DataSource = lista;

            dtgListar.Columns["Id_Articulo"].Visible = false;
            dtgListar.Columns["Descripcion_Articulo"].Visible = false;

            dtgListar.Columns["Codigo_Articulo"].HeaderText = "Codigo";
            dtgListar.Columns["Nombre_Articulo"].HeaderText = "Nombre";
            dtgListar.Columns["Precio_Articulo"].HeaderText = "Precio";
            dtgListar.Columns["Marca_Articulo"].HeaderText = "Marca";
            dtgListar.Columns["Categoria_Articulo"].HeaderText = "Categoria";

            dtgListar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListar.AllowUserToResizeColumns = false;
            dtgListar.AllowUserToResizeRows = false;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            ImagenNegocio imgN = new ImagenNegocio();
            Articulo art = new Articulo();
            Imagen img = new Imagen();

            art = (Articulo)dtgListar.CurrentRow.DataBoundItem;
            img = imgN.BuscarImagenId(art.Id_Articulo);

            FrmDetalle deta = new FrmDetalle(art, img, this);
            deta.ShowDialog();
        }



        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {
            MarcaNegocio marcaN = new MarcaNegocio();
            comboMostrar.DataSource = marcaN.listarMarcas();
            comboMostrar.ValueMember = "Id_Marca";
            comboMostrar.DisplayMember = "Descripcion_Marca";
        }

        private void rbtnCategoria_CheckedChanged(object sender, EventArgs e)
        {
            CategoriaNegocio catN = new CategoriaNegocio();
            comboMostrar.DataSource = catN.lista();
            comboMostrar.ValueMember = "Id_Categoria";
            comboMostrar.DisplayMember = "Descripcion_Categoria";
        }


        private List<Articulo> cargarLista()
        {
            ArticuloNegocio artN = new ArticuloNegocio();
            return artN.Listar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Articulo artiAux = new Articulo();

            List<Articulo> listArticulo = cargarLista();
            List<Articulo> listAux = new List<Articulo>();

            if (rbtnCategoria.Checked)
            {             
                artiAux.Categoria_Articulo = (Categoria)comboMostrar.SelectedItem;
                string nombre = artiAux.Categoria_Articulo.ToString(); ;

                if(nombre != "")
                {

                 listAux = listArticulo.FindAll(arte => arte.Categoria_Articulo.ToString() == nombre);
                }
               else
                {
                    MessageBox.Show("seleccione una categoria");
                    return;
                }
            }
            


            else if(rbtnMarca.Checked)
            {
                artiAux.Marca_Articulo = (Marca)comboMostrar.SelectedItem;
                string nombre = artiAux.Marca_Articulo.ToString();
                if(nombre != "") 
                {
                 listAux = listArticulo.FindAll(marca => marca.Marca_Articulo.ToString() == nombre);
                }
                else
                {
                    MessageBox.Show("seleccione una Marca");
                    return;
                }

               

            }
            else if (rbtnTodos.Checked)
            {
                listAux = listArticulo;
            }
            else if (rbtnRango.Checked)
            {
                
                if(!int.TryParse(txtDesde.Text,out int desde)|| !int.TryParse(txtHasta.Text, out int hasta))
                {
                    MessageBox.Show("solo ingrese numeros");
                    return;
                }

                foreach (Articulo art in listArticulo)
                {
                    if (art.Precio_Articulo >= desde && art.Precio_Articulo <= hasta)
                    {
                        listAux.Add(art);
                    }

                }

            }

            cargarDataGrid(listAux);

        }
    }
}
