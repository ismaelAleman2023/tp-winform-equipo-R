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
    public partial class frmAdminArticulo : Form
    {
        private frmArt frArt =null;
        private FrmAdminPrincipal principal;    
        public frmAdminArticulo()
        {
            InitializeComponent();
        }
        public frmAdminArticulo(FrmAdminPrincipal prin)
        {
            InitializeComponent();
        principal = prin;
        
        }

        private void frmAdminArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                pnlconteArti.Controls.Clear();
                frArt = new frmArt();

                frArt.TopLevel = false;
                frArt.Dock = DockStyle.Fill;

                pnlconteArti.Controls.Add(frArt);

                frArt.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la grilla de articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmArticulo fArti = new frmArticulo();

                fArti.Cancelado += (s, args) => {
                    pnlconteArti.Controls.Clear();
                    frArt = new frmArt();
                    frArt.TopLevel = false;
                    frArt.Dock = DockStyle.Fill;
                    pnlconteArti.Controls.Add(frArt);
                    frArt.Show();
                };

                fArti.Guardado += (s, args) => {
                    pnlconteArti.Controls.Clear();
                    frArt = new frmArt();
                    frArt.TopLevel = false;
                    frArt.Dock = DockStyle.Fill;
                    pnlconteArti.Controls.Add(frArt);
                    frArt.Show();
                };


                fArti.TopLevel = false;
                fArti.Dock = DockStyle.Fill;
                pnlconteArti.Controls.Clear();
                pnlconteArti.Controls.Add(fArti);
                fArti.Show();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio artN = new ArticuloNegocio();  
                Articulo artiselc = (Articulo)frArt.dtgArticulos.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show(
                        "¿Está seguro de eliminar el artículo?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                );
                if (respuesta == DialogResult.Yes)
                {

                    ImagenNegocio imgN = new ImagenNegocio();


                    imgN.eliminarImagen(artiselc.Id_Articulo);

                    artN.eliminar(artiselc.Id_Articulo);
                    MessageBox.Show("Artículo eliminado correctamente.");
                    
                    frArt.cargarGrilla();
                }
                else
                {

                    MessageBox.Show("Eliminacion cancelada.");
                    
                }


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("=== ERROR CRÍTICO EN LA GRILLA ===");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }         
            
            
        }

        private void btnModifical_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio artN = new ArticuloNegocio();

                Articulo artiSelect = (Articulo)frArt.dtgArticulos.CurrentRow.DataBoundItem;

                ImagenNegocio imgN = new ImagenNegocio();

                List<Imagen> listaImg = imgN.BuscarImagenesId(artiSelect.Id_Articulo);

                frmArticulo pantaArt = new frmArticulo(artiSelect, listaImg);

                pantaArt.Cancelado += (s, args) => {

                    pnlconteArti.Controls.Clear();
                    frArt = new frmArt();
                    frArt.TopLevel = false;
                    frArt.Dock = DockStyle.Fill;
                    pnlconteArti.Controls.Add(frArt);
                    frArt.Show();
                };


                pantaArt.Guardado += (s, args) => {
                    pnlconteArti.Controls.Clear();
                    frArt = new frmArt();
                    frArt.TopLevel = false;
                    frArt.Dock = DockStyle.Fill;
                    pnlconteArti.Controls.Add(frArt);
                    frArt.Show();
                };


                pantaArt.TopLevel = false;
                pantaArt.FormBorderStyle = FormBorderStyle.None;
                pantaArt.Dock = DockStyle.Fill;

                pnlconteArti.Controls.Clear();
                pnlconteArti.Controls.Add(pantaArt);
                pantaArt.Show();
                              
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
