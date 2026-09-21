namespace View
{
    partial class frmMisionesRegistradas
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
            dgListMission = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            rchtxtMissionDescription = new RichTextBox();
            txtIdMission = new TextBox();
            txtPointsMission = new TextBox();
            label7 = new Label();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtSearchId = new TextBox();
            btnSearchId = new Button();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgListMission).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
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
            panel10.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(309, 41);
            label4.TabIndex = 49;
            label4.Text = "Misiones registradas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(373, 28);
            label6.TabIndex = 50;
            label6.Text = "Revisa y gestiona las misiones del sistema";
            // 
            // dgListMission
            // 
            dgListMission.BackgroundColor = Color.FromArgb(207, 217, 189);
            dgListMission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListMission.Dock = DockStyle.Fill;
            dgListMission.Location = new Point(3, 122);
            dgListMission.Name = "dgListMission";
            dgListMission.ReadOnly = true;
            dgListMission.RowHeadersWidth = 51;
            dgListMission.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListMission.Size = new Size(613, 576);
            dgListMission.TabIndex = 37;
            dgListMission.CellClick += dgListMission_CellClick;
            dgListMission.CellContentClick += dgListMission_CellContentClick;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1119, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(43, 787);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(43, 787);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(43, 846);
            panel3.Name = "panel3";
            panel3.Size = new Size(1076, 30);
            panel3.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(43, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(1076, 30);
            panel4.TabIndex = 50;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(43, 119);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1076, 727);
            tableLayoutPanel1.TabIndex = 51;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Size = new Size(424, 701);
            tableLayoutPanel4.TabIndex = 53;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(rchtxtMissionDescription, 2, 1);
            tableLayoutPanel2.Controls.Add(txtIdMission, 2, 0);
            tableLayoutPanel2.Controls.Add(txtPointsMission, 2, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel2.Size = new Size(418, 344);
            tableLayoutPanel2.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            label5.Location = new Point(3, 110);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 47;
            label5.Text = "Descripción";
            // 
            // rchtxtMissionDescription
            // 
            rchtxtMissionDescription.Dock = DockStyle.Fill;
            rchtxtMissionDescription.Font = new Font("Segoe UI Historic", 10.2F);
            rchtxtMissionDescription.Location = new Point(132, 113);
            rchtxtMissionDescription.Name = "rchtxtMissionDescription";
            rchtxtMissionDescription.Size = new Size(274, 104);
            rchtxtMissionDescription.TabIndex = 43;
            rchtxtMissionDescription.Text = "";
            // 
            // txtIdMission
            // 
            txtIdMission.Dock = DockStyle.Fill;
            txtIdMission.Font = new Font("Segoe UI Historic", 10.2F);
            txtIdMission.Location = new Point(132, 3);
            txtIdMission.Name = "txtIdMission";
            txtIdMission.Size = new Size(274, 30);
            txtIdMission.TabIndex = 40;
            // 
            // txtPointsMission
            // 
            txtPointsMission.Anchor = AnchorStyles.Left;
            txtPointsMission.Font = new Font("Segoe UI Historic", 10.2F);
            txtPointsMission.Location = new Point(132, 273);
            txtPointsMission.Name = "txtPointsMission";
            txtPointsMission.Size = new Size(274, 30);
            txtPointsMission.TabIndex = 42;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            label7.Location = new Point(3, 277);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 48;
            label7.Text = "Puntaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 46;
            label3.Text = "Id Misión";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(button1, 0, 1);
            tableLayoutPanel5.Controls.Add(button2, 0, 3);
            tableLayoutPanel5.Controls.Add(button3, 0, 5);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 423);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 7;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.Size = new Size(418, 275);
            tableLayoutPanel5.TabIndex = 54;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button1.Location = new Point(3, 30);
            button1.Name = "button1";
            button1.Size = new Size(412, 35);
            button1.TabIndex = 0;
            button1.Text = "Actualizar datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button2.Location = new Point(3, 77);
            button2.Name = "button2";
            button2.Size = new Size(412, 35);
            button2.TabIndex = 1;
            button2.Text = "Limpiar Campos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button3.Location = new Point(3, 124);
            button3.Name = "button3";
            button3.Size = new Size(412, 35);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel7.Controls.Add(dgListMission, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(454, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 83F));
            tableLayoutPanel7.Size = new Size(619, 701);
            tableLayoutPanel7.TabIndex = 54;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Controls.Add(txtSearchId, 0, 1);
            tableLayoutPanel6.Controls.Add(btnSearchId, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.Size = new Size(613, 99);
            tableLayoutPanel6.TabIndex = 40;
            // 
            // txtSearchId
            // 
            txtSearchId.Dock = DockStyle.Fill;
            txtSearchId.Location = new Point(3, 22);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Ingresa el id de la misión que deseas buscar";
            txtSearchId.Size = new Size(484, 27);
            txtSearchId.TabIndex = 0;
            txtSearchId.TextChanged += txtSearchId_TextChanged;
            // 
            // btnSearchId
            // 
            btnSearchId.FlatAppearance.BorderSize = 0;
            btnSearchId.FlatStyle = FlatStyle.Flat;
            btnSearchId.Image = Properties.Resources.Search;
            btnSearchId.Location = new Point(493, 22);
            btnSearchId.Name = "btnSearchId";
            btnSearchId.Size = new Size(48, 48);
            btnSearchId.TabIndex = 39;
            btnSearchId.UseVisualStyleBackColor = true;
            btnSearchId.Click += btnSearchId_Click;
            // 
            // frmMisionesRegistradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel10);
            Name = "frmMisionesRegistradas";
            Text = "MissionRegisterView";
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgListMission).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Label label4;
        private Label label6;
        private DataGridView dgListMission;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TextBox txtIdMission;
        private Label label5;
        private RichTextBox rchtxtMissionDescription;
        private TextBox txtPointsMission;
        private Label label7;
        private TextBox txtSearchId;
        private Button btnSearchId;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button3;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
    }
}