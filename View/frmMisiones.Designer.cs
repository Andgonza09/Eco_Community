namespace View
{
    partial class frmMisiones
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
            panel10 = new Panel();
            label4 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnPrevious = new Button();
            btnNext = new Button();
            labPag = new Label();
            dgListMission = new DataGridView();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListMission).BeginInit();
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
            panel10.TabIndex = 33;
            panel10.Paint += panel10_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(300, 41);
            label4.TabIndex = 49;
            label4.Text = "Listado de Misiones";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(331, 28);
            label6.TabIndex = 50;
            label6.Text = "Tus retos ecológicos comienzan aquí";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgListMission);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 787);
            panel1.TabIndex = 39;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPrevious);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(labPag);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 702);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 85);
            panel2.TabIndex = 39;
            panel2.Paint += panel2_Paint;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.None;
            btnPrevious.BackColor = Color.FromArgb(12, 109, 35);
            btnPrevious.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnPrevious.ForeColor = SystemColors.Control;
            btnPrevious.Location = new Point(398, 28);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(133, 33);
            btnPrevious.TabIndex = 25;
            btnPrevious.Text = "Anterior";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.FromArgb(12, 109, 35);
            btnNext.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnNext.ForeColor = SystemColors.Control;
            btnNext.Location = new Point(668, 28);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(133, 33);
            btnNext.TabIndex = 23;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // labPag
            // 
            labPag.Anchor = AnchorStyles.None;
            labPag.AutoSize = true;
            labPag.Font = new Font("Segoe UI Historic", 12F);
            labPag.Location = new Point(559, 28);
            labPag.Name = "labPag";
            labPag.Size = new Size(71, 28);
            labPag.TabIndex = 24;
            labPag.Text = "Página";
            // 
            // dgListMission
            // 
            dgListMission.BackgroundColor = Color.FromArgb(207, 217, 189);
            dgListMission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListMission.Location = new Point(61, 25);
            dgListMission.Name = "dgListMission";
            dgListMission.RowHeadersWidth = 51;
            dgListMission.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListMission.Size = new Size(1037, 654);
            dgListMission.TabIndex = 38;
            dgListMission.CellContentClick += dgListRequestUser_CellContentClick;
            // 
            // frmMisiones
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(panel1);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMisiones";
            WindowState = FormWindowState.Maximized;
            Load += MissionView_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgListMission).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel10;
        private Label label4;
        private Label label6;
        private Panel panel1;
        private DataGridView dgListMission;
        private Panel panel2;
        private Button btnPrevious;
        private Button btnNext;
        private Label labPag;
    }
}