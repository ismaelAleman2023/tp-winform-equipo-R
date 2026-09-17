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
        public frmAdminArticulo()
        {
            InitializeComponent();
        }

        private void frmAdminArticulo_Load(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            frmArticulo fArti = new frmArticulo();
            fArti.TopLevel = false;
            fArti.Dock = DockStyle.Fill;
            pnlconteArti.Controls.Clear();
            pnlconteArti.Controls.Add(fArti);
            fArti.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
            
            frmEliminarArticulo fElimArt= new frmEliminarArticulo();
            fElimArt.TopLevel = false;
            fElimArt.Dock = DockStyle.Fill;
            pnlconteArti.Controls.Clear();
            pnlconteArti.Controls.Add(fElimArt);
            fElimArt.Show();
        }

        private void btnModifical_Click(object sender, EventArgs e)
        {
            frmModificarIdArt fArtMod = new frmModificarIdArt(this);
            fArtMod.TopLevel = false;
            fArtMod.Dock = DockStyle.Fill;
            pnlconteArti.Controls.Clear();
            pnlconteArti.Controls.Add(fArtMod);
            fArtMod.Show();

        }
    }
}
