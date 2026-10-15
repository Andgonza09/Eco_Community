namespace View
{
    partial class frmDistrito
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistrito));
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            grpListado = new GroupBox();
            dgvDistritos = new DataGridView();
            colIdDistrito = new DataGridViewTextBoxColumn();
            ColDistrito = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            button1 = new Button();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            txtIdDistrito = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnGuardar = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            txtNombreDistrito = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistritos).BeginInit();
            pnlListadoHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(7, 80, 51);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1420, 106);
            pnlHeader.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.location;
            pictureBox1.Location = new Point(37, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(127, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(396, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de Distrito";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(139, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(515, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Administra los distritos asociados a cada distrito del sistema";
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.White;
            grpListado.Controls.Add(dgvDistritos);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(48, 75, 48);
            grpListado.Location = new Point(0, 0);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(971, 754);
            grpListado.TabIndex = 4;
            grpListado.TabStop = false;
            // 
            // dgvDistritos
            // 
            dgvDistritos.AllowUserToAddRows = false;
            dgvDistritos.AllowUserToDeleteRows = false;
            dgvDistritos.AllowUserToResizeRows = false;
            dgvDistritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDistritos.BackgroundColor = Color.White;
            dgvDistritos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 80, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvDistritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDistritos.ColumnHeadersHeight = 38;
            dgvDistritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDistritos.Columns.AddRange(new DataGridViewColumn[] { colIdDistrito, ColDistrito });
            dgvDistritos.Dock = DockStyle.Fill;
            dgvDistritos.EnableHeadersVisualStyles = false;
            dgvDistritos.GridColor = Color.FromArgb(222, 229, 217);
            dgvDistritos.Location = new Point(10, 90);
            dgvDistritos.MultiSelect = false;
            dgvDistritos.Name = "dgvDistritos";
            dgvDistritos.ReadOnly = true;
            dgvDistritos.RowHeadersWidth = 28;
            dgvDistritos.RowTemplate.Height = 33;
            dgvDistritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistritos.Size = new Size(951, 654);
            dgvDistritos.TabIndex = 0;
            dgvDistritos.CellClick += dgvDistritos_CellClick;
            dgvDistritos.CellContentClick += dgvDistritos_CellContentClick;
            // 
            // colIdDistrito
            // 
            colIdDistrito.DataPropertyName = "id_Distrito";
            colIdDistrito.FillWeight = 40F;
            colIdDistrito.HeaderText = "ID Distrito";
            colIdDistrito.MinimumWidth = 6;
            colIdDistrito.Name = "colIdDistrito";
            colIdDistrito.ReadOnly = true;
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
            pnlListadoHeader.Controls.Add(button1);
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Controls.Add(txtIdDistrito);
            pnlListadoHeader.Dock = DockStyle.Top;
            pnlListadoHeader.Location = new Point(10, 35);
            pnlListadoHeader.Name = "pnlListadoHeader";
            pnlListadoHeader.Size = new Size(951, 55);
            pnlListadoHeader.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(649, 4);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            lblListadoTitulo.Text = "Distritos registrados";
            // 
            // txtIdDistrito
            // 
            txtIdDistrito.BorderStyle = BorderStyle.FixedSingle;
            txtIdDistrito.Font = new Font("Segoe UI", 9F);
            txtIdDistrito.Location = new Point(279, 13);
            txtIdDistrito.Name = "txtIdDistrito";
            txtIdDistrito.PlaceholderText = "Buscar por ID de distrito...";
            txtIdDistrito.Size = new Size(364, 27);
            txtIdDistrito.TabIndex = 2;
            txtIdDistrito.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(txtNombreDistrito);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(971, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 754);
            panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(383, 212);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(36, 380);
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
            btnUpdate.Location = new Point(47, 111);
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
            btnClear.Location = new Point(47, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(296, 66);
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
            btnDelete.Location = new Point(47, 203);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(296, 66);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Eliminar ";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtNombreDistrito
            // 
            txtNombreDistrito.Location = new Point(36, 339);
            txtNombreDistrito.Name = "txtNombreDistrito";
            txtNombreDistrito.PlaceholderText = "Por ej: Distrito 8";
            txtNombreDistrito.Size = new Size(393, 27);
            txtNombreDistrito.TabIndex = 3;
            txtNombreDistrito.TextChanged += txtNombreDistrito_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 298);
            label2.Name = "label2";
            label2.Size = new Size(240, 28);
            label2.TabIndex = 2;
            label2.Text = "Agregar / Editar distrito";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(111, 14);
            label1.Name = "label1";
            label1.Size = new Size(271, 41);
            label1.TabIndex = 0;
            label1.Text = "Registrar distritos";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(1420, 42);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 902);
            panel3.Name = "panel3";
            panel3.Size = new Size(1420, 38);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(grpListado);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(971, 754);
            panel4.TabIndex = 8;
            // 
            // frmDistrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1420, 940);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDistrito";
            Text = "frmDistrito";
            WindowState = FormWindowState.Maximized;
            Load += frmDistrito_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDistritos).EndInit();
            pnlListadoHeader.ResumeLayout(false);
            pnlListadoHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private GroupBox grpListado;
        private DataGridView dgvDistritos;
        private Panel pnlListadoHeader;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private TextBox txtIdDistrito;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtNombreDistrito;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnGuardar;
        private Button btnClear;
        private Button btnDelete;
        private PictureBox pictureBox3;
        private Button button1;
        private DataGridViewTextBoxColumn colIdDistrito;
        private DataGridViewTextBoxColumn ColDistrito;
    }
}