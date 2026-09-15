namespace View
{
    partial class frmMisionesRecompensasRegistro
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
            panel1 = new Panel();
            label5 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel9 = new Panel();
            btnSaveData = new Button();
            btnCancelData = new Button();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel10 = new Panel();
            label11 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            richtxtMissionDescription = new RichTextBox();
            label1 = new Label();
            label7 = new Label();
            panelLine = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label10 = new Label();
            nudPointMission = new NumericUpDown();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label12 = new Label();
            richtxtRewardDescription = new RichTextBox();
            label13 = new Label();
            panel12 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label15 = new Label();
            label14 = new Label();
            cmbTypeReward = new ComboBox();
            panel11 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPointMission).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 89);
            panel1.TabIndex = 55;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label5.Location = new Point(43, 9);
            label5.Name = "label5";
            label5.Size = new Size(403, 41);
            label5.TabIndex = 49;
            label5.Text = "Crear misión y recompensa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 12F);
            label9.Location = new Point(43, 50);
            label9.Name = "label9";
            label9.Size = new Size(867, 28);
            label9.TabIndex = 50;
            label9.Text = "Define una nueva misión y su recompensa asociada para motivar la participación de la comunidad.";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1114, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(48, 787);
            panel3.TabIndex = 57;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(48, 787);
            panel2.TabIndex = 58;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(48, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(1066, 22);
            panel4.TabIndex = 59;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnSaveData);
            panel9.Controls.Add(btnCancelData);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(48, 793);
            panel9.Name = "panel9";
            panel9.Size = new Size(1066, 59);
            panel9.TabIndex = 61;
            panel9.Paint += panel9_Paint;
            // 
            // btnSaveData
            // 
            btnSaveData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveData.BackColor = Color.FromArgb(69, 93, 51);
            btnSaveData.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnSaveData.ForeColor = SystemColors.Control;
            btnSaveData.Image = Properties.Resources.Confirm;
            btnSaveData.Location = new Point(850, 6);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(207, 47);
            btnSaveData.TabIndex = 26;
            btnSaveData.Text = "Guardar";
            btnSaveData.TextAlign = ContentAlignment.MiddleRight;
            btnSaveData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveData.UseVisualStyleBackColor = false;
            btnSaveData.Click += btnSaveData_Click;
            // 
            // btnCancelData
            // 
            btnCancelData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelData.BackColor = Color.FromArgb(138, 107, 102);
            btnCancelData.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnCancelData.ForeColor = SystemColors.Control;
            btnCancelData.Image = Properties.Resources.cancel;
            btnCancelData.Location = new Point(639, 6);
            btnCancelData.Name = "btnCancelData";
            btnCancelData.Size = new Size(207, 47);
            btnCancelData.TabIndex = 25;
            btnCancelData.Text = "Cancelar";
            btnCancelData.TextAlign = ContentAlignment.MiddleRight;
            btnCancelData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelData.UseVisualStyleBackColor = false;
            btnCancelData.Click += btnCancelData_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(48, 852);
            panel5.Name = "panel5";
            panel5.Size = new Size(1066, 24);
            panel5.TabIndex = 60;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel10, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(48, 111);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1066, 249);
            tableLayoutPanel1.TabIndex = 62;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(234, 237, 225);
            panel10.Controls.Add(label11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(1060, 43);
            panel10.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(41, 12);
            label11.Name = "label11";
            label11.Size = new Size(223, 23);
            label11.TabIndex = 0;
            label11.Text = "Información de la misión";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(179, 194, 148);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panelLine, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 52);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel2.Size = new Size(1060, 194);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(179, 194, 148);
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Controls.Add(richtxtMissionDescription, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label7, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 59F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel3.Size = new Size(1054, 89);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // richtxtMissionDescription
            // 
            richtxtMissionDescription.Dock = DockStyle.Fill;
            richtxtMissionDescription.Location = new Point(213, 3);
            richtxtMissionDescription.Name = "richtxtMissionDescription";
            richtxtMissionDescription.Size = new Size(838, 46);
            richtxtMissionDescription.TabIndex = 3;
            richtxtMissionDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 2;
            label1.Text = "Descripción de la misión";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(213, 52);
            label7.Name = "label7";
            label7.Size = new Size(457, 23);
            label7.TabIndex = 4;
            label7.Text = "Describe claramente la acción que debe realizar el usuario.";
            // 
            // panelLine
            // 
            panelLine.BackColor = Color.FromArgb(225, 225, 225);
            panelLine.BorderStyle = BorderStyle.FixedSingle;
            panelLine.Dock = DockStyle.Fill;
            panelLine.Location = new Point(3, 98);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(1054, 1);
            panelLine.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(179, 194, 148);
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Controls.Add(label4, 0, 1);
            tableLayoutPanel4.Controls.Add(label10, 1, 2);
            tableLayoutPanel4.Controls.Add(nudPointMission, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 101);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            tableLayoutPanel4.Size = new Size(1054, 90);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 4;
            label4.Text = "Puntaje de la misión";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(213, 55);
            label10.Name = "label10";
            label10.Size = new Size(473, 23);
            label10.TabIndex = 6;
            label10.Text = "Cantidad de puntos que otorgará esta misión al completarse";
            // 
            // nudPointMission
            // 
            nudPointMission.Location = new Point(213, 6);
            nudPointMission.Name = "nudPointMission";
            nudPointMission.Size = new Size(207, 27);
            nudPointMission.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Controls.Add(panel11, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(48, 360);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1066, 433);
            tableLayoutPanel5.TabIndex = 63;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.FromArgb(179, 194, 148);
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(panel12, 0, 1);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 67);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3167572F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 1.36648512F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3167572F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(1060, 363);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.FromArgb(179, 194, 148);
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel7.Controls.Add(label12, 0, 0);
            tableLayoutPanel7.Controls.Add(richtxtRewardDescription, 1, 0);
            tableLayoutPanel7.Controls.Add(label13, 1, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 59F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel7.Size = new Size(1054, 173);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(146, 40);
            label12.TabIndex = 5;
            label12.Text = "Descripción de la recompensa";
            // 
            // richtxtRewardDescription
            // 
            richtxtRewardDescription.Dock = DockStyle.Fill;
            richtxtRewardDescription.Location = new Point(213, 3);
            richtxtRewardDescription.Name = "richtxtRewardDescription";
            richtxtRewardDescription.Size = new Size(838, 96);
            richtxtRewardDescription.TabIndex = 3;
            richtxtRewardDescription.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(213, 102);
            label13.Name = "label13";
            label13.Size = new Size(579, 23);
            label13.TabIndex = 6;
            label13.Text = "Describe claramente en qué consiste la recompensa que recibirá el usuario";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(225, 225, 225);
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Location = new Point(3, 182);
            panel12.Name = "panel12";
            panel12.Size = new Size(814, 1);
            panel12.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.FromArgb(179, 194, 148);
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel8.Controls.Add(label15, 1, 2);
            tableLayoutPanel8.Controls.Add(label14, 0, 1);
            tableLayoutPanel8.Controls.Add(cmbTypeReward, 1, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 186);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            tableLayoutPanel8.Size = new Size(1054, 174);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(213, 72);
            label15.Name = "label15";
            label15.Size = new Size(543, 23);
            label15.TabIndex = 9;
            label15.Text = "Selecciona un tipo de recompensa previamente definido en el sistema";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(163, 20);
            label14.TabIndex = 8;
            label14.Text = "Tipo de recompensa";
            // 
            // cmbTypeReward
            // 
            cmbTypeReward.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTypeReward.FormattingEnabled = true;
            cmbTypeReward.Items.AddRange(new object[] { "Insignia", "Subida de nivel", "Logros", "Puntos adicionales" });
            cmbTypeReward.Location = new Point(213, 6);
            cmbTypeReward.Name = "cmbTypeReward";
            cmbTypeReward.Size = new Size(300, 28);
            cmbTypeReward.TabIndex = 8;
            cmbTypeReward.Text = "  Selecciona un tipo de recompensa";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(234, 237, 225);
            panel11.Controls.Add(label3);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(1060, 58);
            panel11.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 18);
            label3.Name = "label3";
            label3.Size = new Size(270, 23);
            label3.TabIndex = 0;
            label3.Text = "Información de la recompensa";
            // 
            // frmMisionesRecompensasRegistro
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMisionesRecompensasRegistro";
            Text = "GamificationView";
            WindowState = FormWindowState.Maximized;
            Load += GamificationView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPointMission).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label5;
        private Label label9;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel9;
        private Button btnCancelData;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private RichTextBox richtxtMissionDescription;
        private Label label7;
        private Panel panelLine;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private NumericUpDown nudPointMission;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel11;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label12;
        private RichTextBox richtxtRewardDescription;
        private Label label13;
        private Panel panel12;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label15;
        private ComboBox cmbTypeReward;
        private Label label14;
        private Button btnSaveData;
    }
}