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
    public partial class frmFormuListar : Form
    {
        public frmFormuListar()
        {
            InitializeComponent();
        }

  

        private void CargarGrilla(List<Marca> listmar ,List<Categoria>listcate)
        {
            try
            {
             dgvMarcas.DataSource = listmar;

            dgvMarcas.Columns["Id_Marca"].HeaderText = "Id";
            dgvMarcas.Columns["Descripcion_Marca"].HeaderText= "Descripcion";

            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.AllowUserToResizeColumns = false;
            dgvMarcas.AllowUserToResizeRows = false;

                dgvCate.DataSource = listcate;

                dgvCate.Columns["Id_Categoria"].HeaderText = "Id";
                dgvCate.Columns["Descripcion_Categoria"].HeaderText = "Descripcion";




                dgvCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCate.AllowUserToResizeColumns = false;
                dgvCate.AllowUserToResizeRows = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormuListar_Load_1(object sender, EventArgs e)
        {
            CategoriaNegocio cateN=new CategoriaNegocio();
            MarcaNegocio marcN=new MarcaNegocio();

            CargarGrilla(marcN.listarMarcas(),cateN.lista());
        }
    }
}