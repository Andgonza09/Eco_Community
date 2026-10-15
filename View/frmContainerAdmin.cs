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
    public partial class frmContainerAdmin : Form
    {
        public frmContainerAdmin()
        {
            InitializeComponent();
            lblMenu.Text = string.Empty;
            lblItems.Text = string.Empty;

            CustomizeNavegation();
        }
        public void CustomizeNavegation()
        {
            // Ocultar panels subMenu
            pnlSubMenuUsers.Visible = false;
            pnlSubMenuPoints.Visible = false;
            pnlSubMenuRequest.Visible = false;
            pnlSubMenuMissionReward.Visible = false;
            pnlMultimedia.Visible = false;
            pnlGestionResiduos.Visible = false;

        } // end method
        public void HideSubMenu()
        {
            if (pnlSubMenuUsers.Visible == true)
                pnlSubMenuUsers.Visible = false;
            if (pnlSubMenuPoints.Visible == true)
                pnlSubMenuPoints.Visible = false;
            if (pnlSubMenuRequest.Visible == true)
                pnlSubMenuRequest.Visible = false;
            if (pnlSubMenuMissionReward.Visible == true)
                pnlSubMenuMissionReward.Visible = false;
            if (pnlMultimedia.Visible == true)
                pnlMultimedia.Visible = false;
            if (pnlGestionResiduos.Visible == true)
                pnlGestionResiduos.Visible = false;

        }
        private void ShowSubMenú(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        public void OpenForm(Form form)
        {
            panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.Manual;

            form.AutoSize = false;
            form.AutoScroll = false;
            form.MinimumSize = new Size(0, 0);
            form.MaximumSize = new Size(0, 0);

            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            form.Show();

        }
        private void pnlSubMenuCriteria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContainerFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuUsers);

            // Modificar texxto del label para mostrar el menú actual
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Usuarios /";
            lblMenu.BringToFront();
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuPoints);

            // Modificar texxto del label para mostrar el menú actual
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Puntos /";
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuRequest);

            // Modificar texxto del label para mostrar el menú actual
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Solicitudes /";
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuMissionReward);

            // Modificar texxto del label para mostrar el menú actual
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Gamificación /";
        }
        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Usuarios registrados";
            lblItems.SendToBack();

            lblItems.Location = new Point(176, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmUsuariosRegistrados());
        }

        private void btnPoitnsHistory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Historial de puntos";
            lblItems.SendToBack();
            lblItems.Location = new Point(156, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmPuntoRegistrados());
        }

        private void btnRequestManagement_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Gestión de solicitudes";
            lblItems.SendToBack();

            lblItems.Location = new Point(176, 23);
            lblItems.Padding = new Padding(10, 0, 0, 0);
            OpenForm(new frmSolicitudesRegistradas());
        }

        private void btnCreateMission_Click(object sender, EventArgs e)
        {
            MisionesEntidad mission = new MisionesEntidad();
            RecompensaEntidad reward = new RecompensaEntidad();

            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Crear misión y recompensa";
            lblItems.SendToBack();

            lblItems.Location = new Point(176, 23);
            lblItems.Padding = new Padding(20, 0, 0, 0);
            OpenForm(new frmMisionesRecompensas_Registro());
        }

        private void btnListMission_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Misiones registradas";
            lblItems.SendToBack();

            lblItems.Location = new Point(176, 23);
            lblItems.Padding = new Padding(20, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();

            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;

            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            OpenForm(new frmMenúAdministrativo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Recompensas registradas";
            lblItems.SendToBack();

            lblItems.Padding = new Padding(20, 0, 0, 0);

        }

        private void pnlSubMenuMissionReward_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSubMenuRequest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.Controls.Count == 0)
            {
                OpenForm(new frmMenúAdministrativo());
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestiónBarrios_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Gestión de barrios";
            lblItems.SendToBack();
            lblItems.Location = new Point(156, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmBarrios());
        }

        private void btnGestiónDistritos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Gestión de distritos";
            lblItems.SendToBack();
            lblItems.Location = new Point(156, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmDistrito());
        }

        private void btnGestionResiduos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Gestión de residuos";
            lblItems.SendToBack();
            lblItems.Location = new Point(250, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmCatalogoResiduos());
        }

        private void btnGestionMultimedia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Gestión de multimedia";
            lblItems.SendToBack();
            lblItems.Location = new Point(200, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmMultimedia());
        }

        private void btnGestiónExtensiones_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Gestión de extensiones";
            lblItems.SendToBack();
            lblItems.Location = new Point(200, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmExtension());
        }

        private void btnTipoRecompensa_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Gestión de tipo de recompensa";
            lblItems.SendToBack();
            lblItems.Location = new Point(200, 23);
            lblItems.Padding = new Padding(0, 0, 0, 0);
            OpenForm(new frmTipoRecompensa());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlGestionResiduos);
            // Modificar texxto del label para mostrar el menú actual
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Catálogo de Residuos /";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlMultimedia);
            // Modificar texxto del label para mostrar el menú actual
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Multimedia /";
        }
    }
}
