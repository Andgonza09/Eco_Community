namespace View
{
    partial class frmGestiónUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiónUsuarios));
            txtSearchId = new TextBox();
            dgListUser = new DataGridView();
            btnSearchId = new Button();
            panel10 = new Panel();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListUser).BeginInit();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(63, 127);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Ingresa el ID del usuario que deseas buscar";
            txtSearchId.Size = new Size(389, 27);
            txtSearchId.TabIndex = 0;
            txtSearchId.TextChanged += textBox1_TextChanged;
            // 
            // dgListUser
            // 
            dgListUser.BackgroundColor = Color.FromArgb(207, 217, 189);
            dgListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListUser.Location = new Point(63, 181);
            dgListUser.Name = "dgListUser";
            dgListUser.RowHeadersWidth = 51;
            dgListUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListUser.Size = new Size(1037, 670);
            dgListUser.TabIndex = 1;
            dgListUser.CellContentClick += dataGridView1_CellContentClick;
            dgListUser.SelectionChanged += dgListUser_SelectionChanged;
            // 
            // btnSearchId
            // 
            btnSearchId.FlatAppearance.BorderSize = 0;
            btnSearchId.FlatStyle = FlatStyle.Flat;
            btnSearchId.Image = Properties.Resources.Search;
            btnSearchId.Location = new Point(483, 116);
            btnSearchId.Name = "btnSearchId";
            btnSearchId.Size = new Size(48, 48);
            btnSearchId.TabIndex = 2;
            btnSearchId.UseVisualStyleBackColor = true;
            btnSearchId.Click += btnSearchId_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label4);
            panel10.Controls.Add(label6);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1180, 89);
            panel10.TabIndex = 34;
            panel10.Paint += panel10_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(299, 41);
            label4.TabIndex = 49;
            label4.Text = "Gestión de usuarios";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(634, 28);
            label6.TabIndex = 50;
            label6.Text = "Conoce y gestiona la información ingresada por el usuario en el sistema";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(547, 116);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 35;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmGestiónUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1180, 923);
            Controls.Add(button1);
            Controls.Add(panel10);
            Controls.Add(btnSearchId);
            Controls.Add(dgListUser);
            Controls.Add(txtSearchId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGestiónUsuarios";
            Text = "ManageUserView";
            Load += ManageUserView_Load;
            ((System.ComponentModel.ISupportInitialize)dgListUser).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchId;
        private DataGridView dgListUser;
        private Button btnSearchId;
        private Panel panel10;
        private Label label4;
        private Label label6;
        private Button button1;
    }
}