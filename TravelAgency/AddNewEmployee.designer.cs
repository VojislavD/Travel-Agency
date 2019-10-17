﻿namespace TravelAgency
{
    partial class AddNewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewEmployee));
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSave = new System.Windows.Forms.Label();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.radioButtonGenderFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDateOfHire = new System.Windows.Forms.DateTimePicker();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.labelDateOfHire = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.labelJMBG = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.labelSave);
            this.panel3.Controls.Add(this.pictureBoxSave);
            this.panel3.Controls.Add(this.pictureBoxBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(223, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 79);
            this.panel3.TabIndex = 11;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.ForeColor = System.Drawing.Color.White;
            this.labelSave.Location = new System.Drawing.Point(196, 55);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(34, 15);
            this.labelSave.TabIndex = 5;
            this.labelSave.Text = "Save";
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSave.BackgroundImage = global::TravelAgency.Properties.Resources.save_icon;
            this.pictureBoxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSave.Location = new System.Drawing.Point(190, 16);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(45, 35);
            this.pictureBoxSave.TabIndex = 2;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.PictureBoxSave_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackgroundImage = global::TravelAgency.Properties.Resources.back_icon;
            this.pictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Location = new System.Drawing.Point(19, 22);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(45, 35);
            this.pictureBoxBack.TabIndex = 0;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 681);
            this.panel1.TabIndex = 10;
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
            // radioButtonGenderFemale
            // 
            this.radioButtonGenderFemale.AutoSize = true;
            this.radioButtonGenderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGenderFemale.Location = new System.Drawing.Point(529, 420);
            this.radioButtonGenderFemale.Name = "radioButtonGenderFemale";
            this.radioButtonGenderFemale.Size = new System.Drawing.Size(72, 20);
            this.radioButtonGenderFemale.TabIndex = 6;
            this.radioButtonGenderFemale.TabStop = true;
            this.radioButtonGenderFemale.Text = "Female";
            this.radioButtonGenderFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMale
            // 
            this.radioButtonGenderMale.AutoSize = true;
            this.radioButtonGenderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGenderMale.Location = new System.Drawing.Point(436, 420);
            this.radioButtonGenderMale.Name = "radioButtonGenderMale";
            this.radioButtonGenderMale.Size = new System.Drawing.Size(56, 20);
            this.radioButtonGenderMale.TabIndex = 5;
            this.radioButtonGenderMale.TabStop = true;
            this.radioButtonGenderMale.Text = "Male";
            this.radioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateOfHire
            // 
            this.dateTimePickerDateOfHire.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfHire.Location = new System.Drawing.Point(890, 238);
            this.dateTimePickerDateOfHire.Name = "dateTimePickerDateOfHire";
            this.dateTimePickerDateOfHire.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateOfHire.TabIndex = 9;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(890, 359);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(250, 22);
            this.textBoxSalary.TabIndex = 11;
            this.textBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSalary_KeyPress);
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJobTitle.Location = new System.Drawing.Point(890, 299);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(250, 22);
            this.textBoxJobTitle.TabIndex = 10;
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEducation.Location = new System.Drawing.Point(890, 179);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(250, 22);
            this.textBoxEducation.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(890, 119);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 22);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(751, 360);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(49, 18);
            this.labelSalary.TabIndex = 145;
            this.labelSalary.Text = "Salary";
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobTitle.Location = new System.Drawing.Point(751, 300);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(59, 18);
            this.labelJobTitle.TabIndex = 144;
            this.labelJobTitle.Text = "Job title";
            // 
            // labelDateOfHire
            // 
            this.labelDateOfHire.AutoSize = true;
            this.labelDateOfHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfHire.Location = new System.Drawing.Point(751, 240);
            this.labelDateOfHire.Name = "labelDateOfHire";
            this.labelDateOfHire.Size = new System.Drawing.Size(84, 18);
            this.labelDateOfHire.TabIndex = 143;
            this.labelDateOfHire.Text = "Date of hire";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEducation.Location = new System.Drawing.Point(751, 180);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(74, 18);
            this.labelEducation.TabIndex = 142;
            this.labelEducation.Text = "Education";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(751, 120);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 18);
            this.labelPhone.TabIndex = 141;
            this.labelPhone.Text = "Phone";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(268, 420);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(57, 18);
            this.labelGender.TabIndex = 140;
            this.labelGender.Text = "Gender";
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJMBG.Location = new System.Drawing.Point(413, 359);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(250, 22);
            this.textBoxJMBG.TabIndex = 4;
            this.textBoxJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxJMBG_KeyPress);
            // 
            // labelJMBG
            // 
            this.labelJMBG.AutoSize = true;
            this.labelJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJMBG.Location = new System.Drawing.Point(268, 360);
            this.labelJMBG.Name = "labelJMBG";
            this.labelJMBG.Size = new System.Drawing.Size(51, 18);
            this.labelJMBG.TabIndex = 138;
            this.labelJMBG.Text = "JMBG";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(413, 299);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(250, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(413, 239);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(413, 179);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 22);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(413, 119);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 22);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(268, 300);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 18);
            this.labelPassword.TabIndex = 133;
            this.labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(268, 240);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 18);
            this.labelEmail.TabIndex = 132;
            this.labelEmail.Text = "Email";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(268, 180);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 18);
            this.labelLastName.TabIndex = 131;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(268, 120);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(81, 18);
            this.labelFirstName.TabIndex = 130;
            this.labelFirstName.Text = "First Name";
            // 
            // AddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.radioButtonGenderFemale);
            this.Controls.Add(this.radioButtonGenderMale);
            this.Controls.Add(this.dateTimePickerDateOfHire);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxJobTitle);
            this.Controls.Add(this.textBoxEducation);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelJobTitle);
            this.Controls.Add(this.labelDateOfHire);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxJMBG);
            this.Controls.Add(this.labelJMBG);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert New Employee";
            this.Resize += new System.EventHandler(this.AddNewEmployee_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxLogout;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.RadioButton radioButtonGenderFemale;
        private System.Windows.Forms.RadioButton radioButtonGenderMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfHire;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.Label labelDateOfHire;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.Label labelJMBG;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
    }
}