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
    public partial class frmAdminMarca : Form
    {
        public frmAdminMarca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmFormuMarca))
                {
                    return;
                }
            }

            frmFormuMarca frm = new frmFormuMarca();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlContenedorMarca.Controls.Clear();
            pnlContenedorMarca.Controls.Add(frm);
            frm.Show();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            frmFormuModificarMarca frm = new frmFormuModificarMarca();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlContenedorMarca.Controls.Clear();
            pnlContenedorMarca.Controls.Add(frm);
            frm.Show();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            frmFormuEliminarMarca frmEli = new frmFormuEliminarMarca();
            frmEli.TopLevel = false;
            frmEli.Dock = DockStyle.Fill;
            pnlContenedorMarca.Controls.Clear();
            pnlContenedorMarca.Controls.Add(frmEli);
            frmEli.Show();
        }

        private void btnListarMarca_Click(object sender, EventArgs e)
        {
            frmFormuListarMarca frm = new frmFormuListarMarca();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlContenedorMarca.Controls.Clear();
            pnlContenedorMarca.Controls.Add(frm);
            frm.Show();
        }

        private void btnSalirMarca_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}