namespace View
{
    partial class frmPuntosRegistrados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            wv2Map = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel10 = new Panel();
            label4 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtIdPoints = new TextBox();
            txtTypeSite = new TextBox();
            txtLatitude = new TextBox();
            txtLength = new TextBox();
            txtNeighborhood = new TextBox();
            rchtxtAdreess = new RichTextBox();
            btnUpdate = new Button();
            button1 = new Button();
            btnDelete = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)wv2Map).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // wv2Map
            // 
            wv2Map.AllowExternalDrop = true;
            wv2Map.CreationProperties = null;
            wv2Map.DefaultBackgroundColor = Color.White;
            wv2Map.Dock = DockStyle.Fill;
            wv2Map.Location = new Point(584, 13);
            wv2Map.Name = "wv2Map";
            wv2Map.Size = new Size(575, 484);
            wv2Map.TabIndex = 0;
            wv2Map.ZoomFactor = 1D;
            wv2Map.Click += wv2Map_Click;
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
            label4.Size = new Size(460, 41);
            label4.TabIndex = 49;
            label4.Text = "Gestión de puntos ambientales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(652, 28);
            label6.TabIndex = 50;
            label6.Text = "Conoce y gestiona la información de los puntos ambientales en el sistema";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(235, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(924, 270);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.2F);
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 37;
            label1.Text = "Id punto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10.2F);
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 38;
            label2.Text = "Tipo de Sitio";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 10.2F);
            label3.Location = new Point(14, 154);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 39;
            label3.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 10.2F);
            label5.Location = new Point(14, 250);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 40;
            label5.Text = "Latitud";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 10.2F);
            label7.Location = new Point(14, 327);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 41;
            label7.Text = "Longitud";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 10.2F);
            label8.Location = new Point(14, 404);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 42;
            label8.Text = "Barrio";
            // 
            // txtIdPoints
            // 
            txtIdPoints.Dock = DockStyle.Fill;
            txtIdPoints.Font = new Font("Segoe UI Historic", 10.2F);
            txtIdPoints.Location = new Point(157, 3);
            txtIdPoints.Name = "txtIdPoints";
            txtIdPoints.ReadOnly = true;
            txtIdPoints.Size = new Size(396, 30);
            txtIdPoints.TabIndex = 43;
            // 
            // txtTypeSite
            // 
            txtTypeSite.Dock = DockStyle.Fill;
            txtTypeSite.Font = new Font("Segoe UI Historic", 10.2F);
            txtTypeSite.Location = new Point(157, 80);
            txtTypeSite.Name = "txtTypeSite";
            txtTypeSite.ReadOnly = true;
            txtTypeSite.Size = new Size(396, 30);
            txtTypeSite.TabIndex = 44;
            // 
            // txtLatitude
            // 
            txtLatitude.Dock = DockStyle.Fill;
            txtLatitude.Font = new Font("Segoe UI Historic", 10.2F);
            txtLatitude.Location = new Point(157, 253);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(396, 30);
            txtLatitude.TabIndex = 46;
            // 
            // txtLength
            // 
            txtLength.Dock = DockStyle.Fill;
            txtLength.Font = new Font("Segoe UI Historic", 10.2F);
            txtLength.Location = new Point(157, 330);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(396, 30);
            txtLength.TabIndex = 47;
            // 
            // txtNeighborhood
            // 
            txtNeighborhood.Dock = DockStyle.Fill;
            txtNeighborhood.Font = new Font("Segoe UI Historic", 10.2F);
            txtNeighborhood.Location = new Point(157, 407);
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.ReadOnly = true;
            txtNeighborhood.Size = new Size(396, 30);
            txtNeighborhood.TabIndex = 48;
            // 
            // rchtxtAdreess
            // 
            rchtxtAdreess.Dock = DockStyle.Fill;
            rchtxtAdreess.Font = new Font("Segoe UI Historic", 10.2F);
            rchtxtAdreess.Location = new Point(157, 157);
            rchtxtAdreess.Name = "rchtxtAdreess";
            rchtxtAdreess.Size = new Size(396, 71);
            rchtxtAdreess.TabIndex = 49;
            rchtxtAdreess.Text = "";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(69, 93, 51);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(246, 246, 247);
            btnUpdate.Location = new Point(34, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 48);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(96, 111, 82);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(246, 246, 247);
            button1.Location = new Point(34, 85);
            button1.Name = "button1";
            button1.Size = new Size(165, 48);
            button1.TabIndex = 54;
            button1.Text = "Limpiar campos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.FromArgb(138, 107, 102);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(246, 246, 247);
            btnDelete.Location = new Point(34, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 48);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "Eliminar registro";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(wv2Map, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1162, 511);
            tableLayoutPanel1.TabIndex = 56;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            tableLayoutPanel2.Controls.Add(txtIdPoints, 2, 0);
            tableLayoutPanel2.Controls.Add(txtTypeSite, 2, 1);
            tableLayoutPanel2.Controls.Add(label2, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(rchtxtAdreess, 2, 2);
            tableLayoutPanel2.Controls.Add(label3, 1, 2);
            tableLayoutPanel2.Controls.Add(label8, 1, 6);
            tableLayoutPanel2.Controls.Add(txtNeighborhood, 2, 6);
            tableLayoutPanel2.Controls.Add(txtLength, 2, 5);
            tableLayoutPanel2.Controls.Add(label7, 1, 5);
            tableLayoutPanel2.Controls.Add(label5, 1, 4);
            tableLayoutPanel2.Controls.Add(txtLatitude, 2, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 13);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.Size = new Size(575, 484);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 600);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1162, 276);
            tableLayoutPanel3.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 270);
            panel1.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 853);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 23);
            panel2.TabIndex = 58;
            panel2.Paint += panel2_Paint;
            // 
            // frmPuntosRegistrados
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPuntosRegistrados";
            Text = "PointsRegisteredView";
            Load += PointsRegisteredView_Load;
            ((System.ComponentModel.ISupportInitialize)wv2Map).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv2Map;
        private Panel panel10;
        private Label label4;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtIdPoints;
        private TextBox txtTypeSite;
        private TextBox txtLatitude;
        private TextBox txtLength;
        private TextBox txtNeighborhood;
        private RichTextBox rchtxtAdreess;
        private Button btnUpdate;
        private Button button1;
        private Button btnDelete;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Panel panel2;
    }
}