namespace View
{
    partial class frmActualizarSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarSolicitud));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txtSiteId = new TextBox();
            cmbStateRequest = new ComboBox();
            label5 = new Label();
            dtpDateRequest = new DateTimePicker();
            txtUserId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            txtIdRequest = new TextBox();
            label7 = new Label();
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
            panel1.Size = new Size(708, 62);
            panel1.TabIndex = 1;
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
            label1.Size = new Size(239, 23);
            label1.TabIndex = 0;
            label1.Text = "Información de la solicitud";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(653, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 611);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 611);
            panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtIdRequest);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSiteId);
            groupBox1.Controls.Add(cmbStateRequest);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpDateRequest);
            groupBox1.Controls.Add(txtUserId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(54, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 488);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la solicitud";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Historic", 9F);
            txtUsername.Location = new Point(250, 269);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(322, 27);
            txtUsername.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label2.Location = new Point(39, 269);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 14;
            label2.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label6.Location = new Point(39, 195);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 13;
            label6.Text = "Id del sitio";
            // 
            // txtSiteId
            // 
            txtSiteId.Font = new Font("Segoe UI Historic", 9F);
            txtSiteId.Location = new Point(250, 195);
            txtSiteId.Name = "txtSiteId";
            txtSiteId.ReadOnly = true;
            txtSiteId.Size = new Size(322, 27);
            txtSiteId.TabIndex = 12;
            // 
            // cmbStateRequest
            // 
            cmbStateRequest.FormattingEnabled = true;
            cmbStateRequest.Items.AddRange(new object[] { "Aprobada ", "Rechazada" });
            cmbStateRequest.Location = new Point(250, 416);
            cmbStateRequest.Name = "cmbStateRequest";
            cmbStateRequest.Size = new Size(322, 28);
            cmbStateRequest.TabIndex = 11;
            cmbStateRequest.Text = "Pendiente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label5.Location = new Point(39, 118);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 10;
            label5.Text = "Id del usuario";
            // 
            // dtpDateRequest
            // 
            dtpDateRequest.Font = new Font("Segoe UI Historic", 9F);
            dtpDateRequest.Location = new Point(250, 334);
            dtpDateRequest.Name = "dtpDateRequest";
            dtpDateRequest.Size = new Size(322, 27);
            dtpDateRequest.TabIndex = 9;
            // 
            // txtUserId
            // 
            txtUserId.Font = new Font("Segoe UI Historic", 9F);
            txtUserId.Location = new Point(250, 118);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(322, 27);
            txtUserId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label4.Location = new Point(39, 416);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 2;
            label4.Text = "Estado de la solicitud";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label3.Location = new Point(39, 334);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 1;
            label3.Text = "Fecha de Solicitud";
            // 
            // button2
            // 
            button2.Location = new Point(210, 585);
            button2.Name = "button2";
            button2.Size = new Size(297, 50);
            button2.TabIndex = 7;
            button2.Text = "Actualizar datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtIdRequest
            // 
            txtIdRequest.Font = new Font("Segoe UI Historic", 9F);
            txtIdRequest.Location = new Point(250, 47);
            txtIdRequest.Name = "txtIdRequest";
            txtIdRequest.ReadOnly = true;
            txtIdRequest.Size = new Size(322, 27);
            txtIdRequest.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label7.Location = new Point(39, 47);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 17;
            label7.Text = "Id Solicitud";
            // 
            // UpdateRequestView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(708, 673);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UpdateRequestView";
            Text = "UpdateRequestView";
            Load += UpdateRequestView_Load;
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
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox txtUserId;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpDateRequest;
        private Label label5;
        private ComboBox cmbStateRequest;
        private Label label6;
        private TextBox txtSiteId;
        private Button button2;
        private TextBox txtUsername;
        private Label label2;
        private Label label7;
        private TextBox txtIdRequest;
    }
}