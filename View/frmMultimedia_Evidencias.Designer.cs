namespace View
{
    partial class frmMultimedia_Evidencias
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel10 = new Panel();
            label4 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(62, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            tableLayoutPanel1.Size = new Size(1100, 787);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15, 0, 0, 0);
            flowLayoutPanel1.Size = new Size(1094, 766);
            flowLayoutPanel1.TabIndex = 43;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 787);
            panel1.TabIndex = 47;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(7, 80, 51);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(label6);
            panel10.Dock = DockStyle.Top;
            panel10.ForeColor = SystemColors.Control;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1162, 89);
            panel10.TabIndex = 46;
            panel10.Paint += panel10_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(333, 41);
            label4.TabIndex = 49;
            label4.Text = "Evidencias Multimedia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(716, 28);
            label6.TabIndex = 50;
            label6.Text = "Revisa y gestiona las evidencias asociadas a las solicitudes enviadas en el sistema ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1100, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(62, 787);
            panel2.TabIndex = 48;
       
            // 
            // frmMultimedia_Evidencias
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1162, 876);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMultimedia_Evidencias";
            Text = "frmMultimedia_Evidencias";
            WindowState = FormWindowState.Maximized;
            Load += frmMultimedia_Evidencias_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel10;
        private Label label4;
        private Label label6;
        private Panel panel2;
    }
}