namespace TravelAgency
{
    partial class AddHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHotel));
            this.listViewHotels = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWifi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPetFriendly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGym = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPool = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewHotels
            // 
            this.listViewHotels.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewHotels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderCountry,
            this.columnHeaderCity,
            this.columnHeaderStars,
            this.columnHeaderWifi,
            this.columnHeaderSpa,
            this.columnHeaderPetFriendly,
            this.columnHeaderGym,
            this.columnHeaderPool});
            this.listViewHotels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHotels.FullRowSelect = true;
            this.listViewHotels.Location = new System.Drawing.Point(0, 77);
            this.listViewHotels.Name = "listViewHotels";
            this.listViewHotels.Size = new System.Drawing.Size(888, 408);
            this.listViewHotels.TabIndex = 1;
            this.listViewHotels.UseCompatibleStateImageBehavior = false;
            this.listViewHotels.View = System.Windows.Forms.View.Details;
            this.listViewHotels.DoubleClick += new System.EventHandler(this.ListViewHotels_DoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderName.Width = 140;
            // 
            // columnHeaderCountry
            // 
            this.columnHeaderCountry.Text = "Country";
            this.columnHeaderCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCountry.Width = 120;
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "City";
            this.columnHeaderCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCity.Width = 120;
            // 
            // columnHeaderStars
            // 
            this.columnHeaderStars.Text = "Stars";
            this.columnHeaderStars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderStars.Width = 70;
            // 
            // columnHeaderWifi
            // 
            this.columnHeaderWifi.Text = "Wifi";
            this.columnHeaderWifi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderWifi.Width = 70;
            // 
            // columnHeaderSpa
            // 
            this.columnHeaderSpa.Text = "Spa";
            this.columnHeaderSpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSpa.Width = 70;
            // 
            // columnHeaderPetFriendly
            // 
            this.columnHeaderPetFriendly.Text = "Pet friendly";
            this.columnHeaderPetFriendly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPetFriendly.Width = 90;
            // 
            // columnHeaderGym
            // 
            this.columnHeaderGym.Text = "Gym";
            this.columnHeaderGym.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGym.Width = 70;
            // 
            // columnHeaderPool
            // 
            this.columnHeaderPool.Text = "Pool";
            this.columnHeaderPool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPool.Width = 70;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(219, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(450, 24);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Tag = "";
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.Click += new System.EventHandler(this.TextBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // AddHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.listViewHotels);
            this.Controls.Add(this.textBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHotels;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderStars;
        private System.Windows.Forms.ColumnHeader columnHeaderWifi;
        private System.Windows.Forms.ColumnHeader columnHeaderSpa;
        private System.Windows.Forms.ColumnHeader columnHeaderPetFriendly;
        private System.Windows.Forms.ColumnHeader columnHeaderGym;
        private System.Windows.Forms.ColumnHeader columnHeaderPool;
    }
}