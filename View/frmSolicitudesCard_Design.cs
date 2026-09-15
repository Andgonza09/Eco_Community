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

                lbEstado.Text = value;

                if (value == "Aprobada")
                {
                    lbEstado.BackColor = Color.FromArgb(220, 245, 228);
                    lbEstado.ForeColor = Color.FromArgb(30, 120, 60);
                }
                else if (value == "Pendiente")
                {
                    lbEstado.BackColor = Color.FromArgb(255, 243, 205);
                    lbEstado.ForeColor = Color.FromArgb(150, 100, 0);
                }
                else if (value == "Rechazada")
                {
                    lbEstado.BackColor = Color.FromArgb(255, 220, 220);
                    lbEstado.ForeColor = Color.FromArgb(180, 40, 40);
                }

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
                    value.HasValue
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
                        Properties.Resources.PuntoReciclaje;

                else if (estado == "pendiente")
                    pictureBox1.Image =
                        Properties.Resources.PuntoReciclajeYellow;

                else if (estado == "rechazada")
                    pictureBox1.Image =
                        Properties.Resources.PuntoReciclajeRed;
            }
            else if (tipo == "depósito de basura" ||
                     tipo == "deposito de basura")
            {
                if (estado == "aprobada")
                    pictureBox1.Image =
                        Properties.Resources.DepositoBasuraGreen;

                else if (estado == "pendiente")
                    pictureBox1.Image =
                        Properties.Resources.DepositoBasuraYellow;

                else if (estado == "rechazada")
                    pictureBox1.Image =
                        Properties.Resources.DepositoBasuraRed;
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
    }
}
