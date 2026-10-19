using Controller;
using Model.Eco_Community;
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
        private int idMisionActual;
        private long idUsuarioActual;
        public frmMisionesCard_Design()
        {
            InitializeComponent();
            progressBar1.ForeColor = Color.FromArgb(7, 80, 51);
            progressBar1.BackColor = Color.FromArgb(224, 241, 255);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        public void CargarDatos(int idMision, string Descripcion, int Puntaje, long id_Usuario)
        {
            idMisionActual = idMision;
            idUsuarioActual = id_Usuario;

            lblNSolicitud.Text = "Misión #" + idMision.ToString();
            lblDescripcion.Text = Descripcion;
            lblPuntaje.Text = "Puntaje: " + Puntaje.ToString();

            GenerarProgreso();
        }
        private void frmMisionesCard_Design_Load(object sender, EventArgs e)
        {
            GenerarProgreso();
        }
        private void GenerarProgreso()
        {
            Detalle_MisionEntidad detalle_Mision = new Detalle_MisionEntidad()
            {    
                // Se declara el estado completado por defecto debido a que si se va a insertar se supone que ya se completó la misión en el sistema...
                estado_Mision = "Completada",
                id_Usuario = idUsuarioActual,
                id_Mision = idMisionActual
            };
            Detalle_MisionController detalle_MisionController = new Detalle_MisionController();
            bool completada = detalle_MisionController.MisionCompletada(idUsuarioActual, idMisionActual);

            if (completada)
            {
                progressBar1.Value = 100;
                lbCompletado.Text = "1/1";
                lblPorcentaje.Text = progressBar1.Value.ToString() + "%";
                return;
            }

            int progreso = Random.Shared.Next(0, 101);
            progressBar1.Value = progreso;
            progressBar1.Text = progreso + "%";

            if (progressBar1.Value == 100)
            {
                detalle_MisionController.Insert(detalle_Mision);
                lbCompletado.Text = "1/1";
                lblPorcentaje.Text = progressBar1.Value.ToString() + "%";
            }

            else
            {
                lbCompletado.Text = "0/1";
                lblPorcentaje.Text = progressBar1.Value.ToString() + "%";
            }
                
        }


        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntaje_Click(object sender, EventArgs e)
        {

        }
    }
}
