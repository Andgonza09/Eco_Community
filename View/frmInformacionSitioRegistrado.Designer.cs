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
            groupBox2 = new GroupBox();
            txtLongitud = new TextBox();
            lblLongitud = new Label();
            txtLatitud = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            rchResiduos = new RichTextBox();
            label1 = new Label();
            rchDireccion = new RichTextBox();
            txtDistrito = new TextBox();
            txtBarrio = new TextBox();
            txtTipoSitio = new TextBox();
            lblTipoSitio = new Label();
            lbBarro = new Label();
            lblDistrito = new Label();
            lblDireccion = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wv2Map).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(7, 80, 51);
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
            label4.ForeColor = SystemColors.Control;
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
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(43, 51);
            label6.Name = "label6";
            label6.Size = new Size(540, 28);
            label6.TabIndex = 50;
            label6.Text = "Conoce todos los puntos ambientales ubicados en el sistema";
            // 
            // wv2Map
            // 
            wv2Map.AllowExternalDrop = true;
            wv2Map.BackColor = Color.White;
            wv2Map.CreationProperties = null;
            wv2Map.DefaultBackgroundColor = Color.White;
            wv2Map.Dock = DockStyle.Fill;
            wv2Map.Location = new Point(3, 27);
            wv2Map.Name = "wv2Map";
            wv2Map.Size = new Size(1050, 415);
            wv2Map.TabIndex = 37;
            wv2Map.ZoomFactor = 1D;
            wv2Map.Click += webView21_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 19);
            panel1.TabIndex = 38;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1112, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(50, 768);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLongitud);
            groupBox2.Controls.Add(lblLongitud);
            groupBox2.Controls.Add(txtLatitud);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(rchResiduos);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(rchDireccion);
            groupBox2.Controls.Add(txtDistrito);
            groupBox2.Controls.Add(txtBarrio);
            groupBox2.Controls.Add(txtTipoSitio);
            groupBox2.Controls.Add(lblTipoSitio);
            groupBox2.Controls.Add(lbBarro);
            groupBox2.Controls.Add(lblDistrito);
            groupBox2.Controls.Add(lblDireccion);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            groupBox2.Location = new Point(3, 454);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1056, 295);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles del sitio";
            // 
            // txtLongitud
            // 
            txtLongitud.Anchor = AnchorStyles.Top;
            txtLongitud.Location = new Point(734, 252);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.ReadOnly = true;
            txtLongitud.Size = new Size(273, 31);
            txtLongitud.TabIndex = 43;
            // 
            // lblLongitud
            // 
            lblLongitud.Anchor = AnchorStyles.Top;
            lblLongitud.AutoSize = true;
            lblLongitud.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLongitud.ForeColor = Color.Black;
            lblLongitud.Location = new Point(522, 258);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(96, 25);
            lblLongitud.TabIndex = 42;
            lblLongitud.Text = "Longitud:";
            // 
            // txtLatitud
            // 
            txtLatitud.Anchor = AnchorStyles.Top;
            txtLatitud.Location = new Point(734, 195);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.ReadOnly = true;
            txtLatitud.Size = new Size(273, 31);
            txtLatitud.TabIndex = 41;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(522, 198);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 40;
            label3.Text = "Latitud:";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top;
            txtUsuario.Location = new Point(734, 39);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(273, 31);
            txtUsuario.TabIndex = 39;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoEllipsis = true;
            label2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(522, 38);
            label2.Name = "label2";
            label2.Size = new Size(206, 31);
            label2.TabIndex = 38;
            label2.Text = "Usuario responsable:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rchResiduos
            // 
            rchResiduos.Anchor = AnchorStyles.Top;
            rchResiduos.Location = new Point(734, 80);
            rchResiduos.Name = "rchResiduos";
            rchResiduos.ReadOnly = true;
            rchResiduos.Size = new Size(273, 97);
            rchResiduos.TabIndex = 37;
            rchResiduos.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(522, 110);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 36;
            label1.Text = "Residuos admitidos:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rchDireccion
            // 
            rchDireccion.Anchor = AnchorStyles.Top;
            rchDireccion.Location = new Point(185, 78);
            rchDireccion.Name = "rchDireccion";
            rchDireccion.ReadOnly = true;
            rchDireccion.Size = new Size(292, 99);
            rchDireccion.TabIndex = 35;
            rchDireccion.Text = "";
            // 
            // txtDistrito
            // 
            txtDistrito.Anchor = AnchorStyles.Top;
            txtDistrito.Location = new Point(185, 250);
            txtDistrito.Name = "txtDistrito";
            txtDistrito.ReadOnly = true;
            txtDistrito.Size = new Size(292, 31);
            txtDistrito.TabIndex = 34;
            // 
            // txtBarrio
            // 
            txtBarrio.Anchor = AnchorStyles.Top;
            txtBarrio.Location = new Point(185, 187);
            txtBarrio.Name = "txtBarrio";
            txtBarrio.ReadOnly = true;
            txtBarrio.Size = new Size(292, 31);
            txtBarrio.TabIndex = 33;
            // 
            // txtTipoSitio
            // 
            txtTipoSitio.Anchor = AnchorStyles.Top;
            txtTipoSitio.Location = new Point(185, 39);
            txtTipoSitio.Name = "txtTipoSitio";
            txtTipoSitio.ReadOnly = true;
            txtTipoSitio.Size = new Size(292, 31);
            txtTipoSitio.TabIndex = 32;
            // 
            // lblTipoSitio
            // 
            lblTipoSitio.Anchor = AnchorStyles.Top;
            lblTipoSitio.AutoEllipsis = true;
            lblTipoSitio.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoSitio.ForeColor = Color.Black;
            lblTipoSitio.Location = new Point(41, 42);
            lblTipoSitio.Name = "lblTipoSitio";
            lblTipoSitio.Size = new Size(139, 25);
            lblTipoSitio.TabIndex = 26;
            lblTipoSitio.Text = "Tipo de sitio:";
            lblTipoSitio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbBarro
            // 
            lbBarro.Anchor = AnchorStyles.Top;
            lbBarro.AutoSize = true;
            lbBarro.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBarro.ForeColor = Color.Black;
            lbBarro.Location = new Point(41, 187);
            lbBarro.Name = "lbBarro";
            lbBarro.Size = new Size(69, 25);
            lbBarro.TabIndex = 25;
            lbBarro.Text = "Barrio:";
            // 
            // lblDistrito
            // 
            lblDistrito.Anchor = AnchorStyles.Top;
            lblDistrito.AutoSize = true;
            lblDistrito.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistrito.ForeColor = Color.Black;
            lblDistrito.Location = new Point(41, 250);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(83, 25);
            lblDistrito.TabIndex = 30;
            lblDistrito.Text = "Distrito:";
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Top;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = Color.Black;
            lblDireccion.Location = new Point(41, 109);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(99, 25);
            lblDireccion.TabIndex = 27;
            lblDireccion.Text = "Dirección:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(50, 108);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.9999352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.0100999791F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.98996F));
            tableLayoutPanel1.Size = new Size(1062, 752);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(wv2Map);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 445);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mapa de ubicación";
            // 
            // frmInformacionSitioRegistrado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 876);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel10);
            Name = "frmInformacionSitioRegistrado";
            Text = "UserPointsRegisters";
            Load += UserPointsRegisters_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wv2Map).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private Label lblTipoSitio;
        private Label lbBarro;
        private Label lblDistrito;
        private Label lblDireccion;
        private RichTextBox rchDireccion;
        private TextBox txtDistrito;
        private TextBox txtBarrio;
        private TextBox txtTipoSitio;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private RichTextBox rchResiduos;
        private TextBox txtLongitud;
        private Label lblLongitud;
        private TextBox txtLatitud;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
    }
}