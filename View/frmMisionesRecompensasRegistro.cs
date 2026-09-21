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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace View
{
    public partial class frmMisionesRecompensasRegistro : Form
    {
        private readonly MisionesEntidad _currentMission;
        private readonly RecompensaEntidad _currentReward;
        public frmMisionesRecompensasRegistro(MisionesEntidad currentMission, RecompensaEntidad currentReward)
        {
            InitializeComponent();
            _currentMission = currentMission;
            _currentReward = currentReward;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelData_Click(object sender, EventArgs e)
        {
            richtxtMissionDescription.Clear();
            richtxtRewardDescription.Clear();
            nudPointMission.Value = 0;
            cmbTypeReward.SelectedIndex = 0;
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richtxtMissionDescription.Text) || string.IsNullOrEmpty(richtxtRewardDescription.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbTypeReward.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudPointMission.Value <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de puntos válida.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_TypeReward = 0;

            if (cmbTypeReward.SelectedItem.ToString() == "Insignia")
                id_TypeReward = 1;

            else if (cmbTypeReward.SelectedItem.ToString() == "Subida de nivel")
                id_TypeReward = 2;

            else if (cmbTypeReward.SelectedItem.ToString() == "Logros")
                id_TypeReward = 3;

            else if (cmbTypeReward.SelectedItem.ToString() == "Puntos adicionales")
                id_TypeReward = 4;


            // Validamos datos para evitar duplicados en la base de datos

            try
            {
                MisionesEntidad mission = new MisionesEntidad()
                {
                    descripcion = richtxtMissionDescription.Text,
                    puntaje = (int)nudPointMission.Value
                };

                // Le pasamos a la recompensa el valor obtenido en el id de la misión
                RecompensaEntidad reward = new RecompensaEntidad()
                {
                    descripcionRecompensa = richtxtRewardDescription.Text,
                    id_TipoRecompensa = id_TypeReward // 👀👀👀
                };

                if (new MisionesController().MissionExists(mission.descripcion) || new RecompensaController().RewardExist(reward.descripcionRecompensa))
                {
                    MessageBox.Show(
                        "Datos ya existentes en la base de datos, comprueba la información e inténtalo de nuevo",
                        "Error de autentificación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Registro de elementos de gamificación existoso",
                        "Verificación de información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Agregamos la información a sus respectivas tablas
                    int mission_id = new MisionesController().Insert(mission);
                    mission.id_Mision = mission_id;

                    reward.id_Mision = mission_id;
                    int currentReward = new RecompensaController().Insert(reward);
                    reward.id_Recompensa = currentReward;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar información" + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




        }

        private void GamificationView_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
