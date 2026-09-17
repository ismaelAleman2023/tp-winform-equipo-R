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
    public partial class FrmAdminPrincipal : Form
    {
        public FrmAdminPrincipal()
        {
            InitializeComponent();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            pnlConteCentral.Controls.Clear();
            fmAdmiCategoria AdminCate=new fmAdmiCategoria();
            AdminCate.TopLevel = false;
            AdminCate.Dock = DockStyle.Fill;    
            pnlConteCentral.Controls.Add(AdminCate);
            AdminCate.Show();

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            pnlConteCentral.Controls.Clear();
            frmAdminMarca adminMarca= new frmAdminMarca();
            adminMarca.TopLevel=false;
            adminMarca.Dock = DockStyle.Fill;
            pnlConteCentral.Controls.Add(adminMarca);
            adminMarca.Show();


        }

        private void btnArt_Click(object sender, EventArgs e)
        {
            pnlConteCentral.Controls.Clear();
            frmAdminArticulo adminArt= new frmAdminArticulo();
            adminArt.TopLevel=false;
            adminArt.Dock = DockStyle.Fill;
            pnlConteCentral.Controls.Add(adminArt);
            adminArt.Show();
        }
    }
}
