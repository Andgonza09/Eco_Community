using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmMultimedia_EvidenciaCard_Design : UserControl
    {
        private long _idMultimedia;
        private long _idSolicitud;
        private string _rutaArchivo = "";
        public frmMultimedia_EvidenciaCard_Design()
        {
            InitializeComponent();
            lblInformation.Parent = picArchivo;
            lblInformation.Dock = DockStyle.Fill;
            lblInformation.AutoSize = false;
            lblInformation.TextAlign = ContentAlignment.MiddleCenter;
            lblInformation.BackColor = Color.Transparent;
            lblInformation.Visible = false;
        }
        private string ObtenerRutaCompleta(string ruta)
        {
            // Si ya es una ruta completa, la devolvemos tal cual
            if (Path.IsPathRooted(ruta))
            {
                return ruta;
            }

            // Si es una ruta relativa, la combinamos con la carpeta de ejecución
            return Path.Combine(
                AppContext.BaseDirectory,
                ruta
            );
        }
        private void linkOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string rutaCompleta = ObtenerRutaCompleta(_rutaArchivo);

            if (!System.IO.File.Exists(rutaCompleta))
            {
                MessageBox.Show(
                    "El archivo no se encuentra disponible."
                );

                return;
            }

            Process.Start(
                new ProcessStartInfo
                {
                    FileName = rutaCompleta,
                    UseShellExecute = true
                }
            );
        }
        public void CargarDatos(long idMultimedia, string nombre, string tamano, string ruta, DateOnly fecha, string extension, long idSolicitud)
        {
            _idMultimedia = idMultimedia;
            _idSolicitud = idSolicitud;
            _rutaArchivo = ruta;

            lblNombreArchivo.Text = nombre;
            lblTamaño.Text = tamano;
            lblExtension.Text = extension;

            lbNSolicitud.Text = "Solicitud #" + idSolicitud;

            lblFecha.Text = "Adjuntado: " + fecha.ToString("dd/MM/yyyy");

            CargarVistaArchivo();
        }
        private void CargarVistaArchivo()
        {
            string rutaCompleta = ObtenerRutaCompleta(_rutaArchivo);
            picArchivo.Image?.Dispose();
            picArchivo.Image = null;

            if (!System.IO.File.Exists(rutaCompleta))
            {
                return;
            }

            string extension = Path.GetExtension(rutaCompleta).ToLower();

            if (extension == ".png" ||
                extension == ".jpg" ||
                extension == ".jpeg")
            {
                using (Image imagen = Image.FromFile(rutaCompleta))
                {
                    picArchivo.Image = new Bitmap(imagen);
                }

                picArchivo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picArchivo.Image = null;

                // El PictureBox debe seguir visible
                picArchivo.Visible = true;

                lblInformation.Visible = true;

                lblInformation.Text =
                    "Vista previa no disponible." +
                    Environment.NewLine +
                    "Abrir archivo para ver el contenido.";

                lblInformation.BringToFront();
            }
        }

        private void frmMultimedia_EvidenciaCard_Design_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
