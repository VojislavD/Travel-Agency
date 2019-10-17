namespace TravelAgency
{
    partial class AddTouristGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTouristGuide));
            this.listViewTouristGuides = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAvailableForLocations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJobTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewTouristGuides
            // 
            this.listViewTouristGuides.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderAvailableForLocations,
            this.columnHeaderGender,
            this.columnHeaderSalary,
            this.columnHeaderJobTitle});
            this.listViewTouristGuides.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewTouristGuides.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTouristGuides.FullRowSelect = true;
            this.listViewTouristGuides.Location = new System.Drawing.Point(0, 77);
            this.listViewTouristGuides.Name = "listViewTouristGuides";
            this.listViewTouristGuides.Size = new System.Drawing.Size(888, 408);
            this.listViewTouristGuides.TabIndex = 1;
            this.listViewTouristGuides.UseCompatibleStateImageBehavior = false;
            this.listViewTouristGuides.View = System.Windows.Forms.View.Details;
            this.listViewTouristGuides.DoubleClick += new System.EventHandler(this.ListViewTouristGuides_DoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 50;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First name";
            this.columnHeaderFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderFirstName.Width = 170;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last name";
            this.columnHeaderLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLastName.Width = 170;
            // 
            // columnHeaderAvailableForLocations
            // 
            this.columnHeaderAvailableForLocations.Text = "Available for locations";
            this.columnHeaderAvailableForLocations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAvailableForLocations.Width = 250;
            // 
            // columnHeaderGender
            // 
            this.columnHeaderGender.Text = "Gender";
            this.columnHeaderGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGender.Width = 80;
            // 
            // columnHeaderSalary
            // 
            this.columnHeaderSalary.Text = "Salary";
            this.columnHeaderSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSalary.Width = 80;
            // 
            // columnHeaderJobTitle
            // 
            this.columnHeaderJobTitle.Text = "Job title";
            this.columnHeaderJobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderJobTitle.Width = 80;
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
            // AddTouristGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 485);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listViewTouristGuides);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddTouristGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Tourist Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTouristGuides;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderAvailableForLocations;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderSalary;
        private System.Windows.Forms.ColumnHeader columnHeaderJobTitle;
    }
}