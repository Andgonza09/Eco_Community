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

            DataTable solicitudes = new SolicitudesController().ListarSolicitudesPorBusqueda_IdUsuario(idUsuario);

            if (solicitudes.Rows.Count == 0)
            {
                MessageBox.Show("No hay solicitudes ingresadas en el sistema", "Cantidad de solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow fila in solicitudes.Rows)
            {
                frmSolicitudesCard_Design card = new frmSolicitudesCard_Design(_id_Usuario);

                card.IdSolicitud = Convert.ToInt64(fila["id_Solicitud"]);
                card.Estado = fila["estado_Solicitud"].ToString();
                card.TipoSitio = fila["tipoSitio"].ToString();
                card.Direccion = fila["direccion"].ToString();
                card.FechaSolicitud = DateOnly.FromDateTime(Convert.ToDateTime(fila["fecha_Solicitud"]));
                if (fila["fecha_Resolucion"] != DBNull.Value)
                {
                    card.FechaResolucion = DateOnly.FromDateTime(Convert.ToDateTime(fila["fecha_Resolucion"]));
                }


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

