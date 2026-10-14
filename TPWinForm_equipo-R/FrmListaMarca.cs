using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;

namespace TPWinForm_equipo_R
{
    public class FrmListaMarca : Form
    {
        public DataGridView dgvMarcas;

        public FrmListaMarca()
        {
            FormBorderStyle = FormBorderStyle.None;

            dgvMarcas = new DataGridView();
            dgvMarcas.Dock = DockStyle.Fill;
            dgvMarcas.ReadOnly = true;
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AllowUserToDeleteRows = false;
            dgvMarcas.AllowUserToResizeRows = false;
            dgvMarcas.AllowUserToResizeColumns = false;
            dgvMarcas.MultiSelect = false;
            dgvMarcas.RowHeadersVisible = false;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(dgvMarcas);
        }

        public void cargarLista(List<Marca> lista)
        {
            try
            {
                dgvMarcas.DataSource = null;
                dgvMarcas.DataSource = lista;

                dgvMarcas.Columns["Id_Marca"].Visible = false;
                dgvMarcas.Columns["Descripcion_Marca"].HeaderText = "Descripcion";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show("No se pudieron cargar los datos en la lista.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Marca marcaSeleccionada()
        {
            if (dgvMarcas.CurrentRow == null)
                return null;

            return (Marca)dgvMarcas.CurrentRow.DataBoundItem;
        }
    }
}