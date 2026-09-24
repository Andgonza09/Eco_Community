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
    public partial class frmSolicitudesRegistradas : Form
    {
        public frmSolicitudesRegistradas()
        {
            InitializeComponent();
            this.Shown += frmUsuarioRegistrados_shown;
            dgvSolicitudes.CellClick += dgvSolicitudes_CellClick;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.MultiSelect = false;

            dgvSolicitudes.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            dgvSolicitudes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dgvSolicitudes.DefaultCellStyle.SelectionForeColor = Color.White;

        }
        private long idSolicitudSeleccionada = 0;
        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvSolicitudes.Rows[e.RowIndex];
            idSolicitudSeleccionada = Convert.ToInt64(fila.Cells[colIdSolicitud.Index].Value);


            // Evita error al presionar el encabezado
            if (e.RowIndex < 0)
                return;

            // Obtenemos del datagridview y convertirlos a un objeto user
            fila = dgvSolicitudes.CurrentRow;
            object? valorFecha = fila.Cells[colFechaResolucion.Index].Value;

            DateOnly? fechaResolucion = null;

            if (valorFecha != null &&
                valorFecha != DBNull.Value &&
                !string.IsNullOrWhiteSpace(valorFecha.ToString()))
            {
                DateOnly fecha = valorFecha is DateOnly f ? f : DateOnly.FromDateTime(Convert.ToDateTime(valorFecha));
                if (fecha != DateOnly.MinValue)
                {
                    fechaResolucion = fecha;
                }
            }

            SolicitudesEntidad selectedUser = new SolicitudesEntidad()
            {
                id_Solicitud = Convert.ToInt64(fila.Cells[colIdSolicitud.Index].Value),
                estado_Solicitud = fila.Cells[colEstado.Index].Value?.ToString() ?? "",
                fecha_Solicitud = fila.Cells[colFechaSolicitud.Index].Value is DateOnly fechaSolicitud ? fechaSolicitud : DateOnly.FromDateTime(Convert.ToDateTime(fila.Cells[colFechaSolicitud.Index].Value)),

                fecha_Resolucion = fechaResolucion
            };
            // Llenar los campos
            txtIdSolicitud.Text =
                selectedUser.id_Solicitud.ToString();

            cmbEstado.Text =
                selectedUser.estado_Solicitud;

            txtFechaSolicitud.Text =
                selectedUser.fecha_Solicitud.ToString("dd/MM/yyyy");

            txtFechaResolucion.Text = selectedUser.fecha_Resolucion == null || selectedUser.fecha_Resolucion == DateOnly.MinValue ? "" : selectedUser.fecha_Resolucion.Value.ToString("dd/MM/yyyy");

            string tipoSitio = fila.Cells[colTipoSitio.Index].Value?.ToString() ?? "";
            string direccion = fila.Cells[colDireccion.Index].Value?.ToString() ?? "";
            string nombreUsuario = fila.Cells[colNombreUsuario.Index].Value?.ToString() ?? "";

            txtTipoSitio.Text = tipoSitio;
            txtDireccion.Text = direccion;
            txtNombreUsuario.Text = nombreUsuario;
        }

        public void RefreshTable()
        {
            CargarUsuarios();
        }
        private void frmUsuarioRegistrados_shown(object? sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            SolicitudesController controller = new SolicitudesController();
            // Si no escribió nada, mostrar todos
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                var datos = controller.ViewAllRequest();
                var datosGridTodos = datos.Select(x => new
                {
                    Id = x.Item1.id_Solicitud,
                    Estado = x.Item1.estado_Solicitud,
                    FechaSolicitud = x.Item1.fecha_Solicitud,
                    FechaResolucion = x.Item1.fecha_Resolucion,
                    NombreUsuario = x.Item2,
                    TipoSitio = x.Item3,
                    Direccion = x.Item4
                }).ToList();

                // Vincular columnas del diseñador
                colIdSolicitud.DataPropertyName = "Id";
                colEstado.DataPropertyName = "Estado";
                colFechaSolicitud.DataPropertyName = "FechaSolicitud";
                colFechaResolucion.DataPropertyName = "FechaResolucion";
                colNombreUsuario.DataPropertyName = "NombreUsuario";
                colTipoSitio.DataPropertyName = "TipoSitio";
                colDireccion.DataPropertyName = "Direccion";

                dgvSolicitudes.AutoGenerateColumns = false;

                dgvSolicitudes.DataSource = null;
                dgvSolicitudes.DataSource = datosGridTodos;


                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SolicitudesController controller = new SolicitudesController();
            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                CargarUsuarios();
            }
            if (dgvSolicitudes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario primero.");
                return;
            }

            // Si escribió algo, validar que sea número
            if (!long.TryParse(txtBuscarId.Text, out long id_Solicitud))
            {
                return;
            }
            else
            {
                var datos = controller.ViewRequestByID(id_Solicitud);
                var datosGrid = datos.Select(x => new
                {
                    Id = x.Item1.id_Solicitud,
                    Estado = x.Item1.estado_Solicitud,
                    FechaSolicitud = x.Item1.fecha_Solicitud,
                    FechaResolucion = x.Item1.fecha_Resolucion,
                    NombreUsuario = x.Item2,
                    TipoSitio = x.Item3,
                    Direccion = x.Item4
                }).ToList();

                dgvSolicitudes.DataSource = null;
                dgvSolicitudes.Columns.Clear();
                dgvSolicitudes.AutoGenerateColumns = true;
                dgvSolicitudes.DataSource = datosGrid;

                dgvSolicitudes.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvSolicitudes.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvSolicitudes.RowHeadersVisible = false;

                dgvSolicitudes.BackgroundColor = Color.White;
                dgvSolicitudes.BorderStyle = BorderStyle.None;

                dgvSolicitudes.CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal;

                dgvSolicitudes.ColumnHeadersHeight = 38;
                dgvSolicitudes.RowTemplate.Height = 34;

                dgvSolicitudes.Visible = true;
            }

            // validamos que exista un usuario seleccionado
            if (dgvSolicitudes.CurrentRow == null)
            {
                return;
            }

            /*
            // Obtenemos del datagridview y convertirlos a un objeto user
            DataGridViewRow fila = dgvSolicitudes.CurrentRow;
            object? valorFecha = fila.Cells[colFechaResolucion.Index].Value;

            DateOnly? fechaResolucion = null;

            if (valorFecha == null ||
                valorFecha == DBNull.Value ||
                string.IsNullOrWhiteSpace(valorFecha.ToString()))
            {
                txtFechaResolucion.Text = "";
                fechaResolucion = null;
            }
            else
            {
                fechaResolucion = valorFecha is DateOnly fecha
                    ? fecha
                    : DateOnly.FromDateTime(Convert.ToDateTime(valorFecha));

                txtFechaResolucion.Text =
                    fechaResolucion.Value.ToString("dd/MM/yyyy");
            }

            SolicitudesEntidad selectedUser = new SolicitudesEntidad()
            {
                id_Solicitud = Convert.ToInt64(fila.Cells[colIdSolicitud.Index].Value),
                estado_Solicitud = fila.Cells[colEstado.Index].Value?.ToString() ?? "",
                fecha_Solicitud = fila.Cells[colFechaSolicitud.Index].Value is DateOnly fechaSolicitud
                       ? fechaSolicitud : DateOnly.FromDateTime(Convert.ToDateTime(fila.Cells[colFechaSolicitud.Index].Value)),

                fecha_Resolucion = fechaResolucion
            };

            frmActualizarSolicitud editRequest = new frmActualizarSolicitud(); */

        }
        private void button3_Click_1(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void grpAcciones_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaResolucion_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pnlListadoHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSolicitudesRegistradas_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void grpInformacion_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSolicitudes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar la solicitud del sistema?", "Verificación de información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                // Eliminar solicitud
                // Eliminamos el id de la tabla multimedia para evitar las dependencias de llaves foráneas de cada tabla
                new MultimediaController().DeleteMultimedia(idSolicitudSeleccionada);
                new SolicitudesController().DeleteRequest(idSolicitudSeleccionada);
                MessageBox.Show("Solicitud eliminada correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDireccion.Clear();
            cmbEstado.SelectedIndex = -1;
            txtIdSolicitud.Clear();
            txtFechaResolucion.Clear();
            txtFechaSolicitud.Clear();
            txtNombreUsuario.Clear();
            txtTipoSitio.Clear();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
