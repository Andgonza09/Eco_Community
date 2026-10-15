namespace View
{
    partial class frmCatalogoResiduos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogoResiduos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button8 = new Button();
            bntClear = new Button();
            btnDelete = new Button();
            txtCatalogo = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            grpListado = new GroupBox();
            dgvCatalogo = new DataGridView();
            colIdCatalogo = new DataGridViewTextBoxColumn();
            colResiduos = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            button1 = new Button();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            txtIdCatalogo = new TextBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
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
            pnlHeader.TabIndex = 5;
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
            lblTitulo.Size = new Size(413, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de residuos";
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
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(txtCatalogo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(971, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 792);
            panel1.TabIndex = 9;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(bntClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(30, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 374);
            groupBox2.TabIndex = 4;
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
            button6.Location = new Point(47, 112);
            button6.Name = "button6";
            button6.Size = new Size(296, 66);
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
            button8.Location = new Point(47, 26);
            button8.Name = "button8";
            button8.Size = new Size(296, 66);
            button8.TabIndex = 47;
            button8.Text = "Guardar";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // bntClear
            // 
            bntClear.Anchor = AnchorStyles.Right;
            bntClear.BackColor = Color.FromArgb(230, 238, 235);
            bntClear.Cursor = Cursors.Hand;
            bntClear.FlatStyle = FlatStyle.Flat;
            bntClear.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            bntClear.ForeColor = Color.Black;
            bntClear.Image = (Image)resources.GetObject("bntClear.Image");
            bntClear.ImageAlign = ContentAlignment.TopCenter;
            bntClear.Location = new Point(47, 290);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(296, 66);
            bntClear.TabIndex = 50;
            bntClear.Text = "Limpiar";
            bntClear.TextAlign = ContentAlignment.BottomCenter;
            bntClear.UseVisualStyleBackColor = false;
            bntClear.Click += bntClear_Click;
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
            btnDelete.Location = new Point(47, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(296, 66);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Eliminar ";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCatalogo
            // 
            txtCatalogo.Location = new Point(30, 115);
            txtCatalogo.Name = "txtCatalogo";
            txtCatalogo.PlaceholderText = "Por ej: Desechos industriales";
            txtCatalogo.Size = new Size(393, 27);
            txtCatalogo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(255, 28);
            label2.TabIndex = 2;
            label2.Text = "Agregar / Editar Residuos";
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
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(111, 14);
            label1.Name = "label1";
            label1.Size = new Size(305, 41);
            label1.TabIndex = 0;
            label1.Text = "Registro de residuos";
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.White;
            grpListado.Controls.Add(dgvCatalogo);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(48, 75, 48);
            grpListado.Location = new Point(0, 148);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(971, 792);
            grpListado.TabIndex = 10;
            grpListado.TabStop = false;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AllowUserToDeleteRows = false;
            dgvCatalogo.AllowUserToResizeRows = false;
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatalogo.BackgroundColor = Color.White;
            dgvCatalogo.BorderStyle = BorderStyle.Fixed3D;
            dgvCatalogo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 80, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCatalogo.ColumnHeadersHeight = 38;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCatalogo.Columns.AddRange(new DataGridViewColumn[] { colIdCatalogo, colResiduos });
            dgvCatalogo.Dock = DockStyle.Fill;
            dgvCatalogo.EnableHeadersVisualStyles = false;
            dgvCatalogo.GridColor = Color.FromArgb(222, 229, 217);
            dgvCatalogo.Location = new Point(10, 90);
            dgvCatalogo.MultiSelect = false;
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.RowHeadersWidth = 28;
            dgvCatalogo.RowTemplate.Height = 33;
            dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalogo.Size = new Size(951, 692);
            dgvCatalogo.TabIndex = 0;
            dgvCatalogo.CellClick += dgvCatalogo_CellClick;
            dgvCatalogo.CellContentClick += dgvCatalogo_CellContentClick;
            // 
            // colIdCatalogo
            // 
            colIdCatalogo.FillWeight = 40F;
            colIdCatalogo.HeaderText = "ID Catálogo";
            colIdCatalogo.MinimumWidth = 6;
            colIdCatalogo.Name = "colIdCatalogo";
            colIdCatalogo.ReadOnly = true;
            // 
            // colResiduos
            // 
            colResiduos.FillWeight = 65F;
            colResiduos.HeaderText = "Residuos";
            colResiduos.MinimumWidth = 6;
            colResiduos.Name = "colResiduos";
            colResiduos.ReadOnly = true;
            // 
            // pnlListadoHeader
            // 
            pnlListadoHeader.BackColor = Color.White;
            pnlListadoHeader.Controls.Add(button1);
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Controls.Add(txtIdCatalogo);
            pnlListadoHeader.Dock = DockStyle.Top;
            pnlListadoHeader.Location = new Point(10, 35);
            pnlListadoHeader.Name = "pnlListadoHeader";
            pnlListadoHeader.Size = new Size(951, 55);
            pnlListadoHeader.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(652, 2);
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
            lblListadoTitulo.Size = new Size(208, 28);
            lblListadoTitulo.TabIndex = 1;
            lblListadoTitulo.Text = "Residuos registrados";
            // 
            // txtIdCatalogo
            // 
            txtIdCatalogo.BorderStyle = BorderStyle.FixedSingle;
            txtIdCatalogo.Font = new Font("Segoe UI", 9F);
            txtIdCatalogo.Location = new Point(279, 13);
            txtIdCatalogo.Name = "txtIdCatalogo";
            txtIdCatalogo.PlaceholderText = "Buscar por ID de residuos...";
            txtIdCatalogo.Size = new Size(364, 27);
            txtIdCatalogo.TabIndex = 2;
            // 
            // frmCatalogoResiduos
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
            Name = "frmCatalogoResiduos";
            Text = "frmCatalogoResiduos";
            WindowState = FormWindowState.Maximized;
            Load += frmCatalogoResiduos_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
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
        private Button button6;
        private Button button8;
        private Button bntClear;
        private Button btnDelete;
        private TextBox txtCatalogo;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox grpListado;
        private DataGridView dgvCatalogo;
        private DataGridViewTextBoxColumn colIdCatalogo;
        private DataGridViewTextBoxColumn colResiduos;
        private Panel pnlListadoHeader;
        private Button button1;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private TextBox txtIdCatalogo;
    }
}