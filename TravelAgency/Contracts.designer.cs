namespace TravelAgency
{
    partial class Contracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contracts));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.trackBarMaxPrice = new System.Windows.Forms.TrackBar();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.trackBarMinPrice = new System.Windows.Forms.TrackBar();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTouristGuides = new System.Windows.Forms.Button();
            this.buttonHotels = new System.Windows.Forms.Button();
            this.buttonPayments = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonContracts = new System.Windows.Forms.Button();
            this.buttonOffers = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHotels = new System.Windows.Forms.PictureBox();
            this.pictureBoxPayments = new System.Windows.Forms.PictureBox();
            this.pictureBoxClients = new System.Windows.Forms.PictureBox();
            this.pictureBoxContracts = new System.Windows.Forms.PictureBox();
            this.pictureBoxOffers = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.listViewContracts = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContractID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartureDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPrice)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOffers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.labelMinPrice);
            this.panel3.Controls.Add(this.trackBarMaxPrice);
            this.panel3.Controls.Add(this.labelMaxPrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dateTimePickerDeparture);
            this.panel3.Controls.Add(this.trackBarMinPrice);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(223, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 79);
            this.panel3.TabIndex = 5;
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinPrice.Location = new System.Drawing.Point(337, 12);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(142, 18);
            this.labelMinPrice.TabIndex = 8;
            this.labelMinPrice.Text = "Min price: 100 €";
            // 
            // trackBarMaxPrice
            // 
            this.trackBarMaxPrice.LargeChange = 200;
            this.trackBarMaxPrice.Location = new System.Drawing.Point(495, 33);
            this.trackBarMaxPrice.Maximum = 3000;
            this.trackBarMaxPrice.Minimum = 100;
            this.trackBarMaxPrice.Name = "trackBarMaxPrice";
            this.trackBarMaxPrice.Size = new System.Drawing.Size(168, 45);
            this.trackBarMaxPrice.SmallChange = 50;
            this.trackBarMaxPrice.TabIndex = 2;
            this.trackBarMaxPrice.TickFrequency = 150;
            this.trackBarMaxPrice.Value = 3000;
            this.trackBarMaxPrice.Scroll += new System.EventHandler(this.TrackBarMaxPrice_Scroll);
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMaxPrice.Location = new System.Drawing.Point(521, 12);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(142, 18);
            this.labelMaxPrice.TabIndex = 6;
            this.labelMaxPrice.Text = "Max price: 3000 €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(675, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date departure:";
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(790, 34);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(245, 24);
            this.dateTimePickerDeparture.TabIndex = 3;
            this.dateTimePickerDeparture.ValueChanged += new System.EventHandler(this.DateTimePickerDeparture_ValueChanged);
            // 
            // trackBarMinPrice
            // 
            this.trackBarMinPrice.LargeChange = 200;
            this.trackBarMinPrice.Location = new System.Drawing.Point(310, 33);
            this.trackBarMinPrice.Maximum = 3000;
            this.trackBarMinPrice.Minimum = 100;
            this.trackBarMinPrice.Name = "trackBarMinPrice";
            this.trackBarMinPrice.Size = new System.Drawing.Size(168, 45);
            this.trackBarMinPrice.SmallChange = 50;
            this.trackBarMinPrice.TabIndex = 1;
            this.trackBarMinPrice.TickFrequency = 150;
            this.trackBarMinPrice.Value = 100;
            this.trackBarMinPrice.Scroll += new System.EventHandler(this.TrackBarMinPrice_Scroll);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(18, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(268, 24);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Search by client name";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.buttonTouristGuides);
            this.panel1.Controls.Add(this.buttonHotels);
            this.panel1.Controls.Add(this.buttonPayments);
            this.panel1.Controls.Add(this.buttonClients);
            this.panel1.Controls.Add(this.buttonContracts);
            this.panel1.Controls.Add(this.buttonOffers);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBoxHotels);
            this.panel1.Controls.Add(this.pictureBoxPayments);
            this.panel1.Controls.Add(this.pictureBoxClients);
            this.panel1.Controls.Add(this.pictureBoxContracts);
            this.panel1.Controls.Add(this.pictureBoxOffers);
            this.panel1.Controls.Add(this.pictureBoxHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 681);
            this.panel1.TabIndex = 4;
            // 
            // buttonTouristGuides
            // 
            this.buttonTouristGuides.BackColor = System.Drawing.Color.Teal;
            this.buttonTouristGuides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTouristGuides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTouristGuides.FlatAppearance.BorderSize = 0;
            this.buttonTouristGuides.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTouristGuides.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTouristGuides.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTouristGuides.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTouristGuides.Location = new System.Drawing.Point(81, 475);
            this.buttonTouristGuides.Name = "buttonTouristGuides";
            this.buttonTouristGuides.Size = new System.Drawing.Size(133, 30);
            this.buttonTouristGuides.TabIndex = 11;
            this.buttonTouristGuides.TabStop = false;
            this.buttonTouristGuides.Text = "Tourist guides";
            this.buttonTouristGuides.UseVisualStyleBackColor = false;
            this.buttonTouristGuides.Click += new System.EventHandler(this.ButtonTouristGuides_Click);
            // 
            // buttonHotels
            // 
            this.buttonHotels.BackColor = System.Drawing.Color.Teal;
            this.buttonHotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHotels.FlatAppearance.BorderSize = 0;
            this.buttonHotels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHotels.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHotels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHotels.Location = new System.Drawing.Point(81, 415);
            this.buttonHotels.Name = "buttonHotels";
            this.buttonHotels.Size = new System.Drawing.Size(75, 30);
            this.buttonHotels.TabIndex = 10;
            this.buttonHotels.TabStop = false;
            this.buttonHotels.Text = "Hotels";
            this.buttonHotels.UseVisualStyleBackColor = false;
            this.buttonHotels.Click += new System.EventHandler(this.ButtonHotels_Click);
            // 
            // buttonPayments
            // 
            this.buttonPayments.BackColor = System.Drawing.Color.Teal;
            this.buttonPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayments.FlatAppearance.BorderSize = 0;
            this.buttonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayments.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayments.Location = new System.Drawing.Point(81, 355);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Size = new System.Drawing.Size(100, 30);
            this.buttonPayments.TabIndex = 9;
            this.buttonPayments.TabStop = false;
            this.buttonPayments.Text = "Payments";
            this.buttonPayments.UseVisualStyleBackColor = false;
            this.buttonPayments.Click += new System.EventHandler(this.ButtonPayments_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.Teal;
            this.buttonClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClients.Location = new System.Drawing.Point(81, 295);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(78, 30);
            this.buttonClients.TabIndex = 8;
            this.buttonClients.TabStop = false;
            this.buttonClients.Text = "Clients";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.ButtonClients_Click);
            // 
            // buttonContracts
            // 
            this.buttonContracts.BackColor = System.Drawing.Color.Teal;
            this.buttonContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonContracts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContracts.FlatAppearance.BorderSize = 0;
            this.buttonContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContracts.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContracts.Location = new System.Drawing.Point(81, 235);
            this.buttonContracts.Name = "buttonContracts";
            this.buttonContracts.Size = new System.Drawing.Size(100, 30);
            this.buttonContracts.TabIndex = 7;
            this.buttonContracts.TabStop = false;
            this.buttonContracts.Text = "Contracts";
            this.buttonContracts.UseVisualStyleBackColor = false;
            // 
            // buttonOffers
            // 
            this.buttonOffers.BackColor = System.Drawing.Color.Teal;
            this.buttonOffers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOffers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOffers.FlatAppearance.BorderSize = 0;
            this.buttonOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOffers.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOffers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOffers.Location = new System.Drawing.Point(81, 175);
            this.buttonOffers.Name = "buttonOffers";
            this.buttonOffers.Size = new System.Drawing.Size(73, 30);
            this.buttonOffers.TabIndex = 6;
            this.buttonOffers.TabStop = false;
            this.buttonOffers.Text = "Offers";
            this.buttonOffers.UseVisualStyleBackColor = false;
            this.buttonOffers.Click += new System.EventHandler(this.ButtonOffers_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Teal;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHome.Location = new System.Drawing.Point(81, 115);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(71, 30);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.TabStop = false;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::TravelAgency.Properties.Resources.tour_guide_icon;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(30, 475);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 30);
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBoxHotels
            // 
            this.pictureBoxHotels.BackgroundImage = global::TravelAgency.Properties.Resources.hotel_icon;
            this.pictureBoxHotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHotels.Location = new System.Drawing.Point(30, 415);
            this.pictureBoxHotels.Name = "pictureBoxHotels";
            this.pictureBoxHotels.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxHotels.TabIndex = 13;
            this.pictureBoxHotels.TabStop = false;
            // 
            // pictureBoxPayments
            // 
            this.pictureBoxPayments.BackgroundImage = global::TravelAgency.Properties.Resources.payments_icon;
            this.pictureBoxPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPayments.Location = new System.Drawing.Point(30, 355);
            this.pictureBoxPayments.Name = "pictureBoxPayments";
            this.pictureBoxPayments.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxPayments.TabIndex = 12;
            this.pictureBoxPayments.TabStop = false;
            // 
            // pictureBoxClients
            // 
            this.pictureBoxClients.BackgroundImage = global::TravelAgency.Properties.Resources.clients_icon;
            this.pictureBoxClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxClients.Location = new System.Drawing.Point(30, 295);
            this.pictureBoxClients.Name = "pictureBoxClients";
            this.pictureBoxClients.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxClients.TabIndex = 11;
            this.pictureBoxClients.TabStop = false;
            // 
            // pictureBoxContracts
            // 
            this.pictureBoxContracts.BackgroundImage = global::TravelAgency.Properties.Resources.contracts_icon;
            this.pictureBoxContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxContracts.Location = new System.Drawing.Point(30, 235);
            this.pictureBoxContracts.Name = "pictureBoxContracts";
            this.pictureBoxContracts.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxContracts.TabIndex = 10;
            this.pictureBoxContracts.TabStop = false;
            // 
            // pictureBoxOffers
            // 
            this.pictureBoxOffers.BackgroundImage = global::TravelAgency.Properties.Resources.offers_icon;
            this.pictureBoxOffers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxOffers.Location = new System.Drawing.Point(30, 175);
            this.pictureBoxOffers.Name = "pictureBoxOffers";
            this.pictureBoxOffers.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxOffers.TabIndex = 9;
            this.pictureBoxOffers.TabStop = false;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackgroundImage = global::TravelAgency.Properties.Resources.home_icon;
            this.pictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHome.Location = new System.Drawing.Point(30, 115);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxHome.TabIndex = 2;
            this.pictureBoxHome.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBoxLogout);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 79);
            this.panel2.TabIndex = 0;
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.BackgroundImage = global::TravelAgency.Properties.Resources.logout_icon;
            this.pictureBoxLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogout.Image = global::TravelAgency.Properties.Resources.logout_icon;
            this.pictureBoxLogout.Location = new System.Drawing.Point(12, 26);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxLogout.TabIndex = 2;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.PictureBoxLogout_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(63, 32);
            this.labelUsername.MaximumSize = new System.Drawing.Size(150, 18);
            this.labelUsername.MinimumSize = new System.Drawing.Size(150, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(150, 18);
            this.labelUsername.TabIndex = 0;
            // 
            // listViewContracts
            // 
            this.listViewContracts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewContracts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderContractID,
            this.columnHeaderClient,
            this.columnHeaderDestination,
            this.columnHeaderPrice,
            this.columnHeaderDepartureDate});
            this.listViewContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewContracts.FullRowSelect = true;
            this.listViewContracts.Location = new System.Drawing.Point(223, 79);
            this.listViewContracts.Name = "listViewContracts";
            this.listViewContracts.Size = new System.Drawing.Size(1041, 602);
            this.listViewContracts.TabIndex = 4;
            this.listViewContracts.UseCompatibleStateImageBehavior = false;
            this.listViewContracts.View = System.Windows.Forms.View.Details;
            this.listViewContracts.DoubleClick += new System.EventHandler(this.ListViewContracts_DoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderContractID
            // 
            this.columnHeaderContractID.Text = "Contract ID";
            this.columnHeaderContractID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderContractID.Width = 120;
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Client";
            this.columnHeaderClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderClient.Width = 250;
            // 
            // columnHeaderDestination
            // 
            this.columnHeaderDestination.Text = "Destination";
            this.columnHeaderDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDestination.Width = 250;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrice.Width = 100;
            // 
            // columnHeaderDepartureDate
            // 
            this.columnHeaderDepartureDate.Text = "Date Of Departure";
            this.columnHeaderDepartureDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDepartureDate.Width = 200;
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.listViewContracts);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contracts";
            this.Resize += new System.EventHandler(this.Contracts_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOffers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBoxHotels;
        private System.Windows.Forms.PictureBox pictureBoxPayments;
        private System.Windows.Forms.PictureBox pictureBoxClients;
        private System.Windows.Forms.PictureBox pictureBoxContracts;
        private System.Windows.Forms.PictureBox pictureBoxOffers;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ListView listViewContracts;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderContractID;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.ColumnHeader columnHeaderDestination;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartureDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.TrackBar trackBarMinPrice;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.TrackBar trackBarMaxPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Button buttonTouristGuides;
        private System.Windows.Forms.Button buttonHotels;
        private System.Windows.Forms.Button buttonPayments;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonContracts;
        private System.Windows.Forms.Button buttonOffers;
        private System.Windows.Forms.Button buttonHome;
    }
}