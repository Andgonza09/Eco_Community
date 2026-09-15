namespace View
{
    partial class frmCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContraseña));
            label1 = new Label();
            pictureBox21 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            btnVerificateData = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 253);
            label1.Name = "label1";
            label1.Size = new Size(304, 41);
            label1.TabIndex = 15;
            label1.Text = "Cambiar Contraseña";
            // 
            // pictureBox21
            // 
            pictureBox21.Anchor = AnchorStyles.None;
            pictureBox21.Image = View.Properties.Resources.logo_final;
            pictureBox21.Location = new Point(477, 116);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(215, 132);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 23;
            pictureBox21.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(179, 194, 148);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnVerificateData);
            panel1.Location = new Point(271, 312);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 395);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label3.Location = new Point(140, 166);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 22;
            label3.Text = "Confirma tu contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label2.Location = new Point(140, 73);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 21;
            label2.Text = "Nueva contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(507, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(507, 101);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(82, 183);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            linkLabel1.Location = new Point(251, 314);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cancelar cambio";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Historic", 9F);
            textBox1.ForeColor = SystemColors.Desktop;
            textBox1.Location = new Point(140, 189);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Contraseña";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(82, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.Desktop;
            txtPassword.Location = new Point(140, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(343, 27);
            txtPassword.TabIndex = 18;
            // 
            // btnVerificateData
            // 
            btnVerificateData.BackColor = Color.FromArgb(69, 93, 51);
            btnVerificateData.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnVerificateData.ForeColor = SystemColors.Control;
            btnVerificateData.Location = new Point(162, 250);
            btnVerificateData.Name = "btnVerificateData";
            btnVerificateData.Size = new Size(309, 53);
            btnVerificateData.TabIndex = 11;
            btnVerificateData.Text = "Cambiar Contraseña";
            btnVerificateData.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 766);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(912, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 766);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1162, 110);
            panel4.TabIndex = 26;
            // 
            // ChangePasswordView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(pictureBox21);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordView";
            WindowState = FormWindowState.Maximized;
            Load += ChangePasswordView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox21;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
        private Button btnVerificateData;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}