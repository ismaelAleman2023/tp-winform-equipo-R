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
        private FrmAdminPrincipal Principal;

        public fmAdmiCategoria()
        {
            InitializeComponent();
        }

        public fmAdmiCategoria(FrmAdminPrincipal prin)
        {
            InitializeComponent();
            Principal = prin;
        }


        private void btnAgregarCate_Click(object sender, EventArgs e)
        {
            try
            {
            pnlContenedorCate.Controls.Clear();
            frmFormuCategoria frm = new frmFormuCategoria();
          
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;

            pnlContenedorCate.Controls.Add(frm);
            frm.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
          
        }

        private void btnSalirCate_Click(object sender, EventArgs e)
        {
            

            if (Principal != null)
            {
                
                Principal.pnlConteCentral.Controls.Clear();
                frmFormuListar lista = new frmFormuListar();
                lista.TopLevel = false;
                lista.Dock = DockStyle.Fill;
                Principal.pnlConteCentral.Controls.Add(lista);
                lista.Show();            
                        
            }

            Close();
        }

        private void btnEliminarCate_Click(object sender, EventArgs e)
        {
            try { 
            pnlContenedorCate.Controls.Clear();
            frmFormuEliminarCate frmEli=new frmFormuEliminarCate();
            frmEli.TopLevel=false;
            frmEli.Dock = DockStyle.Fill;
            frmEli.FormBorderStyle = FormBorderStyle.None;
            pnlContenedorCate.Controls.Add(frmEli);
            frmEli.Show();}
            catch (Exception ex) { 
                throw ex;
            }

        }

        private void btnModificarCate_Click(object sender, EventArgs e)
        {
            try {
                pnlContenedorCate.Controls.Clear();
            frmIdModificar Modi=new frmIdModificar(this);
            Modi.TopLevel=false;
            Modi.Dock = DockStyle.Fill;
            pnlContenedorCate.Controls.Add((frmIdModificar)Modi);
            Modi.Show(); 
            }
            catch (Exception ex) { 
                throw ex;
            }
            


        }

        private void fmAdmiCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
