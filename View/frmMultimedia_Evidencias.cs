using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmMultimedia_Evidencias : Form
    {
        private long _idUsuario;
        public frmMultimedia_Evidencias(long idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarMultimedia()
        {
            flowLayoutPanel1.Controls.Clear();

            MultimediaController multimediaController = new MultimediaController();
            DataTable dt = multimediaController.ListMultimedia_ByUser(_idUsuario);

            foreach (DataRow fila in dt.Rows)
            {
                frmMultimedia_EvidenciaCard_Design tarjeta = new frmMultimedia_EvidenciaCard_Design();

                tarjeta.CargarDatos(Convert.ToInt64(fila["id_Multimedia"]),
                fila["nombre_ArchivoMultimedia"].ToString() ?? "",
                fila["tamaño_ArchivoMultimedia"].ToString() ?? "",
                fila["ruta_archivoMultimedia"].ToString() ?? "",
                DateOnly.FromDateTime(Convert.ToDateTime(fila["fecha_Adjuncion"])),
                fila["tipo_Extension"].ToString() ?? "", Convert.ToInt64(fila["id_Solicitud"]));

                flowLayoutPanel1.Controls.Add(tarjeta);
            }
        }

        private void frmMultimedia_Evidencias_Load(object sender, EventArgs e)
        {
            CargarMultimedia();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
