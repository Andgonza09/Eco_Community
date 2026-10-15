namespace View
{
    partial class frmExtension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtension));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            pictureBox3 = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panel2 = new Panel();
            grpListado = new GroupBox();
            dgvExtension = new DataGridView();
            colIdExtension = new DataGridViewTextBoxColumn();
            colTipoExtension = new DataGridViewTextBoxColumn();
            pnlListadoHeader = new Panel();
            button1 = new Button();
            lblListadoIcon = new Label();
            lblListadoTitulo = new Label();
            txtIdExtension = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnUpdate = new Button();
            btnClean = new Button();
            btnDelete = new Button();
            btnGuardar = new Button();
            txtExtension = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExtension).BeginInit();
            pnlListadoHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            pnlHeader.TabIndex = 4;
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
            lblTitulo.Size = new Size(479, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de Extensiones";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(139, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(412, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Administra las extensiones validas en el sistema";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 923);
            panel2.Name = "panel2";
            panel2.Size = new Size(1420, 17);
            panel2.TabIndex = 6;
            // 
            // grpListado
            // 
            grpListado.BackColor = Color.White;
            grpListado.Controls.Add(dgvExtension);
            grpListado.Controls.Add(pnlListadoHeader);
            grpListado.Dock = DockStyle.Fill;
            grpListado.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpListado.ForeColor = Color.FromArgb(48, 75, 48);
            grpListado.Location = new Point(0, 0);
            grpListado.Margin = new Padding(0, 0, 0, 8);
            grpListado.Name = "grpListado";
            grpListado.Padding = new Padding(10);
            grpListado.Size = new Size(880, 809);
            grpListado.TabIndex = 7;
            grpListado.TabStop = false;
            // 
            // dgvExtension
            // 
            dgvExtension.AllowUserToAddRows = false;
            dgvExtension.AllowUserToDeleteRows = false;
            dgvExtension.AllowUserToResizeRows = false;
            dgvExtension.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExtension.BackgroundColor = Color.White;
            dgvExtension.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 80, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(57, 115, 92);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvExtension.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExtension.ColumnHeadersHeight = 38;
            dgvExtension.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvExtension.Columns.AddRange(new DataGridViewColumn[] { colIdExtension, colTipoExtension });
            dgvExtension.Dock = DockStyle.Fill;
            dgvExtension.EnableHeadersVisualStyles = false;
            dgvExtension.GridColor = Color.FromArgb(222, 229, 217);
            dgvExtension.Location = new Point(10, 90);
            dgvExtension.MultiSelect = false;
            dgvExtension.Name = "dgvExtension";
            dgvExtension.ReadOnly = true;
            dgvExtension.RowHeadersWidth = 28;
            dgvExtension.RowTemplate.Height = 33;
            dgvExtension.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExtension.Size = new Size(860, 709);
            dgvExtension.TabIndex = 0;
            dgvExtension.CellClick += dgvExtension_CellClick;
            dgvExtension.CellContentClick += dgvExtension_CellContentClick;
            // 
            // colIdExtension
            // 
            colIdExtension.FillWeight = 40F;
            colIdExtension.HeaderText = "ID Extension";
            colIdExtension.MinimumWidth = 6;
            colIdExtension.Name = "colIdExtension";
            colIdExtension.ReadOnly = true;
            // 
            // colTipoExtension
            // 
            colTipoExtension.FillWeight = 65F;
            colTipoExtension.HeaderText = "Tipo de Extension";
            colTipoExtension.MinimumWidth = 6;
            colTipoExtension.Name = "colTipoExtension";
            colTipoExtension.ReadOnly = true;
            // 
            // pnlListadoHeader
            // 
            pnlListadoHeader.BackColor = Color.White;
            pnlListadoHeader.Controls.Add(button1);
            pnlListadoHeader.Controls.Add(lblListadoIcon);
            pnlListadoHeader.Controls.Add(lblListadoTitulo);
            pnlListadoHeader.Controls.Add(txtIdExtension);
            pnlListadoHeader.Dock = DockStyle.Top;
            pnlListadoHeader.Location = new Point(10, 35);
            pnlListadoHeader.Name = "pnlListadoHeader";
            pnlListadoHeader.Size = new Size(860, 55);
            pnlListadoHeader.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(686, 4);
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
            lblListadoTitulo.ForeColor = Color.Black;
            lblListadoTitulo.Location = new Point(52, 12);
            lblListadoTitulo.Name = "lblListadoTitulo";
            lblListadoTitulo.Size = new Size(235, 28);
            lblListadoTitulo.TabIndex = 1;
            lblListadoTitulo.Text = "Extensiones registradas";
            // 
            // txtIdExtension
            // 
            txtIdExtension.BorderStyle = BorderStyle.FixedSingle;
            txtIdExtension.Font = new Font("Segoe UI", 9F);
            txtIdExtension.Location = new Point(317, 15);
            txtIdExtension.Name = "txtIdExtension";
            txtIdExtension.PlaceholderText = "Buscar por ID de extension..";
            txtIdExtension.Size = new Size(359, 27);
            txtIdExtension.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(897, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 811);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(txtExtension);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(514, 439);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnClean);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnGuardar);
            groupBox3.Location = new Point(26, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(482, 192);
            groupBox3.TabIndex = 60;
            groupBox3.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(230, 238, 235);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnUpdate.Location = new Point(239, 97);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(210, 60);
            btnUpdate.TabIndex = 58;
            btnUpdate.Text = "Actualizar";
            btnUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(230, 238, 235);
            btnClean.Cursor = Cursors.Hand;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnClean.ForeColor = Color.Black;
            btnClean.Image = (Image)resources.GetObject("btnClean.Image");
            btnClean.ImageAlign = ContentAlignment.TopCenter;
            btnClean.Location = new Point(23, 97);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(210, 60);
            btnClean.TabIndex = 59;
            btnClean.Text = "Limpiar";
            btnClean.TextAlign = ContentAlignment.BottomCenter;
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(230, 238, 235);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(239, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(210, 60);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Eliminar ";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(57, 115, 92);
            btnGuardar.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(23, 21);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(210, 60);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtExtension
            // 
            txtExtension.Anchor = AnchorStyles.None;
            txtExtension.Location = new Point(28, 142);
            txtExtension.Name = "txtExtension";
            txtExtension.PlaceholderText = "Por ej: .pdf";
            txtExtension.Size = new Size(456, 27);
            txtExtension.TabIndex = 55;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(26, 107);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 54;
            label3.Text = "Extension";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.FromArgb(57, 115, 92);
            label2.Font = new Font("Segoe UI", 8.2F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 179);
            label2.Name = "label2";
            label2.Size = new Size(458, 59);
            label2.TabIndex = 53;
            label2.Text = "💡  Ingresa la extensión con punto (Ej. .jpg, .pdf, .jpeg, .docx, etc..";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(93, 44);
            label1.Name = "label1";
            label1.Size = new Size(391, 41);
            label1.TabIndex = 52;
            label1.Text = "Agregar / Editar extensión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 462);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 346);
            panel1.TabIndex = 51;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(514, 346);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tableLayoutPanel1.Controls.Add(grpListado, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 106);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1420, 817);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // frmExtension
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1420, 940);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmExtension";
            Text = "frmExtension";
            WindowState = FormWindowState.Maximized;
            Load += frmExtension_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExtension).EndInit();
            pnlListadoHeader.ResumeLayout(false);
            pnlListadoHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panel2;
        private GroupBox grpListado;
        private DataGridView dgvExtension;
        private DataGridViewTextBoxColumn colIdExtension;
        private DataGridViewTextBoxColumn colTipoExtension;
        private Panel pnlListadoHeader;
        private Button button1;
        private Label lblListadoIcon;
        private Label lblListadoTitulo;
        private TextBox txtIdExtension;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnClean;
        private Button btnUpdate;
        private Button btnGuardar;
        private TextBox txtExtension;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private PictureBox pictureBox3;
    }
}