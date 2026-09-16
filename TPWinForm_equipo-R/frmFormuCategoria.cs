using dominio;
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
  
    public partial class frmFormuCategoria : Form
    {
        private Categoria categoriaModificar = null;

        public frmFormuCategoria()
        {
            InitializeComponent();
        }
        
        public frmFormuCategoria(Categoria cat)
        {InitializeComponent();

            categoriaModificar=cat;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormuCategoria_Load(object sender, EventArgs e)
        {
            

            if (categoriaModificar!=null) { 
            
                txtId.Text=categoriaModificar.Id_Categoria.ToString();
                txtDescripcion.Text = categoriaModificar.Descripcion_Categoria;
                lbTituloCate.Text = "Modificar Categoria";


            }
            else{

              txtId.Text = "Id Asignado Automanticamente";

                lbTituloCate.Text = "Agregar Categoria";
            }


            
        } 

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) {

                lblMensajes.ForeColor = Color.Red;
                lblMensajes.Text = "El Campo no puede esta vacio";
                txtDescripcion.Focus();
                return;
            }

            if (txtDescripcion.Text.Any(char.IsDigit))
            {
                lblMensajes.ForeColor = Color.Red;
                lblMensajes.Text = "El Campo no puede contener números.";
                txtDescripcion.Focus();
                return;
            }
            

            Categoria cate=new Categoria();
            CategoriaNegocio catenego=new CategoriaNegocio();

            try
            {

                string descrip = txtDescripcion.Text;

                if (lbTituloCate.Text == "Agregar Categoria")
                {

                    cate.Descripcion_Categoria = descrip;
                    catenego.agregarCategoria(cate);
                    lblMensajes.Text = "";
                    MessageBox.Show("Agregado Correctamente");
                    txtDescripcion.Text = "";
                }
                else if(lbTituloCate.Text == "Modificar Categoria")
                {

                    cate.Descripcion_Categoria = descrip;
                    cate.Id_Categoria = int.Parse(txtId.Text);
                    catenego.modificarCategoria(cate);
                    
                    lblMensajes.Text = "";
                    MessageBox.Show("Modificado Correctamente");
                    Close();

                }

                
            
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
