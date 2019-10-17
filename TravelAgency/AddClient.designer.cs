namespace TravelAgency
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPassport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Citizenship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // listViewClients
            // 
            this.listViewClients.BackColor = System.Drawing.SystemColors.Control;
            this.listViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderJMBG,
            this.columnHeaderAge,
            this.columnHeaderPassport,
            this.Citizenship,
            this.columnHeaderEmail,
            this.columnHeaderPhone});
            this.listViewClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.Location = new System.Drawing.Point(0, 77);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(904, 524);
            this.listViewClients.TabIndex = 1;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewClients_MouseDoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderID.Width = 38;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First name";
            this.columnHeaderFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderFirstName.Width = 105;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last name";
            this.columnHeaderLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLastName.Width = 112;
            // 
            // columnHeaderJMBG
            // 
            this.columnHeaderJMBG.Text = "JMBG";
            this.columnHeaderJMBG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderJMBG.Width = 140;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Age";
            this.columnHeaderAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderPassport
            // 
            this.columnHeaderPassport.Text = "Passport number";
            this.columnHeaderPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPassport.Width = 130;
            // 
            // Citizenship
            // 
            this.Citizenship.Text = "Citizenship";
            this.Citizenship.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Citizenship.Width = 100;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderEmail.Width = 119;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Phone";
            this.columnHeaderPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPhone.Width = 94;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(904, 601);
            this.Controls.Add(this.listViewClients);
            this.Controls.Add(this.textBoxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 640);
            this.MinimumSize = new System.Drawing.Size(920, 640);
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderJMBG;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderPassport;
        private System.Windows.Forms.ColumnHeader Citizenship;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
    }
}