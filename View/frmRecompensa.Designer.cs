namespace View
{
    partial class frmRecompensa
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel10.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            panel10.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label4.Location = new Point(43, 9);
            label4.Name = "label4";
            label4.Size = new Size(213, 41);
            label4.TabIndex = 49;
            label4.Text = "Recompensas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 50);
            label6.Name = "label6";
            label6.Size = new Size(488, 28);
            label6.TabIndex = 50;
            label6.Text = "Visualiza las recompensas por tus méritos en el sistema";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(28, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            tableLayoutPanel1.Size = new Size(1106, 787);
            tableLayoutPanel1.TabIndex = 55;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(1100, 766);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1134, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(28, 787);
            panel2.TabIndex = 54;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(28, 787);
            panel1.TabIndex = 56;
            // 
            // frmRecompensa
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1162, 876);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRecompensa";
            Text = "frmRecompensa";
            WindowState = FormWindowState.Maximized;
            Load += frmRecompensa_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Label label4;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}