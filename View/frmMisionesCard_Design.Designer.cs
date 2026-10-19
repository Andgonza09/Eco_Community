namespace View
{
    partial class frmMisionesCard_Design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMisionesCard_Design));
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            lblDescripcion = new Label();
            lblPuntaje = new Label();
            lblNSolicitud = new Label();
            lbCompletado = new Label();
            lblPorcentaje = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(81, 133, 112);
            progressBar1.Location = new Point(450, 277);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(242, 42);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoEllipsis = true;
            lblDescripcion.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(286, 97);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(335, 122);
            lblDescripcion.TabIndex = 27;
            lblDescripcion.Text = "Descripcion Misión";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoEllipsis = true;
            lblPuntaje.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntaje.ForeColor = Color.White;
            lblPuntaje.Location = new Point(580, 42);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(164, 25);
            lblPuntaje.TabIndex = 28;
            lblPuntaje.Text = "Puntaje";
            lblPuntaje.TextAlign = ContentAlignment.MiddleLeft;
            lblPuntaje.Click += lblPuntaje_Click;
            // 
            // lblNSolicitud
            // 
            lblNSolicitud.AutoEllipsis = true;
            lblNSolicitud.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNSolicitud.ForeColor = Color.White;
            lblNSolicitud.Location = new Point(286, 42);
            lblNSolicitud.Name = "lblNSolicitud";
            lblNSolicitud.Size = new Size(164, 25);
            lblNSolicitud.TabIndex = 29;
            lblNSolicitud.Text = "N Misiones";
            lblNSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbCompletado
            // 
            lbCompletado.AutoEllipsis = true;
            lbCompletado.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCompletado.ForeColor = Color.White;
            lbCompletado.Location = new Point(629, 241);
            lbCompletado.Name = "lbCompletado";
            lbCompletado.Size = new Size(46, 25);
            lbCompletado.TabIndex = 30;
            lbCompletado.Text = "0/1";
            lbCompletado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoEllipsis = true;
            lblPorcentaje.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentaje.ForeColor = Color.White;
            lblPorcentaje.Location = new Point(357, 277);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(77, 42);
            lblPorcentaje.TabIndex = 31;
            lblPorcentaje.Text = "%";
            lblPorcentaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMisionesCard_Design
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(81, 133, 112);
            Controls.Add(lblPorcentaje);
            Controls.Add(lbCompletado);
            Controls.Add(lblNSolicitud);
            Controls.Add(lblPuntaje);
            Controls.Add(lblDescripcion);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Name = "frmMisionesCard_Design";
            Size = new Size(758, 331);
            Load += frmMisionesCard_Design_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label lblDescripcion;
        private Label lblPuntaje;
        private Label lblNSolicitud;
        private Label lbCompletado;
        private Label lblPorcentaje;
    }
}
