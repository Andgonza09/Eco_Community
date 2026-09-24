namespace View
{
    partial class frmContainerAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel6 = new Panel();
            label2 = new Label();
            button21 = new Button();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pnlBedcrums = new Panel();
            lblItems = new Label();
            lblMenu = new Label();
            btnExit = new Button();
            lblHome = new Label();
            pnlSideBarLeft = new Panel();
            pnlSubMenuMissionReward = new Panel();
            btnCreateMission = new Button();
            btnMission = new Button();
            pnlSubMenuRequest = new Panel();
            btnRequestManagement = new Button();
            btnRequest = new Button();
            pnlSubMenuPoints = new Panel();
            btnPoitnsHistory = new Button();
            btnPoints = new Button();
            pnlSubMenuUsers = new Panel();
            btnUserRegister = new Button();
            btnUser = new Button();
            pnlHome = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlBedcrums.SuspendLayout();
            pnlSideBarLeft.SuspendLayout();
            pnlSubMenuMissionReward.SuspendLayout();
            pnlSubMenuRequest.SuspendLayout();
            pnlSubMenuPoints.SuspendLayout();
            pnlSubMenuUsers.SuspendLayout();
            pnlHome.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(7, 80, 51);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(button21);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Font = new Font("Segoe UI Historic", 9F);
            panel6.ForeColor = Color.FromArgb(252, 253, 251);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1162, 80);
            panel6.TabIndex = 47;
            panel6.Paint += panel6_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label2.Location = new Point(1031, 31);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 18;
            label2.Text = "Admin";
            // 
            // button21
            // 
            button21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button21.BackgroundImage = Properties.Resources.User_newIcon2;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Location = new Point(954, 6);
            button21.Name = "button21";
            button21.Size = new Size(64, 64);
            button21.TabIndex = 16;
            button21.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_final;
            pictureBox2.Location = new Point(136, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(251, 251, 251);
            label6.Location = new Point(302, 23);
            label6.Name = "label6";
            label6.Size = new Size(514, 31);
            label6.TabIndex = 3;
            label6.Text = "SISTEMA DE GESTIÓN DE RESIDUOS Y RECICLAJE";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlBedcrums
            // 
            pnlBedcrums.BackColor = Color.White;
            pnlBedcrums.Controls.Add(lblItems);
            pnlBedcrums.Controls.Add(lblMenu);
            pnlBedcrums.Controls.Add(btnExit);
            pnlBedcrums.Controls.Add(lblHome);
            pnlBedcrums.Dock = DockStyle.Top;
            pnlBedcrums.Font = new Font("Segoe UI Historic", 9F);
            pnlBedcrums.ForeColor = Color.FromArgb(252, 253, 251);
            pnlBedcrums.Location = new Point(240, 80);
            pnlBedcrums.Name = "pnlBedcrums";
            pnlBedcrums.Size = new Size(922, 60);
            pnlBedcrums.TabIndex = 50;
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblItems.ForeColor = Color.FromArgb(45, 48, 51);
            lblItems.Location = new Point(176, 23);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(45, 20);
            lblItems.TabIndex = 5;
            lblItems.Text = "Items";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.FromArgb(45, 48, 51);
            lblMenu.Location = new Point(92, 23);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(59, 20);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Menú /";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(7, 80, 51);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(246, 246, 247);
            btnExit.Image = Properties.Resources.leave;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(738, 9);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(16, 0, 0, 0);
            btnExit.Size = new Size(113, 40);
            btnExit.TabIndex = 16;
            btnExit.Text = "Salir";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.ForeColor = Color.FromArgb(45, 48, 51);
            lblHome.Location = new Point(30, 23);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(56, 20);
            lblHome.TabIndex = 3;
            lblHome.Text = "Inicio /";
            // 
            // pnlSideBarLeft
            // 
            pnlSideBarLeft.BackColor = Color.FromArgb(32, 98, 71);
            pnlSideBarLeft.Controls.Add(pnlSubMenuMissionReward);
            pnlSideBarLeft.Controls.Add(btnMission);
            pnlSideBarLeft.Controls.Add(pnlSubMenuRequest);
            pnlSideBarLeft.Controls.Add(btnRequest);
            pnlSideBarLeft.Controls.Add(pnlSubMenuPoints);
            pnlSideBarLeft.Controls.Add(btnPoints);
            pnlSideBarLeft.Controls.Add(pnlSubMenuUsers);
            pnlSideBarLeft.Controls.Add(btnUser);
            pnlSideBarLeft.Controls.Add(pnlHome);
            pnlSideBarLeft.Dock = DockStyle.Left;
            pnlSideBarLeft.Font = new Font("Segoe UI Historic", 9F);
            pnlSideBarLeft.ForeColor = Color.FromArgb(252, 253, 251);
            pnlSideBarLeft.Location = new Point(0, 80);
            pnlSideBarLeft.Name = "pnlSideBarLeft";
            pnlSideBarLeft.Size = new Size(240, 796);
            pnlSideBarLeft.TabIndex = 51;
            // 
            // pnlSubMenuMissionReward
            // 
            pnlSubMenuMissionReward.BackColor = Color.FromArgb(57, 115, 92);
            pnlSubMenuMissionReward.Controls.Add(btnCreateMission);
            pnlSubMenuMissionReward.Dock = DockStyle.Top;
            pnlSubMenuMissionReward.Location = new Point(0, 372);
            pnlSubMenuMissionReward.Name = "pnlSubMenuMissionReward";
            pnlSubMenuMissionReward.Size = new Size(240, 69);
            pnlSubMenuMissionReward.TabIndex = 11;
            pnlSubMenuMissionReward.Paint += pnlSubMenuMissionReward_Paint;
            // 
            // btnCreateMission
            // 
            btnCreateMission.Cursor = Cursors.Hand;
            btnCreateMission.Dock = DockStyle.Top;
            btnCreateMission.FlatAppearance.BorderSize = 0;
            btnCreateMission.FlatStyle = FlatStyle.Flat;
            btnCreateMission.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateMission.ForeColor = Color.FromArgb(246, 246, 247);
            btnCreateMission.Location = new Point(0, 0);
            btnCreateMission.Name = "btnCreateMission";
            btnCreateMission.Padding = new Padding(48, 0, 0, 0);
            btnCreateMission.Size = new Size(240, 67);
            btnCreateMission.TabIndex = 7;
            btnCreateMission.Text = "Crear misión y recompensa";
            btnCreateMission.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateMission.UseVisualStyleBackColor = true;
            btnCreateMission.Click += btnCreateMission_Click;
            // 
            // btnMission
            // 
            btnMission.BackColor = Color.FromArgb(6, 72, 46);
            btnMission.Cursor = Cursors.Hand;
            btnMission.Dock = DockStyle.Top;
            btnMission.FlatAppearance.BorderSize = 0;
            btnMission.FlatStyle = FlatStyle.Flat;
            btnMission.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMission.ForeColor = Color.FromArgb(246, 246, 247);
            btnMission.Image = Properties.Resources.mission__2_;
            btnMission.ImageAlign = ContentAlignment.MiddleLeft;
            btnMission.Location = new Point(0, 332);
            btnMission.Name = "btnMission";
            btnMission.Padding = new Padding(16, 0, 0, 0);
            btnMission.Size = new Size(240, 40);
            btnMission.TabIndex = 10;
            btnMission.Text = "Gamificación";
            btnMission.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMission.UseVisualStyleBackColor = false;
            btnMission.Click += btnMission_Click;
            // 
            // pnlSubMenuRequest
            // 
            pnlSubMenuRequest.BackColor = Color.FromArgb(57, 115, 92);
            pnlSubMenuRequest.Controls.Add(btnRequestManagement);
            pnlSubMenuRequest.Dock = DockStyle.Top;
            pnlSubMenuRequest.Location = new Point(0, 274);
            pnlSubMenuRequest.Name = "pnlSubMenuRequest";
            pnlSubMenuRequest.Size = new Size(240, 58);
            pnlSubMenuRequest.TabIndex = 9;
            // 
            // btnRequestManagement
            // 
            btnRequestManagement.Cursor = Cursors.Hand;
            btnRequestManagement.Dock = DockStyle.Top;
            btnRequestManagement.FlatAppearance.BorderSize = 0;
            btnRequestManagement.FlatStyle = FlatStyle.Flat;
            btnRequestManagement.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRequestManagement.ForeColor = Color.FromArgb(246, 246, 247);
            btnRequestManagement.Location = new Point(0, 0);
            btnRequestManagement.Name = "btnRequestManagement";
            btnRequestManagement.Padding = new Padding(56, 0, 0, 0);
            btnRequestManagement.Size = new Size(240, 40);
            btnRequestManagement.TabIndex = 6;
            btnRequestManagement.Text = "Gestión de solicitudes";
            btnRequestManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnRequestManagement.UseVisualStyleBackColor = true;
            btnRequestManagement.Click += btnRequestManagement_Click;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.FromArgb(6, 72, 46);
            btnRequest.Cursor = Cursors.Hand;
            btnRequest.Dock = DockStyle.Top;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.FromArgb(246, 246, 247);
            btnRequest.Image = Properties.Resources.request;
            btnRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequest.Location = new Point(0, 234);
            btnRequest.Name = "btnRequest";
            btnRequest.Padding = new Padding(16, 0, 0, 0);
            btnRequest.Size = new Size(240, 40);
            btnRequest.TabIndex = 8;
            btnRequest.Text = "Solicitudes";
            btnRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // pnlSubMenuPoints
            // 
            pnlSubMenuPoints.BackColor = Color.FromArgb(57, 115, 92);
            pnlSubMenuPoints.Controls.Add(btnPoitnsHistory);
            pnlSubMenuPoints.Dock = DockStyle.Top;
            pnlSubMenuPoints.Location = new Point(0, 186);
            pnlSubMenuPoints.Name = "pnlSubMenuPoints";
            pnlSubMenuPoints.Size = new Size(240, 48);
            pnlSubMenuPoints.TabIndex = 7;
            // 
            // btnPoitnsHistory
            // 
            btnPoitnsHistory.BackColor = Color.FromArgb(57, 115, 92);
            btnPoitnsHistory.Cursor = Cursors.Hand;
            btnPoitnsHistory.Dock = DockStyle.Top;
            btnPoitnsHistory.FlatAppearance.BorderSize = 0;
            btnPoitnsHistory.FlatStyle = FlatStyle.Flat;
            btnPoitnsHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPoitnsHistory.ForeColor = Color.FromArgb(246, 246, 247);
            btnPoitnsHistory.Location = new Point(0, 0);
            btnPoitnsHistory.Name = "btnPoitnsHistory";
            btnPoitnsHistory.Padding = new Padding(56, 0, 0, 0);
            btnPoitnsHistory.Size = new Size(240, 40);
            btnPoitnsHistory.TabIndex = 5;
            btnPoitnsHistory.Text = "Historial de puntos";
            btnPoitnsHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnPoitnsHistory.UseVisualStyleBackColor = false;
            btnPoitnsHistory.Click += btnPoitnsHistory_Click;
            // 
            // btnPoints
            // 
            btnPoints.BackColor = Color.FromArgb(6, 72, 46);
            btnPoints.Cursor = Cursors.Hand;
            btnPoints.Dock = DockStyle.Top;
            btnPoints.FlatAppearance.BorderSize = 0;
            btnPoints.FlatStyle = FlatStyle.Flat;
            btnPoints.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPoints.ForeColor = Color.FromArgb(246, 246, 247);
            btnPoints.Image = Properties.Resources.location;
            btnPoints.ImageAlign = ContentAlignment.MiddleLeft;
            btnPoints.Location = new Point(0, 146);
            btnPoints.Name = "btnPoints";
            btnPoints.Padding = new Padding(16, 0, 0, 0);
            btnPoints.Size = new Size(240, 40);
            btnPoints.TabIndex = 6;
            btnPoints.Text = "Puntos";
            btnPoints.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPoints.UseVisualStyleBackColor = false;
            btnPoints.Click += btnPoints_Click;
            // 
            // pnlSubMenuUsers
            // 
            pnlSubMenuUsers.BackColor = Color.FromArgb(57, 115, 92);
            pnlSubMenuUsers.Controls.Add(btnUserRegister);
            pnlSubMenuUsers.Dock = DockStyle.Top;
            pnlSubMenuUsers.Location = new Point(0, 94);
            pnlSubMenuUsers.Name = "pnlSubMenuUsers";
            pnlSubMenuUsers.Size = new Size(240, 52);
            pnlSubMenuUsers.TabIndex = 4;
            // 
            // btnUserRegister
            // 
            btnUserRegister.Cursor = Cursors.Hand;
            btnUserRegister.Dock = DockStyle.Top;
            btnUserRegister.FlatAppearance.BorderSize = 0;
            btnUserRegister.FlatStyle = FlatStyle.Flat;
            btnUserRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserRegister.ForeColor = Color.FromArgb(246, 246, 247);
            btnUserRegister.Location = new Point(0, 0);
            btnUserRegister.Name = "btnUserRegister";
            btnUserRegister.Padding = new Padding(56, 0, 0, 0);
            btnUserRegister.Size = new Size(240, 40);
            btnUserRegister.TabIndex = 4;
            btnUserRegister.Text = "Usuarios registrados";
            btnUserRegister.TextAlign = ContentAlignment.MiddleLeft;
            btnUserRegister.UseVisualStyleBackColor = true;
            btnUserRegister.Click += btnUserRegister_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(6, 72, 46);
            btnUser.Cursor = Cursors.Hand;
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.FromArgb(246, 246, 247);
            btnUser.Image = Properties.Resources.user__1_;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 54);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(16, 0, 0, 0);
            btnUser.Size = new Size(240, 40);
            btnUser.TabIndex = 5;
            btnUser.Text = "Usuarios";
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(button1);
            pnlHome.Cursor = Cursors.Hand;
            pnlHome.Dock = DockStyle.Top;
            pnlHome.Location = new Point(0, 0);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(240, 54);
            pnlHome.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 98, 71);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(246, 246, 247);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(240, 53);
            button1.TabIndex = 9;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(240, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 736);
            panel1.TabIndex = 52;
            panel1.Paint += panel1_Paint;
            // 
            // frmContainerAdmin
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(panel1);
            Controls.Add(pnlBedcrums);
            Controls.Add(pnlSideBarLeft);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmContainerAdmin";
            Text = "ContainerFormAdmin";
            WindowState = FormWindowState.Maximized;
            Load += ContainerFormAdmin_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlBedcrums.ResumeLayout(false);
            pnlBedcrums.PerformLayout();
            pnlSideBarLeft.ResumeLayout(false);
            pnlSubMenuMissionReward.ResumeLayout(false);
            pnlSubMenuRequest.ResumeLayout(false);
            pnlSubMenuPoints.ResumeLayout(false);
            pnlSubMenuUsers.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Label label2;
        private Button button21;
        private PictureBox pictureBox2;
        private Label label6;
        private Panel pnlBedcrums;
        private Label lblItems;
        private Label lblMenu;
        private Button btnExit;
        private Label lblHome;
        private Panel pnlSideBarLeft;
        private Panel pnlSubMenuMissionReward;
        private Button btnCreateMission;
        private Button btnMission;
        private Panel pnlSubMenuRequest;
        private Button btnRequestManagement;
        private Button btnRequest;
        private Panel pnlSubMenuPoints;
        private Button btnPoitnsHistory;
        private Button btnPoints;
        private Panel pnlSubMenuUsers;
        private Button btnUserRegister;
        private Button btnUser;
        private Panel pnlHome;
        private Button button1;
        private Panel panel1;
    }
}