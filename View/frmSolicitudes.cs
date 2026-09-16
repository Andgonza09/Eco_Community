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
        private long _id_Usuario;
        private SolicitudesEntidad _currentRequest;
        private MultimediaEntidad _currentFile;
        public frmSolicitudes(long id_Usuario)
        {
            InitializeComponent();
            this._id_Usuario = id_Usuario;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;

            MessageBox.Show($"ID recibido en solicitudes: {this._id_Usuario}");

        }

        private void CargarSolicitudes(long idUsuario)
        {
            flowLayoutPanel1.Controls.Clear();

            var solicitudes =
                new SolicitudesController().ViewRequestByUser(idUsuario);

            MessageBox.Show(
            $"Usuario: {idUsuario}\n" +
            $"Solicitudes encontradas: {solicitudes.Count}"
        );

            foreach (var solicitud in solicitudes)
            {
                frmSolicitudesCard_Design card = new frmSolicitudesCard_Design();

                card.IdSolicitud = solicitud.Item1.id_Solicitud;
                card.Estado = solicitud.Item1.estado_Solicitud;
                card.TipoSitio = solicitud.Item2;
                card.Direccion = solicitud.Item3;
                card.FechaSolicitud = solicitud.Item1.fecha_Solicitud;
                card.FechaResolucion = solicitud.Item1.fecha_Resolucion;

                card.Width = flowLayoutPanel1.ClientSize.Width - 30;
                card.Margin = new Padding(5, 5, 5, 15);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void RequestUserView_Load(object sender, EventArgs e)
        {
            CargarSolicitudes(_id_Usuario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* if (dgListRequestUser.SelectedRows.Count == 0)
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
            }*/
        }
        private void RefreshTable()
        {
           // dgListRequestUser.DataSource = new SolicitudesController().ViewAllRequest();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }

}

