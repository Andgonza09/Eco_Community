namespace View
{
    partial class frmRecompensaCard_Design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecompensaCard_Design));
            pictureBox1 = new PictureBox();
            lblNRecompensa = new Label();
            lblDescripcion = new Label();
            lblTipoRecompensa = new Label();
            lblMisionAsociada = new Label();
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblNRecompensa
            // 
            lblNRecompensa.AutoEllipsis = true;
            lblNRecompensa.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNRecompensa.ForeColor = Color.White;
            lblNRecompensa.Location = new Point(294, 13);
            lblNRecompensa.Name = "lblNRecompensa";
            lblNRecompensa.Size = new Size(164, 25);
            lblNRecompensa.TabIndex = 30;
            lblNRecompensa.Text = "N Recompensas";
            lblNRecompensa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoEllipsis = true;
            lblDescripcion.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(294, 76);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(335, 79);
            lblDescripcion.TabIndex = 31;
            lblDescripcion.Text = "Descripcion Recompensa";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipoRecompensa
            // 
            lblTipoRecompensa.AutoEllipsis = true;
            lblTipoRecompensa.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoRecompensa.ForeColor = Color.White;
            lblTipoRecompensa.Location = new Point(510, 13);
            lblTipoRecompensa.Name = "lblTipoRecompensa";
            lblTipoRecompensa.Size = new Size(213, 51);
            lblTipoRecompensa.TabIndex = 32;
            lblTipoRecompensa.Text = "Tipo Recompensa";
            lblTipoRecompensa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMisionAsociada
            // 
            lblMisionAsociada.AutoEllipsis = true;
            lblMisionAsociada.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMisionAsociada.ForeColor = Color.White;
            lblMisionAsociada.Location = new Point(294, 166);
            lblMisionAsociada.Name = "lblMisionAsociada";
            lblMisionAsociada.Size = new Size(335, 122);
            lblMisionAsociada.TabIndex = 33;
            lblMisionAsociada.Text = "Misión Asociada";
            lblMisionAsociada.TextAlign = ContentAlignment.MiddleLeft;
            lblMisionAsociada.Click += lblMisionAsociada_Click;
            // 
            // frmRecompensaCard_Design
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 133, 112);
            Controls.Add(lblMisionAsociada);
            Controls.Add(lblTipoRecompensa);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNRecompensa);
            Controls.Add(pictureBox1);
            Name = "frmRecompensaCard_Design";
            Size = new Size(758, 331);
            Load += frmRecompensaCard_Design_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNRecompensa;
        private Label lblDescripcion;
        private Label lblTipoRecompensa;
        private Label lblMisionAsociada;
    }
}
