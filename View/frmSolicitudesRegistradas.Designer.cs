namespace View
{
    partial class frmSolicitudesRegistradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudesRegistradas));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderIcon = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblMensajeAmbiental = new Label();
            tlpPrincipal = new TableLayoutPanel();
            pnlBusqueda = new Panel();
            button1 = new Button();
            txtBuscarId = new TextBox();
            tlpSuperior = new TableLayoutPanel();
            grpInformacion = new GroupBox();
            tlpCampos = new TableLayoutPanel();
            lbNombreUsuario = new Label();
            lblIdSolicitud = new Label();
            txtIdSolicitud = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblFechaSolicitud = new Label();
            txtFechaSolicitud = new TextBox();
            lblFechaResolucion = new Label();
            txtFechaResolucion = new TextBox();
            lblTipoSitio = new Label();
            txtTipoSitio = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            txtNombreUsuario = new TextBox();
            grpAcciones = new GroupBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            grpListado = new GroupBox();
            dgvSolicitudes = new DataGridView();
            colIdSolicitud = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colFechaSolicitud = new DataGridViewTextBoxColumn();
            colFechaResolucion = new DataGridViewTextBoxColumn();
            colTipoSitio = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colNombreUsuario = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            pnlFooter = new Panel();
            lblRegistros = new Label();
            lblFooterMensaje = new Label();
            pnlHeader.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            tlpSuperior.SuspendLayout();
            grpInformacion.SuspendLayout();
            tlpCampos.SuspendLayout();
            grpAcciones.SuspendLayout();
            groupBox1.SuspendLayout();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            pnlListadoHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
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
            pnlHeader.Size = new Size(1420, 96);
            pnlHeader.TabIndex = 2;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.Font = new Font("Segoe UI Symbol", 31F, FontStyle.Bold);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(25, 13);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(80, 70);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Text = "☷";
            lblHeaderIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(112, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(402, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de solicitudes";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(232, 243, 226);
            lblSubtitulo.Location = new Point(115, 57);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(583, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Revisa y gestiona las solicitudes realizadas por los usuarios en el sistema";
            // 
            // lblMensajeAmbiental
            // 
            lblMensajeAmbiental.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMensajeAmbiental.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblMensajeAmbiental.ForeColor = Color.White;
            lblMensajeAmbiental.Location = new Point(3720, 18);
            lblMensajeAmbiental.Name = "lblMensajeAmbiental";
            lblMensajeAmbiental.Size = new Size(230, 56);
            lblMensajeAmbiental.TabIndex = 3;
            lblMensajeAmbiental.Text = "Gestión responsable,\ncomunidad sostenible";
            lblMensajeAmbiental.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(pnlBusqueda, 0, 0);
            tlpPrincipal.Controls.Add(tlpSuperior, 0, 1);
            tlpPrincipal.Controls.Add(grpListado, 0, 2);
            tlpPrincipal.Controls.Add(pnlFooter, 0, 3);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 96);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(18, 14, 18, 8);
            tlpPrincipal.RowCount = 4;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpPrincipal.Size = new Size(1420, 844);
            tlpPrincipal.TabIndex = 3;
            tlpPrincipal.Paint += tlpPrincipal_Paint;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.FromArgb(246, 248, 243);
            pnlBusqueda.Controls.Add(button1);
            pnlBusqueda.Controls.Add(txtBuscarId);
            pnlBusqueda.Dock = DockStyle.Fill;
            pnlBusqueda.Location = new Point(21, 17);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1378, 56);
            pnlBusqueda.TabIndex = 0;
            pnlBusqueda.Paint += pnlBusqueda_Paint;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(462, 4);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtBuscarId
            // 
            txtBuscarId.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarId.Font = new Font("Segoe UI", 9.5F);
            txtBuscarId.Location = new Point(15, 13);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.PlaceholderText = "Ingresa el ID de la solicitud que deseas buscar";
            txtBuscarId.Size = new Size(430, 29);
            txtBuscarId.TabIndex = 0;
            // 
            // tlpSuperior
            // 
            tlpSuperior.ColumnCount = 2;
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpSuperior.Controls.Add(grpInformacion, 0, 0);
            tlpSuperior.Controls.Add(grpAcciones, 1, 0);
            tlpSuperior.Dock = DockStyle.Fill;
            tlpSuperior.Location = new Point(21, 79);
            tlpSuperior.Name = "tlpSuperior";
            tlpSuperior.RowCount = 1;
            tlpSuperior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSuperior.Size = new Size(1378, 254);
            tlpSuperior.TabIndex = 1;
            // 
            // grpInformacion
            // 
            grpInformacion.BackColor = Color.FromArgb(227, 235, 216);
            grpInformacion.Controls.Add(tlpCampos);
            grpInformacion.Dock = DockStyle.Fill;
            grpInformacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInformacion.ForeColor = Color.FromArgb(48, 75, 48);
            grpInformacion.Location = new Point(0, 0);
            grpInformacion.Margin = new Padding(0, 0, 9, 10);
            grpInformacion.Name = "grpInformacion";
            grpInformacion.Padding = new Padding(14);
            grpInformacion.Size = new Size(1065, 244);
            grpInformacion.TabIndex = 0;
            grpInformacion.TabStop = false;
            grpInformacion.Text = "▣  Información de la solicitud";
            // 
            // tlpCampos
            // 
            tlpCampos.ColumnCount = 4;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tlpCampos.Controls.Add(lbNombreUsuario, 0, 3);
            tlpCampos.Controls.Add(lblIdSolicitud, 0, 0);
            tlpCampos.Controls.Add(txtIdSolicitud, 1, 0);
            tlpCampos.Controls.Add(lblEstado, 2, 0);
            tlpCampos.Controls.Add(cmbEstado, 3, 0);
            tlpCampos.Controls.Add(lblFechaSolicitud, 0, 1);
            tlpCampos.Controls.Add(txtFechaSolicitud, 1, 1);
            tlpCampos.Controls.Add(lblFechaResolucion, 2, 1);
            tlpCampos.Controls.Add(txtFechaResolucion, 3, 1);
            tlpCampos.Controls.Add(lblTipoSitio, 0, 2);
            tlpCampos.Controls.Add(txtTipoSitio, 1, 2);
            tlpCampos.Controls.Add(lblDireccion, 2, 2);
            tlpCampos.Controls.Add(txtDireccion, 3, 2);
            tlpCampos.Controls.Add(txtNombreUsuario, 1, 3);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Font = new Font("Segoe UI", 9F);
            tlpCampos.Location = new Point(14, 39);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.RowCount = 4;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpCampos.Size = new Size(1037, 191);
            tlpCampos.TabIndex = 0;
            // 
            // lbNombreUsuario
            // 
            lbNombreUsuario.Location = new Point(3, 141);
            lbNombreUsuario.Name = "lbNombreUsuario";
            lbNombreUsuario.Size = new Size(139, 23);
            lbNombreUsuario.TabIndex = 13;
            lbNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblIdSolicitud
            // 
            lblIdSolicitud.Location = new Point(3, 0);
            lblIdSolicitud.Name = "lblIdSolicitud";
            lblIdSolicitud.Size = new Size(100, 23);
            lblIdSolicitud.TabIndex = 0;
            lblIdSolicitud.Text = "Id Solicitud";
            // 
            // txtIdSolicitud
            // 
            txtIdSolicitud.Dock = DockStyle.Fill;
            txtIdSolicitud.Location = new Point(148, 3);
            txtIdSolicitud.Name = "txtIdSolicitud";
            txtIdSolicitud.ReadOnly = true;
            txtIdSolicitud.Size = new Size(367, 27);
            txtIdSolicitud.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(521, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.Dock = DockStyle.Fill;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Segoe UI", 9F);
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Aprobada", "Rechazada" });
            cmbEstado.Location = new Point(669, 13);
            cmbEstado.Margin = new Padding(6, 13, 8, 13);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(360, 28);
            cmbEstado.TabIndex = 3;
            // 
            // lblFechaSolicitud
            // 
            lblFechaSolicitud.Location = new Point(3, 47);
            lblFechaSolicitud.Name = "lblFechaSolicitud";
            lblFechaSolicitud.Size = new Size(139, 23);
            lblFechaSolicitud.TabIndex = 4;
            lblFechaSolicitud.Text = "Fecha Solicitud";
            // 
            // txtFechaSolicitud
            // 
            txtFechaSolicitud.Dock = DockStyle.Fill;
            txtFechaSolicitud.Location = new Point(148, 50);
            txtFechaSolicitud.Name = "txtFechaSolicitud";
            txtFechaSolicitud.ReadOnly = true;
            txtFechaSolicitud.Size = new Size(367, 27);
            txtFechaSolicitud.TabIndex = 5;
            // 
            // lblFechaResolucion
            // 
            lblFechaResolucion.Location = new Point(521, 47);
            lblFechaResolucion.Name = "lblFechaResolucion";
            lblFechaResolucion.Size = new Size(139, 23);
            lblFechaResolucion.TabIndex = 6;
            lblFechaResolucion.Text = "Fecha Resolución";
            // 
            // txtFechaResolucion
            // 
            txtFechaResolucion.Dock = DockStyle.Fill;
            txtFechaResolucion.Location = new Point(666, 50);
            txtFechaResolucion.Name = "txtFechaResolucion";
            txtFechaResolucion.ReadOnly = true;
            txtFechaResolucion.Size = new Size(368, 27);
            txtFechaResolucion.TabIndex = 7;
            txtFechaResolucion.TextChanged += txtFechaResolucion_TextChanged;
            // 
            // lblTipoSitio
            // 
            lblTipoSitio.Location = new Point(3, 94);
            lblTipoSitio.Name = "lblTipoSitio";
            lblTipoSitio.Size = new Size(100, 23);
            lblTipoSitio.TabIndex = 8;
            lblTipoSitio.Text = "Tipo de Sitio";
            // 
            // txtTipoSitio
            // 
            txtTipoSitio.Dock = DockStyle.Fill;
            txtTipoSitio.Location = new Point(148, 97);
            txtTipoSitio.Name = "txtTipoSitio";
            txtTipoSitio.ReadOnly = true;
            txtTipoSitio.Size = new Size(367, 27);
            txtTipoSitio.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(521, 94);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(100, 23);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Dock = DockStyle.Fill;
            txtDireccion.Location = new Point(666, 97);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(368, 27);
            txtDireccion.TabIndex = 11;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Dock = DockStyle.Fill;
            txtNombreUsuario.Location = new Point(148, 144);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(367, 27);
            txtNombreUsuario.TabIndex = 12;
            // 
            // grpAcciones
            // 
            grpAcciones.BackColor = Color.FromArgb(227, 235, 216);
            grpAcciones.Controls.Add(groupBox1);
            grpAcciones.Dock = DockStyle.Fill;
            grpAcciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpAcciones.ForeColor = Color.FromArgb(48, 75, 48);
            grpAcciones.Location = new Point(1083, 0);
            grpAcciones.Margin = new Padding(9, 0, 0, 10);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Padding = new Padding(12);
            grpAcciones.Size = new Size(295, 244);
            grpAcciones.TabIndex = 1;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "⚙  Acciones";
            grpAcciones.Enter += grpAcciones_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(45, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 203);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(16, 111);
            button4.Name = "button4";
            button4.Size = new Size(83, 75);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(109, 111);
            button3.Name = "button3";
            button3.Size = new Size(83, 75);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(109, 26);
            button2.Name = "button2";
            button2.Size = new Size(83, 75);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(16, 26);
            button5.Name = "button5";
            button5.Size = new Size(83, 75);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.FromArgb(227, 235, 216);
            grpListado.Controls.Add(dgvSolicitudes);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(48, 75, 48);
            grpListado.Location = new Point(18, 336);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(1384, 458);
            grpListado.TabIndex = 2;
            grpListado.TabStop = false;
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(249, 251, 247);
            dgvSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.BackgroundColor = Color.White;
            dgvSolicitudes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(227, 237, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 75, 48);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(227, 237, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(48, 75, 48);
            dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSolicitudes.ColumnHeadersHeight = 38;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { colIdSolicitud, colEstado, colFechaSolicitud, colFechaResolucion, colTipoSitio, colDireccion, colNombreUsuario });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.6F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(48, 75, 48);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(213, 232, 202);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(48, 75, 48);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSolicitudes.Dock = DockStyle.Fill;
            dgvSolicitudes.EnableHeadersVisualStyles = false;
            dgvSolicitudes.GridColor = Color.FromArgb(222, 229, 217);
            dgvSolicitudes.Location = new Point(10, 90);
            dgvSolicitudes.MultiSelect = false;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersWidth = 28;
            dgvSolicitudes.RowTemplate.Height = 33;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.Size = new Size(1364, 358);
            dgvSolicitudes.TabIndex = 0;
            // 
            // colIdSolicitud
            // 
            colIdSolicitud.FillWeight = 70F;
            colIdSolicitud.HeaderText = "ID Solicitud";
            colIdSolicitud.MinimumWidth = 6;
            colIdSolicitud.Name = "colIdSolicitud";
            colIdSolicitud.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.FillWeight = 80F;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colFechaSolicitud
            // 
            colFechaSolicitud.HeaderText = "Fecha Solicitud";
            colFechaSolicitud.MinimumWidth = 6;
            colFechaSolicitud.Name = "colFechaSolicitud";
            colFechaSolicitud.ReadOnly = true;
            // 
            // colFechaResolucion
            // 
            colFechaResolucion.HeaderText = "Fecha Resolución";
            colFechaResolucion.MinimumWidth = 6;
            colFechaResolucion.Name = "colFechaResolucion";
            colFechaResolucion.ReadOnly = true;
            // 
            // colTipoSitio
            // 
            colTipoSitio.FillWeight = 115F;
            colTipoSitio.HeaderText = "Tipo de sitio";
            colTipoSitio.MinimumWidth = 6;
            colTipoSitio.Name = "colTipoSitio";
            colTipoSitio.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.FillWeight = 160F;
            colDireccion.HeaderText = "Dirección";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colNombreUsuario
            // 
            colNombreUsuario.FillWeight = 120F;
            colNombreUsuario.HeaderText = "Nombre del usuario";
            colNombreUsuario.MinimumWidth = 6;
            colNombreUsuario.Name = "colNombreUsuario";
            colNombreUsuario.ReadOnly = true;
            // 
            // pnlListadoHeader
            // 
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Dock = DockStyle.Top;
            pnlListadoHeader.Location = new Point(10, 35);
            pnlListadoHeader.Name = "pnlListadoHeader";
            pnlListadoHeader.Size = new Size(1364, 55);
            pnlListadoHeader.TabIndex = 1;
            // 
            // lblListadoIcon
            // 
            lblListadoIcon.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold);
            lblListadoIcon.ForeColor = Color.FromArgb(67, 107, 51);
            lblListadoIcon.Location = new Point(3, 7);
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
            lblListadoTitulo.ForeColor = Color.FromArgb(48, 75, 48);
            lblListadoTitulo.Location = new Point(52, 13);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(226, 28);
            lblListadoTitulo.TabIndex = 1;
            lblListadoTitulo.Text = "Solicitudes registradas";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(246, 248, 243);
            pnlFooter.Controls.Add(lblRegistros);
            pnlFooter.Controls.Add(lblFooterMensaje);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(21, 805);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1378, 28);
            pnlFooter.TabIndex = 3;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Font = new Font("Segoe UI", 8.5F);
            lblRegistros.ForeColor = Color.FromArgb(48, 75, 48);
            lblRegistros.Location = new Point(5, 8);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(188, 20);
            lblRegistros.TabIndex = 0;
            lblRegistros.Text = "0 solicitud(es) registrada(s)";
            // 
            // lblFooterMensaje
            // 
            lblFooterMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFooterMensaje.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblFooterMensaje.ForeColor = Color.FromArgb(67, 107, 51);
            lblFooterMensaje.Location = new Point(3526, 6);
            lblFooterMensaje.Name = "lblFooterMensaje";
            lblFooterMensaje.Size = new Size(310, 22);
            lblFooterMensaje.TabIndex = 1;
            lblFooterMensaje.Text = "🌿  Eco Community · Gestión responsable";
            lblFooterMensaje.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmSolicitudesRegistradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 940);
            Controls.Add(tlpPrincipal);
            Controls.Add(pnlHeader);
            Name = "frmSolicitudesRegistradas";
            Text = "frmSolicitudesRegistradas";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            tlpSuperior.ResumeLayout(false);
            grpInformacion.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            grpAcciones.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            pnlListadoHeader.ResumeLayout(false);
            pnlListadoHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderIcon;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblMensajeAmbiental;
        private TableLayoutPanel tlpPrincipal;
        private Panel pnlBusqueda;
        private TextBox txtBuscarId;
        private TableLayoutPanel tlpSuperior;
        private GroupBox grpInformacion;
        private TableLayoutPanel tlpCampos;
        private Label lblIdSolicitud;
        private TextBox txtIdSolicitud;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblFechaSolicitud;
        private TextBox txtFechaSolicitud;
        private Label lblFechaResolucion;
        private TextBox txtFechaResolucion;
        private Label lblTipoSitio;
        private TextBox txtTipoSitio;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private GroupBox grpAcciones;
        private GroupBox grpListado;
        private DataGridView dgvSolicitudes;
        private Panel pnlListadoHeader;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private Panel pnlFooter;
        private Label lblRegistros;
        private Label lblFooterMensaje;
        private Button button1;
        private Label lbNombreUsuario;
        private TextBox txtNombreUsuario;
        private DataGridViewTextBoxColumn colIdSolicitud;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFechaSolicitud;
        private DataGridViewTextBoxColumn colFechaResolucion;
        private DataGridViewTextBoxColumn colTipoSitio;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colNombreUsuario;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
    }
}