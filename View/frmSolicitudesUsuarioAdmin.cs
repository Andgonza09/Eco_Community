using Controller;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmSolicitudesUsuarioAdmin : Form
    {
        private SolicitudesEntidad _currentRequest;
        public frmSolicitudesUsuarioAdmin()
        {
            InitializeComponent();
            SolicitudesEntidad request = new SolicitudesEntidad();
            dgListRequest.CellFormatting += dgListRequest_CellFormatting;

            dgListRequest.DataSource = new SolicitudesController().ViewAllRequest();


        }
        public frmSolicitudesUsuarioAdmin(SolicitudesEntidad currentRequest)
        {
            _currentRequest = currentRequest;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgListRequest_SelectionChanged(object sender, EventArgs e)
        {
            if (dgListRequest.CurrentRow != null)
            {
                _currentRequest = (SolicitudesEntidad)dgListRequest.CurrentRow.DataBoundItem;
            }
        }
        private void RequestView_Load(object sender, EventArgs e)
        {
            try
            {
                SolicitudesEntidad request = new SolicitudesEntidad();

                dgListRequest.AutoGenerateColumns = false;
                dgListRequest.Columns[0].HeaderText = "ID Solicitud";
                dgListRequest.Columns[1].HeaderText = "Fecha de solicitud";
                dgListRequest.Columns[2].HeaderText = "Fecha de resolución";
                dgListRequest.Columns[3].HeaderText = "Estado solicitud";
                dgListRequest.Columns[4].HeaderText = "ID Usuario";
                dgListRequest.Columns[5].HeaderText = "Nombre Usuario";
                dgListRequest.Columns[6].HeaderText = "ID Información Sitio";

                dgListRequest.DataSource = new SolicitudesController().ViewAllRequest();
                dgListRequest.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al mostrar usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgListRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se encontró registros de la solicitud");
                return;
            }
            SolicitudesEntidad requestSelected = (SolicitudesEntidad)dgListRequest.CurrentRow.DataBoundItem;
            if (requestSelected == null)
            {
                MessageBox.Show("No se pudo obtener la información del registro");
                return;
            }

            frmActualizarSolicitud updateRequest = new frmActualizarSolicitud(requestSelected);
            updateRequest.StartPosition = FormStartPosition.CenterScreen;
            updateRequest.ShowDialog();
            this.Show();

            SolicitudesEntidad request = new SolicitudesEntidad();
            dgListRequest.DataSource = new SolicitudesController().ViewAllRequest();

        }

        private void dgListRequest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgListRequest.Columns[e.ColumnIndex];

            if (column.DataPropertyName == nameof(SolicitudesEntidad.id_UsuarioEstandar)
                && e.Value is UsuarioEntidad user)
            {
                e.Value = user.id_Usuario.ToString(); // Muestra el id de forma correcta en el id
            }
            if (column.DataPropertyName == nameof(SolicitudesEntidad.id_InformacionSitio)
                && e.Value is InformacionSitioEntidad site)
            {
                e.Value = site.id_InformacionSitio.ToString();
                e.FormattingApplied = true;
            }


        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {

            SolicitudesEntidad requestSearch = new SolicitudesEntidad();
            dgListRequest.DataSource = new SolicitudesController().ViewAllRequest();

            if (txtSearchId.Text == string.Empty)
                return;

            try
            {
                dgListRequest.DataSource = new SolicitudesController().ViewAllRequest();
                if (!int.TryParse(txtSearchId.Text, out _))
                {
                    MessageBox.Show("Por favor, ingrese un ID de usuario válido (número entero).", "Búsqueda de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                long id_Request = long.Parse(txtSearchId.Text);
               // SolicitudesEntidad request = requestSearch.FindRequest(id_Request);

              //  dgListRequest.DataSource = new List<SolicitudesEntidad> { request };
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la solicitud: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgListRequest.SelectedRows.Count == 0)
                return;


            try
            {
                if (dgListRequest.CurrentRow != null)
                {
                    var result = MessageBox.Show("¿Estás seguro que deseas la solicitud del sistema?", "Validación de información",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        long id_Request = Convert.ToInt64(dgListRequest.CurrentRow.Cells["idRequest"].Value);

                        MessageBox.Show("ID seleccionado: " + id_Request);
                        _currentRequest = (SolicitudesEntidad)dgListRequest.CurrentRow.DataBoundItem;
                      //  _currentRequest.DeleteRequest(id_Request);
                    }
  
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la información de la solicitud: " + ex.Message);
            }

        }
            
    }
}
