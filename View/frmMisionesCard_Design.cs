using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmMisionesCard_Design : UserControl
    {
        public frmMisionesCard_Design()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        public void CargarDatos(int idMision, string Descripcion, int Puntaje)
        {
            lblNSolicitud.Text = "Misión #" + idMision.ToString();
            lblDescripcion.Text = Descripcion;
            lblPuntaje.Text = "Puntaje: " + Puntaje.ToString();

        }
        private void frmMisionesCard_Design_Load(object sender, EventArgs e)
        {
            GenerarProgreso();
        }
        private void GenerarProgreso()
        {
            int progreso = Random.Shared.Next(0, 101);
            progressBar1.Value = progreso;
            progressBar1.Text = progreso + "%";

            if (progressBar1.Value == 100)
                lbCompletado.Text = "1/1";

            else
                lbCompletado.Text = "0/1";
        }


        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntaje_Click(object sender, EventArgs e)
        {

        }
    }
}
