namespace View
{
    partial class frmArchivoCriterios
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
            panel10 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnAttachFile = new Button();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 22);
            panel1.TabIndex = 31;
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 22);
            panel10.Name = "panel10";
            panel10.Size = new Size(1162, 89);
            panel10.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label2.Location = new Point(43, 9);
            label2.Name = "label2";
            label2.Size = new Size(272, 41);
            label2.TabIndex = 49;
            label2.Text = "Guia de ubicación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F);
            label4.Location = new Point(43, 50);
            label4.Name = "label4";
            label4.Size = new Size(746, 28);
            label4.TabIndex = 50;
            label4.Text = "Consulta el documento con los criterios necesarios para evaluar la ubicación del sitio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(207, 217, 189);
            panel2.Controls.Add(btnAttachFile);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 765);
            panel2.TabIndex = 33;
            panel2.Paint += panel2_Paint;
            // 
            // btnAttachFile
            // 
            btnAttachFile.Anchor = AnchorStyles.None;
            btnAttachFile.BackColor = Color.FromArgb(69, 93, 51);
            btnAttachFile.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnAttachFile.ForeColor = Color.FromArgb(246, 246, 247);
            btnAttachFile.Image = Properties.Resources.document__2_;
            btnAttachFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttachFile.Location = new Point(471, 487);
            btnAttachFile.Name = "btnAttachFile";
            btnAttachFile.Size = new Size(224, 44);
            btnAttachFile.TabIndex = 5;
            btnAttachFile.Text = "Ver PDF";
            btnAttachFile.UseVisualStyleBackColor = false;
            btnAttachFile.Click += btnAttachFile_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 372);
            label1.Name = "label1";
            label1.Size = new Size(347, 25);
            label1.TabIndex = 1;
            label1.Text = "Documentos de criterios de ubicación";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(397, 396);
            label3.Name = "label3";
            label3.Size = new Size(368, 76);
            label3.TabIndex = 2;
            label3.Text = "Accede al documento que contiene los criterios necesarios para evaluar la ubicación del sitio.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.pdfImage;
            pictureBox1.Location = new Point(448, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(212, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(738, 43);
            panel3.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(950, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 765);
            panel4.TabIndex = 35;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 765);
            panel5.TabIndex = 36;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(212, 751);
            panel6.Name = "panel6";
            panel6.Size = new Size(738, 125);
            panel6.TabIndex = 37;
            panel6.Paint += panel6_Paint;
            // 
            // frmArchivoCriterios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Name = "frmArchivoCriterios";
            Text = "GuideLocationView";
            Load += GuideLocationView_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel10;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Button btnAttachFile;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}