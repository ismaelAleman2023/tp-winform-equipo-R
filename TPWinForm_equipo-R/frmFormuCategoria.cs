using dominio;
using negocio;
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

    public partial class frmFormuCategoria : Form
    {
        private fmAdmiCategoria conteiner;
        private FrmListaCategoria listacate;
        private Categoria categoriaModificar = null;
       
        public frmFormuCategoria(fmAdmiCategoria cont,FrmListaCategoria list)
        {
            InitializeComponent();
        this.listacate = list;
            this.conteiner = cont;
        }

        public frmFormuCategoria(Categoria cat,fmAdmiCategoria cont,FrmListaCategoria list)
        {
            InitializeComponent();

            categoriaModificar = cat;
            this.conteiner = cont;
            this.listacate = list;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (conteiner != null && listacate != null)
                {
                    CategoriaNegocio cate = new CategoriaNegocio();
                    listacate.cargarLista(cate.lista());

                    conteiner.pnlContenedorCate.Controls.Clear();
                    listacate.TopLevel = false;
                    listacate.Dock = DockStyle.Fill;
                    conteiner.pnlContenedorCate.Controls.Add(listacate);

                    listacate.BringToFront();
                    listacate.Show();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR AL CANCELAR: FILA O COLUMNA INEXISTENTE");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show("No se encontró la columna de datos requerida.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("ERROR AL CANCELAR: FALLÓ INTERFAZ/BASE DE DATOS");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show("No se pudieron cargar los datos en la lista.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();
        }

        private void frmFormuCategoria_Load(object sender, EventArgs e)
        {


            if (categoriaModificar != null)
            {

                txtId.Text = categoriaModificar.Id_Categoria.ToString();
                txtDescripcion.Text = categoriaModificar.Descripcion_Categoria;
                lbTituloCate.Text = "Modificar Categoria";


            }
            else
            {

                txtId.Text = "Id Asignado Automanticamente";

                lbTituloCate.Text = "Agregar Categoria";
            }



        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {

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
            int.TryParse(txtId.Text, out int id);

            if (validarCate(txtDescripcion.Text,id))
            {

                MessageBox.Show("Esta Categoria ya está registrado. Intente Nuevamente.");
                return;
            }



            Categoria cate = new Categoria();
            CategoriaNegocio catenego = new CategoriaNegocio();

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
                else if (lbTituloCate.Text == "Modificar Categoria")
                {

                    cate.Descripcion_Categoria = descrip;
                    cate.Id_Categoria = int.Parse(txtId.Text);
                    catenego.modificarCategoria(cate);

                    lblMensajes.Text = "";
                    MessageBox.Show("Modificado Correctamente");


                    if (conteiner != null && listacate != null)
                    {
                        
                        listacate.cargarLista(catenego.lista());

                        conteiner.pnlContenedorCate.Controls.Clear();
                        listacate.TopLevel = false;
                        listacate.Dock = DockStyle.Fill;
                        conteiner.pnlContenedorCate.Controls.Add(listacate);

                        listacate.BringToFront();
                        listacate.Show();
                    }


                }



            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine("ERROR EN BOTÓN CONFIRMAR");
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show("No se pudieron guardar los cambios en la base de datos.",
                                "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDescripcion.Focus();

            }

        }

        private bool validarCate(string cate , int id)
        {

            CategoriaNegocio cateNego = new CategoriaNegocio();

            List<Categoria> listaCate = cateNego.lista();
            string cateLimpia = cate.Trim();
            bool exis = false;

            try
            {

                foreach (Categoria c in listaCate)
                {
                    if (c.Id_Categoria==id && c.Descripcion_Categoria != null && c.Descripcion_Categoria.Equals(cateLimpia, StringComparison.OrdinalIgnoreCase)) {

                        exis = false;
                        break;
                        
                    }



                    if (c.Id_Categoria!=id && c.Descripcion_Categoria != null && c.Descripcion_Categoria.Equals(cateLimpia, StringComparison.OrdinalIgnoreCase))
                    {

                        exis = true;
                        break;

                    }

                }

                return exis;

            }
            catch (Exception)
            {

                throw;
            }


        }



    }
}
