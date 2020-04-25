namespace St_Thomas_AcademyLibrarySystem
{
    partial class AddaBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtLexileLevel = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBooktitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblBookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTALibraryDataSet1 = new St_Thomas_AcademyLibrarySystem.STALibraryDataSet1();
            this.tblBookListTableAdapter = new St_Thomas_AcademyLibrarySystem.STALibraryDataSet1TableAdapters.tblBookListTableAdapter();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dgvAddBooks = new System.Windows.Forms.DataGridView();
            this.datePublished = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTALibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtCategory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCategory.Location = new System.Drawing.Point(31, 223);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(231, 22);
            this.txtCategory.TabIndex = 15;
            this.txtCategory.Text = "Category";
            this.txtCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCategory_MouseClick);
            this.txtCategory.Enter += new System.EventHandler(this.txtCategory_Enter);
            this.txtCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategory_KeyPress);
            this.txtCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCategory_KeyUp);
            // 
            // txtLexileLevel
            // 
            this.txtLexileLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtLexileLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLexileLevel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtLexileLevel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtLexileLevel.Location = new System.Drawing.Point(31, 179);
            this.txtLexileLevel.Name = "txtLexileLevel";
            this.txtLexileLevel.Size = new System.Drawing.Size(231, 22);
            this.txtLexileLevel.TabIndex = 14;
            this.txtLexileLevel.Text = "Lexile Level";
            this.txtLexileLevel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLexileLevel_MouseClick);
            this.txtLexileLevel.Enter += new System.EventHandler(this.txtLexileLevel_Enter);
            this.txtLexileLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLexileLevel_KeyPress);
            this.txtLexileLevel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLexileLevel_KeyUp);
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtPublisher.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPublisher.Location = new System.Drawing.Point(31, 132);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(231, 22);
            this.txtPublisher.TabIndex = 13;
            this.txtPublisher.Text = "Publisher";
            this.txtPublisher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPublisher_MouseClick);
            this.txtPublisher.Enter += new System.EventHandler(this.txtPublisher_Enter);
            this.txtPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisher_KeyPress);
            this.txtPublisher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPublisher_KeyUp);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAuthor.Location = new System.Drawing.Point(31, 84);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(231, 22);
            this.txtAuthor.TabIndex = 12;
            this.txtAuthor.Text = "Author";
            this.txtAuthor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAuthor_MouseClick);
            this.txtAuthor.Enter += new System.EventHandler(this.txtAuthor_Enter);
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_KeyPress);
            this.txtAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAuthor_KeyUp);
            // 
            // txtBooktitle
            // 
            this.txtBooktitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtBooktitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBooktitle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtBooktitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBooktitle.Location = new System.Drawing.Point(31, 37);
            this.txtBooktitle.Name = "txtBooktitle";
            this.txtBooktitle.Size = new System.Drawing.Size(231, 22);
            this.txtBooktitle.TabIndex = 11;
            this.txtBooktitle.Text = "Book Title";
            this.txtBooktitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBooktitle_MouseClick);
            this.txtBooktitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBooktitle_KeyPress);
            this.txtBooktitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBooktitle_KeyUp);
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtISBN.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtISBN.Location = new System.Drawing.Point(31, 358);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(231, 22);
            this.txtISBN.TabIndex = 22;
            this.txtISBN.Text = "ISBN";
            this.txtISBN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPages_MouseClick);
            this.txtISBN.Enter += new System.EventHandler(this.txtPages_Enter);
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPages_KeyPress);
            this.txtISBN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPages_KeyUp);
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtDatePublished.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatePublished.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtDatePublished.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDatePublished.Location = new System.Drawing.Point(31, 311);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.ReadOnly = true;
            this.txtDatePublished.Size = new System.Drawing.Size(231, 22);
            this.txtDatePublished.TabIndex = 21;
            this.txtDatePublished.Text = "Date Published";
            this.txtDatePublished.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDatePublished_MouseClick);
            this.txtDatePublished.Enter += new System.EventHandler(this.txtDatePublished_Enter);
            this.txtDatePublished.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatePublished_KeyPress);
            this.txtDatePublished.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDatePublished_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.addbookbutton;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(94, 571);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 63);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblBookListBindingSource
            // 
            this.tblBookListBindingSource.DataMember = "tblBookList";
            this.tblBookListBindingSource.DataSource = this.sTALibraryDataSet1;
            // 
            // sTALibraryDataSet1
            // 
            this.sTALibraryDataSet1.DataSetName = "STALibraryDataSet1";
            this.sTALibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBookListTableAdapter
            // 
            this.tblBookListTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.btnBack.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.left207__1_;
            this.btnBack.Location = new System.Drawing.Point(311, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 64);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 40;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label10.Location = new System.Drawing.Point(381, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 54);
            this.label10.TabIndex = 41;
            this.label10.Text = "Back";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox1.Location = new System.Drawing.Point(13, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox2.Location = new System.Drawing.Point(13, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox3.Location = new System.Drawing.Point(13, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox4.Location = new System.Drawing.Point(13, 169);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(266, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 45;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox5.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox5.Location = new System.Drawing.Point(13, 213);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(266, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox6.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox6.Location = new System.Drawing.Point(13, 302);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(266, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox7.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox7.Location = new System.Drawing.Point(13, 349);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(266, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 48;
            this.pictureBox7.TabStop = false;
            // 
            // dgvAddBooks
            // 
            this.dgvAddBooks.AllowUserToAddRows = false;
            this.dgvAddBooks.AllowUserToDeleteRows = false;
            this.dgvAddBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.dgvAddBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAddBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAddBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAddBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAddBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddBooks.Location = new System.Drawing.Point(317, 160);
            this.dgvAddBooks.MultiSelect = false;
            this.dgvAddBooks.Name = "dgvAddBooks";
            this.dgvAddBooks.ReadOnly = true;
            this.dgvAddBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.dgvAddBooks.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAddBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddBooks.Size = new System.Drawing.Size(837, 451);
            this.dgvAddBooks.TabIndex = 50;
            this.dgvAddBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddBooks_CellClick);
            // 
            // datePublished
            // 
            this.datePublished.CustomFormat = "MMMM dd, yyyy";
            this.datePublished.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.datePublished.Location = new System.Drawing.Point(31, 263);
            this.datePublished.Name = "datePublished";
            this.datePublished.Size = new System.Drawing.Size(231, 27);
            this.datePublished.TabIndex = 51;
            this.datePublished.ValueChanged += new System.EventHandler(this.datePublished_ValueChanged);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBook.BackgroundImage = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.addbookbutton;
            this.btnUpdateBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Location = new System.Drawing.Point(95, 502);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(184, 63);
            this.btnUpdateBook.TabIndex = 52;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSearch.Location = new System.Drawing.Point(900, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 22);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox8.Image = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.txtfield;
            this.pictureBox8.Location = new System.Drawing.Point(882, 97);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(266, 41);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 54;
            this.pictureBox8.TabStop = false;
            // 
            // AddaBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::St_Thomas_AcademyLibrarySystem.Properties.Resources.newBG;
            this.ClientSize = new System.Drawing.Size(1171, 628);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.datePublished);
            this.Controls.Add(this.dgvAddBooks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtDatePublished);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtLexileLevel);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBooktitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AddaBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddaBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddaBook_FormClosing);
            this.Load += new System.EventHandler(this.AddaBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBookListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTALibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtLexileLevel;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBooktitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtDatePublished;
        private System.Windows.Forms.Button btnAdd;
        private STALibraryDataSet1 sTALibraryDataSet1;
        private System.Windows.Forms.BindingSource tblBookListBindingSource;
        private STALibraryDataSet1TableAdapters.tblBookListTableAdapter tblBookListTableAdapter;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.DataGridView dgvAddBooks;
        private System.Windows.Forms.DateTimePicker datePublished;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}