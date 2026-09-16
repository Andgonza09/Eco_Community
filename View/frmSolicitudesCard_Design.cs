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
    public partial class frmSolicitudesCard_Design : UserControl
    {
        private string estadoActual = "";
        private string tipoSitioActual = "";
        public frmSolicitudesCard_Design()
        {
            InitializeComponent();
        }


        public long IdSolicitud
        {
            set
            {
                lbNSolicitud.Text = $"Solicitud #{value}";
            }
        }

        public string Estado
        {
            set
            {
                estadoActual = value;

                switch (value.Trim().ToLower())
                {
                    case "aprobada":
                        pbEstado.Image = Properties.Resources.EstadoAprobadoRemove;
                        break;

                    case "pendiente":
                        pbEstado.Image = Properties.Resources.EstadoPendienteRemove;
                        break;

                    case "rechazada":
                        pbEstado.Image = Properties.Resources.EstadoRechazadoRemove;
                        break;

                    default:
                        pbEstado.Image = null;
                        break;
                }

                pbEstado.SizeMode = PictureBoxSizeMode.Zoom;

                ActualizarImagen();
            }
        }
        public string TipoSitio
        {
            set
            {
                tipoSitioActual = value;

                lbTipoSitio.Text = value;

                ActualizarImagen();
            }
        }

        public string Direccion
        {
            set
            {
                lbDireccion.Text = value;
            }
        }

        public DateOnly FechaSolicitud
        {
            set
            {
                lbFechaSolicitud.Text = value.ToString("dd/MM/yyyy");
            }
        }

        public DateOnly? FechaResolucion
        {
            set
            {
                lbFechaResolución.Text =
                    value.HasValue && value.Value != DateOnly.MinValue
                    ? value.Value.ToString("dd/MM/yyyy")
                    : "Sin resolver";
            }
        }

        private void ActualizarImagen()
        {
            if (string.IsNullOrEmpty(estadoActual) ||
                string.IsNullOrEmpty(tipoSitioActual))
                return;

            string estado = estadoActual.Trim().ToLower();
            string tipo = tipoSitioActual.Trim().ToLower();

            if (tipo == "punto de reciclaje")
            {
                if (estado == "aprobada")
                    pictureBox1.Image =
                        Properties.Resources.PuntoReciclajeGreenRemove;

                else if (estado == "pendiente")
                    pictureBox1.Image =
                        Properties.Resources.PuntoReciclajeYelloRemove;

                else if (estado == "rechazada")
                    pictureBox1.Image =
                        Properties.Resources.PuntoReciclajeRedRemove;
            }
            else if (tipo == "depósito de basura" ||
                     tipo == "deposito de basura")
            {
                if (estado == "aprobada")
                    pictureBox1.Image =
                        Properties.Resources.DepositoBasuraGreenRemove;

                else if (estado == "pendiente")
                    pictureBox1.Image =
                        Properties.Resources.DepositoBasuraYellowRemove;

                else if (estado == "rechazada")
                    pictureBox1.Image =
                        Properties.Resources.DepositoBasuraRedRemove;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void frmSolicitudesCard_Design_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFechaSolicitud_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbEstado_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFechaResolución_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
