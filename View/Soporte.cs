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
    public partial class Soporte : Form
    {
        public Soporte()
        {
            InitializeComponent();
        }

        private void Soporte_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que deseas eliminar la solicitud del sistema?",
                "Verificación de información",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            /*
            if (resultado == DialogResult.OK)
            {
                // Eliminar solicitud
                // Eliminamos el id de la tabla multimedia para evitar las dependencias de llaves foráneas de cada tabla
                new MultimediaController().DeleteMultimedia(idSolicitudSeleccionada);
                new SolicitudesController().DeleteRequest(idSolicitudSeleccionada);
                MessageBox.Show("Solicitud eliminada correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshTable();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {/*
            MisionesController controller = new MisionesController();
            RecompensaController recompensaController = new RecompensaController();

            int id_TipoRecompensa;

            if (cmbTipoRecompensa.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de recompensa.");
                return;
            }

            if (cmbTipoRecompensa.SelectedItem.ToString() == "Insignia")
            {
                id_TipoRecompensa = 1;
            }
            else if (cmbTipoRecompensa.SelectedItem.ToString() == "Subida de nivel")
            {
                id_TipoRecompensa = 2;
            }
            else if (cmbTipoRecompensa.SelectedItem.ToString() == "Logros")
            {
                id_TipoRecompensa = 3;
            }
            else
            {
                id_TipoRecompensa = 4;
            }

            MisionesEntidad misiones = new MisionesEntidad()
            {
                puntaje = (int)nudPuntaje.Value,
            };
            RecompensaEntidad recompensaEntidad = new RecompensaEntidad()
            {
                descripcionRecompensa = txtDescripcionRecompensa.Text,
                id_TipoRecompensa = id_TipoRecompensa
            };

            try
            {

                bool Cantidad = controller.MissionExists(txtDescripcionMision.Text);
                bool ExiteRecompensa = recompensaController.RewardExist(txtDescripcionRecompensa.Text);

                if (Cantidad == true)
                {
                    MessageBox.Show("Usuario ya existente, intenta de nuevo", "Verificación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int id_Misión = controller.Insert(misiones);

                    recompensaController.Insert(recompensaEntidad, id_Misión, id_TipoRecompensa);
                    MessageBox.Show("Registro exitoso", "Misión y recompensa agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error de inserción: " + ex.Message, ex);
            }
            */
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
