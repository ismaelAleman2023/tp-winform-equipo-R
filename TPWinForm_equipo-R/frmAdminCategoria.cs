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
        public fmAdmiCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregarCate_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType()==typeof(frmFormuCategoria)) {

                    return;
                }

            }


            frmFormuCategoria frm = new frmFormuCategoria();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlContenedorCate.Controls.Clear();
            pnlContenedorCate.Controls.Add(frm);
            frm.Show();
        }

        private void btnSalirCate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
