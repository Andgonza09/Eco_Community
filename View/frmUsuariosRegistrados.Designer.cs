namespace View
{
    partial class frmUsuariosRegistrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosRegistrados));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderIcon = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblMensajeAmbiental = new Label();
            txtSearchId = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            pnlFooter = new Panel();
            lblRegistros = new Label();
            lblFooterMensaje = new Label();
            grpListado = new GroupBox();
            dgvUsuarios = new DataGridView();
            colIdUsuario = new DataGridViewTextBoxColumn();
            colNombreUsuario = new DataGridViewTextBoxColumn();
            colContrasena = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colFechaRegistro = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            txtBuscarId = new TextBox();
            tlpSuperior = new TableLayoutPanel();
            grpDatos = new GroupBox();
            tlpCampos = new TableLayoutPanel();
            lbNombreUsuario = new Label();
            txtNameUsuario = new TextBox();
            lbcorreoUsuario = new Label();
            txtCorreo = new TextBox();
            lbRol = new Label();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            comboBox1 = new ComboBox();
            grpAcciones = new GroupBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button8 = new Button();
            button14 = new Button();
            btnDelete = new Button();
            tlpPrincipal = new TableLayoutPanel();
            pnlHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlFooter.SuspendLayout();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlListadoHeader.SuspendLayout();
            tlpSuperior.SuspendLayout();
            grpDatos.SuspendLayout();
            tlpCampos.SuspendLayout();
            grpAcciones.SuspendLayout();
            groupBox2.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(7, 80, 51);
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
            lblHeaderIcon.Font = new Font("Segoe UI Emoji", 31F);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(24, 12);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(78, 70);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Text = "👥";
            lblHeaderIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(112, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(362, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de usuarios";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(232, 243, 226);
            lblSubtitulo.Location = new Point(115, 57);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(598, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Conoce y gestiona la información ingresada por los usuarios en el sistema";
            // 
            // lblMensajeAmbiental
            // 
            lblMensajeAmbiental.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMensajeAmbiental.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblMensajeAmbiental.ForeColor = Color.White;
            lblMensajeAmbiental.Location = new Point(3665, 19);
            lblMensajeAmbiental.Name = "lblMensajeAmbiental";
            lblMensajeAmbiental.Size = new Size(225, 56);
            lblMensajeAmbiental.TabIndex = 3;
            lblMensajeAmbiental.Text = "Usuarios seguros,\ncomunidad sostenible";
            lblMensajeAmbiental.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(54, 19);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Ingresa el ID del usuario que deseas buscar";
            txtSearchId.Size = new Size(389, 27);
            txtSearchId.TabIndex = 1;
            txtSearchId.TextChanged += txtSearchId_TextChanged;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(460, 8);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSearchId);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1420, 65);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(246, 248, 243);
            pnlFooter.Controls.Add(lblRegistros);
            pnlFooter.Controls.Add(lblFooterMensaje);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.Location = new Point(21, 740);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1378, 28);
            pnlFooter.TabIndex = 2;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Font = new Font("Segoe UI", 8.5F);
            lblRegistros.ForeColor = Color.FromArgb(48, 75, 48);
            lblRegistros.Location = new Point(5, 8);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(173, 20);
            lblRegistros.TabIndex = 0;
            lblRegistros.Text = "0 usuario(s) registrado(s)";
            lblRegistros.Click += lblRegistros_Click;
            // 
            // lblFooterMensaje
            // 
            lblFooterMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFooterMensaje.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblFooterMensaje.ForeColor = Color.FromArgb(67, 107, 51);
            lblFooterMensaje.Location = new Point(3456, 6);
            lblFooterMensaje.Name = "lblFooterMensaje";
            lblFooterMensaje.Size = new Size(310, 22);
            lblFooterMensaje.TabIndex = 1;
            lblFooterMensaje.Text = "🌿  Eco Community · Gestión responsable";
            lblFooterMensaje.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.White;
            grpListado.Controls.Add(dgvUsuarios);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(48, 75, 48);
            grpListado.Location = new Point(18, 264);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(1384, 465);
            grpListado.TabIndex = 1;
            grpListado.TabStop = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 80, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 38;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colIdUsuario, colNombreUsuario, colContrasena, colCorreo, colFechaRegistro, colRol });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(222, 229, 217);
            dgvUsuarios.Location = new Point(10, 90);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 28;
            dgvUsuarios.RowTemplate.Height = 33;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1364, 365);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // colIdUsuario
            // 
            colIdUsuario.FillWeight = 65F;
            colIdUsuario.HeaderText = "ID Usuario";
            colIdUsuario.MinimumWidth = 6;
            colIdUsuario.Name = "colIdUsuario";
            colIdUsuario.ReadOnly = true;
            // 
            // colNombreUsuario
            // 
            colNombreUsuario.FillWeight = 115F;
            colNombreUsuario.HeaderText = "Nombre de usuario";
            colNombreUsuario.MinimumWidth = 6;
            colNombreUsuario.Name = "colNombreUsuario";
            colNombreUsuario.ReadOnly = true;
            // 
            // colContrasena
            // 
            colContrasena.FillWeight = 105F;
            colContrasena.HeaderText = "Contraseña";
            colContrasena.MinimumWidth = 6;
            colContrasena.Name = "colContrasena";
            colContrasena.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.FillWeight = 160F;
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // colFechaRegistro
            // 
            colFechaRegistro.HeaderText = "Fecha de registro";
            colFechaRegistro.MinimumWidth = 6;
            colFechaRegistro.Name = "colFechaRegistro";
            colFechaRegistro.ReadOnly = true;
            // 
            // colRol
            // 
            colRol.HeaderText = "Rol";
            colRol.MinimumWidth = 6;
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            // 
            // pnlListadoHeader
            // 
            pnlListadoHeader.BackColor = Color.White;
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Controls.Add(txtBuscarId);
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
            lblListadoTitulo.ForeColor = Color.Black;
            lblListadoTitulo.Location = new Point(52, 13);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(205, 28);
            lblListadoTitulo.TabIndex = 1;
            lblListadoTitulo.Text = "Usuarios registrados";
            // 
            // txtBuscarId
            // 
            txtBuscarId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarId.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarId.Font = new Font("Segoe UI", 9F);
            txtBuscarId.Location = new Point(3438, 12);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.PlaceholderText = "Buscar por ID de usuario...";
            txtBuscarId.Size = new Size(300, 27);
            txtBuscarId.TabIndex = 2;
            // 
            // tlpSuperior
            // 
            tlpSuperior.ColumnCount = 2;
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpSuperior.Controls.Add(grpDatos, 0, 0);
            tlpSuperior.Controls.Add(grpAcciones, 1, 0);
            tlpSuperior.Dock = DockStyle.Fill;
            tlpSuperior.Location = new Point(21, 17);
            tlpSuperior.Name = "tlpSuperior";
            tlpSuperior.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSuperior.Size = new Size(1378, 244);
            tlpSuperior.TabIndex = 0;
            tlpSuperior.Paint += tlpSuperior_Paint;
            // 
            // grpDatos
            // 
            grpDatos.BackColor = Color.White;
            grpDatos.Controls.Add(tlpCampos);
            grpDatos.Dock = DockStyle.Fill;
            grpDatos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDatos.ForeColor = Color.Black;
            grpDatos.Location = new Point(0, 0);
            grpDatos.Margin = new Padding(0, 0, 9, 10);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(14);
            grpDatos.Size = new Size(1065, 234);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "👤  Información del usuario";
            grpDatos.Enter += grpDatos_Enter;
            // 
            // tlpCampos
            // 
            tlpCampos.BackColor = Color.White;
            tlpCampos.ColumnCount = 4;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tlpCampos.Controls.Add(lbNombreUsuario, 0, 0);
            tlpCampos.Controls.Add(txtNameUsuario, 1, 0);
            tlpCampos.Controls.Add(lbcorreoUsuario, 0, 1);
            tlpCampos.Controls.Add(txtCorreo, 1, 1);
            tlpCampos.Controls.Add(lbRol, 2, 1);
            tlpCampos.Controls.Add(lblContrasena, 2, 0);
            tlpCampos.Controls.Add(txtContrasena, 3, 0);
            tlpCampos.Controls.Add(comboBox1, 3, 1);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Font = new Font("Segoe UI", 9F);
            tlpCampos.Location = new Point(14, 39);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.RowCount = 2;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tlpCampos.Size = new Size(1037, 181);
            tlpCampos.TabIndex = 0;
            // 
            // lbNombreUsuario
            // 
            lbNombreUsuario.Location = new Point(3, 0);
            lbNombreUsuario.Name = "lbNombreUsuario";
            lbNombreUsuario.Size = new Size(139, 23);
            lbNombreUsuario.TabIndex = 0;
            lbNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNameUsuario
            // 
            txtNameUsuario.Dock = DockStyle.Fill;
            txtNameUsuario.Location = new Point(148, 3);
            txtNameUsuario.Name = "txtNameUsuario";
            txtNameUsuario.Size = new Size(367, 27);
            txtNameUsuario.TabIndex = 1;
            // 
            // lbcorreoUsuario
            // 
            lbcorreoUsuario.Location = new Point(3, 90);
            lbcorreoUsuario.Name = "lbcorreoUsuario";
            lbcorreoUsuario.Size = new Size(100, 23);
            lbcorreoUsuario.TabIndex = 4;
            lbcorreoUsuario.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Dock = DockStyle.Fill;
            txtCorreo.Location = new Point(148, 93);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(367, 27);
            txtCorreo.TabIndex = 5;
            // 
            // lbRol
            // 
            lbRol.Location = new Point(521, 90);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(139, 23);
            lbRol.TabIndex = 6;
            lbRol.Text = "Rol";
            // 
            // lblContrasena
            // 
            lblContrasena.Location = new Point(521, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(100, 23);
            lblContrasena.TabIndex = 10;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Dock = DockStyle.Fill;
            txtContrasena.Location = new Point(666, 3);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(368, 27);
            txtContrasena.TabIndex = 11;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Usuario Estándar" });
            comboBox1.Location = new Point(666, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(368, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // grpAcciones
            // 
            grpAcciones.BackColor = Color.White;
            grpAcciones.Controls.Add(groupBox2);
            grpAcciones.Dock = DockStyle.Fill;
            grpAcciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpAcciones.ForeColor = Color.Black;
            grpAcciones.Location = new Point(1083, 0);
            grpAcciones.Margin = new Padding(9, 0, 0, 10);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Padding = new Padding(12);
            grpAcciones.Size = new Size(295, 234);
            grpAcciones.TabIndex = 1;
            grpAcciones.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button14);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(15, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 199);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(230, 238, 235);
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(135, 109);
            button6.Name = "button6";
            button6.Size = new Size(114, 66);
            button6.TabIndex = 49;
            button6.Text = "Actualizar";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(57, 115, 92);
            button8.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.Control;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.Location = new Point(15, 31);
            button8.Name = "button8";
            button8.Size = new Size(114, 66);
            button8.TabIndex = 47;
            button8.Text = "Guardar";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Right;
            button14.BackColor = Color.FromArgb(230, 238, 235);
            button14.Cursor = Cursors.Hand;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button14.ForeColor = Color.Black;
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.TopCenter;
            button14.Location = new Point(15, 109);
            button14.Name = "button14";
            button14.Size = new Size(114, 66);
            button14.TabIndex = 50;
            button14.Text = "Limpiar";
            button14.TextAlign = ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(230, 238, 235);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(135, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 66);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Eliminar ";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button7_Click;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(tlpSuperior, 0, 0);
            tlpPrincipal.Controls.Add(grpListado, 0, 1);
            tlpPrincipal.Controls.Add(pnlFooter, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 161);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(18, 14, 18, 8);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpPrincipal.Size = new Size(1420, 779);
            tlpPrincipal.TabIndex = 4;
            tlpPrincipal.Paint += tlpPrincipal_Paint;
            // 
            // frmUsuariosRegistrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 940);
            Controls.Add(tlpPrincipal);
            Controls.Add(groupBox1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmUsuariosRegistrados";
            Text = "frmUsuariosRegistrados";
            WindowState = FormWindowState.Maximized;
            Load += frmUsuariosRegistrados_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnlListadoHeader.ResumeLayout(false);
            pnlListadoHeader.PerformLayout();
            tlpSuperior.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            grpAcciones.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tlpPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderIcon;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblMensajeAmbiental;
        private TextBox txtSearchId;
        private Button button1;
        private GroupBox groupBox1;
        private Panel pnlFooter;
        private Label lblRegistros;
        private Label lblFooterMensaje;
        private GroupBox grpListado;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colIdUsuario;
        private DataGridViewTextBoxColumn colNombreUsuario;
        private DataGridViewTextBoxColumn colContrasena;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colFechaRegistro;
        private DataGridViewTextBoxColumn colRol;
        private Panel pnlListadoHeader;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private TextBox txtBuscarId;
        private TableLayoutPanel tlpSuperior;
        private GroupBox grpDatos;
        private TableLayoutPanel tlpCampos;
        private Label lbNombreUsuario;
        private TextBox txtNameUsuario;
        private Label lbcorreoUsuario;
        private TextBox txtCorreo;
        private Label lbRol;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private GroupBox grpAcciones;
        private TableLayoutPanel tlpPrincipal;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button button14;
        private Button button6;
        private Button btnDelete;
        private Button button8;
    }
}