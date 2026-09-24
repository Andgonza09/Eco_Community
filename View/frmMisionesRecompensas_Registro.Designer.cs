namespace View
{
    partial class frmMisionesRecompensas_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMisionesRecompensas_Registro));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblIcono = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            tlpPrincipal = new TableLayoutPanel();
            tlpSuperior = new TableLayoutPanel();
            grpMision = new GroupBox();
            tlpMision = new TableLayoutPanel();
            lblDescripcionMision = new Label();
            txtDescripcionMision = new TextBox();
            lblAyudaMision = new Label();
            lblPuntaje = new Label();
            nudPuntaje = new NumericUpDown();
            lblAyudaPuntaje = new Label();
            grpRecompensa = new GroupBox();
            tlpRecompensa = new TableLayoutPanel();
            lblDescripcionRecompensa = new Label();
            txtDescripcionRecompensa = new TextBox();
            lblAyudaRecompensa = new Label();
            lblTipoRecompensa = new Label();
            cmbTipoRecompensa = new ComboBox();
            lblAyudaTipo = new Label();
            grpAcciones = new GroupBox();
            groupBox2 = new GroupBox();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button15 = new Button();
            grpMisiones = new GroupBox();
            dgvMisiones = new DataGridView();
            colIdMision = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPuntaje = new DataGridViewTextBoxColumn();
            colRecompensa = new DataGridViewTextBoxColumn();
            colTipoRecompensa = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtSearchId = new TextBox();
            pnlHeader.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            tlpSuperior.SuspendLayout();
            grpMision.SuspendLayout();
            tlpMision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPuntaje).BeginInit();
            grpRecompensa.SuspendLayout();
            tlpRecompensa.SuspendLayout();
            grpAcciones.SuspendLayout();
            groupBox2.SuspendLayout();
            grpMisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMisiones).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(7, 80, 51);
            pnlHeader.Controls.Add(lblIcono);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1420, 108);
            pnlHeader.TabIndex = 2;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblIcono
            // 
            lblIcono.Font = new Font("Segoe UI Symbol", 34F, FontStyle.Bold);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(30, 18);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(80, 68);
            lblIcono.TabIndex = 0;
            lblIcono.Text = "♧";
            lblIcono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(118, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(533, 54);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Crear misión y recompensa";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(121, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(843, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Define una nueva misión y su recompensa asociada para motivar la participación de la comunidad.";
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(tlpSuperior, 0, 0);
            tlpPrincipal.Controls.Add(grpMisiones, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 173);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(16, 12, 16, 14);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 365F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(1420, 767);
            tlpPrincipal.TabIndex = 4;
            // 
            // tlpSuperior
            // 
            tlpSuperior.ColumnCount = 3;
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tlpSuperior.Controls.Add(grpMision, 0, 0);
            tlpSuperior.Controls.Add(grpRecompensa, 1, 0);
            tlpSuperior.Controls.Add(grpAcciones, 2, 0);
            tlpSuperior.Dock = DockStyle.Fill;
            tlpSuperior.Location = new Point(16, 12);
            tlpSuperior.Margin = new Padding(0, 0, 0, 10);
            tlpSuperior.Name = "tlpSuperior";
            tlpSuperior.RowCount = 1;
            tlpSuperior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSuperior.Size = new Size(1388, 355);
            tlpSuperior.TabIndex = 0;
            // 
            // grpMision
            // 
            grpMision.Controls.Add(tlpMision);
            grpMision.Dock = DockStyle.Fill;
            grpMision.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpMision.ForeColor = Color.Black;
            grpMision.Location = new Point(0, 0);
            grpMision.Margin = new Padding(0, 0, 8, 0);
            grpMision.Name = "grpMision";
            grpMision.Size = new Size(519, 355);
            grpMision.TabIndex = 0;
            grpMision.TabStop = false;
            grpMision.Text = "Información de la Misión";
            grpMision.Enter += grpMision_Enter;
            // 
            // tlpMision
            // 
            tlpMision.ColumnCount = 1;
            tlpMision.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMision.Controls.Add(lblDescripcionMision, 0, 0);
            tlpMision.Controls.Add(txtDescripcionMision, 0, 1);
            tlpMision.Controls.Add(lblAyudaMision, 0, 2);
            tlpMision.Controls.Add(lblPuntaje, 0, 3);
            tlpMision.Controls.Add(nudPuntaje, 0, 4);
            tlpMision.Controls.Add(lblAyudaPuntaje, 0, 5);
            tlpMision.Dock = DockStyle.Fill;
            tlpMision.Location = new Point(3, 28);
            tlpMision.Name = "tlpMision";
            tlpMision.Padding = new Padding(12, 7, 12, 10);
            tlpMision.RowCount = 6;
            tlpMision.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpMision.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            tlpMision.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMision.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpMision.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpMision.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tlpMision.Size = new Size(513, 324);
            tlpMision.TabIndex = 0;
            // 
            // lblDescripcionMision
            // 
            lblDescripcionMision.Font = new Font("Segoe UI", 10F);
            lblDescripcionMision.Location = new Point(15, 7);
            lblDescripcionMision.Name = "lblDescripcionMision";
            lblDescripcionMision.Size = new Size(230, 23);
            lblDescripcionMision.TabIndex = 0;
            lblDescripcionMision.Text = "Misión";
            // 
            // txtDescripcionMision
            // 
            txtDescripcionMision.Dock = DockStyle.Fill;
            txtDescripcionMision.Font = new Font("Segoe UI", 10F);
            txtDescripcionMision.Location = new Point(12, 35);
            txtDescripcionMision.Margin = new Padding(0, 0, 0, 4);
            txtDescripcionMision.Multiline = true;
            txtDescripcionMision.Name = "txtDescripcionMision";
            txtDescripcionMision.ScrollBars = ScrollBars.Vertical;
            txtDescripcionMision.Size = new Size(489, 148);
            txtDescripcionMision.TabIndex = 1;
            // 
            // lblAyudaMision
            // 
            lblAyudaMision.Location = new Point(15, 187);
            lblAyudaMision.Name = "lblAyudaMision";
            lblAyudaMision.Size = new Size(100, 23);
            lblAyudaMision.TabIndex = 2;
            // 
            // lblPuntaje
            // 
            lblPuntaje.Font = new Font("Segoe UI", 10F);
            lblPuntaje.Location = new Point(15, 217);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(100, 23);
            lblPuntaje.TabIndex = 3;
            lblPuntaje.Text = "Puntaje";
            // 
            // nudPuntaje
            // 
            nudPuntaje.Dock = DockStyle.Fill;
            nudPuntaje.Font = new Font("Segoe UI", 10F);
            nudPuntaje.Location = new Point(12, 248);
            nudPuntaje.Margin = new Padding(0, 3, 0, 3);
            nudPuntaje.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPuntaje.Name = "nudPuntaje";
            nudPuntaje.Size = new Size(489, 30);
            nudPuntaje.TabIndex = 4;
            // 
            // lblAyudaPuntaje
            // 
            lblAyudaPuntaje.Location = new Point(15, 283);
            lblAyudaPuntaje.Name = "lblAyudaPuntaje";
            lblAyudaPuntaje.Size = new Size(100, 23);
            lblAyudaPuntaje.TabIndex = 5;
            // 
            // grpRecompensa
            // 
            grpRecompensa.Controls.Add(tlpRecompensa);
            grpRecompensa.Dock = DockStyle.Fill;
            grpRecompensa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpRecompensa.ForeColor = Color.Black;
            grpRecompensa.Location = new Point(535, 0);
            grpRecompensa.Margin = new Padding(8, 0, 8, 0);
            grpRecompensa.Name = "grpRecompensa";
            grpRecompensa.Size = new Size(511, 355);
            grpRecompensa.TabIndex = 1;
            grpRecompensa.TabStop = false;
            grpRecompensa.Text = "Recompensa Asociada";
            // 
            // tlpRecompensa
            // 
            tlpRecompensa.ColumnCount = 1;
            tlpRecompensa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRecompensa.Controls.Add(lblDescripcionRecompensa, 0, 0);
            tlpRecompensa.Controls.Add(txtDescripcionRecompensa, 0, 1);
            tlpRecompensa.Controls.Add(lblAyudaRecompensa, 0, 2);
            tlpRecompensa.Controls.Add(lblTipoRecompensa, 0, 3);
            tlpRecompensa.Controls.Add(cmbTipoRecompensa, 0, 4);
            tlpRecompensa.Controls.Add(lblAyudaTipo, 0, 5);
            tlpRecompensa.Dock = DockStyle.Fill;
            tlpRecompensa.Location = new Point(3, 28);
            tlpRecompensa.Name = "tlpRecompensa";
            tlpRecompensa.Padding = new Padding(12, 7, 12, 10);
            tlpRecompensa.RowCount = 6;
            tlpRecompensa.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRecompensa.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            tlpRecompensa.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpRecompensa.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpRecompensa.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpRecompensa.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tlpRecompensa.Size = new Size(505, 324);
            tlpRecompensa.TabIndex = 0;
            // 
            // lblDescripcionRecompensa
            // 
            lblDescripcionRecompensa.Font = new Font("Segoe UI", 10F);
            lblDescripcionRecompensa.Location = new Point(15, 7);
            lblDescripcionRecompensa.Name = "lblDescripcionRecompensa";
            lblDescripcionRecompensa.Size = new Size(137, 23);
            lblDescripcionRecompensa.TabIndex = 0;
            lblDescripcionRecompensa.Text = "Recompensa";
            // 
            // txtDescripcionRecompensa
            // 
            txtDescripcionRecompensa.Dock = DockStyle.Fill;
            txtDescripcionRecompensa.Font = new Font("Segoe UI", 10F);
            txtDescripcionRecompensa.Location = new Point(12, 35);
            txtDescripcionRecompensa.Margin = new Padding(0, 0, 0, 4);
            txtDescripcionRecompensa.Multiline = true;
            txtDescripcionRecompensa.Name = "txtDescripcionRecompensa";
            txtDescripcionRecompensa.ScrollBars = ScrollBars.Vertical;
            txtDescripcionRecompensa.Size = new Size(481, 148);
            txtDescripcionRecompensa.TabIndex = 1;
            // 
            // lblAyudaRecompensa
            // 
            lblAyudaRecompensa.Location = new Point(15, 187);
            lblAyudaRecompensa.Name = "lblAyudaRecompensa";
            lblAyudaRecompensa.Size = new Size(100, 23);
            lblAyudaRecompensa.TabIndex = 2;
            // 
            // lblTipoRecompensa
            // 
            lblTipoRecompensa.Font = new Font("Segoe UI", 10F);
            lblTipoRecompensa.Location = new Point(15, 217);
            lblTipoRecompensa.Name = "lblTipoRecompensa";
            lblTipoRecompensa.Size = new Size(354, 23);
            lblTipoRecompensa.TabIndex = 3;
            lblTipoRecompensa.Text = "Tipo Recompensa";
            // 
            // cmbTipoRecompensa
            // 
            cmbTipoRecompensa.Dock = DockStyle.Fill;
            cmbTipoRecompensa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoRecompensa.FlatStyle = FlatStyle.Flat;
            cmbTipoRecompensa.Font = new Font("Segoe UI", 10F);
            cmbTipoRecompensa.Items.AddRange(new object[] { "Insignia", "Subida de nivel", "Logros", "Puntos adicionales" });
            cmbTipoRecompensa.Location = new Point(12, 248);
            cmbTipoRecompensa.Margin = new Padding(0, 3, 0, 3);
            cmbTipoRecompensa.Name = "cmbTipoRecompensa";
            cmbTipoRecompensa.Size = new Size(481, 31);
            cmbTipoRecompensa.TabIndex = 4;
            // 
            // lblAyudaTipo
            // 
            lblAyudaTipo.Location = new Point(15, 283);
            lblAyudaTipo.Name = "lblAyudaTipo";
            lblAyudaTipo.Size = new Size(100, 23);
            lblAyudaTipo.TabIndex = 5;
            // 
            // grpAcciones
            // 
            grpAcciones.Controls.Add(groupBox2);
            grpAcciones.Dock = DockStyle.Fill;
            grpAcciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpAcciones.ForeColor = Color.FromArgb(48, 75, 48);
            grpAcciones.Location = new Point(1062, 0);
            grpAcciones.Margin = new Padding(8, 0, 0, 0);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Size = new Size(326, 355);
            grpAcciones.TabIndex = 2;
            grpAcciones.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button15);
            groupBox2.Location = new Point(15, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 281);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Right;
            button9.BackColor = Color.FromArgb(230, 238, 235);
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(160, 137);
            button9.Name = "button9";
            button9.Size = new Size(122, 66);
            button9.TabIndex = 51;
            button9.Text = "Actualizar";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Right;
            button10.BackColor = Color.FromArgb(230, 238, 235);
            button10.Cursor = Cursors.Hand;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button10.ForeColor = Color.Black;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.Location = new Point(160, 56);
            button10.Name = "button10";
            button10.Size = new Size(122, 66);
            button10.TabIndex = 50;
            button10.Text = "Eliminar ";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(57, 115, 92);
            button11.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.Control;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.TopCenter;
            button11.Location = new Point(19, 55);
            button11.Name = "button11";
            button11.Size = new Size(122, 66);
            button11.TabIndex = 49;
            button11.Text = "Guardar";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Right;
            button15.BackColor = Color.FromArgb(230, 238, 235);
            button15.Cursor = Cursors.Hand;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button15.ForeColor = Color.Black;
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.ImageAlign = ContentAlignment.TopCenter;
            button15.Location = new Point(19, 137);
            button15.Name = "button15";
            button15.Size = new Size(122, 66);
            button15.TabIndex = 52;
            button15.Text = "Limpiar";
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // grpMisiones
            // 
            grpMisiones.Controls.Add(dgvMisiones);
            grpMisiones.Dock = DockStyle.Fill;
            grpMisiones.Location = new Point(16, 377);
            grpMisiones.Margin = new Padding(0);
            grpMisiones.Name = "grpMisiones";
            grpMisiones.Padding = new Padding(10, 27, 10, 10);
            grpMisiones.Size = new Size(1388, 376);
            grpMisiones.TabIndex = 1;
            grpMisiones.TabStop = false;
            grpMisiones.Enter += grpMisiones_Enter;
            // 
            // dgvMisiones
            // 
            dgvMisiones.AllowUserToAddRows = false;
            dgvMisiones.AllowUserToDeleteRows = false;
            dgvMisiones.AllowUserToResizeRows = false;
            dgvMisiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMisiones.BackgroundColor = SystemColors.Control;
            dgvMisiones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvMisiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMisiones.ColumnHeadersHeight = 38;
            dgvMisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMisiones.Columns.AddRange(new DataGridViewColumn[] { colIdMision, colDescripcion, colPuntaje, colRecompensa, colTipoRecompensa });
            dgvMisiones.Dock = DockStyle.Fill;
            dgvMisiones.EnableHeadersVisualStyles = false;
            dgvMisiones.GridColor = Color.White;
            dgvMisiones.Location = new Point(10, 47);
            dgvMisiones.MultiSelect = false;
            dgvMisiones.Name = "dgvMisiones";
            dgvMisiones.ReadOnly = true;
            dgvMisiones.RowHeadersWidth = 28;
            dgvMisiones.RowTemplate.Height = 30;
            dgvMisiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMisiones.Size = new Size(1368, 319);
            dgvMisiones.TabIndex = 0;
            dgvMisiones.CellContentClick += dgvMisiones_CellContentClick_1;
            // 
            // colIdMision
            // 
            colIdMision.FillWeight = 65F;
            colIdMision.HeaderText = "Id Misión";
            colIdMision.MinimumWidth = 6;
            colIdMision.Name = "colIdMision";
            colIdMision.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.FillWeight = 190F;
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPuntaje
            // 
            colPuntaje.FillWeight = 75F;
            colPuntaje.HeaderText = "Puntaje";
            colPuntaje.MinimumWidth = 6;
            colPuntaje.Name = "colPuntaje";
            colPuntaje.ReadOnly = true;
            // 
            // colRecompensa
            // 
            colRecompensa.FillWeight = 135F;
            colRecompensa.HeaderText = "Recompensa asociada";
            colRecompensa.MinimumWidth = 6;
            colRecompensa.Name = "colRecompensa";
            colRecompensa.ReadOnly = true;
            // 
            // colTipoRecompensa
            // 
            colTipoRecompensa.FillWeight = 110F;
            colTipoRecompensa.HeaderText = "Tipo de recompensa";
            colTipoRecompensa.MinimumWidth = 6;
            colTipoRecompensa.Name = "colTipoRecompensa";
            colTipoRecompensa.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSearchId);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1420, 65);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(460, 8);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(54, 19);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Ingresa el ID del Misión que deseas buscar";
            txtSearchId.Size = new Size(389, 27);
            txtSearchId.TabIndex = 1;
            // 
            // frmMisionesRecompensas_Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 940);
            Controls.Add(tlpPrincipal);
            Controls.Add(groupBox1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMisionesRecompensas_Registro";
            Text = "frmMisionesRecompensas_Registro";
            WindowState = FormWindowState.Maximized;
            Load += frmMisionesRecompensas_Registro_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpSuperior.ResumeLayout(false);
            grpMision.ResumeLayout(false);
            tlpMision.ResumeLayout(false);
            tlpMision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPuntaje).EndInit();
            grpRecompensa.ResumeLayout(false);
            tlpRecompensa.ResumeLayout(false);
            tlpRecompensa.PerformLayout();
            grpAcciones.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            grpMisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMisiones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblIcono;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpSuperior;
        private GroupBox grpMision;
        private TableLayoutPanel tlpMision;
        private Label lblDescripcionMision;
        private TextBox txtDescripcionMision;
        private Label lblAyudaMision;
        private Label lblPuntaje;
        private NumericUpDown nudPuntaje;
        private Label lblAyudaPuntaje;
        private GroupBox grpRecompensa;
        private TableLayoutPanel tlpRecompensa;
        private Label lblDescripcionRecompensa;
        private TextBox txtDescripcionRecompensa;
        private Label lblAyudaRecompensa;
        private Label lblTipoRecompensa;
        private ComboBox cmbTipoRecompensa;
        private Label lblAyudaTipo;
        private GroupBox grpAcciones;
        private GroupBox grpMisiones;
        private DataGridView dgvMisiones;
        private DataGridViewTextBoxColumn colIdMision;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPuntaje;
        private DataGridViewTextBoxColumn colRecompensa;
        private DataGridViewTextBoxColumn colTipoRecompensa;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtSearchId;
        private GroupBox groupBox2;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button15;
    }
}