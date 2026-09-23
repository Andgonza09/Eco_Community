namespace View
{
    partial class frmPuntoRegistrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoRegistrados));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderIcon = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblMensajeAmbiental = new Label();
            tlpPrincipal = new TableLayoutPanel();
            tlpSuperior = new TableLayoutPanel();
            grpInformacion = new GroupBox();
            tlpCampos = new TableLayoutPanel();
            textBox1 = new TextBox();
            lblIdPunto = new Label();
            txtIdPunto = new TextBox();
            lblTipoSitio = new Label();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblLongitud = new Label();
            txtLongitud = new TextBox();
            lblLatitud = new Label();
            txtLatitud = new TextBox();
            lblBarrio = new Label();
            txtBarrio = new TextBox();
            grpMapa = new GroupBox();
            wv2Map = new Microsoft.Web.WebView2.WinForms.WebView2();
            grpAcciones = new GroupBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            grpListado = new GroupBox();
            dgvPuntos = new DataGridView();
            colIdPunto = new DataGridViewTextBoxColumn();
            colTipoSitio = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colLatitud = new DataGridViewTextBoxColumn();
            colLongitud = new DataGridViewTextBoxColumn();
            colBarrio = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            txtBuscar = new TextBox();
            pnlHeader.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            tlpSuperior.SuspendLayout();
            grpInformacion.SuspendLayout();
            tlpCampos.SuspendLayout();
            grpMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wv2Map).BeginInit();
            grpAcciones.SuspendLayout();
            groupBox2.SuspendLayout();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).BeginInit();
            pnlListadoHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(111, 146, 82);
            pnlHeader.Controls.Add(lblHeaderIcon);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblMensajeAmbiental);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1420, 95);
            pnlHeader.TabIndex = 2;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.Font = new Font("Segoe UI Emoji", 34F);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(26, 12);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(80, 70);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Text = "🌿";
            lblHeaderIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(115, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(558, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de puntos ambientales";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(234, 245, 232);
            lblSubtitulo.Location = new Point(118, 56);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(633, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Conoce y gestiona la información de los puntos ambientales en el sistema";
            // 
            // lblMensajeAmbiental
            // 
            lblMensajeAmbiental.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMensajeAmbiental.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblMensajeAmbiental.ForeColor = Color.White;
            lblMensajeAmbiental.Location = new Point(3760, 18);
            lblMensajeAmbiental.Name = "lblMensajeAmbiental";
            lblMensajeAmbiental.Size = new Size(230, 58);
            lblMensajeAmbiental.TabIndex = 3;
            lblMensajeAmbiental.Text = "Un entorno más limpio\r\npara todas y todos";
            lblMensajeAmbiental.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(tlpSuperior, 0, 0);
            tlpPrincipal.Controls.Add(grpListado, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 95);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(18, 14, 18, 8);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpPrincipal.Size = new Size(1420, 845);
            tlpPrincipal.TabIndex = 3;
            tlpPrincipal.Paint += tlpPrincipal_Paint;
            // 
            // tlpSuperior
            // 
            tlpSuperior.ColumnCount = 3;
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tlpSuperior.Controls.Add(grpInformacion, 0, 0);
            tlpSuperior.Controls.Add(grpMapa, 1, 0);
            tlpSuperior.Controls.Add(grpAcciones, 2, 0);
            tlpSuperior.Dock = DockStyle.Fill;
            tlpSuperior.Location = new Point(21, 17);
            tlpSuperior.Name = "tlpSuperior";
            tlpSuperior.RowCount = 1;
            tlpSuperior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSuperior.Size = new Size(1378, 394);
            tlpSuperior.TabIndex = 0;
            tlpSuperior.Paint += tlpSuperior_Paint;
            // 
            // grpInformacion
            // 
            grpInformacion.BackColor = Color.FromArgb(227, 235, 216);
            grpInformacion.Controls.Add(tlpCampos);
            grpInformacion.Dock = DockStyle.Fill;
            grpInformacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInformacion.ForeColor = Color.FromArgb(31, 58, 42);
            grpInformacion.Location = new Point(0, 0);
            grpInformacion.Margin = new Padding(0, 0, 8, 10);
            grpInformacion.Name = "grpInformacion";
            grpInformacion.Padding = new Padding(14);
            grpInformacion.Size = new Size(529, 384);
            grpInformacion.TabIndex = 0;
            grpInformacion.TabStop = false;
            grpInformacion.Text = "▣  Información del punto ambiental";
            // 
            // tlpCampos
            // 
            tlpCampos.ColumnCount = 4;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpCampos.Controls.Add(textBox1, 3, 0);
            tlpCampos.Controls.Add(lblIdPunto, 0, 0);
            tlpCampos.Controls.Add(txtIdPunto, 1, 0);
            tlpCampos.Controls.Add(lblTipoSitio, 2, 0);
            tlpCampos.Controls.Add(lblDireccion, 0, 1);
            tlpCampos.Controls.Add(txtDireccion, 1, 1);
            tlpCampos.Controls.Add(lblLongitud, 2, 1);
            tlpCampos.Controls.Add(txtLongitud, 3, 1);
            tlpCampos.Controls.Add(lblLatitud, 0, 2);
            tlpCampos.Controls.Add(txtLatitud, 1, 2);
            tlpCampos.Controls.Add(lblBarrio, 2, 2);
            tlpCampos.Controls.Add(txtBarrio, 3, 2);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Font = new Font("Segoe UI", 9F);
            tlpCampos.Location = new Point(14, 39);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.RowCount = 3;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.333F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.333F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.334F));
            tlpCampos.Size = new Size(501, 331);
            tlpCampos.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(328, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 12;
            // 
            // lblIdPunto
            // 
            lblIdPunto.Location = new Point(3, 0);
            lblIdPunto.Name = "lblIdPunto";
            lblIdPunto.Size = new Size(73, 23);
            lblIdPunto.TabIndex = 0;
            lblIdPunto.Text = "Id punto";
            // 
            // txtIdPunto
            // 
            txtIdPunto.Dock = DockStyle.Fill;
            txtIdPunto.Location = new Point(103, 3);
            txtIdPunto.Name = "txtIdPunto";
            txtIdPunto.ReadOnly = true;
            txtIdPunto.Size = new Size(119, 27);
            txtIdPunto.TabIndex = 1;
            // 
            // lblTipoSitio
            // 
            lblTipoSitio.Location = new Point(228, 0);
            lblTipoSitio.Name = "lblTipoSitio";
            lblTipoSitio.Size = new Size(73, 23);
            lblTipoSitio.TabIndex = 2;
            lblTipoSitio.Text = "Tipo Sitio";
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(3, 110);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(73, 23);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Dock = DockStyle.Fill;
            txtDireccion.Location = new Point(103, 113);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(119, 27);
            txtDireccion.TabIndex = 5;
            // 
            // lblLongitud
            // 
            lblLongitud.Location = new Point(228, 110);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(73, 23);
            lblLongitud.TabIndex = 6;
            lblLongitud.Text = "Longitud";
            // 
            // txtLongitud
            // 
            txtLongitud.Dock = DockStyle.Fill;
            txtLongitud.Location = new Point(328, 113);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(170, 27);
            txtLongitud.TabIndex = 7;
            // 
            // lblLatitud
            // 
            lblLatitud.Location = new Point(3, 220);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(73, 23);
            lblLatitud.TabIndex = 8;
            lblLatitud.Text = "Latitud";
            // 
            // txtLatitud
            // 
            txtLatitud.Dock = DockStyle.Fill;
            txtLatitud.Location = new Point(103, 223);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(119, 27);
            txtLatitud.TabIndex = 9;
            // 
            // lblBarrio
            // 
            lblBarrio.Location = new Point(228, 220);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(73, 23);
            lblBarrio.TabIndex = 10;
            lblBarrio.Text = "Barrio";
            // 
            // txtBarrio
            // 
            txtBarrio.Dock = DockStyle.Fill;
            txtBarrio.Location = new Point(328, 223);
            txtBarrio.Name = "txtBarrio";
            txtBarrio.ReadOnly = true;
            txtBarrio.Size = new Size(170, 27);
            txtBarrio.TabIndex = 11;
            // 
            // grpMapa
            // 
            grpMapa.BackColor = Color.FromArgb(227, 235, 216);
            grpMapa.Controls.Add(wv2Map);
            grpMapa.Dock = DockStyle.Fill;
            grpMapa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpMapa.ForeColor = Color.FromArgb(31, 58, 42);
            grpMapa.Location = new Point(545, 0);
            grpMapa.Margin = new Padding(8, 0, 8, 10);
            grpMapa.Name = "grpMapa";
            grpMapa.Padding = new Padding(10);
            grpMapa.Size = new Size(604, 384);
            grpMapa.TabIndex = 1;
            grpMapa.TabStop = false;
            grpMapa.Text = "📍  Ubicación en el mapa";
            // 
            // wv2Map
            // 
            wv2Map.AllowExternalDrop = true;
            wv2Map.CreationProperties = null;
            wv2Map.DefaultBackgroundColor = Color.White;
            wv2Map.Dock = DockStyle.Fill;
            wv2Map.Location = new Point(10, 35);
            wv2Map.Name = "wv2Map";
            wv2Map.Size = new Size(584, 339);
            wv2Map.TabIndex = 1;
            wv2Map.ZoomFactor = 1D;
            // 
            // grpAcciones
            // 
            grpAcciones.BackColor = Color.FromArgb(227, 235, 216);
            grpAcciones.Controls.Add(groupBox2);
            grpAcciones.Dock = DockStyle.Fill;
            grpAcciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpAcciones.ForeColor = Color.FromArgb(31, 58, 42);
            grpAcciones.Location = new Point(1165, 0);
            grpAcciones.Margin = new Padding(8, 0, 0, 10);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Padding = new Padding(14);
            grpAcciones.Size = new Size(213, 384);
            grpAcciones.TabIndex = 2;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "⚙  Acciones";
            grpAcciones.Enter += grpAcciones_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(28, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(159, 328);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(34, 130);
            button4.Name = "button4";
            button4.Size = new Size(83, 75);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(34, 31);
            button3.Name = "button3";
            button3.Size = new Size(83, 75);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(34, 234);
            button2.Name = "button2";
            button2.Size = new Size(83, 75);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.FromArgb(227, 235, 216);
            grpListado.Controls.Add(dgvPuntos);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(31, 58, 42);
            grpListado.Location = new Point(18, 414);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(1384, 380);
            grpListado.TabIndex = 1;
            grpListado.TabStop = false;
            // 
            // dgvPuntos
            // 
            dgvPuntos.AllowUserToAddRows = false;
            dgvPuntos.AllowUserToDeleteRows = false;
            dgvPuntos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 251, 248);
            dgvPuntos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPuntos.BackgroundColor = Color.White;
            dgvPuntos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(230, 240, 225);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(31, 58, 42);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 240, 225);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 58, 42);
            dgvPuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPuntos.ColumnHeadersHeight = 36;
            dgvPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPuntos.Columns.AddRange(new DataGridViewColumn[] { colIdPunto, colTipoSitio, colDireccion, colLatitud, colLongitud, colBarrio });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.6F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 58, 42);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(217, 236, 208);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 58, 42);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPuntos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPuntos.Dock = DockStyle.Fill;
            dgvPuntos.EnableHeadersVisualStyles = false;
            dgvPuntos.GridColor = Color.FromArgb(222, 229, 217);
            dgvPuntos.Location = new Point(10, 87);
            dgvPuntos.MultiSelect = false;
            dgvPuntos.Name = "dgvPuntos";
            dgvPuntos.ReadOnly = true;
            dgvPuntos.RowHeadersWidth = 28;
            dgvPuntos.RowTemplate.Height = 31;
            dgvPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuntos.Size = new Size(1364, 283);
            dgvPuntos.TabIndex = 0;
            dgvPuntos.CellContentClick += dgvPuntos_CellContentClick;
            // 
            // colIdPunto
            // 
            colIdPunto.FillWeight = 70F;
            colIdPunto.HeaderText = "Id punto";
            colIdPunto.MinimumWidth = 6;
            colIdPunto.Name = "colIdPunto";
            colIdPunto.ReadOnly = true;
            // 
            // colTipoSitio
            // 
            colTipoSitio.FillWeight = 110F;
            colTipoSitio.HeaderText = "Tipo de sitio";
            colTipoSitio.MinimumWidth = 6;
            colTipoSitio.Name = "colTipoSitio";
            colTipoSitio.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.FillWeight = 190F;
            colDireccion.HeaderText = "Dirección";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colLatitud
            // 
            colLatitud.FillWeight = 90F;
            colLatitud.HeaderText = "Latitud";
            colLatitud.MinimumWidth = 6;
            colLatitud.Name = "colLatitud";
            colLatitud.ReadOnly = true;
            // 
            // colLongitud
            // 
            colLongitud.HeaderText = "Longitud";
            colLongitud.MinimumWidth = 6;
            colLongitud.Name = "colLongitud";
            colLongitud.ReadOnly = true;
            // 
            // colBarrio
            // 
            colBarrio.FillWeight = 115F;
            colBarrio.HeaderText = "Barrio";
            colBarrio.MinimumWidth = 6;
            colBarrio.Name = "colBarrio";
            colBarrio.ReadOnly = true;
            // 
            // pnlListadoHeader
            // 
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Controls.Add(txtBuscar);
            pnlListadoHeader.Dock = DockStyle.Top;
            pnlListadoHeader.Location = new Point(10, 35);
            pnlListadoHeader.Name = "pnlListadoHeader";
            pnlListadoHeader.Size = new Size(1364, 52);
            pnlListadoHeader.TabIndex = 1;
            // 
            // lblListadoIcon
            // 
            lblListadoIcon.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            lblListadoIcon.ForeColor = Color.FromArgb(47, 111, 62);
            lblListadoIcon.Location = new Point(3, 5);
            lblListadoIcon.Name = "lblListadoIcon";
            lblListadoIcon.Size = new Size(46, 40);
            lblListadoIcon.TabIndex = 0;
            lblListadoIcon.Text = "☷";
            lblListadoIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblListadoTitulo
            // 
            lblListadoTitulo.AutoSize = true;
            lblListadoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListadoTitulo.ForeColor = Color.FromArgb(31, 58, 42);
            lblListadoTitulo.Location = new Point(52, 12);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(301, 28);
            lblListadoTitulo.TabIndex = 1;
            lblListadoTitulo.Text = "Listado de puntos ambientales";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 9F);
            txtBuscar.Location = new Point(3558, 9);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar punto ambiental...";
            txtBuscar.Size = new Size(300, 27);
            txtBuscar.TabIndex = 2;
            // 
            // frmPuntoRegistrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 940);
            Controls.Add(tlpPrincipal);
            Controls.Add(pnlHeader);
            Name = "frmPuntoRegistrados";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpSuperior.ResumeLayout(false);
            grpInformacion.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            grpMapa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wv2Map).EndInit();
            grpAcciones.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).EndInit();
            pnlListadoHeader.ResumeLayout(false);
            pnlListadoHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderIcon;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblMensajeAmbiental;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpSuperior;
        private GroupBox grpInformacion;
        private TableLayoutPanel tlpCampos;
        private Label lblIdPunto;
        private TextBox txtIdPunto;
        private Label lblTipoSitio;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblLongitud;
        private TextBox txtLongitud;
        private Label lblLatitud;
        private TextBox txtLatitud;
        private Label lblBarrio;
        private TextBox txtBarrio;
        private GroupBox grpMapa;
        private GroupBox grpAcciones;
        private GroupBox grpListado;
        private DataGridView dgvPuntos;
        private DataGridViewTextBoxColumn colIdPunto;
        private DataGridViewTextBoxColumn colTipoSitio;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colLatitud;
        private DataGridViewTextBoxColumn colLongitud;
        private DataGridViewTextBoxColumn colBarrio;
        private Panel pnlListadoHeader;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private TextBox txtBuscar;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv2Map;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}