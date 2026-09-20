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
    
    public partial class FrmAdminPrincipal : Form
    {
        private frmPrincipal principal;
        public FrmAdminPrincipal()
        {
            InitializeComponent();
        }

        public FrmAdminPrincipal(frmPrincipal prin)
        {
            InitializeComponent();
            principal=prin;
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            try
            {
                
                pnlConteCentral.Controls.Clear();
                fmAdmiCategoria AdminCate = new fmAdmiCategoria(this);
                AdminCate.TopLevel = false;
                AdminCate.Dock = DockStyle.Fill;
                pnlConteCentral.Controls.Add(AdminCate);
                AdminCate.Show();

            }
            catch(Exception ex) {

                throw ex;
            
            }
            

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {

            try {
                pnlConteCentral.Controls.Clear();
                frmAdminMarca adminMarca = new frmAdminMarca(this);
                adminMarca.TopLevel = false;
                adminMarca.Dock = DockStyle.Fill;
                pnlConteCentral.Controls.Add(adminMarca);
                adminMarca.Show();


            }
            catch (Exception ex) {

                throw ex;
            
            }
           

        }

        private void btnArt_Click(object sender, EventArgs e)
        {
            try
            {
                pnlConteCentral.Controls.Clear();
                frmAdminArticulo adminArt = new frmAdminArticulo(this);
                adminArt.TopLevel = false;
                adminArt.Dock = DockStyle.Fill;
                pnlConteCentral.Controls.Add(adminArt);
                adminArt.Show();
            }
            catch (Exception ex) 
            {
                throw ex;
            
            }

                      
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
             ArticuloNegocio artN = new ArticuloNegocio();


            principal.cargarDataGrid(artN.Listar());


            principal.dtgListar.CurrentCell = principal.dtgListar.Rows[0].Cells[1];
            }
            catch (Exception ex)
            {

                throw ex;
            }
            




            Close();
        }

        private void FrmAdminPrincipal_Load(object sender, EventArgs e)
        {
            pnlConteCentral.Controls.Clear();
            frmFormuListar listar=new frmFormuListar();
            listar.TopLevel=false;
            listar.Dock = DockStyle.Fill;
            pnlConteCentral.Controls.Add(listar);
            listar.Show();



        }

        private void pnlConteCentral_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
