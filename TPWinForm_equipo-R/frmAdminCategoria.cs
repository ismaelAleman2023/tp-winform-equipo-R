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
    public partial class fmAdmiCategoria : Form
    {
        private FrmAdminPrincipal Principal;
        private FrmListaCategoria listcat;

        public fmAdmiCategoria()
        {
            InitializeComponent();
        }

        public fmAdmiCategoria(FrmAdminPrincipal prin)
        {
            InitializeComponent();
            Principal = prin;
        }


        private void btnAgregarCate_Click(object sender, EventArgs e)
        {
            try
            {
                pnlContenedorCate.Controls.Clear();
                frmFormuCategoria frm = new frmFormuCategoria(this, listcat);

                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;

                pnlContenedorCate.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR EN BOTÓN AGREGAR");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show("No se pudo cargar la pantalla de Agregar.",
                          "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void btnEliminarCate_Click(object sender, EventArgs e)
        {
            try
            {

                if (listcat != null && listcat.dgvCate != null && listcat.dgvCate.CurrentRow != null)
                {

                    Categoria seleccionada = (Categoria)listcat.dgvCate.CurrentRow.DataBoundItem;


                    bool asociado = validarArt(seleccionada.Descripcion_Categoria);

                    if (asociado)
                    {
                        MessageBox.Show("No se puede Eliminar Una categoria que esta asociada a un Articulo");
                        return;

                    }


                    DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar la categoría '{seleccionada.Descripcion_Categoria}'?",
                                                             "Confirmar Eliminación",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question);


                    if (respuesta == DialogResult.Yes)
                    {
                        CategoriaNegocio catenego = new CategoriaNegocio();


                        catenego.eliminarCategoria(seleccionada.Id_Categoria);

                        listcat.cargarLista(catenego.lista());

                        MessageBox.Show("Categoría eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría de la lista para eliminar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("ERROR EN BOTÓN ELIMINAR DIRECTO");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("Ocurrió un error inesperado al intentar eliminar la categoría. Por favor, intente nuevamente más tarde.",
                                "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {

                if (listcat != null && listcat.dgvCate != null)
                {
                    listcat.dgvCate.ClearSelection();
                }


            }

        }

        private void btnModificarCate_Click(object sender, EventArgs e)
        {
            try
            {

                if (listcat != null && listcat.dgvCate != null && listcat.dgvCate.CurrentRow != null)
                {

                    Categoria seleccionada = (Categoria)listcat.dgvCate.CurrentRow.DataBoundItem;

                    pnlContenedorCate.Controls.Clear();


                    frmFormuCategoria modificar = new frmFormuCategoria(seleccionada, this, listcat);
                    modificar.TopLevel = false;
                    modificar.Dock = DockStyle.Fill;
                    modificar.FormBorderStyle = FormBorderStyle.None;

                    pnlContenedorCate.Controls.Add(modificar);
                    modificar.BringToFront();
                    modificar.Show();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR EN BOTÓN MODIFICAR");
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo cargar la pantalla.", "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void fmAdmiCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                pnlContenedorCate.Controls.Clear();

                listcat = new FrmListaCategoria();
                listcat.TopLevel = false;
                listcat.Dock = DockStyle.Fill;
                pnlContenedorCate.Controls.Add(listcat);
                listcat.Show();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR AL CONTENER LA GRILA EN EL PANEL");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show("No se pudo inicializar el panel de visualización.",
                        "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }

        private bool validarArt(string nombre)
        {

            ArticuloNegocio artNego = new ArticuloNegocio();
            bool aux = false;

            foreach (Articulo art in artNego.Listar())
            {

                if (art.Categoria_Articulo.Descripcion_Categoria == nombre)
                {

                    return true;

                }

            }


            return false;


        }


    }
}
