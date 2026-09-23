using Microsoft.Data.SqlClient;
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
    public partial class frmMenúAdministrativo : Form
    {
        public frmMenúAdministrativo()
        {
            InitializeComponent();
            ///CountRequestRejected();
            //CountRequestApproved();
            //CountRequestEarrings();
        }

        private void pnlBedcrums_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminStartView_Load(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListMission_Click(object sender, EventArgs e)
        {

        }

        private void btnCriteriaGuide_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblDescriptionViewPoints_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
private void CountRequestApproved()
{
using SelectQuery query = new SelectQuery();

string sql = @"SELECT COUNT(*) FROM Solicitudes
INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Aprobada'";

object? total = query.ExecuteScalar(sql);
label12.Text = total?.ToString() ?? "0";
}
private void CountRequestEarrings()
{
using SelectQuery query = new SelectQuery();

string sql = @"SELECT COUNT(*) FROM Solicitudes
INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Pendiente'";

object? total = query.ExecuteScalar(sql);
label1.Text = total?.ToString() ?? "0";
}
private void CountRequestRejected()
{
using SelectQuery query = new SelectQuery();

string sql = @"SELECT COUNT(*) FROM Solicitudes
INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Rechazada'";

object? total = query.ExecuteScalar(sql);
label3.Text = total?.ToString() ?? "0";
}*/
    }
}
