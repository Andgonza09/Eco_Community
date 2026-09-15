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
            pictureBox1 = new PictureBox();
            lbNSolicitud = new Label();
            lbEstado = new Label();
            lbTipoSitio = new Label();
            lbDireccion = new Label();
            lbFechaSolicitud = new Label();
            lbFechaResolución = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lbNSolicitud
            // 
            lbNSolicitud.AutoSize = true;
            lbNSolicitud.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNSolicitud.Location = new Point(243, 14);
            lbNSolicitud.Name = "lbNSolicitud";
            lbNSolicitud.Size = new Size(164, 25);
            lbNSolicitud.TabIndex = 16;
            lbNSolicitud.Text = "Número solicitud";
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEstado.Location = new Point(614, 14);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(72, 25);
            lbEstado.TabIndex = 17;
            lbEstado.Text = "Estado";
            // 
            // lbTipoSitio
            // 
            lbTipoSitio.AutoSize = true;
            lbTipoSitio.Font = new Font("Segoe UI Historic", 10.8F);
            lbTipoSitio.Location = new Point(243, 77);
            lbTipoSitio.Name = "lbTipoSitio";
            lbTipoSitio.Size = new Size(110, 25);
            lbTipoSitio.TabIndex = 18;
            lbTipoSitio.Text = "Tipo de sitio";
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Segoe UI Historic", 10.8F);
            lbDireccion.Location = new Point(243, 137);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(85, 25);
            lbDireccion.TabIndex = 19;
            lbDireccion.Text = "Dirección";
            // 
            // lbFechaSolicitud
            // 
            lbFechaSolicitud.AutoSize = true;
            lbFechaSolicitud.Font = new Font("Segoe UI Historic", 10.8F);
            lbFechaSolicitud.Location = new Point(292, 237);
            lbFechaSolicitud.Name = "lbFechaSolicitud";
            lbFechaSolicitud.Size = new Size(130, 25);
            lbFechaSolicitud.TabIndex = 20;
            lbFechaSolicitud.Text = "Fecha Solicitud";
            lbFechaSolicitud.Click += lbFechaSolicitud_Click;
            // 
            // lbFechaResolución
            // 
            lbFechaResolución.AutoSize = true;
            lbFechaResolución.Font = new Font("Segoe UI Historic", 10.8F);
            lbFechaResolución.Location = new Point(494, 237);
            lbFechaResolución.Name = "lbFechaResolución";
            lbFechaResolución.Size = new Size(148, 25);
            lbFechaResolución.TabIndex = 21;
            lbFechaResolución.Text = "Fecha Resolución";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.location3;
            pictureBox2.Location = new Point(201, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.8F);
            label1.Location = new Point(292, 199);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 23;
            label1.Text = "Fecha Solicitud";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10.8F);
            label2.Location = new Point(494, 199);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 24;
            label2.Text = "Fecha Resolución";
            // 
            // frmSolicitudesCard_Design
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 217, 189);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbNSolicitud);
            Controls.Add(lbEstado);
            Controls.Add(lbTipoSitio);
            Controls.Add(lbDireccion);
            Controls.Add(lbFechaSolicitud);
            Controls.Add(lbFechaResolución);
            Name = "frmSolicitudesCard_Design";
            Size = new Size(774, 285);
            Load += frmSolicitudesCard_Design_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbNSolicitud;
        private Label lbEstado;
        private Label lbTipoSitio;
        private Label lbDireccion;
        private Label lbFechaSolicitud;
        private Label lbFechaResolución;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}
