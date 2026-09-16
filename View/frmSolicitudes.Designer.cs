namespace View 
{ 
    partial class frmSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudes));
            panel10 = new Panel();
            label4 = new Label();
            label6 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.Controls.Add(label4);
            panel10.Controls.Add(label6);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1162, 89);
            panel10.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(181, 41);
            label4.TabIndex = 49;
            label4.Text = "Solicitudes ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(406, 28);
            label6.TabIndex = 50;
            label6.Text = "Revisa y gestiona tus solicitudes en el sistema";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(34, 29);
            button2.Name = "button2";
            button2.Size = new Size(48, 48);
            button2.TabIndex = 41;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 787);
            panel1.TabIndex = 42;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(116, 89);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1046, 787);
            flowLayoutPanel1.TabIndex = 43;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // frmSolicitudes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel10);
            Name = "frmSolicitudes";
            Text = "RequestUserView";
            Load += RequestUserView_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Label label4;
        private Label label6;
        private Button button2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}