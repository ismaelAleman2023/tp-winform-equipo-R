using dominio;
using negocio;
using System;
using System.Windows.Forms;

namespace TPWinForm_equipo_R
{
    public partial class frmAdminMarca : Form
    {
        private FrmAdminPrincipal principal;
        private FrmListaMarca listaMarca;

        public frmAdminMarca()
        {
            InitializeComponent();
        }

        public frmAdminMarca(FrmAdminPrincipal prin)
        {
            InitializeComponent();
            principal = prin;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void frmAdminMarca_Load(object sender, EventArgs e)
        {
            mostrarLista();
        }

        private void mostrarLista()
        {
            try
            {
                if (listaMarca == null || listaMarca.IsDisposed)
                {
                    listaMarca = new FrmListaMarca();
                    listaMarca.TopLevel = false;
                    listaMarca.Dock = DockStyle.Fill;
                }

                MarcaNegocio negocio = new MarcaNegocio();
                listaMarca.cargarLista(negocio.listarMarcas());

                pnlContenedorMarca.Controls.Clear();
                pnlContenedorMarca.Controls.Add(listaMarca);
                listaMarca.Show();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo mostrar la lista de marcas.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Marca obtenerSeleccion()
        {
            if (listaMarca == null || !pnlContenedorMarca.Controls.Contains(listaMarca))
            {
                mostrarLista();
                MessageBox.Show("Seleccione una marca de la lista.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            Marca seleccionada = listaMarca.marcaSeleccionada();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una marca de la lista.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return seleccionada;
        }

        private void mostrarFormulario(frmFormuMarca frm)
        {
            pnlContenedorMarca.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlContenedorMarca.Controls.Add(frm);
            frm.Show();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                mostrarFormulario(new frmFormuMarca(mostrarLista));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo cargar la pantalla de Agregar.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca seleccionada = obtenerSeleccion();
                if (seleccionada == null)
                    return;

                mostrarFormulario(new frmFormuMarca(seleccionada, mostrarLista));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo cargar la pantalla de Modificar.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca seleccionada = obtenerSeleccion();
                if (seleccionada == null)
                    return;

                MarcaNegocio negocio = new MarcaNegocio();

                if (negocio.tieneArticulos(seleccionada.Id_Marca))
                {
                    MessageBox.Show("No se puede eliminar la marca '" + seleccionada.Descripcion_Marca +
                                    "' porque está asociada a uno o más artículos.",
                                    "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar la marca '" + seleccionada.Descripcion_Marca + "'?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminarMarca(seleccionada.Id_Marca);
                    mostrarLista();
                    MessageBox.Show("Marca eliminada con éxito.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo eliminar la marca seleccionada. Intente nuevamente.",
                                "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (principal != null)
                {
                    principal.pnlConteCentral.Controls.Clear();
                    frmFormuListar lista = new frmFormuListar();
                    lista.TopLevel = false;
                    lista.Dock = DockStyle.Fill;
                    principal.pnlConteCentral.Controls.Add(lista);
                    lista.Show();
                }

                Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo regresar a la pantalla anterior.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}