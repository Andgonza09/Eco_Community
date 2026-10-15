namespace View
{
    partial class frmTipoRecompensa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoRecompensa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnGuardar = new Button();
            btnClean = new Button();
            btnDelete = new Button();
            txtTipoRecompensa = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            grpListado = new GroupBox();
            dgvTipoRecompensa = new DataGridView();
            colIdTipoRecompensa = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            btnSearch = new Button();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            txtIdTipoRecompensa = new TextBox();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoRecompensa).BeginInit();
            pnlListadoHeader.SuspendLayout();
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
            pnlHeader.TabIndex = 6;
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
            lblTitulo.Size = new Size(658, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de tipo de recompensas";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(139, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(410, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Administra los residuos admitidos en el sistema";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(1420, 42);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(txtTipoRecompensa);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(971, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 792);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 525);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnClean);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(30, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 374);
            groupBox2.TabIndex = 4;
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
            btnUpdate.Location = new Point(47, 109);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(296, 66);
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
            btnGuardar.Location = new Point(47, 26);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(296, 66);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnClean
            // 
            btnClean.Anchor = AnchorStyles.Right;
            btnClean.BackColor = Color.FromArgb(230, 238, 235);
            btnClean.Cursor = Cursors.Hand;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnClean.ForeColor = Color.Black;
            btnClean.Image = (Image)resources.GetObject("btnClean.Image");
            btnClean.ImageAlign = ContentAlignment.TopCenter;
            btnClean.Location = new Point(47, 287);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(296, 66);
            btnClean.TabIndex = 50;
            btnClean.Text = "Limpiar";
            btnClean.TextAlign = ContentAlignment.BottomCenter;
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
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
            btnDelete.Location = new Point(47, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(296, 66);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Eliminar ";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtTipoRecompensa
            // 
            txtTipoRecompensa.Location = new Point(30, 115);
            txtTipoRecompensa.Name = "txtTipoRecompensa";
            txtTipoRecompensa.PlaceholderText = "Por ej: Insignia";
            txtTipoRecompensa.Size = new Size(393, 27);
            txtTipoRecompensa.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(334, 28);
            label2.TabIndex = 2;
            label2.Text = "Agregar / Editar tipo Recompensa";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(58, 14);
            label1.Name = "label1";
            label1.Size = new Size(387, 37);
            label1.TabIndex = 0;
            label1.Text = "Registro tipo de recompensa";
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.White;
            grpListado.Controls.Add(dgvTipoRecompensa);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(48, 75, 48);
            grpListado.Location = new Point(0, 148);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(971, 792);
            grpListado.TabIndex = 11;
            grpListado.TabStop = false;
            // 
            // dgvTipoRecompensa
            // 
            dgvTipoRecompensa.AllowUserToAddRows = false;
            dgvTipoRecompensa.AllowUserToDeleteRows = false;
            dgvTipoRecompensa.AllowUserToResizeRows = false;
            dgvTipoRecompensa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoRecompensa.BackgroundColor = Color.White;
            dgvTipoRecompensa.BorderStyle = BorderStyle.Fixed3D;
            dgvTipoRecompensa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 80, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvTipoRecompensa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTipoRecompensa.ColumnHeadersHeight = 38;
            dgvTipoRecompensa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTipoRecompensa.Columns.AddRange(new DataGridViewColumn[] { colIdTipoRecompensa, colTipo });
            dgvTipoRecompensa.Dock = DockStyle.Fill;
            dgvTipoRecompensa.EnableHeadersVisualStyles = false;
            dgvTipoRecompensa.GridColor = Color.FromArgb(222, 229, 217);
            dgvTipoRecompensa.Location = new Point(10, 90);
            dgvTipoRecompensa.MultiSelect = false;
            dgvTipoRecompensa.Name = "dgvTipoRecompensa";
            dgvTipoRecompensa.ReadOnly = true;
            dgvTipoRecompensa.RowHeadersWidth = 28;
            dgvTipoRecompensa.RowTemplate.Height = 33;
            dgvTipoRecompensa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoRecompensa.Size = new Size(951, 692);
            dgvTipoRecompensa.TabIndex = 0;
            dgvTipoRecompensa.CellClick += dgvTipoRecompensa_CellClick;
            dgvTipoRecompensa.CellContentClick += dgvTipoRecompensa_CellContentClick;
            // 
            // colIdTipoRecompensa
            // 
            colIdTipoRecompensa.DataPropertyName = "id_tipo_Recompensa";
            colIdTipoRecompensa.FillWeight = 40F;
            colIdTipoRecompensa.HeaderText = "ID Tipo Recompensa";
            colIdTipoRecompensa.MinimumWidth = 6;
            colIdTipoRecompensa.Name = "colIdTipoRecompensa";
            colIdTipoRecompensa.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "tipo_Recompensa";
            colTipo.FillWeight = 65F;
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // pnlListadoHeader
            // 
            pnlListadoHeader.BackColor = Color.White;
            pnlListadoHeader.Controls.Add(btnSearch);
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Controls.Add(txtIdTipoRecompensa);
            pnlListadoHeader.Dock = DockStyle.Top;
            pnlListadoHeader.Location = new Point(10, 35);
            pnlListadoHeader.Name = "pnlListadoHeader";
            pnlListadoHeader.Size = new Size(951, 55);
            pnlListadoHeader.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(799, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 48);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            lblListadoTitulo.Size = new Size(333, 28);
            lblListadoTitulo.TabIndex = 1;
            lblListadoTitulo.Text = "Tipos de recompensas registrados";
            // 
            // txtIdTipoRecompensa
            // 
            txtIdTipoRecompensa.BorderStyle = BorderStyle.FixedSingle;
            txtIdTipoRecompensa.Font = new Font("Segoe UI", 9F);
            txtIdTipoRecompensa.Location = new Point(424, 13);
            txtIdTipoRecompensa.Name = "txtIdTipoRecompensa";
            txtIdTipoRecompensa.PlaceholderText = "Buscar por ID de tipo...";
            txtIdTipoRecompensa.Size = new Size(364, 27);
            txtIdTipoRecompensa.TabIndex = 2;
            // 
            // frmTipoRecompensa
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1420, 940);
            Controls.Add(grpListado);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTipoRecompensa";
            Text = "frmTipoRecompensa";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTipoRecompensa).EndInit();
            pnlListadoHeader.ResumeLayout(false);
            pnlListadoHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox3;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnGuardar;
        private Button btnClean;
        private Button btnDelete;
        private TextBox txtTipoRecompensa;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox grpListado;
        private DataGridView dgvTipoRecompensa;
        private DataGridViewTextBoxColumn colIdTipoRecompensa;
        private DataGridViewTextBoxColumn colTipo;
        private Panel pnlListadoHeader;
        private Button btnSearch;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private TextBox txtIdTipoRecompensa;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}