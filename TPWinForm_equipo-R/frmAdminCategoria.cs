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
            
            pnlContenedorCate.Controls.Clear();
            frmFormuCategoria frm = new frmFormuCategoria();
          
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;

            pnlContenedorCate.Controls.Add(frm);
            frm.Show();
        }

        private void btnSalirCate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarCate_Click(object sender, EventArgs e)
        {
           


            pnlContenedorCate.Controls.Clear();
            frmFormuEliminarCate frmEli=new frmFormuEliminarCate();
            frmEli.TopLevel=false;
            frmEli.Dock = DockStyle.Fill;
            frmEli.FormBorderStyle = FormBorderStyle.None;
            pnlContenedorCate.Controls.Add(frmEli);
            frmEli.Show();

        }

        private void btnModificarCate_Click(object sender, EventArgs e)
        {
            pnlContenedorCate.Controls.Clear();
            frmIdModificar Modi=new frmIdModificar(this);
            Modi.TopLevel=false;
            Modi.Dock = DockStyle.Fill;
            pnlContenedorCate.Controls.Add((frmIdModificar)Modi);
            Modi.Show();


        }
    }
}
