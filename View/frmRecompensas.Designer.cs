namespace View
{
    partial class frmRecompensas
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
            btnNext = new Button();
            labPag = new Label();
            btnPrevious = new Button();
            panel10 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            dgListReward = new DataGridView();
            panel2 = new Panel();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListReward).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = Color.FromArgb(12, 109, 35);
            btnNext.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnNext.ForeColor = SystemColors.Control;
            btnNext.Location = new Point(669, 42);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(133, 33);
            btnNext.TabIndex = 23;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // labPag
            // 
            labPag.Anchor = AnchorStyles.None;
            labPag.AutoSize = true;
            labPag.Font = new Font("Segoe UI Historic", 12F);
            labPag.Location = new Point(560, 42);
            labPag.Name = "labPag";
            labPag.Size = new Size(71, 28);
            labPag.TabIndex = 24;
            labPag.Text = "Página";
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.None;
            btnPrevious.BackColor = Color.FromArgb(12, 109, 35);
            btnPrevious.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnPrevious.ForeColor = SystemColors.Control;
            btnPrevious.Location = new Point(399, 42);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(133, 33);
            btnPrevious.TabIndex = 25;
            btnPrevious.Text = "Anterior";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1162, 89);
            panel10.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label2.Location = new Point(43, 9);
            label2.Name = "label2";
            label2.Size = new Size(372, 41);
            label2.TabIndex = 49;
            label2.Text = "Recompensas ecológicas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F);
            label4.Location = new Point(43, 50);
            label4.Name = "label4";
            label4.Size = new Size(590, 28);
            label4.TabIndex = 50;
            label4.Text = "Conoce las recompensas disponibles por tu progreso en el sistema";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgListReward);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 787);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
            // 
            // dgListReward
            // 
            dgListReward.BackgroundColor = Color.FromArgb(207, 217, 189);
            dgListReward.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListReward.Location = new Point(65, 31);
            dgListReward.Name = "dgListReward";
            dgListReward.RowHeadersWidth = 51;
            dgListReward.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListReward.Size = new Size(1037, 670);
            dgListReward.TabIndex = 38;
            dgListReward.CellContentClick += dgListRequestUser_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPrevious);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(labPag);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 751);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 125);
            panel2.TabIndex = 31;
            panel2.Paint += panel2_Paint;
            // 
            // frmRecompensas
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRecompensas";
            WindowState = FormWindowState.Maximized;
            Load += RewardView_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgListReward).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNext;
        private Label labPag;
        private Button btnPrevious;
        private Panel panel10;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgListReward;
    }
}