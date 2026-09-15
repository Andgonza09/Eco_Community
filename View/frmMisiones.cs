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
    public partial class frmMisiones : Form
    {
        public int pagNumber = 1;

        public frmMisiones()
        {
            InitializeComponent();
            MisionesEntidad mission = new MisionesEntidad();
            dgListMission.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            // dgListMission.DataSource = mission.ViewAllMissions();

            dgListMission.AutoGenerateColumns = true;
            dgListMission.Columns["IdMission"].Visible = false;

            dgListMission.AutoGenerateColumns = false;
            dgListMission.Columns[1].HeaderText = "Misión";
            dgListMission.Columns[2].HeaderText = "Puntaje de la misión";



        }

        private void MissionView_Load(object sender, EventArgs e)
        {
            labPag.Text = "Página " + pagNumber;
            this.FormClosing += MissionView_FormClosing;
        }
        private void MissionView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void labPag_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pagNumber > 1)
            {
                pagNumber--;
                labPag.Text = "Página " + pagNumber;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            pagNumber++;
            labPag.Text = "Página " + pagNumber;
        }

        private void dgListRequestUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
