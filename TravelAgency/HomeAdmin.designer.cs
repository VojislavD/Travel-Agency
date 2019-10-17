namespace TravelAgency
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAddNewEmployee = new System.Windows.Forms.Label();
            this.pictureBoxAddNewEmployee = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddNewEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.labelAddNewEmployee);
            this.panel3.Controls.Add(this.pictureBoxAddNewEmployee);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(223, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 79);
            this.panel3.TabIndex = 3;
            // 
            // labelAddNewEmployee
            // 
            this.labelAddNewEmployee.AutoSize = true;
            this.labelAddNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewEmployee.ForeColor = System.Drawing.Color.White;
            this.labelAddNewEmployee.Location = new System.Drawing.Point(49, 51);
            this.labelAddNewEmployee.Name = "labelAddNewEmployee";
            this.labelAddNewEmployee.Size = new System.Drawing.Size(111, 15);
            this.labelAddNewEmployee.TabIndex = 10;
            this.labelAddNewEmployee.Text = "Add new employee";
            // 
            // pictureBoxAddNewEmployee
            // 
            this.pictureBoxAddNewEmployee.BackgroundImage = global::TravelAgency.Properties.Resources.add_new_employee;
            this.pictureBoxAddNewEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAddNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddNewEmployee.Location = new System.Drawing.Point(81, 13);
            this.pictureBoxAddNewEmployee.Name = "pictureBoxAddNewEmployee";
            this.pictureBoxAddNewEmployee.Size = new System.Drawing.Size(45, 35);
            this.pictureBoxAddNewEmployee.TabIndex = 9;
            this.pictureBoxAddNewEmployee.TabStop = false;
            this.pictureBoxAddNewEmployee.Click += new System.EventHandler(this.PictureBoxAddNewEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 681);
            this.panel1.TabIndex = 2;
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
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderEmail,
            this.columnHeaderPhone});
            this.listViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.Location = new System.Drawing.Point(223, 79);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(1041, 602);
            this.listViewEmployees.TabIndex = 0;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.DoubleClick += new System.EventHandler(this.ListViewEmployees_DoubleClick);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderFirstName.Width = 250;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLastName.Width = 250;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderEmail.Width = 220;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Phone";
            this.columnHeaderPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPhone.Width = 220;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.listViewEmployees);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Admin";
            this.Resize += new System.EventHandler(this.HomeAdmin_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddNewEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.Label labelAddNewEmployee;
        private System.Windows.Forms.PictureBox pictureBoxAddNewEmployee;
    }
}