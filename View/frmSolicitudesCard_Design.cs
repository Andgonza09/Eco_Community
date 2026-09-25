using Model.Eco_Community;
using Controller;
using View;
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
        private bool seleccionada = false;
        private bool mouseEncima = false;
        private long _idUsuario;
        private long id_Solicitud;
        private readonly Color colorNormal =
            Color.FromArgb(244, 248, 238);
        private readonly Color colorHover =
            Color.FromArgb(230, 242, 224);
        private readonly Color colorSeleccionada =
            Color.FromArgb(214, 235, 207);
        public event Action SolicitudEliminada;
        public frmSolicitudesCard_Design(long id_Usuario)
        {
            InitializeComponent();

            this._idUsuario = id_Usuario;
            this.Cursor = Cursors.Hand;

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true
            );

            AsignarEventos(this);
        }


        private void AsignarEventos(Control control)
        {
            control.MouseEnter += Card_MouseEnter;
            control.MouseLeave += Card_MouseLeave;
            control.Click += Card_Click;
            control.Cursor = Cursors.Hand;

            foreach (Control hijo in control.Controls)
            {
                AsignarEventos(hijo);
            }
        }
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            mouseEncima = true;

            if (!seleccionada)
            {
                this.BackColor = colorHover;
            }

            this.Invalidate();
        }
        private void Card_MouseLeave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(
                this.PointToClient(Cursor.Position)))
            {
                mouseEncima = false;

                if (!seleccionada)
                {
                    this.BackColor = colorNormal;
                }

                this.Invalidate();
            }
        }
        private void Card_Click(object sender, EventArgs e)
        {
            seleccionada = !seleccionada;

            if (seleccionada)
            {
                this.BackColor = colorSeleccionada;
            }
            else
            {
                this.BackColor = mouseEncima
                    ? colorHover
                    : colorNormal;
            }

            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borde;
            int grosor;

            if (seleccionada)
            {
                borde = Color.FromArgb(48, 125, 70);
                grosor = 3;
            }
            else if (mouseEncima)
            {
                borde = Color.FromArgb(120, 170, 125);
                grosor = 2;
            }
            else
            {
                borde = Color.FromArgb(210, 220, 205);
                grosor = 1;
            }

            using Pen pen = new Pen(borde, grosor);

            Rectangle rect = new Rectangle(
                1,
                1,
                this.Width - 3,
                this.Height - 3
            );

            e.Graphics.DrawRectangle(pen, rect);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public long IdSolicitud
        {
            get => id_Solicitud;

            set
            {
                id_Solicitud = value;
                lbNSolicitud.Text = $"Solicitud #{value}";
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
                        pbEstado.Image = Properties.Resources.EstadoRePendienteRemove;
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TipoSitio
        {
            set
            {
                tipoSitioActual = value;

                lbTipoSitio.Text = value;

                ActualizarImagen();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public string Direccion
        {
            set
            {
                lbDireccion.Text = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateOnly FechaSolicitud
        {
            set
            {
                lbFechaSolicitud.Text = value.ToString("dd/MM/yyyy");
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
            else if (tipo == "depósitos de basura" ||
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
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que deseas eliminar la solicitud del sistema?",
                "Verificación de información",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.OK)
            {
                // Eliminamos el id de la tabla multimedia para evitar las dependencias de llaves foráneas de cada tabla
                new MultimediaController().DeleteMultimedia(id_Solicitud);
                new SolicitudesController().DeleteRequest(id_Solicitud);
                MessageBox.Show("Solicitud eliminada correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Avisar al formulario principal
                SolicitudEliminada?.Invoke();
            }


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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pbEstado_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
