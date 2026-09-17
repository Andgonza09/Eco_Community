namespace View
{
    partial class frmInformacionSitio
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
            panel3 = new Panel();
            label5 = new Label();
            label9 = new Label();
            ckListTypeWaste = new CheckedListBox();
            panel7 = new Panel();
            panel8 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel10 = new Panel();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            tlpInformationSite = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            cmbTypeSite = new ComboBox();
            label3 = new Label();
            panel9 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label10 = new Label();
            panel12 = new Panel();
            btnSendRequest = new Button();
            button3 = new Button();
            btnCancelData = new Button();
            btnNext = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            pnlSiteLocation = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            tlyDistrict = new TableLayoutPanel();
            cmbDistrict = new ComboBox();
            label12 = new Label();
            tlyNeighborhood = new TableLayoutPanel();
            cmbNeighborhood = new ComboBox();
            label6 = new Label();
            tlpAddress = new TableLayoutPanel();
            rchtxtAddress = new RichTextBox();
            label13 = new Label();
            panel16 = new Panel();
            panel15 = new Panel();
            panel14 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            listViewFile = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel2 = new Panel();
            btnAttachFile = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel11 = new Panel();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tlpInformationSite.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel12.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            pnlSiteLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tlyDistrict.SuspendLayout();
            tlyNeighborhood.SuspendLayout();
            tlpAddress.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1162, 89);
            panel3.TabIndex = 56;
            panel3.Paint += panel3_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            label5.Location = new Point(43, 9);
            label5.Name = "label5";
            label5.Size = new Size(222, 41);
            label5.TabIndex = 49;
            label5.Text = "Datos del sitio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 12F);
            label9.Location = new Point(43, 50);
            label9.Name = "label9";
            label9.Size = new Size(799, 28);
            label9.TabIndex = 50;
            label9.Text = "Completa la información general y la ubicación del punto de residuos que deseas registrar.";
            // 
            // ckListTypeWaste
            // 
            ckListTypeWaste.Location = new Point(213, 3);
            ckListTypeWaste.Name = "ckListTypeWaste";
            ckListTypeWaste.Size = new Size(468, 70);
            ckListTypeWaste.TabIndex = 0;
            ckListTypeWaste.SelectedIndexChanged += ckListTypeWaste_SelectedIndexChanged;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1114, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(48, 787);
            panel7.TabIndex = 60;
            panel7.Paint += panel7_Paint;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(48, 89);
            panel8.Name = "panel8";
            panel8.Size = new Size(1066, 13);
            panel8.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel10, 0, 0);
            tableLayoutPanel1.Controls.Add(tlpInformationSite, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(48, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.4150944F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.58491F));
            tableLayoutPanel1.Size = new Size(1066, 191);
            tableLayoutPanel1.TabIndex = 62;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(234, 237, 225);
            panel10.Controls.Add(pictureBox2);
            panel10.Controls.Add(label11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(1060, 44);
            panel10.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.InformationIcon;
            pictureBox2.Location = new Point(26, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(83, 12);
            label11.Name = "label11";
            label11.Size = new Size(187, 23);
            label11.TabIndex = 0;
            label11.Text = "Información del sitio";
            // 
            // tlpInformationSite
            // 
            tlpInformationSite.BackColor = Color.FromArgb(179, 194, 148);
            tlpInformationSite.ColumnCount = 1;
            tlpInformationSite.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformationSite.Controls.Add(tableLayoutPanel4, 0, 0);
            tlpInformationSite.Controls.Add(tableLayoutPanel3, 0, 1);
            tlpInformationSite.Controls.Add(panel9, 0, 2);
            tlpInformationSite.Controls.Add(tableLayoutPanel5, 0, 4);
            tlpInformationSite.Dock = DockStyle.Fill;
            tlpInformationSite.Location = new Point(3, 53);
            tlpInformationSite.Name = "tlpInformationSite";
            tlpInformationSite.RowCount = 5;
            tlpInformationSite.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tlpInformationSite.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tlpInformationSite.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            tlpInformationSite.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tlpInformationSite.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            tlpInformationSite.Size = new Size(1060, 135);
            tlpInformationSite.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1054, 1);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Controls.Add(cmbTypeSite, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 8);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1054, 29);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // cmbTypeSite
            // 
            cmbTypeSite.Anchor = AnchorStyles.Left;
            cmbTypeSite.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTypeSite.ForeColor = SystemColors.Desktop;
            cmbTypeSite.FormattingEnabled = true;
            cmbTypeSite.Items.AddRange(new object[] { "Punto de reciclaje", "Depósitos de basura" });
            cmbTypeSite.Location = new Point(213, 3);
            cmbTypeSite.Name = "cmbTypeSite";
            cmbTypeSite.Size = new Size(462, 28);
            cmbTypeSite.TabIndex = 9;
            cmbTypeSite.Text = "  Selecciona el tipo de sitio que deseas registrar";
            cmbTypeSite.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 8;
            label3.Text = "Tipo de sitio";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(225, 225, 225);
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 43);
            panel9.Name = "panel9";
            panel9.Size = new Size(1054, 1);
            panel9.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.Controls.Add(ckListTypeWaste, 1, 0);
            tableLayoutPanel5.Controls.Add(label10, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 50);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1054, 82);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 11;
            label10.Text = "Tipo de residuos";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnSendRequest);
            panel12.Controls.Add(button3);
            panel12.Controls.Add(btnCancelData);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(48, 794);
            panel12.Name = "panel12";
            panel12.Size = new Size(1066, 59);
            panel12.TabIndex = 64;
            panel12.Paint += panel12_Paint;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSendRequest.BackColor = Color.FromArgb(47, 93, 140);
            btnSendRequest.FlatAppearance.BorderSize = 0;
            btnSendRequest.FlatStyle = FlatStyle.Flat;
            btnSendRequest.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnSendRequest.ForeColor = Color.FromArgb(246, 246, 247);
            btnSendRequest.Image = Properties.Resources.send;
            btnSendRequest.Location = new Point(815, 6);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(185, 44);
            btnSendRequest.TabIndex = 28;
            btnSendRequest.Text = "Enviar Solicitud";
            btnSendRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSendRequest.UseVisualStyleBackColor = false;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(138, 107, 102);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(246, 246, 247);
            button3.Image = Properties.Resources.trash;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(9, 8);
            button3.Name = "button3";
            button3.Size = new Size(187, 44);
            button3.TabIndex = 27;
            button3.Text = "Eliminar archivo";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnCancelData
            // 
            btnCancelData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelData.BackColor = Color.FromArgb(138, 107, 102);
            btnCancelData.FlatAppearance.BorderSize = 0;
            btnCancelData.FlatStyle = FlatStyle.Flat;
            btnCancelData.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnCancelData.ForeColor = SystemColors.Control;
            btnCancelData.Image = Properties.Resources.cancel;
            btnCancelData.Location = new Point(583, 6);
            btnCancelData.Name = "btnCancelData";
            btnCancelData.Size = new Size(211, 44);
            btnCancelData.TabIndex = 25;
            btnCancelData.Text = "Cancelar";
            btnCancelData.TextAlign = ContentAlignment.MiddleRight;
            btnCancelData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelData.UseVisualStyleBackColor = false;
            btnCancelData.Click += btnCancelData_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(0, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(pnlSiteLocation, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(48, 293);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 72F));
            tableLayoutPanel6.Size = new Size(1066, 213);
            tableLayoutPanel6.TabIndex = 65;
            // 
            // pnlSiteLocation
            // 
            pnlSiteLocation.BackColor = Color.FromArgb(234, 237, 225);
            pnlSiteLocation.Controls.Add(pictureBox3);
            pnlSiteLocation.Controls.Add(label4);
            pnlSiteLocation.Dock = DockStyle.Fill;
            pnlSiteLocation.Location = new Point(3, 3);
            pnlSiteLocation.Name = "pnlSiteLocation";
            pnlSiteLocation.Size = new Size(1060, 53);
            pnlSiteLocation.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = Properties.Resources.locationSite;
            pictureBox3.Location = new Point(26, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 14);
            label4.Name = "label4";
            label4.Size = new Size(168, 23);
            label4.TabIndex = 0;
            label4.Text = "Ubicación del sitio";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.FromArgb(179, 194, 148);
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tlyDistrict, 0, 2);
            tableLayoutPanel7.Controls.Add(tlyNeighborhood, 0, 4);
            tableLayoutPanel7.Controls.Add(tlpAddress, 0, 6);
            tableLayoutPanel7.Controls.Add(panel16, 0, 5);
            tableLayoutPanel7.Controls.Add(panel15, 0, 3);
            tableLayoutPanel7.Controls.Add(panel14, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 62);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 7;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 2.94117641F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 1.96078432F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 30.3921566F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 1.96078432F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 30.3921566F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 1.96078432F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 30.3921566F));
            tableLayoutPanel7.Size = new Size(1060, 148);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // tlyDistrict
            // 
            tlyDistrict.ColumnCount = 2;
            tlyDistrict.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlyDistrict.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlyDistrict.Controls.Add(cmbDistrict, 1, 0);
            tlyDistrict.Controls.Add(label12, 0, 0);
            tlyDistrict.Dock = DockStyle.Fill;
            tlyDistrict.Location = new Point(3, 9);
            tlyDistrict.Name = "tlyDistrict";
            tlyDistrict.RowCount = 1;
            tlyDistrict.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlyDistrict.Size = new Size(1054, 38);
            tlyDistrict.TabIndex = 3;
            // 
            // cmbDistrict
            // 
            cmbDistrict.FormattingEnabled = true;
            cmbDistrict.Items.AddRange(new object[] { "Distrito I", "Distrito II", "Distrito III", "Distrito IV", "Distrito V", "Distrito VI", "Distrito VII" });
            cmbDistrict.Location = new Point(213, 3);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Size = new Size(456, 28);
            cmbDistrict.TabIndex = 12;
            cmbDistrict.SelectedIndexChanged += cmbDistrict_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 11;
            label12.Text = "Distrito";
            // 
            // tlyNeighborhood
            // 
            tlyNeighborhood.ColumnCount = 2;
            tlyNeighborhood.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlyNeighborhood.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlyNeighborhood.Controls.Add(cmbNeighborhood, 1, 0);
            tlyNeighborhood.Controls.Add(label6, 0, 0);
            tlyNeighborhood.Dock = DockStyle.Fill;
            tlyNeighborhood.Location = new Point(3, 55);
            tlyNeighborhood.Name = "tlyNeighborhood";
            tlyNeighborhood.RowCount = 1;
            tlyNeighborhood.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlyNeighborhood.Size = new Size(1054, 38);
            tlyNeighborhood.TabIndex = 4;
            // 
            // cmbNeighborhood
            // 
            cmbNeighborhood.FormattingEnabled = true;
            cmbNeighborhood.IntegralHeight = false;
            cmbNeighborhood.Location = new Point(213, 3);
            cmbNeighborhood.Name = "cmbNeighborhood";
            cmbNeighborhood.Size = new Size(456, 28);
            cmbNeighborhood.TabIndex = 13;
            cmbNeighborhood.SelectedIndexChanged += cmbNeighborhood_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 12;
            label6.Text = "Barrio";
            // 
            // tlpAddress
            // 
            tlpAddress.ColumnCount = 2;
            tlpAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpAddress.Controls.Add(rchtxtAddress, 1, 0);
            tlpAddress.Controls.Add(label13, 0, 0);
            tlpAddress.Dock = DockStyle.Fill;
            tlpAddress.Location = new Point(3, 101);
            tlpAddress.Name = "tlpAddress";
            tlpAddress.RowCount = 1;
            tlpAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAddress.Size = new Size(1054, 44);
            tlpAddress.TabIndex = 5;
            // 
            // rchtxtAddress
            // 
            rchtxtAddress.Location = new Point(213, 3);
            rchtxtAddress.Name = "rchtxtAddress";
            rchtxtAddress.Size = new Size(542, 38);
            rchtxtAddress.TabIndex = 14;
            rchtxtAddress.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(81, 20);
            label13.TabIndex = 13;
            label13.Text = "Dirección";
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(225, 225, 225);
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(3, 99);
            panel16.Name = "panel16";
            panel16.Size = new Size(1054, 1);
            panel16.TabIndex = 2;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(225, 225, 225);
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(3, 53);
            panel15.Name = "panel15";
            panel15.Size = new Size(1054, 1);
            panel15.TabIndex = 1;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(225, 225, 225);
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(3, 7);
            panel14.Name = "panel14";
            panel14.Size = new Size(1054, 1);
            panel14.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNext);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 787);
            panel1.TabIndex = 66;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(listViewFile, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(48, 506);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(1066, 288);
            tableLayoutPanel2.TabIndex = 67;
            // 
            // listViewFile
            // 
            listViewFile.BackColor = Color.FromArgb(179, 194, 148);
            listViewFile.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewFile.Dock = DockStyle.Fill;
            listViewFile.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewFile.FullRowSelect = true;
            listViewFile.Location = new Point(3, 60);
            listViewFile.Name = "listViewFile";
            listViewFile.Size = new Size(1060, 225);
            listViewFile.TabIndex = 5;
            listViewFile.UseCompatibleStateImageBehavior = false;
            listViewFile.View = System.Windows.Forms.View.Details;
            listViewFile.SelectedIndexChanged += listViewFile_SelectedIndexChanged;
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
            panel2.Controls.Add(btnAttachFile);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1060, 51);
            panel2.TabIndex = 4;
            // 
            // btnAttachFile
            // 
            btnAttachFile.Anchor = AnchorStyles.Right;
            btnAttachFile.BackColor = Color.FromArgb(69, 93, 51);
            btnAttachFile.Cursor = Cursors.Hand;
            btnAttachFile.FlatAppearance.BorderSize = 0;
            btnAttachFile.FlatStyle = FlatStyle.Flat;
            btnAttachFile.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            btnAttachFile.ForeColor = Color.FromArgb(246, 246, 247);
            btnAttachFile.Image = Properties.Resources.plus;
            btnAttachFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttachFile.Location = new Point(812, 3);
            btnAttachFile.Name = "btnAttachFile";
            btnAttachFile.Size = new Size(211, 44);
            btnAttachFile.TabIndex = 5;
            btnAttachFile.Text = "Adjuntar archivo";
            btnAttachFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttachFile.UseVisualStyleBackColor = false;
            btnAttachFile.Click += btnAttachFile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.AttachIcon;
            pictureBox1.Location = new Point(26, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 13);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 0;
            label1.Text = "Evidencia multimedia";
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(48, 853);
            panel11.Name = "panel11";
            panel11.Size = new Size(1066, 23);
            panel11.TabIndex = 63;
            // 
            // frmInformacionSitio
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(227, 235, 216);
            ClientSize = new Size(1162, 876);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel6);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInformacionSitio";
            WindowState = FormWindowState.Maximized;
            Load += SiteLocationView_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tlpInformationSite.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel12.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            pnlSiteLocation.ResumeLayout(false);
            pnlSiteLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tlyDistrict.ResumeLayout(false);
            tlyDistrict.PerformLayout();
            tlyNeighborhood.ResumeLayout(false);
            tlyNeighborhood.PerformLayout();
            tlpAddress.ResumeLayout(false);
            tlpAddress.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label5;
        private Label label9;
        private Panel panel4;
        private Panel panel7;
        private CheckedListBox ckListTypeWaste;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel10;
        private Label label11;
        private PictureBox pictureBox2;
        private TableLayoutPanel tlpInformationSite;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private Label label3;
        private ComboBox cmbTypeSite;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel12;
        private Button btnCancelData;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel pnlSiteLocation;
        private PictureBox pictureBox3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel16;
        private Panel panel15;
        private Panel panel14;
        private TableLayoutPanel tlyDistrict;
        private TableLayoutPanel tlyNeighborhood;
        private TableLayoutPanel tlpAddress;
        private Label label12;
        private ComboBox cmbDistrict;
        private Label label6;
        private ComboBox cmbNeighborhood;
        private Label label13;
        private RichTextBox rchtxtAddress;
        private Button btnNext;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private ListView listViewFile;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnAttachFile;
        private Button button3;
        private Panel panel11;
        private Button btnSendRequest;
    }
}