namespace View
{
    partial class frmMultimedia_EvidenciaCard_Design
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
            picArchivo = new PictureBox();
            lbNSolicitud = new Label();
            lblNombreArchivo = new Label();
            lblExtension = new Label();
            lblTamaño = new Label();
            linkOpen = new LinkLabel();
            lblFecha = new Label();
            groupBox1 = new GroupBox();
            lblInformation = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picArchivo).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // picArchivo
            // 
            picArchivo.Location = new Point(41, 26);
            picArchivo.Name = "picArchivo";
            picArchivo.Size = new Size(318, 217);
            picArchivo.SizeMode = PictureBoxSizeMode.StretchImage;
            picArchivo.TabIndex = 0;
            picArchivo.TabStop = false;
            // 
            // lbNSolicitud
            // 
            lbNSolicitud.AutoSize = true;
            lbNSolicitud.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNSolicitud.ForeColor = Color.White;
            lbNSolicitud.Location = new Point(41, 145);
            lbNSolicitud.Name = "lbNSolicitud";
            lbNSolicitud.Size = new Size(164, 25);
            lbNSolicitud.TabIndex = 25;
            lbNSolicitud.Text = "Número solicitud";
            // 
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoEllipsis = true;
            lblNombreArchivo.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreArchivo.ForeColor = Color.White;
            lblNombreArchivo.Location = new Point(41, 42);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(164, 25);
            lblNombreArchivo.TabIndex = 26;
            lblNombreArchivo.Text = "Nombre Archivo";
            lblNombreArchivo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtension.ForeColor = Color.White;
            lblExtension.Location = new Point(41, 97);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(96, 25);
            lblExtension.TabIndex = 27;
            lblExtension.Text = "Extensión";
            // 
            // lblTamaño
            // 
            lblTamaño.AutoSize = true;
            lblTamaño.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTamaño.ForeColor = Color.White;
            lblTamaño.Location = new Point(277, 97);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(82, 25);
            lblTamaño.TabIndex = 28;
            lblTamaño.Text = "Tamaño";
            // 
            // linkOpen
            // 
            linkOpen.AutoSize = true;
            linkOpen.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            linkOpen.LinkColor = Color.Navy;
            linkOpen.Location = new Point(147, 248);
            linkOpen.Name = "linkOpen";
            linkOpen.Size = new Size(129, 25);
            linkOpen.TabIndex = 29;
            linkOpen.TabStop = true;
            linkOpen.Text = "Abrir Archivo";
            linkOpen.LinkClicked += linkOpen_LinkClicked;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(41, 201);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 25);
            lblFecha.TabIndex = 30;
            lblFecha.Text = "Fecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picArchivo);
            groupBox1.Controls.Add(lblInformation);
            groupBox1.Location = new Point(33, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 271);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            lblInformation.Location = new Point(155, 114);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(79, 25);
            lblInformation.TabIndex = 33;
            lblInformation.Text = "Archivo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNombreArchivo);
            groupBox2.Controls.Add(lbNSolicitud);
            groupBox2.Controls.Add(linkOpen);
            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(lblExtension);
            groupBox2.Controls.Add(lblTamaño);
            groupBox2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            groupBox2.Location = new Point(33, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 290);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles del archivo";
            // 
            // frmMultimedia_EvidenciaCard_Design
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 133, 112);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmMultimedia_EvidenciaCard_Design";
            Size = new Size(464, 619);
            Load += frmMultimedia_EvidenciaCard_Design_Load;
            ((System.ComponentModel.ISupportInitialize)picArchivo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picArchivo;
        private Label lbNSolicitud;
        private Label lblNombreArchivo;
        private Label lblExtension;
        private Label lblTamaño;
        private LinkLabel linkOpen;
        private Label lblFecha;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblInformation;
    }
}
