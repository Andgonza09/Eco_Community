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
    public partial class frmTipoRecompensa : Form
    {
        TipoRecompensaController controller = new TipoRecompensaController();
        public frmTipoRecompensa()
        {
            InitializeComponent();
            this.Shown += frmTipoRecompensa_Shown;
            dgvTipoRecompensa.CellClick += tipoRecompensa_CellClick;
        }


        private void tipoRecompensa_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvTipoRecompensa.Rows[e.RowIndex];

            //  txtTipoRecompensaId.Text = fila.Cells["colIdTipoRecompensa"].Value?.ToString()??"";
            // txtTipoRecompensa.Text = fila.Cells["TipoRecompensaId"].Value?.ToString() ?? "";
            txtIdTipoRecompensa.Text = fila.Cells[0].Value?.ToString() ?? "";
            txtTipoRecompensa.Text = fila.Cells[1].Value?.ToString() ?? "";

        }
        private void dgvTipoRecompensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmTipoRecompensa_Shown(object? sender, EventArgs e)
        {
            ListarTipoRecompensa();
        }

        private void ConfigurarColumnas()
        {
            dgvTipoRecompensa.AutoGenerateColumns = false;

            colIdTipoRecompensa.DataPropertyName = "id_TipoRecompensa";
            colTipo.DataPropertyName = "tipoRecompensa";
        }

        private void ListarTipoRecompensa()
        {
            try
            {
                ConfigurarColumnas();

                dgvTipoRecompensa.DataSource = controller.ListarTipoRecompensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los tipos de recompensa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipoRecompensa.Text))
            {
                MessageBox.Show("Ingrese el nombre del tipo de recompensa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreTipo = txtTipoRecompensa.Text.Trim();

            if (controller.TipoRecompensaExiste(nombreTipo))
            {
                MessageBox.Show("Ese tipo de recompensa ya existe, intenta de nuevo.", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TipoRecompensaEntidad tipo = new TipoRecompensaEntidad()
                {
                    tipoRecompensa = txtTipoRecompensa.Text.Trim()
                };

                controller.InsertarTipoRecompensa(tipo);

                MessageBox.Show("Tipo de recompensa registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ListarTipoRecompensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el tipo de recompensa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdTipoRecompensa.Text.Trim(), out int id))
            {
                MessageBox.Show("Seleccione un tipo de recompensa válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipoRecompensa.Text))
            {
                MessageBox.Show("Ingrese el nombre del tipo de recompensa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Desea actualizar este tipo de recompensa?", "Confirmar actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado != DialogResult.OK)
                return;

            try
            {
                controller.ActualizarTipoRecompensa(id, txtTipoRecompensa.Text.Trim());

                MessageBox.Show("Tipo de recompensa actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ListarTipoRecompensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el tipo de recompensa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdTipoRecompensa.Text.Trim(), out int id))
            {
                MessageBox.Show("Seleccione o busque un tipo de recompensa válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este tipo de recompensa?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado != DialogResult.OK)
                return;

            try
            {
                // 1. Obtener los ids de las misiones (la recompensa aún existe)
                List<int> idS_Mision = new MisionesController().ObtenerIds_AsociadoTipoRecompensa(id);

                // 2. Eliminar los detalles de usuarios de esas misiones
                foreach (int id_Mision in idS_Mision)
                {
                    new Detalle_MisionController().EliminarDetalleMision_PorIdMision(id_Mision);
                }
                // 3. Eliminar la recompensa (la que une tipo y misión)
                new RecompensaController().EliminarTipoRecompensa_Asociado_A_Recompensa(id);

                // 4. Eliminar las misiones, ahora por la lista de ids
                foreach (int id_Mision in idS_Mision)
                {
                    new MisionesController().EliminarMisiones(id_Mision);   // método por id_Mision
                }

                // 5. Eliminar el tipo
                controller.EliminarTipoRecompensa(id);

                MessageBox.Show("Tipo de recompensa eliminado correctamente.", "Eliminación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ListarTipoRecompensa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el tipo de recompensa. Compruebe si está asociado a una recompensa.\n\n" + ex.Message, "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ListarTipoRecompensa();
        }
        private void LimpiarCampos()
        {
            txtIdTipoRecompensa.Clear();
            txtTipoRecompensa.Clear();
            dgvTipoRecompensa.ClearSelection();
            txtTipoRecompensa.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdTipoRecompensa.Text))
            {
                ListarTipoRecompensa();
                return;
            }

            if (!int.TryParse(txtIdTipoRecompensa.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un ID válido.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConfigurarColumnas();

                DataTable resultado =
                    controller.BuscarTipoRecompensa_PorId(id);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún tipo de recompensa con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvTipoRecompensa.DataSource = null;
                    txtTipoRecompensa.Clear();
                    return;
                }

                dgvTipoRecompensa.DataSource = resultado;
                dgvTipoRecompensa.ClearSelection();

                // Mostrar también el nombre en el campo de texto.
                txtTipoRecompensa.Text = resultado.Rows[0]["tipoRecompensa"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el tipo de recompensa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTipoRecompensa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar la fila seleccionada
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvTipoRecompensa.Rows[e.RowIndex];

            // Evitar seleccionar filas nuevas
            if (fila.IsNewRow)
                return;

            // Cargar información en los TextBox
            txtIdTipoRecompensa.Text =
                fila.Cells[colIdTipoRecompensa.Index].Value?.ToString() ?? "";

            txtTipoRecompensa.Text =
                fila.Cells[colTipo.Index].Value?.ToString() ?? "";
        }
    }
}
