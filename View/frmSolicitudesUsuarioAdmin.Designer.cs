namespace View
{
    partial class frmSolicitudesUsuarioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudesUsuarioAdmin));
            panel10 = new Panel();
            label4 = new Label();
            label6 = new Label();
            dgListRequest = new DataGridView();
            txtSearchId = new TextBox();
            btnSearchId = new Button();
            button1 = new Button();
            button2 = new Button();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListRequest).BeginInit();
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
            panel10.Paint += panel10_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(332, 41);
            label4.TabIndex = 49;
            label4.Text = "Gestión de solicitudes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(637, 28);
            label6.TabIndex = 50;
            label6.Text = "Revisa y gestiona las solicitudes realizadas por los usuarios en el sistema";
            // 
            // dgListRequest
            // 
            dgListRequest.BackgroundColor = Color.FromArgb(207, 217, 189);
            dgListRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListRequest.Location = new Point(63, 181);
            dgListRequest.Name = "dgListRequest";
            dgListRequest.RowHeadersWidth = 51;
            dgListRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListRequest.Size = new Size(1037, 670);
            dgListRequest.TabIndex = 36;
            dgListRequest.CellContentClick += dgListUser_CellContentClick;
            dgListRequest.CellFormatting += dgListRequest_CellFormatting;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(63, 127);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Ingresa el ID de la solicitud que deseas buscar";
            txtSearchId.Size = new Size(389, 27);
            txtSearchId.TabIndex = 37;
            txtSearchId.TextChanged += txtSearchId_TextChanged;
            // 
            // btnSearchId
            // 
            btnSearchId.FlatAppearance.BorderSize = 0;
            btnSearchId.FlatStyle = FlatStyle.Flat;
            btnSearchId.Image = View.Properties.Resources.Search;
            btnSearchId.Location = new Point(483, 116);
            btnSearchId.Name = "btnSearchId";
            btnSearchId.Size = new Size(48, 48);
            btnSearchId.TabIndex = 38;
            btnSearchId.UseVisualStyleBackColor = true;
            btnSearchId.Click += btnSearchId_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(547, 116);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 39;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(609, 116);
            button2.Name = "button2";
            button2.Size = new Size(48, 48);
            button2.TabIndex = 40;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RequestView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSearchId);
            Controls.Add(txtSearchId);
            Controls.Add(dgListRequest);
            Controls.Add(panel10);
            Name = "RequestView";
            Text = "RequestView";
            Load += RequestView_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgListRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel10;
        private Label label4;
        private Label label6;
        private DataGridView dgListRequest;
        private TextBox txtSearchId;
        private Button btnSearchId;
        private Button button1;
        private Button button2;
    }
}