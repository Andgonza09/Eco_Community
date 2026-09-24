using Microsoft.Data.SqlClient;
using Controller;
using Model.Eco_Community;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public partial class frmMenúPrincipal : Form
    {
        private UsuarioEntidad _currentUser;
        private string _username;
        private string _password;
        public frmMenúPrincipal(UsuarioEntidad currentUser, string username, string password)
        {
            InitializeComponent();
            _currentUser = currentUser;
            this._username = username;
            this._password = password;

            lblUsernamePnl.Text = $"¡Bienvenido, {username}!";
            ConfigureRoundedControl(pnlAddPoints, 15);
            ConfigureRoundedControl(pnlViewMyPoints, 15);
            ConfigureRoundedControl(pnlViewMyRequest, 15);

            // CountRequestApproved();
            // CountRequestEarrings();
        }

        // Configurar todos los formularios que se encuentran contenidos dentro del container form con el objetivo
        // de hacer los ejecutables del form principal del proyecto...
        private void ConfigureRoundedControl(Control control, int radius)
        {
            frmContainer.RoundEdge(control, radius);

            control.SizeChanged += (sender, e) =>
            {
                frmContainer.RoundEdge(control, radius);
            };
        }

        private void UserStartView_Load(object sender, EventArgs e)
        {
            frmContainer.RoundEdge(pnlAddPoints, 15);
            frmContainer.RoundEdge(pnlViewMyPoints, 15);
            frmContainer.RoundEdge(pnlViewMyRequest, 15);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCriteriaGuide_Click(object sender, EventArgs e)
        {

        }

        private void lblUsernamePnl_Click(object sender, EventArgs e)
        {

        }

        private void pnlViewMyPoints_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {


        }
        /*
        private void CountRequestApproved()
        {
            using SelectQuery query = new SelectQuery();

            string sql = @"SELECT COUNT(*) FROM Solicitudes
            INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Aprobada'
            AND Usuario.id_Usuario = @IdUser;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdUser", SqlDbType.BigInt) {Value = _currentUser.IdUser}
            };

            object? total = query.ExecuteScalar(sql, parameters);
            label12.Text = total?.ToString() ?? "0";
        }
        private void CountRequestEarrings()
        {
            using SelectQuery query = new SelectQuery();

            string sql = @"SELECT COUNT(*) FROM Solicitudes
            INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Pendiente'
            AND Usuario.id_Usuario = @IdUser;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdUser", SqlDbType.BigInt) {Value = _currentUser.IdUser}
            };

            object? total = query.ExecuteScalar(sql, parameters);
            label1.Text = total?.ToString() ?? "0";
        }*/

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblDescriptionViewPoints_Click(object sender, EventArgs e)
        {

        }

        private void lblViewRequest_Click(object sender, EventArgs e)
        {

        }

        private void lblDescriptionRequest_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
