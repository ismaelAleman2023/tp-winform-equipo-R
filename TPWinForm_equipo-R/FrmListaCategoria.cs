using negocio;
using dominio;
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
    public partial class FrmListaCategoria : Form
    {
        public FrmListaCategoria()
        {
            InitializeComponent();
        }

        private void FrmListaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio cateN = new CategoriaNegocio();
            cargarLista(cateN.lista());


        }


        public void cargarLista(List<Categoria> listcate) {

            try
            {
               
                dgvCate.DataSource = listcate;
       
               

                dgvCate.Columns[0].Visible = false;
                dgvCate.Columns["Descripcion_Categoria"].HeaderText = "Descripcion";

                dgvCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCate.AllowUserToResizeColumns = false;
                dgvCate.AllowUserToResizeRows = false;

            }
            catch (ArgumentOutOfRangeException ex) {
                System.Diagnostics.Debug.WriteLine("=== ERROR GRILLA: COLUMNA INEXISTENTE ===");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show("No se encontró la columna de datos requerida.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("=== ERROR CRÍTICO EN LA GRILLA ===");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show("No se pudieron cargar los datos en la lista.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
