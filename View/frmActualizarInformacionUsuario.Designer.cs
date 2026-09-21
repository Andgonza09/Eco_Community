namespace View
{
    partial class frmActualizarInformacionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarInformacionUsuario));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dtpRegisterDate = new DateTimePicker();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 146, 82);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 62);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(660, 7);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(245, 245, 251);
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(214, 23);
            label1.TabIndex = 0;
            label1.Text = "Información del usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpRegisterDate);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(56, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 376);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label5.Location = new Point(76, 294);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 8;
            label5.Text = "Fecha de registro";
            // 
            // dtpRegisterDate
            // 
            dtpRegisterDate.Font = new Font("Segoe UI Historic", 9F);
            dtpRegisterDate.Location = new Point(255, 294);
            dtpRegisterDate.Name = "dtpRegisterDate";
            dtpRegisterDate.Size = new Size(322, 27);
            dtpRegisterDate.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Historic", 9F);
            txtPassword.Location = new Point(255, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(322, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Historic", 9F);
            txtEmail.Location = new Point(255, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Historic", 9F);
            txtUsername.Location = new Point(255, 72);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(322, 27);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label4.Location = new Point(76, 214);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 2;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label3.Location = new Point(76, 142);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 1;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label2.Location = new Point(76, 72);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre del usuario";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(671, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 516);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 516);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(267, 484);
            button2.Name = "button2";
            button2.Size = new Size(189, 50);
            button2.TabIndex = 4;
            button2.Text = "Actualizar datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmActualizarInformacionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(726, 578);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmActualizarInformacionUsuario";
            Text = "UpdateInformationView";
            Load += UpdateInformationView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private DateTimePicker dtpRegisterDate;
        private Button button2;
    }
}