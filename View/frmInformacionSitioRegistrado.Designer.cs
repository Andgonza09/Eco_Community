namespace View
{
    partial class frmInformacionSitioRegistrado
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
            wv2Map = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wv2Map).BeginInit();
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
            label4.Location = new Point(43, 10);
            label4.Name = "label4";
            label4.Size = new Size(464, 41);
            label4.TabIndex = 49;
            label4.Text = "Puntos ambientales registrados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 12F);
            label6.Location = new Point(43, 51);
            label6.Name = "label6";
            label6.Size = new Size(540, 28);
            label6.TabIndex = 50;
            label6.Text = "Conoce todos los puntos ambientales ubicados en el sistema";
            // 
            // wv2Map
            // 
            wv2Map.AllowExternalDrop = true;
            wv2Map.CreationProperties = null;
            wv2Map.DefaultBackgroundColor = Color.White;
            wv2Map.Dock = DockStyle.Fill;
            wv2Map.Location = new Point(0, 89);
            wv2Map.Name = "wv2Map";
            wv2Map.Size = new Size(1162, 787);
            wv2Map.TabIndex = 37;
            wv2Map.ZoomFactor = 1D;
            wv2Map.Click += webView21_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 19);
            panel1.TabIndex = 38;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1112, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 768);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 768);
            panel3.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(50, 860);
            panel4.Name = "panel4";
            panel4.Size = new Size(1062, 16);
            panel4.TabIndex = 41;
            panel4.Paint += panel4_Paint;
            // 
            // frmInformacionSitioRegistrado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(wv2Map);
            Controls.Add(panel10);
            Name = "frmInformacionSitioRegistrado";
            Text = "UserPointsRegisters";
            Load += UserPointsRegisters_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wv2Map).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Label label4;
        private Label label6;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv2Map;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}