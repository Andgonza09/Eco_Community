namespace View
{
    partial class frmInformacionSitios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionSitios));
            pnlHeader = new Panel();
            lblHeaderIcon = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblMarca = new Label();
            tlpSuperior = new TableLayoutPanel();
            grpInformacion = new GroupBox();
            tlpInformacion = new TableLayoutPanel();
            cmbTypeSite = new ComboBox();
            ckListTypeWaste = new CheckedListBox();
            lblTipoSitio = new Label();
            lblTipoResiduos = new Label();
            grpUbicacion = new GroupBox();
            tlpUbicacion = new TableLayoutPanel();
            cmbNeighborhood = new ComboBox();
            cmbDistrict = new ComboBox();
            lblDistrito = new Label();
            lblBarrio = new Label();
            lblDireccion = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            rchtxtAddress = new RichTextBox();
            label1 = new Label();
            grpAcciones = new GroupBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            listViewFile = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            pnlHeader.SuspendLayout();
            tlpSuperior.SuspendLayout();
            grpInformacion.SuspendLayout();
            tlpInformacion.SuspendLayout();
            grpUbicacion.SuspendLayout();
            tlpUbicacion.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpAcciones.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(111, 146, 82);
            pnlHeader.Controls.Add(lblHeaderIcon);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblMarca);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1420, 105);
            pnlHeader.TabIndex = 2;
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.Font = new Font("Segoe UI Emoji", 31F);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(26, 18);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(70, 70);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Text = "📍";
            lblHeaderIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(105, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(324, 52);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Sitio";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(228, 241, 250);
            lblSubtitulo.Location = new Point(108, 67);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(566, 25);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Registra la información, evidencia y seguimiento de las solicitudes";
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMarca.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblMarca.ForeColor = Color.FromArgb(218, 239, 250);
            lblMarca.Location = new Point(3630, 26);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(200, 50);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Cuidemos\r\nnuestro entorno";
            lblMarca.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpSuperior
            // 
            tlpSuperior.ColumnCount = 3;
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tlpSuperior.Controls.Add(grpInformacion, 0, 0);
            tlpSuperior.Controls.Add(grpUbicacion, 1, 0);
            tlpSuperior.Controls.Add(grpAcciones, 2, 0);
            tlpSuperior.Dock = DockStyle.Fill;
            tlpSuperior.Location = new Point(3, 8);
            tlpSuperior.Name = "tlpSuperior";
            tlpSuperior.RowCount = 1;
            tlpSuperior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSuperior.Size = new Size(1414, 282);
            tlpSuperior.TabIndex = 3;
            tlpSuperior.Paint += tlpSuperior_Paint;
            // 
            // grpInformacion
            // 
            grpInformacion.BackColor = Color.FromArgb(234, 237, 225);
            grpInformacion.Controls.Add(tlpInformacion);
            grpInformacion.Dock = DockStyle.Fill;
            grpInformacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInformacion.ForeColor = Color.FromArgb(48, 75, 48);
            grpInformacion.Location = new Point(0, 0);
            grpInformacion.Margin = new Padding(0, 0, 8, 8);
            grpInformacion.Name = "grpInformacion";
            grpInformacion.Padding = new Padding(14);
            grpInformacion.Size = new Size(529, 274);
            grpInformacion.TabIndex = 0;
            grpInformacion.TabStop = false;
            grpInformacion.Text = "ⓘ  Información del sitio";
            // 
            // tlpInformacion
            // 
            tlpInformacion.ColumnCount = 2;
            tlpInformacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29F));
            tlpInformacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71F));
            tlpInformacion.Controls.Add(cmbTypeSite, 1, 0);
            tlpInformacion.Controls.Add(ckListTypeWaste, 1, 1);
            tlpInformacion.Controls.Add(lblTipoSitio, 0, 0);
            tlpInformacion.Controls.Add(lblTipoResiduos, 0, 1);
            tlpInformacion.Dock = DockStyle.Fill;
            tlpInformacion.Font = new Font("Segoe UI", 9F);
            tlpInformacion.Location = new Point(14, 39);
            tlpInformacion.Name = "tlpInformacion";
            tlpInformacion.RowCount = 2;
            tlpInformacion.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tlpInformacion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformacion.Size = new Size(501, 221);
            tlpInformacion.TabIndex = 0;
            // 
            // cmbTypeSite
            // 
            cmbTypeSite.Anchor = AnchorStyles.Left;
            cmbTypeSite.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTypeSite.ForeColor = SystemColors.Desktop;
            cmbTypeSite.FormattingEnabled = true;
            cmbTypeSite.Items.AddRange(new object[] { "Punto de reciclaje", "Depósitos de basura" });
            cmbTypeSite.Location = new Point(148, 13);
            cmbTypeSite.Name = "cmbTypeSite";
            cmbTypeSite.Size = new Size(340, 28);
            cmbTypeSite.TabIndex = 10;
            cmbTypeSite.Text = "  Selecciona el tipo de sitio a registrar";
            // 
            // ckListTypeWaste
            // 
            ckListTypeWaste.Dock = DockStyle.Fill;
            ckListTypeWaste.Location = new Point(148, 57);
            ckListTypeWaste.Name = "ckListTypeWaste";
            ckListTypeWaste.Size = new Size(350, 161);
            ckListTypeWaste.TabIndex = 3;
            // 
            // lblTipoSitio
            // 
            lblTipoSitio.Dock = DockStyle.Fill;
            lblTipoSitio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTipoSitio.ForeColor = Color.FromArgb(30, 48, 70);
            lblTipoSitio.Location = new Point(3, 0);
            lblTipoSitio.Name = "lblTipoSitio";
            lblTipoSitio.Size = new Size(139, 54);
            lblTipoSitio.TabIndex = 0;
            lblTipoSitio.Text = "Tipo de sitio";
            lblTipoSitio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipoResiduos
            // 
            lblTipoResiduos.Dock = DockStyle.Fill;
            lblTipoResiduos.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTipoResiduos.ForeColor = Color.FromArgb(30, 48, 70);
            lblTipoResiduos.Location = new Point(3, 54);
            lblTipoResiduos.Name = "lblTipoResiduos";
            lblTipoResiduos.Padding = new Padding(0, 7, 0, 0);
            lblTipoResiduos.Size = new Size(139, 167);
            lblTipoResiduos.TabIndex = 2;
            lblTipoResiduos.Text = "Tipo de residuos";
            // 
            // grpUbicacion
            // 
            grpUbicacion.BackColor = Color.FromArgb(234, 237, 225);
            grpUbicacion.Controls.Add(tlpUbicacion);
            grpUbicacion.Dock = DockStyle.Fill;
            grpUbicacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpUbicacion.ForeColor = Color.FromArgb(48, 75, 48);
            grpUbicacion.Location = new Point(545, 0);
            grpUbicacion.Margin = new Padding(8, 0, 8, 8);
            grpUbicacion.Name = "grpUbicacion";
            grpUbicacion.Padding = new Padding(14);
            grpUbicacion.Size = new Size(521, 274);
            grpUbicacion.TabIndex = 1;
            grpUbicacion.TabStop = false;
            grpUbicacion.Text = "📍  Ubicación del sitio";
            // 
            // tlpUbicacion
            // 
            tlpUbicacion.ColumnCount = 2;
            tlpUbicacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpUbicacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tlpUbicacion.Controls.Add(cmbNeighborhood, 1, 1);
            tlpUbicacion.Controls.Add(cmbDistrict, 1, 0);
            tlpUbicacion.Controls.Add(lblDistrito, 0, 0);
            tlpUbicacion.Controls.Add(lblBarrio, 0, 1);
            tlpUbicacion.Controls.Add(lblDireccion, 0, 2);
            tlpUbicacion.Controls.Add(tableLayoutPanel2, 1, 2);
            tlpUbicacion.Dock = DockStyle.Fill;
            tlpUbicacion.Font = new Font("Segoe UI", 9F);
            tlpUbicacion.Location = new Point(14, 39);
            tlpUbicacion.Name = "tlpUbicacion";
            tlpUbicacion.RowCount = 3;
            tlpUbicacion.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpUbicacion.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpUbicacion.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpUbicacion.Size = new Size(493, 221);
            tlpUbicacion.TabIndex = 0;
            // 
            // cmbNeighborhood
            // 
            cmbNeighborhood.FormattingEnabled = true;
            cmbNeighborhood.IntegralHeight = false;
            cmbNeighborhood.Location = new Point(126, 63);
            cmbNeighborhood.Name = "cmbNeighborhood";
            cmbNeighborhood.Size = new Size(354, 28);
            cmbNeighborhood.TabIndex = 14;
            cmbNeighborhood.SelectedIndexChanged += cmbNeighborhood_SelectedIndexChanged;
            // 
            // cmbDistrict
            // 
            cmbDistrict.FormattingEnabled = true;
            cmbDistrict.Items.AddRange(new object[] { "Distrito I", "Distrito II", "Distrito III", "Distrito IV", "Distrito V", "Distrito VI", "Distrito VII" });
            cmbDistrict.Location = new Point(126, 3);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(354, 28);
            cmbDistrict.TabIndex = 13;
            cmbDistrict.SelectedIndexChanged += cmbDistrict_SelectedIndexChanged_1;
            // 
            // lblDistrito
            // 
            lblDistrito.Dock = DockStyle.Fill;
            lblDistrito.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDistrito.ForeColor = Color.FromArgb(30, 48, 70);
            lblDistrito.Location = new Point(3, 0);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(117, 60);
            lblDistrito.TabIndex = 0;
            lblDistrito.Text = "Distrito";
            lblDistrito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBarrio
            // 
            lblBarrio.Dock = DockStyle.Fill;
            lblBarrio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBarrio.ForeColor = Color.FromArgb(30, 48, 70);
            lblBarrio.Location = new Point(3, 60);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(117, 60);
            lblBarrio.TabIndex = 2;
            lblBarrio.Text = "Barrio";
            lblBarrio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDireccion
            // 
            lblDireccion.Dock = DockStyle.Fill;
            lblDireccion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.FromArgb(30, 48, 70);
            lblDireccion.Location = new Point(3, 120);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(117, 101);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección";
            lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(rchtxtAddress, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(126, 123);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.40594F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.980198F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.61386F));
            tableLayoutPanel2.Size = new Size(364, 95);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // rchtxtAddress
            // 
            rchtxtAddress.Dock = DockStyle.Fill;
            rchtxtAddress.Location = new Point(3, 3);
            rchtxtAddress.Name = "rchtxtAddress";
            rchtxtAddress.Size = new Size(358, 50);
            rchtxtAddress.TabIndex = 15;
            rchtxtAddress.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(239, 244, 234);
            label1.Font = new Font("Segoe UI", 8.2F);
            label1.ForeColor = Color.FromArgb(79, 106, 71);
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 10;
            label1.Text = "💡  Asegúrate de brindar una dirección clara y referencias\r\n     para una mejor ubicación del sitio.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpAcciones
            // 
            grpAcciones.BackColor = Color.FromArgb(234, 237, 225);
            grpAcciones.Controls.Add(groupBox1);
            grpAcciones.Dock = DockStyle.Fill;
            grpAcciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpAcciones.ForeColor = Color.FromArgb(48, 75, 48);
            grpAcciones.Location = new Point(1082, 0);
            grpAcciones.Margin = new Padding(8, 0, 0, 8);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Padding = new Padding(14);
            grpAcciones.Size = new Size(332, 274);
            grpAcciones.TabIndex = 2;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "⚙  Acciones";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(67, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 208);
            groupBox1.TabIndex = 31;
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
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(109, 111);
            button2.Name = "button2";
            button2.Size = new Size(83, 75);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(109, 26);
            button5.Name = "button5";
            button5.Size = new Size(83, 75);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(16, 26);
            button6.Name = "button6";
            button6.Size = new Size(83, 75);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tlpSuperior, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 105);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            tableLayoutPanel1.Size = new Size(1420, 293);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // listViewFile
            // 
            listViewFile.BackColor = Color.FromArgb(234, 237, 225);
            listViewFile.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewFile.Dock = DockStyle.Fill;
            listViewFile.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewFile.FullRowSelect = true;
            listViewFile.Location = new Point(3, 61);
            listViewFile.Name = "listViewFile";
            listViewFile.Size = new Size(1408, 195);
            listViewFile.TabIndex = 6;
            listViewFile.UseCompatibleStateImageBehavior = false;
            listViewFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre del archivo";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de archivo";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tamaño del archivo";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ruta ";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha de adjunción";
            columnHeader5.Width = 200;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(234, 237, 225);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(48, 75, 48);
            panel2.Location = new Point(3, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1408, 45);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(240, 244, 237);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(67, 107, 51);
            button3.Image = Properties.Resources.trash;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(1181, 4);
            button3.Name = "button3";
            button3.Size = new Size(200, 38);
            button3.TabIndex = 28;
            button3.Text = "Eliminar archivo";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(111, 146, 82);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(246, 246, 247);
            button1.Image = Properties.Resources.plus;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(967, 4);
            button1.Name = "button1";
            button1.Size = new Size(200, 38);
            button1.TabIndex = 6;
            button1.Text = "Adjuntar archivo";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.AttachIcon;
            pictureBox1.Location = new Point(11, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(48, 75, 48);
            label2.Location = new Point(80, 10);
            label2.Name = "label2";
            label2.Size = new Size(200, 25);
            label2.TabIndex = 0;
            label2.Text = "Evidencia multimedia";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel2, 0, 1);
            tableLayoutPanel3.Controls.Add(listViewFile, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            tableLayoutPanel3.Size = new Size(1414, 259);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 398);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 49F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1420, 542);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel1, 0, 0);
            tableLayoutPanel5.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 278);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            tableLayoutPanel5.Size = new Size(1414, 261);
            tableLayoutPanel5.TabIndex = 8;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 237, 225);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1408, 48);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.AttachIcon;
            pictureBox2.Location = new Point(11, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(48, 75, 48);
            label3.Location = new Point(80, 11);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 0;
            label3.Text = "Solicitudes enviadas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(3, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1408, 196);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmInformacionSitios
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1420, 940);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmInformacionSitios";
            Text = "frmBeta";
            WindowState = FormWindowState.Maximized;
            Load += frmBeta_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpSuperior.ResumeLayout(false);
            grpInformacion.ResumeLayout(false);
            tlpInformacion.ResumeLayout(false);
            grpUbicacion.ResumeLayout(false);
            tlpUbicacion.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            grpAcciones.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderIcon;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblMarca;
        private TableLayoutPanel tlpSuperior;
        private GroupBox grpInformacion;
        private TableLayoutPanel tlpInformacion;
        private Label lblTipoSitio;
        private Label lblTipoResiduos;
        private GroupBox grpUbicacion;
        private TableLayoutPanel tlpUbicacion;
        private Label lblDistrito;
        private Label lblBarrio;
        private Label lblDireccion;
        private GroupBox grpAcciones;
        private CheckedListBox ckListTypeWaste;
        private ComboBox cmbTypeSite;
        private ComboBox cmbDistrict;
        private ComboBox cmbNeighborhood;
        private RichTextBox rchtxtAddress;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private ListView listViewFile;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panel2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button2;
        private Button button5;
        private Button button6;
    }
}