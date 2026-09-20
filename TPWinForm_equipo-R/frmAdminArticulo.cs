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
        private FrmAdminPrincipal principal;    
        public frmAdminArticulo()
        {
            InitializeComponent();
        }
        public frmAdminArticulo(FrmAdminPrincipal prin)
        {
            InitializeComponent();
        principal = prin;
        
        }

        private void frmAdminArticulo_Load(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmArticulo fArti = new frmArticulo();
                fArti.TopLevel = false;
                fArti.Dock = DockStyle.Fill;
                pnlconteArti.Controls.Clear();
                pnlconteArti.Controls.Add(fArti);
                fArti.Show();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmAdminPrincipal principal = this.ParentForm as FrmAdminPrincipal;

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

            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                frmEliminarArticulo fElimArt = new frmEliminarArticulo();
                fElimArt.TopLevel = false;
                fElimArt.Dock = DockStyle.Fill;
                pnlconteArti.Controls.Clear();
                pnlconteArti.Controls.Add(fElimArt);
                fElimArt.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }         
            
            
        }

        private void btnModifical_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarIdArt fArtMod = new frmModificarIdArt(this);
                fArtMod.TopLevel = false;
                fArtMod.Dock = DockStyle.Fill;
                pnlconteArti.Controls.Clear();
                pnlconteArti.Controls.Add(fArtMod);
                fArtMod.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
    }
}
