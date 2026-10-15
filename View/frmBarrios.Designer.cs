namespace View
{
    partial class frmBarrios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarrios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderIcon = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            tlpSuperior = new TableLayoutPanel();
            grpInformacion = new GroupBox();
            tlpInformacion = new TableLayoutPanel();
            lblNombreBarrio = new Label();
            txtNombreBarrio = new TextBox();
            lblDistrito = new Label();
            cmbDistrito = new ComboBox();
            grpReferencia = new GroupBox();
            pnlReferencia = new Panel();
            lblReferenciaTexto = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnGuardar = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            grpListado = new GroupBox();
            dgvBarrios = new DataGridView();
            colIdBarrio = new DataGridViewTextBoxColumn();
            ColNombreBarrio = new DataGridViewTextBoxColumn();
            ColDistrito = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            tlpPrincipal = new TableLayoutPanel();
            pnlBusqueda = new Panel();
            btnSearch = new Button();
            txtSearchId = new TextBox();
            pnlHeader.SuspendLayout();
            tlpSuperior.SuspendLayout();
            grpInformacion.SuspendLayout();
            tlpInformacion.SuspendLayout();
            grpReferencia.SuspendLayout();
            pnlReferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarrios).BeginInit();
            pnlListadoHeader.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(7, 80, 51);
            pnlHeader.Controls.Add(lblHeaderIcon);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1420, 106);
            pnlHeader.TabIndex = 2;
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.Font = new Font("Segoe UI Symbol", 34F, FontStyle.Bold);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(36, 19);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(85, 72);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Text = "⌖";
            lblHeaderIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(127, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(387, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de barrios";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(139, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(507, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Administra los barrios asociados a cada distrito del sistema";
            // 
            // tlpSuperior
            // 
            tlpSuperior.ColumnCount = 3;
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8962555F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8962555F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2074928F));
            tlpSuperior.Controls.Add(grpInformacion, 0, 0);
            tlpSuperior.Controls.Add(grpReferencia, 1, 0);
            tlpSuperior.Controls.Add(groupBox2, 2, 0);
            tlpSuperior.Dock = DockStyle.Fill;
            tlpSuperior.Location = new Point(16, 70);
            tlpSuperior.Margin = new Padding(0, 0, 0, 10);
            tlpSuperior.Name = "tlpSuperior";
            tlpSuperior.RowCount = 1;
            tlpSuperior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSuperior.Size = new Size(1388, 305);
            tlpSuperior.TabIndex = 1;
            // 
            // grpInformacion
            // 
            grpInformacion.Controls.Add(tlpInformacion);
            grpInformacion.Location = new Point(0, 0);
            grpInformacion.Margin = new Padding(0, 0, 8, 0);
            grpInformacion.Name = "grpInformacion";
            grpInformacion.Size = new Size(518, 296);
            grpInformacion.TabIndex = 0;
            grpInformacion.TabStop = false;
            // 
            // tlpInformacion
            // 
            tlpInformacion.ColumnCount = 2;
            tlpInformacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpInformacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tlpInformacion.Controls.Add(lblNombreBarrio, 0, 0);
            tlpInformacion.Controls.Add(txtNombreBarrio, 1, 0);
            tlpInformacion.Controls.Add(lblDistrito, 0, 1);
            tlpInformacion.Controls.Add(cmbDistrito, 1, 1);
            tlpInformacion.Dock = DockStyle.Fill;
            tlpInformacion.Location = new Point(3, 23);
            tlpInformacion.Name = "tlpInformacion";
            tlpInformacion.Padding = new Padding(14, 10, 14, 16);
            tlpInformacion.RowCount = 2;
            tlpInformacion.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9925041F));
            tlpInformacion.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0075F));
            tlpInformacion.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpInformacion.Size = new Size(512, 270);
            tlpInformacion.TabIndex = 0;
            // 
            // lblNombreBarrio
            // 
            lblNombreBarrio.Dock = DockStyle.Fill;
            lblNombreBarrio.Location = new Point(17, 10);
            lblNombreBarrio.Name = "lblNombreBarrio";
            lblNombreBarrio.Size = new Size(148, 121);
            lblNombreBarrio.TabIndex = 2;
            lblNombreBarrio.Text = "Barrio";
            // 
            // txtNombreBarrio
            // 
            txtNombreBarrio.Dock = DockStyle.Fill;
            txtNombreBarrio.Location = new Point(176, 26);
            txtNombreBarrio.Margin = new Padding(8, 16, 0, 16);
            txtNombreBarrio.Name = "txtNombreBarrio";
            txtNombreBarrio.Size = new Size(322, 27);
            txtNombreBarrio.TabIndex = 3;
            // 
            // lblDistrito
            // 
            lblDistrito.Dock = DockStyle.Fill;
            lblDistrito.Location = new Point(17, 131);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(148, 123);
            lblDistrito.TabIndex = 4;
            lblDistrito.Text = "Distrito";
            // 
            // cmbDistrito
            // 
            cmbDistrito.BackColor = SystemColors.ControlLight;
            cmbDistrito.Dock = DockStyle.Fill;
            cmbDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrito.FlatStyle = FlatStyle.Flat;
            cmbDistrito.Items.AddRange(new object[] { "Distrito I", "Distrito II", "Distrito III", "Distrito IV", "Distrito V", "Distrito VI", "Distrito VII" });
            cmbDistrito.Location = new Point(176, 147);
            cmbDistrito.Margin = new Padding(8, 16, 0, 16);
            cmbDistrito.Name = "cmbDistrito";
            cmbDistrito.Size = new Size(322, 28);
            cmbDistrito.TabIndex = 5;
            // 
            // grpReferencia
            // 
            grpReferencia.Controls.Add(pnlReferencia);
            grpReferencia.Dock = DockStyle.Fill;
            grpReferencia.Location = new Point(534, 0);
            grpReferencia.Margin = new Padding(8, 0, 8, 0);
            grpReferencia.Name = "grpReferencia";
            grpReferencia.Size = new Size(510, 305);
            grpReferencia.TabIndex = 1;
            grpReferencia.TabStop = false;
            // 
            // pnlReferencia
            // 
            pnlReferencia.BackColor = Color.FromArgb(248, 250, 246);
            pnlReferencia.Controls.Add(lblReferenciaTexto);
            pnlReferencia.Controls.Add(pictureBox1);
            pnlReferencia.Dock = DockStyle.Fill;
            pnlReferencia.Location = new Point(3, 23);
            pnlReferencia.Name = "pnlReferencia";
            pnlReferencia.Size = new Size(504, 279);
            pnlReferencia.TabIndex = 0;
            // 
            // lblReferenciaTexto
            // 
            lblReferenciaTexto.Dock = DockStyle.Bottom;
            lblReferenciaTexto.Font = new Font("Segoe UI", 9.5F);
            lblReferenciaTexto.ForeColor = Color.FromArgb(76, 92, 73);
            lblReferenciaTexto.Location = new Point(0, 218);
            lblReferenciaTexto.Name = "lblReferenciaTexto";
            lblReferenciaTexto.Padding = new Padding(20, 8, 20, 0);
            lblReferenciaTexto.Size = new Size(504, 61);
            lblReferenciaTexto.TabIndex = 0;
            lblReferenciaTexto.Text = "Gestiona correctamente los barrios para mantener organizada la ubicación de los puntos ambientales.";
            lblReferenciaTexto.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(1066, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 293);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(230, 238, 235);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnUpdate.Location = new Point(164, 161);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 66);
            btnUpdate.TabIndex = 49;
            btnUpdate.Text = "Actualizar";
            btnUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(57, 115, 92);
            btnGuardar.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(33, 69);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 66);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(230, 238, 235);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.TopCenter;
            btnClear.Location = new Point(33, 161);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 66);
            btnClear.TabIndex = 50;
            btnClear.Text = "Limpiar";
            btnClear.TextAlign = ContentAlignment.BottomCenter;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
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
            btnDelete.Location = new Point(164, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 66);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Eliminar ";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.White;
            grpListado.Controls.Add(dgvBarrios);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(48, 75, 48);
            grpListado.Location = new Point(16, 385);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(1388, 427);
            grpListado.TabIndex = 2;
            grpListado.TabStop = false;
            // 
            // dgvBarrios
            // 
            dgvBarrios.AllowUserToAddRows = false;
            dgvBarrios.AllowUserToDeleteRows = false;
            dgvBarrios.AllowUserToResizeRows = false;
            dgvBarrios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarrios.BackgroundColor = Color.White;
            dgvBarrios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 80, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvBarrios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBarrios.ColumnHeadersHeight = 38;
            dgvBarrios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBarrios.Columns.AddRange(new DataGridViewColumn[] { colIdBarrio, ColNombreBarrio, ColDistrito });
            dgvBarrios.Dock = DockStyle.Fill;
            dgvBarrios.EnableHeadersVisualStyles = false;
            dgvBarrios.GridColor = Color.FromArgb(222, 229, 217);
            dgvBarrios.Location = new Point(10, 90);
            dgvBarrios.MultiSelect = false;
            dgvBarrios.Name = "dgvBarrios";
            dgvBarrios.ReadOnly = true;
            dgvBarrios.RowHeadersWidth = 28;
            dgvBarrios.RowTemplate.Height = 33;
            dgvBarrios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarrios.Size = new Size(1368, 327);
            dgvBarrios.TabIndex = 0;
            dgvBarrios.CellClick += dgvBarrios_CellClick;
            dgvBarrios.CellContentClick += dgvBarrios_CellContentClick;
            // 
            // colIdBarrio
            // 
            colIdBarrio.DataPropertyName = "id_Barrio";
            colIdBarrio.FillWeight = 65F;
            colIdBarrio.HeaderText = "ID Barrio";
            colIdBarrio.MinimumWidth = 6;
            colIdBarrio.Name = "colIdBarrio";
            colIdBarrio.ReadOnly = true;
            // 
            // ColNombreBarrio
            // 
            ColNombreBarrio.DataPropertyName = "nombre_Barrio";
            ColNombreBarrio.FillWeight = 115F;
            ColNombreBarrio.HeaderText = "Nombre del Barrio";
            ColNombreBarrio.MinimumWidth = 6;
            ColNombreBarrio.Name = "ColNombreBarrio";
            ColNombreBarrio.ReadOnly = true;
            // 
            // ColDistrito
            // 
            ColDistrito.DataPropertyName = "nombre_Distrito";
            ColDistrito.FillWeight = 65F;
            ColDistrito.HeaderText = "Distrito";
            ColDistrito.MinimumWidth = 6;
            ColDistrito.Name = "ColDistrito";
            ColDistrito.ReadOnly = true;
            // 
            // pnlListadoHeader
            // 
            pnlListadoHeader.BackColor = Color.White;
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Dock = DockStyle.Top;
            pnlListadoHeader.Location = new Point(10, 35);
            pnlListadoHeader.Name = "pnlListadoHeader";
            pnlListadoHeader.Size = new Size(1368, 55);
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
            lblListadoTitulo.Size = new Size(191, 28);
            lblListadoTitulo.TabIndex = 1;
            lblListadoTitulo.Text = "Barrios registrados";
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.White;
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(grpListado, 0, 2);
            tlpPrincipal.Controls.Add(pnlBusqueda, 0, 0);
            tlpPrincipal.Controls.Add(tlpSuperior, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 106);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(16, 10, 16, 14);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 315F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(1420, 834);
            tlpPrincipal.TabIndex = 3;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.Controls.Add(btnSearch);
            pnlBusqueda.Controls.Add(txtSearchId);
            pnlBusqueda.Dock = DockStyle.Fill;
            pnlBusqueda.Location = new Point(19, 13);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1382, 54);
            pnlBusqueda.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(416, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 48);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(10, 12);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Ingresa el nombre del barrio que deseas buscar";
            txtSearchId.Size = new Size(389, 27);
            txtSearchId.TabIndex = 2;
            // 
            // frmBarrios
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1420, 940);
            Controls.Add(tlpPrincipal);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmBarrios";
            Text = "frmBarrios";
            WindowState = FormWindowState.Maximized;
            Load += frmBarrios_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpSuperior.ResumeLayout(false);
            grpInformacion.ResumeLayout(false);
            tlpInformacion.ResumeLayout(false);
            tlpInformacion.PerformLayout();
            grpReferencia.ResumeLayout(false);
            pnlReferencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBarrios).EndInit();
            pnlListadoHeader.ResumeLayout(false);
            pnlListadoHeader.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderIcon;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private TableLayoutPanel tlpSuperior;
        private GroupBox grpInformacion;
        private TableLayoutPanel tlpInformacion;
        private Label lblNombreBarrio;
        private TextBox txtNombreBarrio;
        private Label lblDistrito;
        private ComboBox cmbDistrito;
        private GroupBox grpReferencia;
        private Panel pnlReferencia;
        private Label lblReferenciaTexto;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnGuardar;
        private Button btnClear;
        private Button btnDelete;
        private GroupBox grpListado;
        private DataGridView dgvBarrios;
        private DataGridViewTextBoxColumn colIdBarrio;
        private DataGridViewTextBoxColumn ColNombreBarrio;
        private DataGridViewTextBoxColumn ColDistrito;
        private Panel pnlListadoHeader;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private TableLayoutPanel tlpPrincipal;
        private Panel pnlBusqueda;
        private Button btnSearch;
        private TextBox txtSearchId;
    }
}