namespace View
{
    partial class frmMultimedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultimedia));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            tlpMain = new TableLayoutPanel();
            grpVistaPrevia = new GroupBox();
            lblVistaPrevia = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            picVistaPrevia = new PictureBox();
            lblSinVistaPrevia = new Label();
            grpListado = new GroupBox();
            dgvMultimedia = new DataGridView();
            colIdMultimedia = new DataGridViewTextBoxColumn();
            colArchivo = new DataGridViewTextBoxColumn();
            colTamañoArchivo = new DataGridViewTextBoxColumn();
            colRutaArchivo = new DataGridViewTextBoxColumn();
            colFechaAdjunción = new DataGridViewTextBoxColumn();
            colNombreUsuario = new DataGridViewTextBoxColumn();
            colExtension = new DataGridViewTextBoxColumn();
            colIdSolicitud = new DataGridViewTextBoxColumn();
            pnlListadoTop = new Panel();
            button1 = new Button();
            txtBuscar = new TextBox();
            grpInformacion = new GroupBox();
            groupBox2 = new GroupBox();
            tlpCampos = new TableLayoutPanel();
            lblId = new Label();
            txtIdMultimedia = new TextBox();
            lblArchivo = new Label();
            txtArchivo = new TextBox();
            lblRuta = new Label();
            txtRuta = new TextBox();
            lblTamano = new Label();
            txtTamano = new TextBox();
            lblFecha = new Label();
            dtpFechaAdjuncion = new DateTimePicker();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSolicitud = new Label();
            txtSolicitud = new TextBox();
            lblExtension = new Label();
            cmbExtension = new ComboBox();
            button3 = new Button();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button14 = new Button();
            btnDelete = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tlpMain.SuspendLayout();
            grpVistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVistaPrevia).BeginInit();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMultimedia).BeginInit();
            pnlListadoTop.SuspendLayout();
            grpInformacion.SuspendLayout();
            groupBox2.SuspendLayout();
            tlpCampos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(7, 80, 51);
            pnlHeader.Controls.Add(pictureBox3);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1420, 106);
            pnlHeader.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(30, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(127, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(414, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión Multimedia";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(139, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(437, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Gestiona las evidencias de los usuarios del sistema";
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.White;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpMain.Controls.Add(grpVistaPrevia, 1, 1);
            tlpMain.Controls.Add(grpListado, 1, 0);
            tlpMain.Controls.Add(grpInformacion, 0, 0);
            tlpMain.Controls.Add(groupBox1, 2, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 106);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(16, 12, 16, 16);
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tlpMain.Size = new Size(1420, 834);
            tlpMain.TabIndex = 8;
            // 
            // grpVistaPrevia
            // 
            grpVistaPrevia.BackColor = Color.White;
            grpVistaPrevia.Controls.Add(lblVistaPrevia);
            grpVistaPrevia.Controls.Add(linkLabel2);
            grpVistaPrevia.Controls.Add(linkLabel1);
            grpVistaPrevia.Controls.Add(picVistaPrevia);
            grpVistaPrevia.Controls.Add(lblSinVistaPrevia);
            grpVistaPrevia.Dock = DockStyle.Fill;
            grpVistaPrevia.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpVistaPrevia.ForeColor = Color.FromArgb(24, 55, 44);
            grpVistaPrevia.Location = new Point(371, 471);
            grpVistaPrevia.Margin = new Padding(8, 8, 8, 0);
            grpVistaPrevia.Name = "grpVistaPrevia";
            grpVistaPrevia.Padding = new Padding(10, 28, 10, 10);
            grpVistaPrevia.Size = new Size(816, 347);
            grpVistaPrevia.TabIndex = 17;
            grpVistaPrevia.TabStop = false;
            grpVistaPrevia.Text = "  Vista previa";
            grpVistaPrevia.Enter += grpVistaPrevia_Enter;
            // 
            // lblVistaPrevia
            // 
            lblVistaPrevia.AutoSize = true;
            lblVistaPrevia.Location = new Point(451, 136);
            lblVistaPrevia.Name = "lblVistaPrevia";
            lblVistaPrevia.Size = new Size(204, 25);
            lblVistaPrevia.TabIndex = 4;
            lblVistaPrevia.Text = "Selecciona un archivo";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Navy;
            linkLabel2.Location = new Point(654, 4);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(149, 25);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Abrir ubicación";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(506, 4);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Abrir Archivo";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // picVistaPrevia
            // 
            picVistaPrevia.BackColor = Color.FromArgb(250, 252, 249);
            picVistaPrevia.Location = new Point(93, 38);
            picVistaPrevia.Name = "picVistaPrevia";
            picVistaPrevia.Padding = new Padding(8);
            picVistaPrevia.Size = new Size(311, 257);
            picVistaPrevia.SizeMode = PictureBoxSizeMode.Zoom;
            picVistaPrevia.TabIndex = 0;
            picVistaPrevia.TabStop = false;
            picVistaPrevia.Click += picVistaPrevia_Click;
            // 
            // lblSinVistaPrevia
            // 
            lblSinVistaPrevia.Dock = DockStyle.Bottom;
            lblSinVistaPrevia.ForeColor = Color.FromArgb(92, 112, 102);
            lblSinVistaPrevia.Location = new Point(10, 298);
            lblSinVistaPrevia.Name = "lblSinVistaPrevia";
            lblSinVistaPrevia.Size = new Size(796, 39);
            lblSinVistaPrevia.TabIndex = 1;
            lblSinVistaPrevia.Text = "Selecciona un archivo para visualizarlo.";
            lblSinVistaPrevia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.White;
            grpListado.Controls.Add(dgvMultimedia);
            grpListado.Controls.Add(pnlListadoTop);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(24, 55, 44);
            grpListado.Location = new Point(371, 12);
            grpListado.Margin = new Padding(8, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10, 28, 10, 10);
            grpListado.Size = new Size(824, 443);
            grpListado.TabIndex = 5;
            grpListado.TabStop = false;
            grpListado.Text = "  Listado de archivos multimedia";
            // 
            // dgvMultimedia
            // 
            dgvMultimedia.AllowUserToAddRows = false;
            dgvMultimedia.AllowUserToDeleteRows = false;
            dgvMultimedia.AllowUserToResizeRows = false;
            dgvMultimedia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMultimedia.BackgroundColor = Color.White;
            dgvMultimedia.BorderStyle = BorderStyle.Fixed3D;
            dgvMultimedia.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 80, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvMultimedia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMultimedia.ColumnHeadersHeight = 38;
            dgvMultimedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMultimedia.Columns.AddRange(new DataGridViewColumn[] { colIdMultimedia, colArchivo, colTamañoArchivo, colRutaArchivo, colFechaAdjunción, colNombreUsuario, colExtension, colIdSolicitud });
            dgvMultimedia.Dock = DockStyle.Fill;
            dgvMultimedia.EnableHeadersVisualStyles = false;
            dgvMultimedia.GridColor = Color.FromArgb(222, 229, 217);
            dgvMultimedia.Location = new Point(10, 103);
            dgvMultimedia.MultiSelect = false;
            dgvMultimedia.Name = "dgvMultimedia";
            dgvMultimedia.ReadOnly = true;
            dgvMultimedia.RowHeadersWidth = 28;
            dgvMultimedia.RowTemplate.Height = 33;
            dgvMultimedia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMultimedia.Size = new Size(804, 330);
            dgvMultimedia.TabIndex = 2;
            dgvMultimedia.CellContentClick += dgvMultimedia_CellContentClick;
            dgvMultimedia.SelectionChanged += dgvMultimedia_SelectionChanged;
            // 
            // colIdMultimedia
            // 
            colIdMultimedia.DataPropertyName = "id_Multimedia";
            colIdMultimedia.FillWeight = 40F;
            colIdMultimedia.HeaderText = "ID Multimedia";
            colIdMultimedia.MinimumWidth = 6;
            colIdMultimedia.Name = "colIdMultimedia";
            colIdMultimedia.ReadOnly = true;
            // 
            // colArchivo
            // 
            colArchivo.DataPropertyName = "nombre_ArchivoMultimedia";
            colArchivo.FillWeight = 65F;
            colArchivo.HeaderText = "Archivo";
            colArchivo.MinimumWidth = 6;
            colArchivo.Name = "colArchivo";
            colArchivo.ReadOnly = true;
            // 
            // colTamañoArchivo
            // 
            colTamañoArchivo.DataPropertyName = "tamaño_ArchivoMultimedia";
            colTamañoArchivo.FillWeight = 50F;
            colTamañoArchivo.HeaderText = "Tamaño";
            colTamañoArchivo.MinimumWidth = 6;
            colTamañoArchivo.Name = "colTamañoArchivo";
            colTamañoArchivo.ReadOnly = true;
            // 
            // colRutaArchivo
            // 
            colRutaArchivo.DataPropertyName = "ruta_archivoMultimedia";
            colRutaArchivo.HeaderText = "Ruta del archivo";
            colRutaArchivo.MinimumWidth = 6;
            colRutaArchivo.Name = "colRutaArchivo";
            colRutaArchivo.ReadOnly = true;
            // 
            // colFechaAdjunción
            // 
            colFechaAdjunción.DataPropertyName = "fecha_Adjuncion";
            colFechaAdjunción.FillWeight = 60F;
            colFechaAdjunción.HeaderText = "Fecha de adjunción";
            colFechaAdjunción.MinimumWidth = 6;
            colFechaAdjunción.Name = "colFechaAdjunción";
            colFechaAdjunción.ReadOnly = true;
            // 
            // colNombreUsuario
            // 
            colNombreUsuario.DataPropertyName = "nombre_Usuario";
            colNombreUsuario.FillWeight = 50F;
            colNombreUsuario.HeaderText = "Nombre del usuario";
            colNombreUsuario.MinimumWidth = 6;
            colNombreUsuario.Name = "colNombreUsuario";
            colNombreUsuario.ReadOnly = true;
            // 
            // colExtension
            // 
            colExtension.DataPropertyName = "tipo_Extension";
            colExtension.FillWeight = 50F;
            colExtension.HeaderText = "Extensión";
            colExtension.MinimumWidth = 6;
            colExtension.Name = "colExtension";
            colExtension.ReadOnly = true;
            // 
            // colIdSolicitud
            // 
            colIdSolicitud.DataPropertyName = "id_Solicitud";
            colIdSolicitud.FillWeight = 50F;
            colIdSolicitud.HeaderText = "ID Solicitud";
            colIdSolicitud.MinimumWidth = 6;
            colIdSolicitud.Name = "colIdSolicitud";
            colIdSolicitud.ReadOnly = true;
            // 
            // pnlListadoTop
            // 
            pnlListadoTop.BackColor = Color.White;
            pnlListadoTop.Controls.Add(button1);
            pnlListadoTop.Controls.Add(txtBuscar);
            pnlListadoTop.Dock = DockStyle.Top;
            pnlListadoTop.Location = new Point(10, 53);
            pnlListadoTop.Name = "pnlListadoTop";
            pnlListadoTop.Size = new Size(804, 50);
            pnlListadoTop.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(469, 0);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(17, 9);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por id de solicitud";
            txtBuscar.Size = new Size(444, 32);
            txtBuscar.TabIndex = 0;
            // 
            // grpInformacion
            // 
            grpInformacion.BackColor = Color.White;
            grpInformacion.Controls.Add(groupBox2);
            grpInformacion.Dock = DockStyle.Fill;
            grpInformacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInformacion.ForeColor = Color.FromArgb(24, 55, 44);
            grpInformacion.Location = new Point(16, 12);
            grpInformacion.Margin = new Padding(0, 0, 8, 8);
            grpInformacion.Name = "grpInformacion";
            grpInformacion.Padding = new Padding(10, 28, 10, 10);
            tlpMain.SetRowSpan(grpInformacion, 2);
            grpInformacion.Size = new Size(339, 798);
            grpInformacion.TabIndex = 0;
            grpInformacion.TabStop = false;
            grpInformacion.Text = "  Información del archivo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tlpCampos);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(10, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 735);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // tlpCampos
            // 
            tlpCampos.ColumnCount = 3;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.55556F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.44444F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tlpCampos.Controls.Add(lblId, 0, 0);
            tlpCampos.Controls.Add(txtIdMultimedia, 1, 0);
            tlpCampos.Controls.Add(lblArchivo, 0, 1);
            tlpCampos.Controls.Add(txtArchivo, 1, 1);
            tlpCampos.Controls.Add(lblRuta, 0, 2);
            tlpCampos.Controls.Add(txtRuta, 1, 2);
            tlpCampos.Controls.Add(lblTamano, 0, 3);
            tlpCampos.Controls.Add(txtTamano, 1, 3);
            tlpCampos.Controls.Add(lblFecha, 0, 4);
            tlpCampos.Controls.Add(dtpFechaAdjuncion, 1, 4);
            tlpCampos.Controls.Add(lblUsuario, 0, 5);
            tlpCampos.Controls.Add(txtUsuario, 1, 5);
            tlpCampos.Controls.Add(lblSolicitud, 0, 6);
            tlpCampos.Controls.Add(txtSolicitud, 1, 6);
            tlpCampos.Controls.Add(lblExtension, 0, 7);
            tlpCampos.Controls.Add(cmbExtension, 1, 7);
            tlpCampos.Controls.Add(button3, 2, 1);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(3, 28);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.Padding = new Padding(14, 10, 14, 180);
            tlpCampos.RowCount = 8;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpCampos.Size = new Size(313, 704);
            tlpCampos.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(24, 55, 44);
            lblId.Location = new Point(17, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(78, 64);
            lblId.TabIndex = 0;
            lblId.Text = "ID Multimedia";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIdMultimedia
            // 
            txtIdMultimedia.Dock = DockStyle.Fill;
            txtIdMultimedia.Font = new Font("Segoe UI", 9.5F);
            txtIdMultimedia.Location = new Point(103, 17);
            txtIdMultimedia.Margin = new Padding(5, 7, 5, 7);
            txtIdMultimedia.Name = "txtIdMultimedia";
            txtIdMultimedia.ReadOnly = true;
            txtIdMultimedia.Size = new Size(144, 29);
            txtIdMultimedia.TabIndex = 1;
            // 
            // lblArchivo
            // 
            lblArchivo.Dock = DockStyle.Fill;
            lblArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblArchivo.ForeColor = Color.FromArgb(24, 55, 44);
            lblArchivo.Location = new Point(17, 74);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(78, 64);
            lblArchivo.TabIndex = 2;
            lblArchivo.Text = "Archivo";
            lblArchivo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtArchivo
            // 
            txtArchivo.Dock = DockStyle.Fill;
            txtArchivo.Font = new Font("Segoe UI", 9.5F);
            txtArchivo.Location = new Point(103, 81);
            txtArchivo.Margin = new Padding(5, 7, 5, 7);
            txtArchivo.Name = "txtArchivo";
            txtArchivo.Size = new Size(144, 29);
            txtArchivo.TabIndex = 3;
            // 
            // lblRuta
            // 
            lblRuta.Dock = DockStyle.Fill;
            lblRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRuta.ForeColor = Color.FromArgb(24, 55, 44);
            lblRuta.Location = new Point(17, 138);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(78, 64);
            lblRuta.TabIndex = 5;
            lblRuta.Text = "Ruta del archivo";
            lblRuta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRuta
            // 
            txtRuta.Dock = DockStyle.Fill;
            txtRuta.Font = new Font("Segoe UI", 9.5F);
            txtRuta.Location = new Point(103, 145);
            txtRuta.Margin = new Padding(5, 7, 5, 7);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(144, 29);
            txtRuta.TabIndex = 6;
            // 
            // lblTamano
            // 
            lblTamano.Dock = DockStyle.Fill;
            lblTamano.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTamano.ForeColor = Color.FromArgb(24, 55, 44);
            lblTamano.Location = new Point(17, 202);
            lblTamano.Name = "lblTamano";
            lblTamano.Size = new Size(78, 64);
            lblTamano.TabIndex = 7;
            lblTamano.Text = "Tamaño";
            lblTamano.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTamano
            // 
            txtTamano.Dock = DockStyle.Fill;
            txtTamano.Font = new Font("Segoe UI", 9.5F);
            txtTamano.Location = new Point(103, 209);
            txtTamano.Margin = new Padding(5, 7, 5, 7);
            txtTamano.Name = "txtTamano";
            txtTamano.ReadOnly = true;
            txtTamano.Size = new Size(144, 29);
            txtTamano.TabIndex = 8;
            // 
            // lblFecha
            // 
            lblFecha.Dock = DockStyle.Fill;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(24, 55, 44);
            lblFecha.Location = new Point(17, 266);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(78, 64);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha de adjunción";
            lblFecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaAdjuncion
            // 
            dtpFechaAdjuncion.Dock = DockStyle.Fill;
            dtpFechaAdjuncion.Format = DateTimePickerFormat.Short;
            dtpFechaAdjuncion.Location = new Point(103, 273);
            dtpFechaAdjuncion.Margin = new Padding(5, 7, 5, 7);
            dtpFechaAdjuncion.Name = "dtpFechaAdjuncion";
            dtpFechaAdjuncion.Size = new Size(144, 32);
            dtpFechaAdjuncion.TabIndex = 10;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(24, 55, 44);
            lblUsuario.Location = new Point(17, 330);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(78, 64);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Segoe UI", 9.5F);
            txtUsuario.Location = new Point(103, 337);
            txtUsuario.Margin = new Padding(5, 7, 5, 7);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(144, 29);
            txtUsuario.TabIndex = 12;
            // 
            // lblSolicitud
            // 
            lblSolicitud.Dock = DockStyle.Fill;
            lblSolicitud.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSolicitud.ForeColor = Color.FromArgb(24, 55, 44);
            lblSolicitud.Location = new Point(17, 394);
            lblSolicitud.Name = "lblSolicitud";
            lblSolicitud.Size = new Size(78, 64);
            lblSolicitud.TabIndex = 13;
            lblSolicitud.Text = "Solicitud";
            lblSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSolicitud
            // 
            txtSolicitud.Dock = DockStyle.Fill;
            txtSolicitud.Font = new Font("Segoe UI", 9.5F);
            txtSolicitud.Location = new Point(103, 401);
            txtSolicitud.Margin = new Padding(5, 7, 5, 7);
            txtSolicitud.Name = "txtSolicitud";
            txtSolicitud.ReadOnly = true;
            txtSolicitud.Size = new Size(144, 29);
            txtSolicitud.TabIndex = 14;
            // 
            // lblExtension
            // 
            lblExtension.Dock = DockStyle.Fill;
            lblExtension.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExtension.ForeColor = Color.FromArgb(24, 55, 44);
            lblExtension.Location = new Point(17, 458);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(78, 66);
            lblExtension.TabIndex = 15;
            lblExtension.Text = "Extensión";
            lblExtension.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbExtension
            // 
            cmbExtension.Dock = DockStyle.Fill;
            cmbExtension.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExtension.Location = new Point(103, 465);
            cmbExtension.Margin = new Padding(5, 7, 5, 7);
            cmbExtension.Name = "cmbExtension";
            cmbExtension.Size = new Size(144, 33);
            cmbExtension.TabIndex = 16;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(255, 77);
            button3.Name = "button3";
            button3.Size = new Size(41, 39);
            button3.TabIndex = 17;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button14);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(1198, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 445);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.BackColor = Color.FromArgb(230, 238, 235);
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(9, 86);
            button6.Name = "button6";
            button6.Size = new Size(189, 66);
            button6.TabIndex = 52;
            button6.Text = "Actualizar";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Top;
            button14.BackColor = Color.FromArgb(230, 238, 235);
            button14.Cursor = Cursors.Hand;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button14.ForeColor = Color.Black;
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.TopCenter;
            button14.Location = new Point(9, 287);
            button14.Name = "button14";
            button14.Size = new Size(189, 66);
            button14.TabIndex = 53;
            button14.Text = "Limpiar";
            button14.TextAlign = ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.FromArgb(230, 238, 235);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(9, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 66);
            btnDelete.TabIndex = 51;
            btnDelete.Text = "Eliminar ";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmMultimedia
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1420, 940);
            Controls.Add(tlpMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMultimedia";
            Text = "frmMultimedia";
            WindowState = FormWindowState.Maximized;
            Load += frmMultimedia_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tlpMain.ResumeLayout(false);
            grpVistaPrevia.ResumeLayout(false);
            grpVistaPrevia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVistaPrevia).EndInit();
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMultimedia).EndInit();
            pnlListadoTop.ResumeLayout(false);
            pnlListadoTop.PerformLayout();
            grpInformacion.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private TableLayoutPanel tlpMain;
        private GroupBox grpInformacion;
        private TableLayoutPanel tlpCampos;
        private Label lblId;
        private TextBox txtIdMultimedia;
        private Label lblArchivo;
        private TextBox txtArchivo;
        private Label lblRuta;
        private TextBox txtRuta;
        private Label lblTamano;
        private TextBox txtTamano;
        private Label lblFecha;
        private DateTimePicker dtpFechaAdjuncion;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSolicitud;
        private TextBox txtSolicitud;
        private Label lblExtension;
        private ComboBox cmbExtension;
        private GroupBox groupBox1;
        private Button button6;
        private Button button14;
        private Button btnDelete;
        private GroupBox groupBox2;
        private GroupBox grpListado;
        private DataGridView dgvMultimedia;
        private DataGridViewTextBoxColumn colIdMultimedia;
        private DataGridViewTextBoxColumn colArchivo;
        private DataGridViewTextBoxColumn colTamañoArchivo;
        private DataGridViewTextBoxColumn colRutaArchivo;
        private DataGridViewTextBoxColumn colFechaAdjunción;
        private DataGridViewTextBoxColumn colIdSolicitud;
        private DataGridViewTextBoxColumn colNombreUsuario;
        private DataGridViewTextBoxColumn colExtension;
        private Panel pnlListadoTop;
        private Button button1;
        private TextBox txtBuscar;
        private GroupBox grpVistaPrevia;
        private PictureBox picVistaPrevia;
        private Label lblSinVistaPrevia;
        private Button button3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label lblVistaPrevia;
    }
}