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
    public partial class frmDistrito : Form
    {
        public frmDistrito()
        {
            InitializeComponent();
            ConfigureGrid();
            ListarDistritos();
        }
        private void ConfigureGrid()
        {
            dgvDistritos.AutoGenerateColumns = false;

            colIdDistrito.DataPropertyName = "id_Distrito";
            ColDistrito.DataPropertyName = "nombre_Distrito";
        }
        private void ListarDistritos()
        {
            DistritoController controller = new DistritoController();
            dgvDistritos.DataSource = controller.ListarDistritos();
        }


        private void dgvDistritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDistrito_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDistrito.Text))
                {
                    ListarDistritos();
                    return;
                }

                if (!int.TryParse(txtIdDistrito.Text, out int idDistrito))
                {
                    MessageBox.Show("Ingresa un ID numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DistritoController controller = new DistritoController();
                DataTable resultado = controller.BuscarDistritoById(idDistrito);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún distrito con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvDistritos.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreDistrito.Text))
                {
                    MessageBox.Show("Completa el nombre del distrito.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DistritoController controller = new DistritoController();

                if (controller.DistritoExiste(txtNombreDistrito.Text))
                {
                    MessageBox.Show("Ese distrito ya existe, intenta de nuevo", "Verificacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DistritoEntidad distrito = new DistritoEntidad()
                {
                    nombre_Distrito = txtNombreDistrito.Text
                };

                // DistritoController controller = new DistritoController();
                controller.Insert(distrito);

                MessageBox.Show("Registro agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarDistritos();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDistrito.Text))
                {
                    MessageBox.Show("Selecciona un distrito primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreDistrito.Text))
                {
                    MessageBox.Show("Completa el nombre del distrito.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idDistrito = Convert.ToInt32(txtIdDistrito.Text);

                DistritoController controller = new DistritoController();
                controller.Update(idDistrito, txtNombreDistrito.Text);

                MessageBox.Show("Registro actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarDistritos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDistrito.Text))
                {
                    MessageBox.Show("Selecciona un distrito primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar el distrito del sistema?", "Verificación de información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado != DialogResult.OK)
                    return;

                int idDistrito = Convert.ToInt32(txtIdDistrito.Text);

                DistritoController controller = new DistritoController();
                controller.Delete(idDistrito);

                MessageBox.Show("Registro eliminado correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarDistritos();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNombreDistrito.Clear();
            txtNombreDistrito.Clear();
            dgvDistritos.ClearSelection();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDistrito_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDistritos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvDistritos.Rows[e.RowIndex];

            if (fila.IsNewRow)
                return;


            txtIdDistrito.Text =
                fila.Cells[colIdDistrito.Index].Value?.ToString() ?? "";

            txtNombreDistrito.Text =
                fila.Cells[ColDistrito.Index].Value?.ToString() ?? "";
        }
    }
}
