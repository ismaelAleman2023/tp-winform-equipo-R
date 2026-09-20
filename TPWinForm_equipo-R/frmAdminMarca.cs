using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_R
{
    public partial class frmAdminMarca : Form
    {
        private FrmAdminPrincipal principal;
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

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {

            try
            {
                pnlContenedorMarca.Controls.Clear();
                frmFormuMarca frm = new frmFormuMarca();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;

                pnlContenedorMarca.Controls.Add(frm);
                frm.Show();
            }
            catch(Exception ex) {

                throw ex;
            
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            try { 
            pnlContenedorMarca.Controls.Clear();
            frmFormuModificarMarca frm = new frmFormuModificarMarca();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            
            pnlContenedorMarca.Controls.Add(frm);
            frm.Show();
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }
            
          }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {


            try
            {
            pnlContenedorMarca.Controls.Clear();
            frmFormuEliminarMarca frmEli = new frmFormuEliminarMarca();
            frmEli.TopLevel = false;
            frmEli.Dock = DockStyle.Fill;
            
            pnlContenedorMarca.Controls.Add(frmEli);
            frmEli.Show();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void frmAdminMarca_Load(object sender, EventArgs e)
        {

        }
    }
}