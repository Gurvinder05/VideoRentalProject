namespace VideoRentalProject
{
    partial class VideosRentalSystem
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
            this.griddataCustomer = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.areatextAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxMobile = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridVideoData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textTitleVideo = new System.Windows.Forms.TextBox();
            this.dateRelease = new System.Windows.Forms.DateTimePicker();
            this.TextCost = new System.Windows.Forms.TextBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.TextGenre = new System.Windows.Forms.TextBox();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.Textplot = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpRentedDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRentedOut = new System.Windows.Forms.Button();
            this.ddlVideoList = new System.Windows.Forms.ComboBox();
            this.btnAllRentedVideo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.ddlCutomerList = new System.Windows.Forms.ComboBox();
            this.gridRentalVideos = new System.Windows.Forms.DataGridView();
            this.RMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVideoOnRental = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridCustomeList = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gridPopularVideoList = new System.Windows.Forms.DataGridView();
            this.video_id = new System.Windows.Forms.Label();
            this.rentalMovie_id = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.griddataCustomer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideoData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentalVideos)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomeList)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideoList)).BeginInit();
            this.SuspendLayout();
            // 
            // griddataCustomer
            // 
            this.griddataCustomer.AllowUserToAddRows = false;
            this.griddataCustomer.AllowUserToDeleteRows = false;
            this.griddataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddataCustomer.Location = new System.Drawing.Point(481, 15);
            this.griddataCustomer.Name = "griddataCustomer";
            this.griddataCustomer.ReadOnly = true;
            this.griddataCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.griddataCustomer.Size = new System.Drawing.Size(485, 382);
            this.griddataCustomer.TabIndex = 0;
            this.griddataCustomer.Click += new System.EventHandler(this.griddataCustomer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 454);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textboxFirstName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TextLastname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.customer_id);
            this.tabPage1.Controls.Add(this.areatextAddress);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textboxMobile);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.griddataCustomer);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "First Name";
            // 
            // textboxFirstName
            // 
            this.textboxFirstName.Location = new System.Drawing.Point(170, 37);
            this.textboxFirstName.Name = "textboxFirstName";
            this.textboxFirstName.Size = new System.Drawing.Size(223, 26);
            this.textboxFirstName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Last Name";
            // 
            // TextLastname
            // 
            this.TextLastname.Location = new System.Drawing.Point(170, 87);
            this.TextLastname.Name = "TextLastname";
            this.TextLastname.Size = new System.Drawing.Size(223, 26);
            this.TextLastname.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Address";
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Location = new System.Drawing.Point(26, 226);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(0, 20);
            this.customer_id.TabIndex = 7;
            this.customer_id.Visible = false;
            // 
            // areatextAddress
            // 
            this.areatextAddress.Location = new System.Drawing.Point(170, 137);
            this.areatextAddress.Multiline = true;
            this.areatextAddress.Name = "areatextAddress";
            this.areatextAddress.Size = new System.Drawing.Size(223, 49);
            this.areatextAddress.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Phone No";
            // 
            // textboxMobile
            // 
            this.textboxMobile.Location = new System.Drawing.Point(170, 206);
            this.textboxMobile.Name = "textboxMobile";
            this.textboxMobile.Size = new System.Drawing.Size(223, 26);
            this.textboxMobile.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(6, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 58);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(157, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 56);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(309, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 54);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridVideoData);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textTitleVideo);
            this.tabPage2.Controls.Add(this.dateRelease);
            this.tabPage2.Controls.Add(this.TextCost);
            this.tabPage2.Controls.Add(this.btnDeleteMovie);
            this.tabPage2.Controls.Add(this.TextGenre);
            this.tabPage2.Controls.Add(this.btnUpdateMovie);
            this.tabPage2.Controls.Add(this.Textplot);
            this.tabPage2.Controls.Add(this.btnAddMovie);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridVideoData
            // 
            this.gridVideoData.AllowUserToAddRows = false;
            this.gridVideoData.AllowUserToDeleteRows = false;
            this.gridVideoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVideoData.Location = new System.Drawing.Point(447, 11);
            this.gridVideoData.Name = "gridVideoData";
            this.gridVideoData.ReadOnly = true;
            this.gridVideoData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVideoData.Size = new System.Drawing.Size(519, 393);
            this.gridVideoData.TabIndex = 1;
            this.gridVideoData.Click += new System.EventHandler(this.gridVideoData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Video Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Release Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rental Cost";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Genre";
            // 
            // textTitleVideo
            // 
            this.textTitleVideo.Location = new System.Drawing.Point(161, 30);
            this.textTitleVideo.Name = "textTitleVideo";
            this.textTitleVideo.Size = new System.Drawing.Size(193, 26);
            this.textTitleVideo.TabIndex = 10;
            // 
            // dateRelease
            // 
            this.dateRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRelease.Location = new System.Drawing.Point(161, 70);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(193, 20);
            this.dateRelease.TabIndex = 11;
            this.dateRelease.ValueChanged += new System.EventHandler(this.dateRelease_ValueChanged);
            // 
            // TextCost
            // 
            this.TextCost.Location = new System.Drawing.Point(161, 107);
            this.TextCost.Name = "TextCost";
            this.TextCost.Size = new System.Drawing.Size(193, 26);
            this.TextCost.TabIndex = 12;
            this.TextCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMovie.Location = new System.Drawing.Point(285, 265);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(105, 64);
            this.btnDeleteMovie.TabIndex = 17;
            this.btnDeleteMovie.Text = "Delete";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // TextGenre
            // 
            this.TextGenre.Location = new System.Drawing.Point(161, 144);
            this.TextGenre.Name = "TextGenre";
            this.TextGenre.Size = new System.Drawing.Size(193, 26);
            this.TextGenre.TabIndex = 13;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdateMovie.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMovie.Location = new System.Drawing.Point(148, 265);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(105, 64);
            this.btnUpdateMovie.TabIndex = 16;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // Textplot
            // 
            this.Textplot.Location = new System.Drawing.Point(161, 183);
            this.Textplot.Name = "Textplot";
            this.Textplot.Size = new System.Drawing.Size(193, 26);
            this.Textplot.TabIndex = 14;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddMovie.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.Location = new System.Drawing.Point(22, 265);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(105, 64);
            this.btnAddMovie.TabIndex = 15;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dtpRentedDate);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnRentedOut);
            this.tabPage3.Controls.Add(this.ddlVideoList);
            this.tabPage3.Controls.Add(this.btnAllRentedVideo);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnReturnMovie);
            this.tabPage3.Controls.Add(this.ddlCutomerList);
            this.tabPage3.Controls.Add(this.gridRentalVideos);
            this.tabPage3.Controls.Add(this.btnVideoOnRental);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental/Return Video\'s";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Rental Date";
            // 
            // dtpRentedDate
            // 
            this.dtpRentedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpRentedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentedDate.Location = new System.Drawing.Point(133, 103);
            this.dtpRentedDate.Name = "dtpRentedDate";
            this.dtpRentedDate.Size = new System.Drawing.Size(230, 20);
            this.dtpRentedDate.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Select Video";
            // 
            // btnRentedOut
            // 
            this.btnRentedOut.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRentedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentedOut.ForeColor = System.Drawing.Color.White;
            this.btnRentedOut.Location = new System.Drawing.Point(858, 148);
            this.btnRentedOut.Name = "btnRentedOut";
            this.btnRentedOut.Size = new System.Drawing.Size(104, 37);
            this.btnRentedOut.TabIndex = 33;
            this.btnRentedOut.Text = "Rented Out Video";
            this.btnRentedOut.UseVisualStyleBackColor = false;
            this.btnRentedOut.Click += new System.EventHandler(this.btnRentedOut_Click);
            // 
            // ddlVideoList
            // 
            this.ddlVideoList.FormattingEnabled = true;
            this.ddlVideoList.Location = new System.Drawing.Point(133, 61);
            this.ddlVideoList.Name = "ddlVideoList";
            this.ddlVideoList.Size = new System.Drawing.Size(230, 28);
            this.ddlVideoList.TabIndex = 46;
           
            // 
            // btnAllRentedVideo
            // 
            this.btnAllRentedVideo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAllRentedVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRentedVideo.ForeColor = System.Drawing.Color.White;
            this.btnAllRentedVideo.Location = new System.Drawing.Point(744, 148);
            this.btnAllRentedVideo.Name = "btnAllRentedVideo";
            this.btnAllRentedVideo.Size = new System.Drawing.Size(104, 37);
            this.btnAllRentedVideo.TabIndex = 23;
            this.btnAllRentedVideo.Text = "All Rented Video List";
            this.btnAllRentedVideo.UseVisualStyleBackColor = false;
            this.btnAllRentedVideo.Click += new System.EventHandler(this.btnAllRentedVideo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Select Customer";
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.White;
            this.btnReturnMovie.Location = new System.Drawing.Point(634, 148);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(104, 37);
            this.btnReturnMovie.TabIndex = 22;
            this.btnReturnMovie.Text = "Return Video";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // ddlCutomerList
            // 
            this.ddlCutomerList.FormattingEnabled = true;
            this.ddlCutomerList.Location = new System.Drawing.Point(133, 13);
            this.ddlCutomerList.Name = "ddlCutomerList";
            this.ddlCutomerList.Size = new System.Drawing.Size(230, 28);
            this.ddlCutomerList.TabIndex = 44;
           
            // 
            // gridRentalVideos
            // 
            this.gridRentalVideos.AllowUserToAddRows = false;
            this.gridRentalVideos.AllowUserToDeleteRows = false;
            this.gridRentalVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRentalVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMID,
            this.CustId,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone,
            this.MovieId,
            this.Title,
            this.ReleaseDate,
            this.RentalCost,
            this.Genre,
            this.Plot,
            this.DateRented,
            this.DateReturned});
            this.gridRentalVideos.Location = new System.Drawing.Point(6, 191);
            this.gridRentalVideos.Name = "gridRentalVideos";
            this.gridRentalVideos.ReadOnly = true;
            this.gridRentalVideos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRentalVideos.Size = new System.Drawing.Size(960, 224);
            this.gridRentalVideos.TabIndex = 2;
            this.gridRentalVideos.Click += new System.EventHandler(this.gridRentalVideos_Click);
            // 
            // RMID
            // 
            this.RMID.DataPropertyName = "RentedMovieId";
            this.RMID.HeaderText = "RMID";
            this.RMID.Name = "RMID";
            this.RMID.ReadOnly = true;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "CustId";
            this.CustId.Name = "CustId";
            this.CustId.ReadOnly = true;
            this.CustId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Movie Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Visible = false;
            // 
            // RentalCost
            // 
            this.RentalCost.DataPropertyName = "RentalCost";
            this.RentalCost.HeaderText = "Rental Cost";
            this.RentalCost.Name = "RentalCost";
            this.RentalCost.ReadOnly = true;
            this.RentalCost.Width = 50;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Visible = false;
            // 
            // Plot
            // 
            this.Plot.DataPropertyName = "Plot";
            this.Plot.HeaderText = "Plot";
            this.Plot.Name = "Plot";
            this.Plot.ReadOnly = true;
            this.Plot.Visible = false;
            // 
            // DateRented
            // 
            this.DateRented.DataPropertyName = "DateRented";
            this.DateRented.HeaderText = "Date Rented";
            this.DateRented.Name = "DateRented";
            this.DateRented.ReadOnly = true;
            this.DateRented.Width = 150;
            // 
            // DateReturned
            // 
            this.DateReturned.DataPropertyName = "DateReturned";
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            this.DateReturned.Width = 150;
            // 
            // btnVideoOnRental
            // 
            this.btnVideoOnRental.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnVideoOnRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoOnRental.ForeColor = System.Drawing.Color.White;
            this.btnVideoOnRental.Location = new System.Drawing.Point(133, 136);
            this.btnVideoOnRental.Name = "btnVideoOnRental";
            this.btnVideoOnRental.Size = new System.Drawing.Size(122, 37);
            this.btnVideoOnRental.TabIndex = 20;
            this.btnVideoOnRental.Text = "Video On Rental";
            this.btnVideoOnRental.UseVisualStyleBackColor = false;
            this.btnVideoOnRental.Click += new System.EventHandler(this.btnVideoOnRental_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridCustomeList);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(972, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Most Rental Customer List";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gridCustomeList
            // 
            this.gridCustomeList.AllowUserToAddRows = false;
            this.gridCustomeList.AllowUserToDeleteRows = false;
            this.gridCustomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomeList.Location = new System.Drawing.Point(135, 18);
            this.gridCustomeList.Name = "gridCustomeList";
            this.gridCustomeList.ReadOnly = true;
            this.gridCustomeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomeList.Size = new System.Drawing.Size(639, 381);
            this.gridCustomeList.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gridPopularVideoList);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(972, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Most Popular Video\'s";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gridPopularVideoList
            // 
            this.gridPopularVideoList.AllowUserToAddRows = false;
            this.gridPopularVideoList.AllowUserToDeleteRows = false;
            this.gridPopularVideoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopularVideoList.Location = new System.Drawing.Point(164, 16);
            this.gridPopularVideoList.Name = "gridPopularVideoList";
            this.gridPopularVideoList.ReadOnly = true;
            this.gridPopularVideoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPopularVideoList.Size = new System.Drawing.Size(647, 399);
            this.gridPopularVideoList.TabIndex = 3;
            // 
            // video_id
            // 
            this.video_id.AutoSize = true;
            this.video_id.Location = new System.Drawing.Point(80, 44);
            this.video_id.Name = "video_id";
            this.video_id.Size = new System.Drawing.Size(0, 13);
            this.video_id.TabIndex = 19;
            this.video_id.Visible = false;
            // 
            // rentalMovie_id
            // 
            this.rentalMovie_id.AutoSize = true;
            this.rentalMovie_id.Location = new System.Drawing.Point(131, 43);
            this.rentalMovie_id.Name = "rentalMovie_id";
            this.rentalMovie_id.Size = new System.Drawing.Size(0, 13);
            this.rentalMovie_id.TabIndex = 21;
            this.rentalMovie_id.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(306, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(412, 53);
            this.label10.TabIndex = 36;
            this.label10.Text = "Video Rental System";
            // 
            // VideosRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rentalMovie_id);
            this.Controls.Add(this.video_id);
            this.Controls.Add(this.tabControl1);
            this.Name = "VideosRentalSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Rental system";
            this.Load += new System.EventHandler(this.VideosRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddataCustomer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideoData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRentalVideos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomeList)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularVideoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView griddataCustomer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridVideoData;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox Textplot;
        private System.Windows.Forms.TextBox TextCost;
        private System.Windows.Forms.TextBox TextGenre;
        private System.Windows.Forms.TextBox textTitleVideo;
        private System.Windows.Forms.DateTimePicker dateRelease;
        private System.Windows.Forms.Label video_id;
        private System.Windows.Forms.Button btnVideoOnRental;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridRentalVideos;
        private System.Windows.Forms.Label rentalMovie_id;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnAllRentedVideo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView gridCustomeList;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView gridPopularVideoList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRentedOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox areatextAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxMobile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpRentedDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlVideoList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddlCutomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plot;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
        private System.Windows.Forms.Label customer_id;
    }
}

