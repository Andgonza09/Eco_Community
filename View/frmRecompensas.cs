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
    public partial class frmRecompensas : Form
    {
        public int pagNumber = 1;
        public frmRecompensas()
        {
            InitializeComponent();
            RecompensaEntidad reward = new RecompensaEntidad();
          //  dgListReward.DataSource = reward.ViewAllRewards();
            dgListReward.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgListReward.AutoGenerateColumns = true;
            dgListReward.Columns["IdReward"].Visible = false;
            dgListReward.Columns["MissionId"].Visible = false;

            dgListReward.AutoGenerateColumns = false;
            dgListReward.Columns[1].HeaderText = "Recompensa";
            dgListReward.Columns[2].HeaderText = "Tipo de recompensa";
            dgListReward.Columns[4].HeaderText = "Misión a realizar";

        }
        private void RewardView_Load(object sender, EventArgs e)
        {
            labPag.Text = "Página " + pagNumber;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pagNumber++;
            labPag.Text = "Página " + pagNumber;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pagNumber > 1)
            {
                pagNumber--;
                labPag.Text = "Página " + pagNumber;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgListRequestUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
