using Microsoft.Data.SqlClient;
using Model.Eco_Community;
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
    public partial class frmMisionesRegistradas : Form
    {
        public frmMisionesRegistradas()
        {
            InitializeComponent();
            MisionesEntidad mission = new MisionesEntidad();

            //    dgListMission.DataSource = mission.ViewAllMissions();
            dgListMission.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

            dgListMission.Columns[0].HeaderText = "Id Misión";
            dgListMission.Columns[1].HeaderText = "Descripción de la misión";
            dgListMission.Columns[2].HeaderText = "Puntaje";
        }

        private void dgListMission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgListMission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMission.Text = dgListMission.SelectedCells[0].Value.ToString();
            rchtxtMissionDescription.Text = dgListMission.SelectedCells[1].Value.ToString();
            txtPointsMission.Text = dgListMission.SelectedCells[2].Value.ToString();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgListMission.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListMission.MultiSelect = false;
            MisionesEntidad mission = new MisionesEntidad();
            try
            {
                dgListMission.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgListMission.MultiSelect = false;

                if (txtIdMission.Text == string.Empty)
                    return;

                if (dgListMission.SelectedRows.Count == 0)
                    return;

                var verificate =
                    MessageBox.Show("¨¿Estás seguro que deseas eliminar esta misión del sistema?", "Verificando información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (verificate == DialogResult.OK)
                {
                    // Validar la eliminación del valor de la tabla detalle
                    int id_Mission = int.Parse(txtIdMission.Text);
                    //    mission.DeleteMission(id_Mission);

                    MessageBox.Show("Misión eliminada correctamente", "Eliminación de Misión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar esta misión: " + ex.Message, "Error en eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgListMission.EndEdit();
            MisionesEntidad mission = new MisionesEntidad();
            try
            {

                dgListMission.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgListMission.MultiSelect = false;

                if (txtIdMission.Text == string.Empty)
                    return;

                if (dgListMission.SelectedRows.Count == 0)
                    return;

                string currentDescription = dgListMission.CurrentRow.Cells["MissionDescription"].Value.ToString();
                string currentPoints = dgListMission.CurrentRow.Cells["PointsMission"].Value.ToString();

                if (currentDescription != rchtxtMissionDescription.Text || currentPoints != txtPointsMission.Text)
                {
                    var verificate = MessageBox.Show("¨¿Estás seguro que deseas actualizar la información de la misión?", "Verificando información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (verificate == DialogResult.OK)
                    {
                        // Validar la eliminación del valor de la tabla detalle
                        int id_Mission = int.Parse(txtIdMission.Text);
                        string missionDescription = rchtxtMissionDescription.Text;
                        int missionPoints = int.Parse(txtPointsMission.Text);

                    //    mission.UpdateMission(id_Mission, missionDescription, missionPoints);
                        MessageBox.Show("Misión actualizada correctamente", "Actualización de Misión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshTable();
                    }
                }
                else
                {
                    MessageBox.Show("No se ingresaron datos nuevos", "Validando actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar esta misión: " + ex.Message, "Error en eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshTable()
        {
            MisionesEntidad mission = new MisionesEntidad();
            //   dgListMission.DataSource = mission.ViewAllMissions();
        }

        /*

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            MisionesEntidad mission = new MisionesEntidad();
            if (string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                dgListMission.DataSource = mission.ViewAllMissions();
                return;
            }


            if (!int.TryParse(txtSearchId.Text, out int idMission))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            try
            {
                using SelectQuery query = new SelectQuery();

                string sql = @"SELECT id_Mision, descripcion, puntaje FROM Misiones WHERE id_Mision = @IDMission";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDMission", SqlDbType.Int) {Value =  idMission},
                };

                using SqlDataReader result = query.ExecuteSelect(sql, parameters);
                if (result.Read())
                {
                    mission = new Mission
                    {
                        IdMission = Convert.ToInt32(result["id_Mision"]),
                        MissionDescription = result["descripcion"].ToString(),
                        PointsMission = Convert.ToInt32(result["puntaje"])
                    };

                    dgListMission.DataSource = null;
                    dgListMission.DataSource = new List<Mission> { mission };
                }
                else
                {
                    dgListMission.DataSource = null;
                    MessageBox.Show($"No se encontró información de la misión con el id: {txtSearchId.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la misión: " + ex.Message);
            }
        }*/

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {

        }
    }
}
