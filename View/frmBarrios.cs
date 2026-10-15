using Controller;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmBarrios : Form
    {
        public frmBarrios()
        {
            InitializeComponent();
            dgvBarrios.CellClick += dgvBarrios_CellContentClick;
        }
        BarrioController barrioController = new BarrioController();
        DistritoController distritoController = new DistritoController();

        private void dgvBarrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataRowView fila = (DataRowView)dgvBarrios.Rows[e.RowIndex].DataBoundItem;

            txtSearchId.Text = fila["id_Barrio"].ToString();
            txtNombreBarrio.Text = fila["nombre_Barrio"].ToString();
            cmbDistrito.SelectedValue = Convert.ToInt32(fila["id_Distrito"]);
        }

        private void frmBarrios_Load(object sender, EventArgs e)
        {
            CargarDistritos();
            CargarBarrios();
        }
        public void CargarDistritos()
        {
            DataTable distritos = distritoController.ListarDistritos();
            cmbDistrito.DataSource = distritos;
            cmbDistrito.DisplayMember = "nombre_Distrito";
            cmbDistrito.ValueMember = "id_Distrito";
            cmbDistrito.SelectedIndex = -1;
        }
        private void CargarBarrios()
        {
            DataTable barrios = barrioController.ListarBarrios();
            dgvBarrios.DataSource = barrios;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchId.Text, out int idBarrio))
            {
                MessageBox.Show("Seleccione un barrio válido para actualizar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreBarrio.Text))
            {
                MessageBox.Show("Ingrese el nombre del barrio.");
                txtNombreBarrio.Focus();
                return;
            }

            if (cmbDistrito.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un distrito.");
                cmbDistrito.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea actualizar este barrio?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                string nombreBarrio = txtNombreBarrio.Text.Trim();
                int idDistrito = Convert.ToInt32(cmbDistrito.SelectedValue);

                barrioController.Update(idBarrio, nombreBarrio, idDistrito);

                MessageBox.Show("Barrio actualizado correctamente.");

                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el barrio: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchId.Clear();
            txtNombreBarrio.Clear();
            cmbDistrito.SelectedIndex = -1;
            dgvBarrios.ClearSelection();

            CargarBarrios();
            txtNombreBarrio.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchId.Text, out int idBarrio))
            {
                MessageBox.Show("Seleccione un barrio válido para eliminar.");
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar este barrio?", "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                barrioController.Delete(idBarrio);

                MessageBox.Show("Barrio eliminado correctamente.");

                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el barrio. Puede estar relacionado con otros registros.\n\n" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtNombreBarrio.Text)) { MessageBox.Show("Ingrese el nombre del barrio."); txtNombreBarrio.Focus(); return; }
                if (cmbDistrito.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un distrito.");
                    cmbDistrito.Focus();
                    return;
                }

                try
                {
                    string nombreBarrio = txtNombreBarrio.Text.Trim();
                    int idDistrito = Convert.ToInt32(cmbDistrito.SelectedValue);

                    if (barrioController.BarrioExiste(nombreBarrio, idDistrito))
                    {
                        MessageBox.Show("Ese barrio ya existe en este distrito, intenta de nuevo.", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    BarrioEntidad barrio = new BarrioEntidad
                    {
                        nombre_Barrio = txtNombreBarrio.Text.Trim(),
                        id_Distrito = Convert.ToInt32(cmbDistrito.SelectedValue)
                    };

                    barrioController.Insert(barrio);

                    MessageBox.Show("Barrio agregado correctamente.");

                    btnClear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el barrio: " + ex.Message);
                }
            }
        }

        private void dgvBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvBarrios.Rows[e.RowIndex];

            if (fila.IsNewRow)
                return;

            txtNombreBarrio.Text =
                fila.Cells[ColNombreBarrio.Index].Value?.ToString() ?? "";

            cmbDistrito.Text = fila.Cells[ColDistrito.Index].Value?.ToString() ?? "";
        }
    }
}
