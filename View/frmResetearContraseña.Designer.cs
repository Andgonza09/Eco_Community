namespace View
{
    partial class frmResetearContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetearContraseña));
            label1 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnVerificateData = new Button();
            txtEmail = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            pictureBox21 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(471, 245);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 1;
            label1.Text = "Buscar tu cuenta";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(179, 194, 148);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnVerificateData);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtUser);
            panel1.Location = new Point(271, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 395);
            panel1.TabIndex = 8;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(227, 269);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(194, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Volver al menú principal";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(107, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(107, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnVerificateData
            // 
            btnVerificateData.BackColor = Color.FromArgb(69, 93, 51);
            btnVerificateData.Cursor = Cursors.Hand;
            btnVerificateData.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificateData.ForeColor = SystemColors.Control;
            btnVerificateData.Location = new Point(175, 204);
            btnVerificateData.Name = "btnVerificateData";
            btnVerificateData.Size = new Size(309, 53);
            btnVerificateData.TabIndex = 11;
            btnVerificateData.Text = "Verificar datos";
            btnVerificateData.UseVisualStyleBackColor = false;
            btnVerificateData.Click += btnVerificateData_Click;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.Hand;
            txtEmail.Font = new Font("Segoe UI Historic", 9F);
            txtEmail.ForeColor = SystemColors.Desktop;
            txtEmail.Location = new Point(165, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo electrónico";
            txtEmail.Size = new Size(343, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtUser
            // 
            txtUser.Cursor = Cursors.Hand;
            txtUser.Font = new Font("Segoe UI Historic", 9F);
            txtUser.ForeColor = SystemColors.Desktop;
            txtUser.Location = new Point(165, 87);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Nombre de usuario";
            txtUser.Size = new Size(343, 27);
            txtUser.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F);
            label2.Location = new Point(369, 287);
            label2.Name = "label2";
            label2.Size = new Size(470, 28);
            label2.TabIndex = 15;
            label2.Text = "Ingresa tu nombre de usuario y tu correo electrónico";
            label2.Click += label2_Click;
            // 
            // pictureBox21
            // 
            pictureBox21.Anchor = AnchorStyles.None;
            pictureBox21.Image = Properties.Resources.logo_final;
            pictureBox21.Location = new Point(477, 116);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(215, 132);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 25;
            pictureBox21.TabStop = false;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1162, 110);
            panel4.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 766);
            panel2.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(912, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 766);
            panel3.TabIndex = 31;
            // 
            // frmResetearContraseña
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(pictureBox21);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResetearContraseña";
            WindowState = FormWindowState.Maximized;
            Load += ResetPasswordView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnVerificateData;
        private TextBox txtEmail;
        private TextBox txtUser;
        private Label label2;
        private PictureBox pictureBox21;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
    }
}