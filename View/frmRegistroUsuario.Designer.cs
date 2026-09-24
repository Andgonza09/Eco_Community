namespace View
{
    partial class frmRegistroUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnRegister = new Button();
            checkBox1 = new CheckBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            pictureBox21 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            label1.Location = new Point(450, 249);
            label1.Name = "label1";
            label1.Size = new Size(279, 41);
            label1.TabIndex = 0;
            label1.Text = "Vamos a empezar ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F);
            label2.Location = new Point(506, 290);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 1;
            label2.Text = "Crea tu cuenta";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(7, 80, 51);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(271, 331);
            panel1.Margin = new Padding(16);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(618, 395);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(218, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(200, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Inicia sesión en tu cuenta";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(239, 331);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 16;
            label3.Text = "¿Ya tienes cuenta?";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(522, 155);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(97, 155);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(97, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(57, 115, 92);
            btnRegister.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(161, 261);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(309, 53);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Registrarte";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Historic", 9F);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(97, 218);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(407, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Acepto los términos de privacidad y protección de datos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Historic", 9F);
            txtPassword.ForeColor = SystemColors.Desktop;
            txtPassword.Location = new Point(155, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(343, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Font = new Font("Segoe UI Historic", 9F);
            txtEmail.ForeColor = SystemColors.Desktop;
            txtEmail.Location = new Point(155, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo electrónico";
            txtEmail.Size = new Size(343, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Historic", 9F);
            txtUsername.ForeColor = SystemColors.Desktop;
            txtUsername.Location = new Point(155, 46);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nombre de usuario";
            txtUsername.Size = new Size(343, 27);
            txtUsername.TabIndex = 7;
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
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1162, 110);
            panel4.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 766);
            panel2.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(912, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 766);
            panel3.TabIndex = 30;
            // 
            // frmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1162, 876);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(pictureBox21);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistroUsuario";
            WindowState = FormWindowState.Maximized;
            Load += RegisterView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnRegister;
        private CheckBox checkBox1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox pictureBox21;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
    }
}
