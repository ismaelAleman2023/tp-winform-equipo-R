using dominio;
using negocio;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TPWinForm_equipo_R
{
    public partial class frmFormuMarca : Form
    {
        private Marca marcaModificar = null;
        private Action alVolver;

        public frmFormuMarca()
        {
            InitializeComponent();
        }

        public frmFormuMarca(Action alVolver)
        {
            InitializeComponent();
            this.alVolver = alVolver;
        }

        public frmFormuMarca(Marca marca, Action alVolver)
        {
            InitializeComponent();
            marcaModificar = marca;
            this.alVolver = alVolver;
        }

        private void frmFormuMarca_Load(object sender, EventArgs e)
        {
            if (marcaModificar != null)
            {
                label1.Text = "Modificar Marca";
                txtDescripcion.Text = marcaModificar.Descripcion_Marca;
            }
            else
            {
                label1.Text = "Agregar Marca";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void volver()
        {
            if (alVolver != null)
                alVolver();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                volver();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudo volver a la lista de marcas.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string descrip = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(descrip))
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El campo no puede estar vacío.";
                txtDescripcion.Focus();
                return;
            }

            if (descrip.Any(char.IsDigit))
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El nombre no puede contener números.";
                txtDescripcion.Focus();
                return;
            }

            MarcaNegocio marcaNego = new MarcaNegocio();

            try
            {
                int idActual = marcaModificar != null ? marcaModificar.Id_Marca : 0;

                if (marcaNego.existeMarca(descrip, idActual))
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Esta marca ya está registrada.";
                    txtDescripcion.Focus();
                    return;
                }

                if (marcaModificar == null)
                {
                    Marca nueva = new Marca();
                    nueva.Descripcion_Marca = descrip;
                    marcaNego.agregarMarca(nueva);

                    lblMensaje.Text = "";
                    MessageBox.Show("Marca agregada correctamente.");
                    txtDescripcion.Text = "";
                }
                else
                {
                    marcaModificar.Descripcion_Marca = descrip;
                    marcaNego.modificarMarca(marcaModificar);

                    MessageBox.Show("Marca modificada correctamente.");
                    volver();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudieron guardar los cambios en la base de datos.",
                                "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
            }
        }
    }
}