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
    public partial class frmFormuListarMarca : Form
    {
        public frmFormuListarMarca()
        {
            InitializeComponent();
        }

        private void frmFormuListarMarca_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MarcaNegocio marcaNego = new MarcaNegocio();
            dgvMarcas.DataSource = marcaNego.listarMarcas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}