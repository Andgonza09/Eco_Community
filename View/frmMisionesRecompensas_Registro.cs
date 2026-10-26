using Controller;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


//TRABAJAR EL DATAGRIED VIEW
namespace View
{
    public partial class frmMisionesRecompensas_Registro : Form
    {
        public frmMisionesRecompensas_Registro()
        {
            InitializeComponent();
            CargarTiposRecompensa();
            ConfigureGrid();

            this.Shown += frmMisionesRegistradas_shown;
            dgvMisiones.CellClick += dgvMisiones_CellClick;
            dgvMisiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMisiones.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dgvMisiones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dgvMisiones.DefaultCellStyle.SelectionForeColor = Color.White;

        }
        private void CargarTiposRecompensa()
        {
            TipoRecompensaController controller = new TipoRecompensaController();

            cmbTipoRecompensa.DataSource = controller.ListarTipoRecompensa();
            cmbTipoRecompensa.DisplayMember = "tipoRecompensa";
            cmbTipoRecompensa.ValueMember = "id_TipoRecompensa";
            cmbTipoRecompensa.SelectedIndex = -1;
        }
        private void ConfigureGrid()
        {
            dgvMisiones.AutoGenerateColumns = false;

            colIdMision.DataPropertyName = "id_Mision";
            colDescripcion.DataPropertyName = "descripcion";
            colPuntaje.DataPropertyName = "puntaje";
            colRecompensa.DataPropertyName = "descripcionRecompensa";
            colTipoRecompensa.DataPropertyName = "tipoRecompensa";
        }
        public void RefreshTable()
        {
            CargarMisiones();
        }
        private void frmMisionesRegistradas_shown(object? sender, EventArgs e)
        {
            CargarMisiones();
        }
        private void CargarMisiones()
        {
            MisionesController controller = new MisionesController();
            dgvMisiones.DataSource = controller.ListarMisionesData();
        }

        public int id_MisionSeleccionada = 0;
        public int id_RecompensaSeleccionada = 0;
        private void dgvMisiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvMisiones.Rows[e.RowIndex];
            id_MisionSeleccionada = Convert.ToInt32(fila.Cells[colIdMision.Index].Value);

            // Evita error al presionar el encabezado
            if (e.RowIndex < 0)
                return;

            // Obtenemos del datagridview y convertirlos a un objeto user
            fila = dgvMisiones.CurrentRow;

            MisionesEntidad selectedMisiones = new MisionesEntidad()
            {
                id_Mision = Convert.ToInt32(fila.Cells[colIdMision.Index].Value),
                descripcion = fila.Cells[colDescripcion.Index].Value?.ToString() ?? "",
                puntaje = (int)fila.Cells[colPuntaje.Index].Value,
            };

            // Llenar los campos
            txtDescripcionMision.Text = selectedMisiones.descripcion;
            nudPuntaje.Value = selectedMisiones.puntaje;

            string descripcionRecompensa = fila.Cells[colRecompensa.Index].Value?.ToString() ?? "";
            txtDescripcionRecompensa.Text = descripcionRecompensa;


            if (fila.DataBoundItem is DataRowView rowView)
            {
                id_RecompensaSeleccionada = Convert.ToInt32(rowView["id_Recompensa"]);
                int idTipoRecompensa = Convert.ToInt32(rowView["id_TipoRecompensa"]);
                cmbTipoRecompensa.SelectedValue = idTipoRecompensa;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                CargarMisiones();
                return;
            }

