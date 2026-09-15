using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmSolicitudesCard : Form
    {
        private long idUsuario;

        public frmSolicitudesCard(long idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
        }

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            CargarSolicitudes(idUsuario);
        }

        private void CargarSolicitudes(long idUsuario)
        {
            flowLayoutPanel1.Controls.Clear();

            var solicitudes =
                new SolicitudesController().ViewRequestByUser(idUsuario);

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


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSolicitudesCard_Load(object sender, EventArgs e)
        {
            
        }
        
    }

}
