namespace Popcornia
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QueryBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movieYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.movieGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.movieDirector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.movieProducer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.movieComposer = new System.Windows.Forms.TextBox();
            this.ActorBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.movieSearch = new System.Windows.Forms.TextBox();
            this.SearchByActor = new System.Windows.Forms.TextBox();
            this.searchByRoleActor = new System.Windows.Forms.Button();
            this.searchType = new System.Windows.Forms.ComboBox();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FAV2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.FAV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nTotal = new System.Windows.Forms.Label();
            this.expireDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.nDays = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.extraMoney = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.extraDays = new System.Windows.Forms.NumericUpDown();
            this.ExtendButton = new System.Windows.Forms.Button();
            this.DeleteRent = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rentSDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RentBox = new System.Windows.Forms.ListBox();
            this.rentRDate = new System.Windows.Forms.TextBox();
            this.rentDaysLeft = new System.Windows.Forms.TextBox();
            this.rentPrice = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.rentTitle = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popcorniaDataSet1 = new Popcornia.PopcorniaDataSet1();
            this.moviesTableAdapter = new Popcornia.PopcorniaDataSet1TableAdapters.MoviesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraDays)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QueryBox
            // 
            this.QueryBox.FormattingEnabled = true;
            this.QueryBox.Location = new System.Drawing.Point(222, 71);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(314, 381);
            this.QueryBox.TabIndex = 1;
            this.QueryBox.SelectedIndexChanged += new System.EventHandler(this.QueryBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All Movies Library";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // movieTitle
            // 
            this.movieTitle.Enabled = false;
            this.movieTitle.Location = new System.Drawing.Point(74, 71);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(142, 20);
            this.movieTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Year";
            // 
            // movieYear
            // 
            this.movieYear.Enabled = false;
            this.movieYear.Location = new System.Drawing.Point(74, 97);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(142, 20);
            this.movieYear.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Genre";
            // 
            // movieGenre
            // 
            this.movieGenre.Enabled = false;
            this.movieGenre.Location = new System.Drawing.Point(74, 123);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(142, 20);
            this.movieGenre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Director";
            // 
            // movieDirector
            // 
            this.movieDirector.Enabled = false;
            this.movieDirector.Location = new System.Drawing.Point(74, 149);
            this.movieDirector.Name = "movieDirector";
            this.movieDirector.Size = new System.Drawing.Size(142, 20);
            this.movieDirector.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Producer";
            // 
            // movieProducer
            // 
            this.movieProducer.Enabled = false;
            this.movieProducer.Location = new System.Drawing.Point(74, 175);
            this.movieProducer.Name = "movieProducer";
            this.movieProducer.Size = new System.Drawing.Size(142, 20);
            this.movieProducer.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Composer";
            // 
            // movieComposer
            // 
            this.movieComposer.Enabled = false;
            this.movieComposer.Location = new System.Drawing.Point(74, 201);
            this.movieComposer.Name = "movieComposer";
            this.movieComposer.Size = new System.Drawing.Size(142, 20);
            this.movieComposer.TabIndex = 17;
            // 
            // ActorBox
            // 
            this.ActorBox.FormattingEnabled = true;
            this.ActorBox.Location = new System.Drawing.Point(18, 266);
            this.ActorBox.Name = "ActorBox";
            this.ActorBox.Size = new System.Drawing.Size(198, 186);
            this.ActorBox.TabIndex = 19;
            this.ActorBox.SelectedIndexChanged += new System.EventHandler(this.ActorBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 22);
            this.button2.TabIndex = 20;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // movieSearch
            // 
            this.movieSearch.Enabled = false;
            this.movieSearch.Location = new System.Drawing.Point(222, 24);
            this.movieSearch.MinimumSize = new System.Drawing.Size(4, 21);
            this.movieSearch.Name = "movieSearch";
            this.movieSearch.Size = new System.Drawing.Size(229, 20);
            this.movieSearch.TabIndex = 21;
            // 
            // SearchByActor
            // 
            this.SearchByActor.Enabled = false;
            this.SearchByActor.Location = new System.Drawing.Point(74, 227);
            this.SearchByActor.Name = "SearchByActor";
            this.SearchByActor.Size = new System.Drawing.Size(142, 20);
            this.SearchByActor.TabIndex = 24;
            this.SearchByActor.TextChanged += new System.EventHandler(this.SearchByActor_TextChanged);
            // 
            // searchByRoleActor
            // 
            this.searchByRoleActor.Enabled = false;
            this.searchByRoleActor.Location = new System.Drawing.Point(18, 458);
            this.searchByRoleActor.Name = "searchByRoleActor";
            this.searchByRoleActor.Size = new System.Drawing.Size(200, 22);
            this.searchByRoleActor.TabIndex = 25;
            this.searchByRoleActor.UseVisualStyleBackColor = true;
            this.searchByRoleActor.Click += new System.EventHandler(this.searchByRoleActor_Click);
            // 
            // searchType
            // 
            this.searchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchType.FormattingEnabled = true;
            this.searchType.Items.AddRange(new object[] {
            "Name",
            "Actor",
            "Role",
            "Genre",
            "Director",
            "Producer",
            "Composer"});
            this.searchType.Location = new System.Drawing.Point(74, 24);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(142, 21);
            this.searchType.TabIndex = 26;
            this.searchType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GenreBox
            // 
            this.GenreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Items.AddRange(new object[] {
            "Action ",
            "Adventure ",
            "Comedy ",
            "Crime ",
            "Drama ",
            "Fantasy ",
            "Historical ",
            "Hi - Fi",
            "Horror ",
            "Magical ",
            "Mystery ",
            "Paranoid ",
            "Philosophical ",
            "Political ",
            "Romance ",
            "Saga ",
            "Satire ",
            "Sc-fi",
            "Slice of Life ",
            "Speculative ",
            "Thriller ",
            "Llrban ",
            "Western"});
            this.GenreBox.Location = new System.Drawing.Point(222, 24);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(229, 21);
            this.GenreBox.TabIndex = 27;
            this.GenreBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FAV2);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.FAV);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Controls.Add(this.QueryBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.movieYear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ActorBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.movieSearch);
            this.groupBox1.Controls.Add(this.movieGenre);
            this.groupBox1.Controls.Add(this.movieProducer);
            this.groupBox1.Controls.Add(this.SearchByActor);
            this.groupBox1.Controls.Add(this.GenreBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.movieTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.searchType);
            this.groupBox1.Controls.Add(this.searchByRoleActor);
            this.groupBox1.Controls.Add(this.movieDirector);
            this.groupBox1.Controls.Add(this.movieComposer);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(456, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 582);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Movies";
            // 
            // FAV2
            // 
            this.FAV2.Location = new System.Drawing.Point(50, 70);
            this.FAV2.Name = "FAV2";
            this.FAV2.Size = new System.Drawing.Size(22, 22);
            this.FAV2.TabIndex = 35;
            this.FAV2.Text = "☆";
            this.FAV2.UseVisualStyleBackColor = true;
            this.FAV2.Click += new System.EventHandler(this.FAV2_Click_1);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(15, 251);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(202, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "Roles          ----------------------------------------------";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // FAV
            // 
            this.FAV.Location = new System.Drawing.Point(50, 226);
            this.FAV.Name = "FAV";
            this.FAV.Size = new System.Drawing.Size(22, 22);
            this.FAV.TabIndex = 33;
            this.FAV.Text = "☆";
            this.FAV.UseVisualStyleBackColor = true;
            this.FAV.Click += new System.EventHandler(this.FAV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nTotal);
            this.groupBox2.Controls.Add(this.expireDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nDays);
            this.groupBox2.Controls.Add(this.Days);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Rent);
            this.groupBox2.Controls.Add(this.Total);
            this.groupBox2.Location = new System.Drawing.Point(18, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 74);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rent";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(252, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 13);
            this.label13.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Movie:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "Return Date:";
            // 
            // nTotal
            // 
            this.nTotal.BackColor = System.Drawing.SystemColors.Control;
            this.nTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.nTotal.Location = new System.Drawing.Point(344, 50);
            this.nTotal.Name = "nTotal";
            this.nTotal.Size = new System.Drawing.Size(59, 13);
            this.nTotal.TabIndex = 39;
            this.nTotal.Text = "0 $";
            // 
            // expireDate
            // 
            this.expireDate.Enabled = false;
            this.expireDate.Location = new System.Drawing.Point(12, 37);
            this.expireDate.MinDate = new System.DateTime(2017, 5, 5, 2, 10, 48, 0);
            this.expireDate.MinimumSize = new System.Drawing.Size(4, 26);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(198, 26);
            this.expireDate.TabIndex = 32;
            this.expireDate.Value = new System.DateTime(2017, 5, 5, 2, 10, 48, 0);
            this.expireDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(310, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = " Total:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // nDays
            // 
            this.nDays.Location = new System.Drawing.Point(276, 50);
            this.nDays.Name = "nDays";
            this.nDays.Size = new System.Drawing.Size(33, 21);
            this.nDays.TabIndex = 38;
            this.nDays.Text = "0";
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(252, 45);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(0, 13);
            this.Days.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(215, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total Days: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Rent
            // 
            this.Rent.Enabled = false;
            this.Rent.Location = new System.Drawing.Point(424, 37);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(79, 25);
            this.Rent.TabIndex = 37;
            this.Rent.Text = "Rent";
            this.Rent.UseVisualStyleBackColor = true;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(377, 45);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 13);
            this.Total.TabIndex = 36;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(222, 52);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(314, 16);
            this.searchText.TabIndex = 31;
            this.searchText.Text = "Movies: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Actor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Search By:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.confirmButton);
            this.groupBox3.Controls.Add(this.extraMoney);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.extraDays);
            this.groupBox3.Controls.Add(this.ExtendButton);
            this.groupBox3.Controls.Add(this.DeleteRent);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.rentSDate);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.RentBox);
            this.groupBox3.Controls.Add(this.rentRDate);
            this.groupBox3.Controls.Add(this.rentDaysLeft);
            this.groupBox3.Controls.Add(this.rentPrice);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.rentTitle);
            this.groupBox3.Location = new System.Drawing.Point(12, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 271);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rents";
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(160, 238);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(62, 22);
            this.confirmButton.TabIndex = 48;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // extraMoney
            // 
            this.extraMoney.Enabled = false;
            this.extraMoney.Location = new System.Drawing.Point(97, 239);
            this.extraMoney.Name = "extraMoney";
            this.extraMoney.Size = new System.Drawing.Size(58, 20);
            this.extraMoney.TabIndex = 47;
            this.extraMoney.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Extra Days:";
            this.label20.Visible = false;
            // 
            // extraDays
            // 
            this.extraDays.Location = new System.Drawing.Point(20, 239);
            this.extraDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.extraDays.Name = "extraDays";
            this.extraDays.Size = new System.Drawing.Size(71, 20);
            this.extraDays.TabIndex = 45;
            this.extraDays.ThousandsSeparator = true;
            this.extraDays.Visible = false;
            this.extraDays.ValueChanged += new System.EventHandler(this.extraDays_ValueChanged);
            // 
            // ExtendButton
            // 
            this.ExtendButton.Enabled = false;
            this.ExtendButton.Location = new System.Drawing.Point(16, 194);
            this.ExtendButton.Name = "ExtendButton";
            this.ExtendButton.Size = new System.Drawing.Size(207, 23);
            this.ExtendButton.TabIndex = 44;
            this.ExtendButton.Text = "Extend";
            this.ExtendButton.UseVisualStyleBackColor = true;
            this.ExtendButton.Click += new System.EventHandler(this.ExtendButton_Click);
            // 
            // DeleteRent
            // 
            this.DeleteRent.Enabled = false;
            this.DeleteRent.Location = new System.Drawing.Point(16, 165);
            this.DeleteRent.Name = "DeleteRent";
            this.DeleteRent.Size = new System.Drawing.Size(207, 23);
            this.DeleteRent.TabIndex = 43;
            this.DeleteRent.Text = "Return";
            this.DeleteRent.UseVisualStyleBackColor = true;
            this.DeleteRent.Click += new System.EventHandler(this.DeleteRent_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Start Date";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(226, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Rented Movies:";
            // 
            // rentSDate
            // 
            this.rentSDate.Enabled = false;
            this.rentSDate.Location = new System.Drawing.Point(81, 60);
            this.rentSDate.Name = "rentSDate";
            this.rentSDate.Size = new System.Drawing.Size(142, 20);
            this.rentSDate.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Title";
            // 
            // RentBox
            // 
            this.RentBox.FormattingEnabled = true;
            this.RentBox.Location = new System.Drawing.Point(229, 34);
            this.RentBox.Name = "RentBox";
            this.RentBox.Size = new System.Drawing.Size(203, 225);
            this.RentBox.TabIndex = 33;
            this.RentBox.SelectedIndexChanged += new System.EventHandler(this.RentBox_SelectedIndexChanged);
            // 
            // rentRDate
            // 
            this.rentRDate.Enabled = false;
            this.rentRDate.Location = new System.Drawing.Point(81, 86);
            this.rentRDate.Name = "rentRDate";
            this.rentRDate.Size = new System.Drawing.Size(142, 20);
            this.rentRDate.TabIndex = 37;
            // 
            // rentDaysLeft
            // 
            this.rentDaysLeft.Enabled = false;
            this.rentDaysLeft.Location = new System.Drawing.Point(81, 112);
            this.rentDaysLeft.Name = "rentDaysLeft";
            this.rentDaysLeft.Size = new System.Drawing.Size(142, 20);
            this.rentDaysLeft.TabIndex = 39;
            // 
            // rentPrice
            // 
            this.rentPrice.Enabled = false;
            this.rentPrice.Location = new System.Drawing.Point(81, 138);
            this.rentPrice.Name = "rentPrice";
            this.rentPrice.Size = new System.Drawing.Size(142, 20);
            this.rentPrice.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Return Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Days Left";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Price";
            // 
            // rentTitle
            // 
            this.rentTitle.Enabled = false;
            this.rentTitle.Location = new System.Drawing.Point(81, 34);
            this.rentTitle.Name = "rentTitle";
            this.rentTitle.Size = new System.Drawing.Size(142, 20);
            this.rentTitle.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.birthdayLabel);
            this.groupBox4.Controls.Add(this.addressLabel);
            this.groupBox4.Controls.Add(this.emailLabel);
            this.groupBox4.Controls.Add(this.phoneLabel);
            this.groupBox4.Controls.Add(this.usernameLabel);
            this.groupBox4.Controls.Add(this.nameLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 70);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Location = new System.Drawing.Point(226, 47);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(206, 13);
            this.birthdayLabel.TabIndex = 20;
            this.birthdayLabel.Text = "Birthday: ";
            // 
            // addressLabel
            // 
            this.addressLabel.Location = new System.Drawing.Point(226, 17);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(206, 14);
            this.addressLabel.TabIndex = 18;
            this.addressLabel.Text = "Address: ";
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(13, 47);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(210, 13);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Email: ";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Location = new System.Drawing.Point(226, 32);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(206, 13);
            this.phoneLabel.TabIndex = 19;
            this.phoneLabel.Text = "Phone: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(13, 17);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(210, 13);
            this.usernameLabel.TabIndex = 15;
            this.usernameLabel.Text = "Username: ";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(13, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(210, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 447);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(203, 147);
            this.listBox1.TabIndex = 49;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(241, 447);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(203, 147);
            this.listBox2.TabIndex = 50;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 431);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "★ Favorite Actors:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(238, 431);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "★ Favorite Movies:";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.popcorniaDataSet1;
            // 
            // popcorniaDataSet1
            // 
            this.popcorniaDataSet1.DataSetName = "PopcorniaDataSet1";
            this.popcorniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 606);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.Text = "Popcornia";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraDays)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popcorniaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox QueryBox;
        private System.Windows.Forms.Button button1;
        private PopcorniaDataSet1 popcorniaDataSet1;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private PopcorniaDataSet1TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movieYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox movieGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox movieDirector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox movieProducer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox movieComposer;
        private System.Windows.Forms.ListBox ActorBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox movieSearch;
        private System.Windows.Forms.TextBox SearchByActor;
        private System.Windows.Forms.Button searchByRoleActor;
        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.ComboBox GenreBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label searchText;
        private System.Windows.Forms.DateTimePicker expireDate;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.Label nDays;
        private System.Windows.Forms.Label nTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox rentSDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox RentBox;
        private System.Windows.Forms.TextBox rentRDate;
        private System.Windows.Forms.TextBox rentDaysLeft;
        private System.Windows.Forms.TextBox rentPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox rentTitle;
        private System.Windows.Forms.Button ExtendButton;
        private System.Windows.Forms.Button DeleteRent;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox extraMoney;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown extraDays;
        private System.Windows.Forms.Button FAV;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button FAV2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}