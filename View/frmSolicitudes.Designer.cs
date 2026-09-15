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
        dgListRequestUser = new DataGridView();
        button2 = new Button();
        panel10.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgListRequestUser).BeginInit();
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
        // dgListRequestUser
        // 
        dgListRequestUser.BackgroundColor = Color.FromArgb(207, 217, 189);
        dgListRequestUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgListRequestUser.Location = new Point(77, 123);
        dgListRequestUser.Name = "dgListRequestUser";
        dgListRequestUser.RowHeadersWidth = 51;
        dgListRequestUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgListRequestUser.Size = new Size(1053, 670);
        dgListRequestUser.TabIndex = 37;
        dgListRequestUser.CellContentClick += dgListRequest_CellContentClick;
        // 
        // button2
        // 
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Image = (Image)resources.GetObject("button2.Image");
        button2.Location = new Point(12, 123);
        button2.Name = "button2";
        button2.Size = new Size(48, 48);
        button2.TabIndex = 41;
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // frmSolicitudes
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(227, 235, 216);
        ClientSize = new Size(1162, 876);
        Controls.Add(button2);
        Controls.Add(dgListRequestUser);
        Controls.Add(panel10);
        Name = "frmSolicitudes";
        Text = "RequestUserView";
        Load += RequestUserView_Load;
        panel10.ResumeLayout(false);
        panel10.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgListRequestUser).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel10;
        private Label label4;
        private Label label6;
        private DataGridView dgListRequestUser;
        private Button button2;
    }
}