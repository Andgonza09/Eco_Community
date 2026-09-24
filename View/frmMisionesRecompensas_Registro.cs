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

namespace View
{
    public partial class frmMisionesRecompensas_Registro : Form
    {
        public frmMisionesRecompensas_Registro()
        {
            InitializeComponent();
            this.Shown += frmMisionesRegistradas_shown;
            dgvMisiones.CellClick += dgvMisiones_CellClick;
            dgvMisiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMisiones.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dgvMisiones.DefaultCellStyle.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dgvMisiones.DefaultCellStyle.SelectionForeColor = Color.White;

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
            // Si no escribió nada, mostrar todos
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                var datos = controller.ViewAllMissions();
                var datosGridTodos = datos.Select(x => new
                {
                    Id_Misión = x.Item1.id_Mision,
                    Descripción = x.Item1.descripcion,
                    Puntaje = x.Item1.puntaje,
                    Recompensa = x.Item2,
                    TipoRecompensa = x.Item3,

                }).ToList();

                // Vincular columnas del diseñador
                colIdMision.DataPropertyName = "Id_Misión";
                colDescripcion.DataPropertyName = "Descripción";
                colPuntaje.DataPropertyName = "Puntaje";
                colRecompensa.DataPropertyName = "Recompensa";
                colTipoRecompensa.DataPropertyName = "TipoRecompensa";

                dgvMisiones.AutoGenerateColumns = false;

                dgvMisiones.DataSource = null;
                dgvMisiones.DataSource = datosGridTodos;


                return;
            }
        }
        public int id_MisionSeleccionada = 0;
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
            txtDescripcionRecompensa.Text = fila.Cells[colRecompensa.Index].Value?.ToString() ?? "";

            string descripcionRecompensa = fila.Cells[colRecompensa.Index].Value?.ToString() ?? "";
            string tipoRecompensa = fila.Cells[colTipoRecompensa.Index].Value?.ToString() ?? "";
            txtDescripcionRecompensa.Text = descripcionRecompensa;
            cmbTipoRecompensa.Text = tipoRecompensa;

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

        private void button1_Click(object sender, EventArgs e)
        {
            MisionesController controller = new MisionesController();
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                CargarMisiones();
            }
            if (dgvMisiones.CurrentRow == null)
            {
                return;
            }

            // Si escribió algo, validar que sea número
            if (!int.TryParse(txtSearchId.Text, out int id_Misión))
            {
                return;
            }
            else
            {
                var datos = controller.FindById(id_Misión);
                var datosGridID = datos.Select(x => new
                {
                    Id_Misión = x.Item1.id_Mision,
                    Descripción = x.Item1.descripcion,
                    Puntaje = x.Item1.puntaje,
                    Recompensa = x.Item2,
                    TipoRecompensa = x.Item3,

                }).ToList();

                dgvMisiones.DataSource = null;
                dgvMisiones.Columns.Clear();
                dgvMisiones.AutoGenerateColumns = true;
                dgvMisiones.DataSource = datosGridID;

                dgvMisiones.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvMisiones.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvMisiones.RowHeadersVisible = false;

                dgvMisiones.BackgroundColor = Color.White;
                dgvMisiones.BorderStyle = BorderStyle.None;

                dgvMisiones.CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal;

                dgvMisiones.ColumnHeadersHeight = 38;
                dgvMisiones.RowTemplate.Height = 34;

                dgvMisiones.Visible = true;
            }

            // validamos que exista un usuario seleccionado
            if (dgvMisiones.CurrentRow == null)
            {
                return;
            }
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

                bool Cantidad = controller.MissionExists(txtDescripcionMision.Text);
                bool ExiteRecompensa = recompensaController.RewardExist(txtDescripcionRecompensa.Text);

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
                    int id_Misión = controller.Insert(misiones);

                    recompensaController.Insert(recompensaEntidad, id_Misión, id_TipoRecompensa);
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
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar la solicitud del sistema?", "Verificación de información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                // Eliminar solicitud
                // Eliminamos el id de la tabla recompensa para evitar las dependencias de llaves foráneas de cada tabla
                new RecompensaController().DeleteReward(id_MisionSeleccionada);

                new MisionesController().DeleteMission(id_MisionSeleccionada);
                MessageBox.Show("Solicitud eliminada correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            dgvMisiones.ClearSelection();
        }
    }
}
