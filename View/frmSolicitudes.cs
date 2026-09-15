using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using Controller;
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
    public partial class frmSolicitudes : Form
    {
        private UsuarioEntidad _currentUser;
        private SolicitudesEntidad _currentRequest;
        private MultimediaEntidad _currentFile;
        public frmSolicitudes(UsuarioEntidad currentUser)
        {          
            InitializeComponent();
            _currentUser = currentUser;

            var solicitudes = new SolicitudesController().ViewRequestByUser(_currentUser.id_Usuario);

            var datos = solicitudes.Select(x => new
            {
                x.Item1.id_Solicitud,
                x.Item1.fecha_Solicitud,
                x.Item1.fecha_Resolucion,
                x.Item1.estado_Solicitud,
                
                tipoSitio = x.Item2,
                direccion = x.Item3
            }).ToList();

            dgListRequestUser.DataSource = null;
            dgListRequestUser.Columns.Clear();
            dgListRequestUser.AutoGenerateColumns = true;
            dgListRequestUser.DataSource = datos;

            dgListRequestUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgListRequestUser.Columns["id_Solicitud"].Visible = false;

            // dgListRequestUser.Columns["id_UsuarioEstandar"].Visible = false;
            // dgListRequestUser.Columns["nombre_Usuario"].Visible = false;
            // dgListRequestUser.Columns["id_InformacionSitio"].Visible = false;
            
            dgListRequestUser.AutoGenerateColumns = false;
            dgListRequestUser.Columns[1].HeaderText = "Fecha de solicitud";
            dgListRequestUser.Columns[2].HeaderText = "Fecha de resolución";
            dgListRequestUser.Columns[3].HeaderText = "Estado";
            dgListRequestUser.Columns[4].HeaderText = "Tipo de sitio";
            dgListRequestUser.Columns[5].HeaderText = "Dirección";

            var cantidad = new SolicitudesController().ViewRequestByUser(_currentUser.id_Usuario);
            MessageBox.Show("Cantidad de solicitudes de usuarios: " + cantidad.Count);
        }

        private void dgListRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RequestUserView_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgListRequestUser.SelectedRows.Count == 0)
                return;

            try
            {
                if (dgListRequestUser.CurrentRow != null)
                {
                    var result = MessageBox.Show("¿Estás seguro que deseas  eliminar la solicitud del sistema?", "Validación de información",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        if (dgListRequestUser.CurrentRow.DataBoundItem is not SolicitudesEntidad selectedRequest)
                        {
                            MessageBox.Show("No se pudo obtener la solicitud seleccionada.");
                            return;
                        }
                        MessageBox.Show("ID seleccionado: " + selectedRequest.id_Solicitud);

                        MultimediaEntidad multimediaFile = new MultimediaEntidad();
                     //   multimediaFile.DeleteMultimedia(selectedRequest.id_Solicitud);

                        _currentRequest = selectedRequest;
                     //   _currentRequest.DeleteRequest(selectedRequest.id_Solicitud);
                        new SolicitudesController().DeleteRequest(selectedRequest.id_Solicitud);

                        RefreshTable();
                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la información de la solicitud: " + ex.Message);
            }
        }
        private void RefreshTable()
        {
            dgListRequestUser.DataSource = new SolicitudesController().ViewAllRequest(); 
        }

    }
        
}