            if (!int.TryParse(txtSearchId.Text, out int id_Misión))
            {
                MessageBox.Show("Ingresa un ID numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MisionesController controller = new MisionesController();
            DataTable resultado = controller.BuscarMisionPorId(id_Misión);

            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ninguna misión con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvMisiones.DataSource = resultado;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MisionesController controller = new MisionesController();
            RecompensaController recompensaController = new RecompensaController();

            int id_TipoRecompensa;

            if (cmbTipoRecompensa.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de recompensa.");
                return;
            }

            if (cmbTipoRecompensa.SelectedItem.ToString() == "Insignia")
            {
                id_TipoRecompensa = 1;
            }
            else if (cmbTipoRecompensa.SelectedItem.ToString() == "Subida de nivel")
            {
                id_TipoRecompensa = 2;
            }
            else if (cmbTipoRecompensa.SelectedItem.ToString() == "Logros")
            {
                id_TipoRecompensa = 3;
            }
            else
            {
                id_TipoRecompensa = 4;
            }

            MisionesEntidad misiones = new MisionesEntidad()
            {
                descripcion = txtDescripcionMision.Text,
                puntaje = (int)nudPuntaje.Value,
            };
            RecompensaEntidad recompensaEntidad = new RecompensaEntidad()
            {
                descripcionRecompensa = txtDescripcionRecompensa.Text,
                id_TipoRecompensa = id_TipoRecompensa
            };

            try
            {

                bool Cantidad = controller.MisionExiste(txtDescripcionMision.Text);
                bool ExiteRecompensa = recompensaController.RecompensaExiste(txtDescripcionRecompensa.Text);

                if (Cantidad == true)
                {
                    MessageBox.Show("Usuario ya existente, intenta de nuevo", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (nudPuntaje.Value == 0)
                    {
                        MessageBox.Show("No se puede ingresar al sistema una misión sin puntaje", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int id_Misión = controller.InsertarMisiones(misiones);

                    recompensaController.InsertarRecompensa(recompensaEntidad, id_Misión, id_TipoRecompensa);
                    MessageBox.Show("Registro exitoso", "Misión y recompensa agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                    dgvMisiones.ClearSelection();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error de inserción: " + ex.Message, ex);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar la Misión del sistema?", "Verificación de información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                // Eliminar solicitud
                // Eliminamos el id de la tabla recompensa para evitar las dependencias de llaves foráneas de cada tabla
                new RecompensaController().EliminarRecompensa_PorIdMision(id_MisionSeleccionada);
                new Detalle_MisionController().EliminarDetalleMision_PorIdMision(id_MisionSeleccionada);
                new MisionesController().EliminarMisiones(id_MisionSeleccionada);
                MessageBox.Show("Misión eliminada correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
                dgvMisiones.ClearSelection();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDescripcionMision.Clear();
            nudPuntaje.Value = 0;
            txtDescripcionRecompensa.Clear();
            cmbTipoRecompensa.SelectedIndex = -1;
            dgvMisiones.ClearSelection();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_MisionSeleccionada == 0 || id_RecompensaSeleccionada == 0)
                {
                    MessageBox.Show("Selecciona una misión primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcionMision.Text) || string.IsNullOrWhiteSpace(txtDescripcionRecompensa.Text))
                {
                    MessageBox.Show("Completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbTipoRecompensa.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un tipo de recompensa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nudPuntaje.Value == 0)
                {
                    MessageBox.Show("No se puede actualizar una misión sin puntaje", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MisionesEntidad mision = new MisionesEntidad()
                {
                    id_Mision = id_MisionSeleccionada,
                    descripcion = txtDescripcionMision.Text,
                    puntaje = (int)nudPuntaje.Value
                };

                RecompensaEntidad recompensa = new RecompensaEntidad()
                {
                    id_Recompensa = id_RecompensaSeleccionada,
                    descripcionRecompensa = txtDescripcionRecompensa.Text,
                    id_TipoRecompensa = Convert.ToInt32(cmbTipoRecompensa.SelectedValue)
                };

                MisionesController controller = new MisionesController();
                RecompensaController recompensaController = new RecompensaController();

                controller.ActualizarMisiones(mision);
                recompensaController.ActualizarRecompensa(recompensa);

                MessageBox.Show("Registro actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
                dgvMisiones.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grpRecompensa_Enter(object sender, EventArgs e)
        {

        }

        private void dgvMisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpMisiones_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescripcionRecompensa_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMisionesRecompensas_Registro_Load(object sender, EventArgs e)
        {

        }
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dgvMisiones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpMision_Enter(object sender, EventArgs e)
        {

        }


    }

}
