namespace View
{
    partial class frmSolicitudesCard_Design
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudesCard_Design));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            pbEstado = new PictureBox();
            lbDireccionTitulo = new Label();
            lbTipoSitioTitulo = new Label();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbDireccion = new Label();
            lbTipoSitio = new Label();
            lbEstado = new Label();
            lbNSolicitud = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbFechaSolicitud = new Label();
            label2 = new Label();
            lbFechaResolución = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(81, 133, 112);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(18, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 327);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(81, 133, 112);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 350);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(81, 133, 112);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(18, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 13);
            panel1.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(81, 133, 112);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(18, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(981, 10);
            panel4.TabIndex = 20;
            panel4.Paint += panel4_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(81, 133, 112);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(212, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            tableLayoutPanel1.Size = new Size(787, 327);
            tableLayoutPanel1.TabIndex = 31;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 1);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(81, 133, 112);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(pbEstado);
            panel5.Controls.Add(lbDireccionTitulo);
            panel5.Controls.Add(lbTipoSitioTitulo);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(lbDireccion);
            panel5.Controls.Add(lbTipoSitio);
            panel5.Controls.Add(lbEstado);
            panel5.Controls.Add(lbNSolicitud);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(781, 190);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(656, 9);
            button2.Name = "button2";
            button2.Size = new Size(48, 48);
            button2.TabIndex = 42;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pbEstado
            // 
            pbEstado.Location = new Point(461, 71);
            pbEstado.Name = "pbEstado";
            pbEstado.Size = new Size(156, 31);
            pbEstado.TabIndex = 33;
            pbEstado.TabStop = false;
            pbEstado.Click += pbEstado_Click;
            // 
            // lbDireccionTitulo
            // 
            lbDireccionTitulo.AutoSize = true;
            lbDireccionTitulo.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDireccionTitulo.ForeColor = SystemColors.Control;
            lbDireccionTitulo.Location = new Point(70, 116);
            lbDireccionTitulo.Name = "lbDireccionTitulo";
            lbDireccionTitulo.Size = new Size(72, 20);
            lbDireccionTitulo.TabIndex = 32;
            lbDireccionTitulo.Text = "Dirección";
            // 
            // lbTipoSitioTitulo
            // 
            lbTipoSitioTitulo.AutoSize = true;
            lbTipoSitioTitulo.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTipoSitioTitulo.ForeColor = SystemColors.Control;
            lbTipoSitioTitulo.Location = new Point(70, 43);
            lbTipoSitioTitulo.Name = "lbTipoSitioTitulo";
            lbTipoSitioTitulo.Size = new Size(92, 20);
            lbTipoSitioTitulo.TabIndex = 31;
            lbTipoSitioTitulo.Text = "Tipo de sitio";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.TipoSitioIcon;
            pictureBox5.Location = new Point(28, 67);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ubicacionPro;
            pictureBox2.Location = new Point(28, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Segoe UI Historic", 10.8F);
            lbDireccion.ForeColor = SystemColors.Control;
            lbDireccion.Location = new Point(70, 142);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(85, 25);
            lbDireccion.TabIndex = 28;
            lbDireccion.Text = "Dirección";
            // 
            // lbTipoSitio
            // 
            lbTipoSitio.AutoSize = true;
            lbTipoSitio.Font = new Font("Segoe UI Historic", 10.8F);
            lbTipoSitio.ForeColor = SystemColors.Control;
            lbTipoSitio.Location = new Point(70, 70);
            lbTipoSitio.Name = "lbTipoSitio";
            lbTipoSitio.Size = new Size(110, 25);
            lbTipoSitio.TabIndex = 26;
            lbTipoSitio.Text = "Tipo de sitio";
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEstado.ForeColor = SystemColors.Control;
            lbEstado.Location = new Point(503, 43);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(72, 25);
            lbEstado.TabIndex = 25;
            lbEstado.Text = "Estado";
            // 
            // lbNSolicitud
            // 
            lbNSolicitud.AutoSize = true;
            lbNSolicitud.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNSolicitud.ForeColor = SystemColors.Control;
            lbNSolicitud.Location = new Point(28, 9);
            lbNSolicitud.Name = "lbNSolicitud";
            lbNSolicitud.Size = new Size(164, 25);
            lbNSolicitud.TabIndex = 24;
            lbNSolicitud.Text = "Número solicitud";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(81, 133, 112);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(lbFechaSolicitud);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(lbFechaResolución);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 202);
            panel6.Name = "panel6";
            panel6.Size = new Size(781, 122);
            panel6.TabIndex = 2;
            panel6.Paint += panel6_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Calendario;
            pictureBox4.Location = new Point(322, 36);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CalendarioSinFecha;
            pictureBox3.Location = new Point(21, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // lbFechaSolicitud
            // 
            lbFechaSolicitud.AutoSize = true;
            lbFechaSolicitud.Font = new Font("Segoe UI Historic", 10.8F);
            lbFechaSolicitud.ForeColor = SystemColors.Control;
            lbFechaSolicitud.Location = new Point(93, 72);
            lbFechaSolicitud.Name = "lbFechaSolicitud";
            lbFechaSolicitud.Size = new Size(130, 25);
            lbFechaSolicitud.TabIndex = 20;
            lbFechaSolicitud.Text = "Fecha Solicitud";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(393, 36);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 24;
            label2.Text = "Fecha Resolución";
            // 
            // lbFechaResolución
            // 
            lbFechaResolución.AutoSize = true;
            lbFechaResolución.Font = new Font("Segoe UI Historic", 10.8F);
            lbFechaResolución.ForeColor = SystemColors.Control;
            lbFechaResolución.Location = new Point(394, 72);
            lbFechaResolución.Name = "lbFechaResolución";
            lbFechaResolución.Size = new Size(148, 25);
            lbFechaResolución.TabIndex = 21;
            lbFechaResolución.Text = "Fecha Resolución";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(93, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 23;
            label1.Text = "Fecha Solicitud";
            // 
            // frmSolicitudesCard_Design
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 247, 238);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmSolicitudesCard_Design";
            Size = new Size(999, 350);
            Load += frmSolicitudesCard_Design_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel5;
        private PictureBox pbEstado;
        private Label lbDireccionTitulo;
        private Label lbTipoSitioTitulo;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Label lbDireccion;
        private Label lbTipoSitio;
        private Label lbEstado;
        private Label lbNSolicitud;
        private Panel panel6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lbFechaSolicitud;
        private Label label2;
        private Label lbFechaResolución;
        private Label label1;
        private Button button2;
    }
}
