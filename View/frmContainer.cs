using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmContainer : Form
    {
        private string _username { get; set; }
        private string _password { get; set; }

        // Uso único del objeto User
        private readonly UsuarioEntidad _currentUser;
        private long _id_Usuario;

        public frmContainer(UsuarioEntidad currentUser, long id_usuario, string username, string password)
        {
            InitializeComponent();

            // Captura del objeto del usuario actual
            _currentUser = currentUser;
            this._id_Usuario = id_usuario;

            this._username = username;
            this._password = password;
            this.MinimumSize = new Size(1300, 900);

            lblMenu.Text = string.Empty;
            lblItems.Text = string.Empty;

            lblUsername.Text = username;

            CustomizeNavegation();
        }
        public void UpdateUserData(string newUsername, string newPassword)
        {
            _username = newUsername;
            _password = newPassword;

            lblUsername.Text = $"{newUsername}!";
        }
        public void OpenForm(Form form)
        {
            panelContent.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.Manual;

            form.AutoSize = false;
            form.AutoScroll = false;
            form.MinimumSize = new Size(0, 0);
            form.MaximumSize = new Size(0, 0);

            form.Dock = DockStyle.Fill;

            panelContent.Controls.Add(form);
            form.Show();

        }
        public void CustomizeNavegation()
        {
            // Ocultar panels subMenu
            pnlSubMenuPointsWaste.Visible = false;
            pnlSubMenuRequest.Visible = false;
            pnlSubMenuMission.Visible = false;
            pnlSubMenuReward.Visible = false;
            pnlSubMenuCriteria.Visible = false;
        } // end method
        public void HideSubMenu()
        {
            if (pnlSubMenuPointsWaste.Visible == true)
                pnlSubMenuPointsWaste.Visible = false;
            if (pnlSubMenuRequest.Visible == true)
                pnlSubMenuRequest.Visible = false;
            if (pnlSubMenuMission.Visible == true)
                pnlSubMenuMission.Visible = false;
            if (pnlSubMenuReward.Visible == true)
                pnlSubMenuReward.Visible = false;
            if (pnlSubMenuCriteria.Visible == true)
                pnlSubMenuCriteria.Visible = false;
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

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void ContainerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPointsWaste_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuPointsWaste);

            // Modificar texxto del label para mostrar el menú actual
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Puntos de residuos /";

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuRequest);
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Solicitudes /";
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuMission);
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Misiones /";
        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuReward);
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Recompensas /";
        }

        private void btnLocationCriteria_Click(object sender, EventArgs e)
        {
            ShowSubMenú(pnlSubMenuCriteria);
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Criterios de ubicación /";
        }

        private void bntAddPoints_Click(object sender, EventArgs e)
        {
            ShowSiteLocation();

        }
        private void ShowSiteLocation()
        {
            lblItems.Text = "Registrar nuevo punto /";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(60, 0, 0, 0);

            // Formulario de ubicación del punto
            frmInformacionSitios view = new frmInformacionSitios(_currentUser, _currentUser.id_Usuario);
            OpenForm(view);
        }
        /*
        private void ShowAttachMultimedia()
        {
            lblItems.Text = "Registrar nuevo punto /  Adjunción Multimedia";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(60, 0, 0, 0);

            // Formulario de adjunción Multimedia
            AttachMultimediaView viewAttach = new AttachMultimediaView();

            viewAttach.NextClickedBack += (s, e) =>
            {
                var result = MessageBox.Show("¿Desea regresar a la ubicación del punto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ShowSiteLocation();
                }

            };

            OpenForm(viewAttach);
        }*/

        private void btnMyPoints_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPointsRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Puntos registrados";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(60, 0, 0, 0);
            OpenForm(new frmInformacionSitioRegistrado());
        }

        private void btnMyRequests_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Mis solicitudes";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(15, 0, 0, 0);
            OpenForm(new frmSolicitudes(_id_Usuario));
        }

        private void btnHistoryRequests_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Historial de solicitudes";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(15, 0, 0, 0);

        }

        private void btnMissionComplete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Misiones completadas";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(0, 0, 0, 0);
        }
        private void btnRewardObtained_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Recompensas obtenidas";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(25, 0, 0, 0);
        }

        private void btnExploreReward_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Explorar recompensas";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(25, 0, 0, 0);
           // OpenForm(new frmRecompensas());
        }

        private void btnCriteriaGuide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Guia de ubicación";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(80, 0, 0, 0);
            panelContent.Controls.Clear();
            OpenForm(new frmArchivoCriterios(_currentUser));
        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();

            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;

            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            OpenForm(new frmMenúPrincipal(_currentUser, this.lblUsername.Text.Trim(), this._password));
        }

        private void pnlBedcrums_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Destruye y libera recursos ocupados.
            Application.Exit();
            // this.close() -- Solo cierra, pero no libera recursos.
            // this.Hide() -- Mantiene el objeto, pero no destruye ni libera recursos

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSubMenuMission_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMissionCompleted_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Misiones completadas";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(0, 0, 0, 0);
        }

        private void btnListMission_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblItems.Text))
                lblItems.Text = string.Empty;
            lblItems.Text = "Listado de misiones";
            lblItems.SendToBack();
            lblItems.Padding = new Padding(0, 0, 0, 0);
          //  OpenForm(new frmMisiones());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            // Al cargar el panel por primera vez, mostrar la vista de inicio del usuario
            if (panelContent.Controls.Count == 0)
            {
                OpenForm(new frmMenúPrincipal(_currentUser, this.lblUsername.Text.Trim(), this._password));
            }

        }
        public static void RoundEdge(Control control, int radius)
        {
            if (control.ClientSize.Width <= 0 || control.ClientSize.Height <= 0)
                return;

            // El diámetro es el doble del radio.
            int diameter = radius * 2;

            // Evita que la curva sea mayor que el control.
            diameter = Math.Min(
                diameter,
                Math.Min(control.ClientSize.Width, control.ClientSize.Height)
            );

            Rectangle rectangle = new Rectangle(
                0,
                0,
                control.ClientSize.Width - 1,
                control.ClientSize.Height - 1
            );

            using GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            // Esquina superior izquierda
            path.AddArc(
                rectangle.Left,
                rectangle.Top,
                diameter,
                diameter,
                180,
                90
            );

            // Esquina superior derecha
            path.AddArc(
                rectangle.Right - diameter,
                rectangle.Top,
                diameter,
                diameter,
                270,
                90
            );

            // Esquina inferior derecha
            path.AddArc(
                rectangle.Right - diameter,
                rectangle.Bottom - diameter,
                diameter,
                diameter,
                0,
                90
            );

            // Esquina inferior izquierda
            path.AddArc(
                rectangle.Left,
                rectangle.Bottom - diameter,
                diameter,
                diameter,
                90,
                90
            );

            path.CloseFigure();

            Region newRegion = new Region(path);

            control.Region?.Dispose();
            control.Region = newRegion;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMenu.Text))
                lblMenu.Text = string.Empty;

            lblItems.Text = string.Empty;
            lblMenu.Text = "Perfil de usuario";
            lblItems.Padding = new Padding(0, 0, 0, 0);
            frmPerfilUsuario profileView = new frmPerfilUsuario(_currentUser, this, _username, _password);
            OpenForm(profileView);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {


        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
