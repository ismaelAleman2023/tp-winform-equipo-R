using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;


namespace TPWinForm_equipo_R
{
    public partial class frmArt : Form
    {
        public frmArt()
        {
            InitializeComponent();
        }

        private void frmArt_Load(object sender, EventArgs e)
        {
            try
            {
                cargarGrilla();
                dtgArticulos.EnableHeadersVisualStyles = false;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("=== ERROR CRÍTICO EN LA GRILLA ===");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
               
            }
        }


        public void cargarGrilla()
        {
            ArticuloNegocio artN = new ArticuloNegocio();

            dtgArticulos.DataSource = artN.Listar();
            dtgArticulos.Columns["Descripcion_Articulo"].Visible = false;
            dtgArticulos.Columns["Precio_Articulo"].Visible = false;

            dtgArticulos.Columns["Id_Articulo"].HeaderText = "Id";
            dtgArticulos.Columns["Codigo_Articulo"].HeaderText = "Codigo";
            dtgArticulos.Columns["Nombre_Articulo"].HeaderText = "Nombre";
            dtgArticulos.Columns["Marca_Articulo"].HeaderText = "Marca";
            dtgArticulos.Columns["Categoria_Articulo"].HeaderText = "Categoria";
           
            dtgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgArticulos.AllowUserToResizeColumns = false;
            dtgArticulos.AllowUserToResizeRows = false;
        }   

    }
}
