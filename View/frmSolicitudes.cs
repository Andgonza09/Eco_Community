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

        }

        public void CargarSolicitudes(long idUsuario)
        {
            flowLayoutPanel1.Controls.Clear();

            var solicitudes =
                new SolicitudesController().ViewRequestByUser(idUsuario);


            foreach (var solicitud in solicitudes)
            {
                frmSolicitudesCard_Design card = new frmSolicitudesCard_Design(_id_Usuario);

                card.IdSolicitud = solicitud.Item1.id_Solicitud;
                card.Estado = solicitud.Item1.estado_Solicitud;
                card.TipoSitio = solicitud.Item2;
                card.Direccion = solicitud.Item3;
                card.FechaSolicitud = solicitud.Item1.fecha_Solicitud;
                card.FechaResolucion = solicitud.Item1.fecha_Resolucion;

                card.Width = flowLayoutPanel1.ClientSize.Width - 30;
                card.Margin = new Padding(5, 5, 5, 15);

                // Escuchar cuando una tarjeta sea eliminada
                card.SolicitudEliminada += () =>
                {
                    CargarSolicitudes(_id_Usuario);
                };

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void RequestUserView_Load(object sender, EventArgs e)
        {
            CargarSolicitudes(_id_Usuario);
            frmSolicitudesCard_Design frmCard = new frmSolicitudesCard_Design(_id_Usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

