
namespace StudentsListApplication
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.StudentGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteAvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.AddAvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.HighlightCheckBox = new System.Windows.Forms.CheckBox();
            this.EducationFormComboBox = new System.Windows.Forms.ComboBox();
            this.EducationFormLabel = new System.Windows.Forms.Label();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.RecordNumberTextBox = new System.Windows.Forms.TextBox();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.RecordNumberLabel = new System.Windows.Forms.Label();
            this.AddStudentPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteStudentPictureBox = new System.Windows.Forms.PictureBox();
            this.StudentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteStudentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.ItemHeight = 20;
            this.StudentsListBox.Location = new System.Drawing.Point(12, 12);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(409, 384);
            this.StudentsListBox.TabIndex = 0;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // StudentGroupBox
            // 
            this.StudentGroupBox.Controls.Add(this.DeleteAvatarPictureBox);
            this.StudentGroupBox.Controls.Add(this.AddAvatarPictureBox);
            this.StudentGroupBox.Controls.Add(this.AvatarPictureBox);
            this.StudentGroupBox.Controls.Add(this.HighlightCheckBox);
            this.StudentGroupBox.Controls.Add(this.EducationFormComboBox);
            this.StudentGroupBox.Controls.Add(this.EducationFormLabel);
            this.StudentGroupBox.Controls.Add(this.FacultyComboBox);
            this.StudentGroupBox.Controls.Add(this.GroupTextBox);
            this.StudentGroupBox.Controls.Add(this.RecordNumberTextBox);
            this.StudentGroupBox.Controls.Add(this.FacultyLabel);
            this.StudentGroupBox.Controls.Add(this.FullNameTextBox);
            this.StudentGroupBox.Controls.Add(this.GroupLabel);
            this.StudentGroupBox.Controls.Add(this.FullNameLabel);
            this.StudentGroupBox.Controls.Add(this.RecordNumberLabel);
            this.StudentGroupBox.Location = new System.Drawing.Point(427, 12);
            this.StudentGroupBox.Name = "StudentGroupBox";
            this.StudentGroupBox.Size = new System.Drawing.Size(418, 384);
            this.StudentGroupBox.TabIndex = 1;
            this.StudentGroupBox.TabStop = false;
            this.StudentGroupBox.Text = "Selected Student";
            // 
            // DeleteAvatarPictureBox
            // 
            this.DeleteAvatarPictureBox.Enabled = false;
            this.DeleteAvatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAvatarPictureBox.Image")));
            this.DeleteAvatarPictureBox.Location = new System.Drawing.Point(285, 82);
            this.DeleteAvatarPictureBox.Name = "DeleteAvatarPictureBox";
            this.DeleteAvatarPictureBox.Size = new System.Drawing.Size(54, 50);
            this.DeleteAvatarPictureBox.TabIndex = 13;
            this.DeleteAvatarPictureBox.TabStop = false;
            this.DeleteAvatarPictureBox.Click += new System.EventHandler(this.DeleteAvatarPictureBox_Click);
            this.DeleteAvatarPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteAvatarPictureBox_MouseDown);
            this.DeleteAvatarPictureBox.MouseEnter += new System.EventHandler(this.DeleteAvatarPictureBox_MouseEnter);
            this.DeleteAvatarPictureBox.MouseLeave += new System.EventHandler(this.DeleteAvatarPictureBox_MouseLeave);
            this.DeleteAvatarPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DeleteAvatarPictureBox_MouseUp);
            // 
            // AddAvatarPictureBox
            // 
            this.AddAvatarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddAvatarPictureBox.Enabled = false;
            this.AddAvatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddAvatarPictureBox.Image")));
            this.AddAvatarPictureBox.Location = new System.Drawing.Point(285, 26);
            this.AddAvatarPictureBox.Name = "AddAvatarPictureBox";
            this.AddAvatarPictureBox.Size = new System.Drawing.Size(54, 50);
            this.AddAvatarPictureBox.TabIndex = 12;
            this.AddAvatarPictureBox.TabStop = false;
            this.AddAvatarPictureBox.Click += new System.EventHandler(this.AddAvatarPictureBox_Click);
            this.AddAvatarPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddAvatarPictureBox_MouseDown);
            this.AddAvatarPictureBox.MouseEnter += new System.EventHandler(this.AddAvatarPictureBox_MouseEnter);
            this.AddAvatarPictureBox.MouseLeave += new System.EventHandler(this.AddAvatarPictureBox_MouseLeave);
            this.AddAvatarPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddAvatarPictureBox_MouseUp);
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("AvatarPictureBox.InitialImage")));
            this.AvatarPictureBox.Location = new System.Drawing.Point(129, 26);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(150, 150);
            this.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarPictureBox.TabIndex = 4;
            this.AvatarPictureBox.TabStop = false;
            // 
            // HighlightCheckBox
            // 
            this.HighlightCheckBox.AutoSize = true;
            this.HighlightCheckBox.Location = new System.Drawing.Point(129, 349);
            this.HighlightCheckBox.Name = "HighlightCheckBox";
            this.HighlightCheckBox.Size = new System.Drawing.Size(195, 24);
            this.HighlightCheckBox.TabIndex = 11;
            this.HighlightCheckBox.Text = "Highlighting not entered";
            this.HighlightCheckBox.UseVisualStyleBackColor = true;
            this.HighlightCheckBox.CheckedChanged += new System.EventHandler(this.HighlightCheckBox_CheckedChanged);
            // 
            // EducationFormComboBox
            // 
            this.EducationFormComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EducationFormComboBox.FormattingEnabled = true;
            this.EducationFormComboBox.Location = new System.Drawing.Point(129, 315);
            this.EducationFormComboBox.Name = "EducationFormComboBox";
            this.EducationFormComboBox.Size = new System.Drawing.Size(151, 28);
            this.EducationFormComboBox.TabIndex = 9;
            this.EducationFormComboBox.SelectionChangeCommitted += new System.EventHandler(this.EducationFormComboBox_SelectionChangeCommitted);
            // 
            // EducationFormLabel
            // 
            this.EducationFormLabel.AutoSize = true;
            this.EducationFormLabel.Location = new System.Drawing.Point(7, 318);
            this.EducationFormLabel.Name = "EducationFormLabel";
            this.EducationFormLabel.Size = new System.Drawing.Size(116, 20);
            this.EducationFormLabel.TabIndex = 4;
            this.EducationFormLabel.Text = "Education Form:";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(130, 281);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(151, 28);
            this.FacultyComboBox.TabIndex = 8;
            this.FacultyComboBox.SelectionChangeCommitted += new System.EventHandler(this.FacultyComboBox_SelectionChangeCommitted);
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(130, 248);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(125, 27);
            this.GroupTextBox.TabIndex = 7;
            this.GroupTextBox.TextChanged += new System.EventHandler(this.GroupTextBox_TextChanged);
            // 
            // RecordNumberTextBox
            // 
            this.RecordNumberTextBox.Location = new System.Drawing.Point(130, 215);
            this.RecordNumberTextBox.Name = "RecordNumberTextBox";
            this.RecordNumberTextBox.Size = new System.Drawing.Size(125, 27);
            this.RecordNumberTextBox.TabIndex = 6;
            this.RecordNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RecordNumberTextBox_KeyPress);
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(66, 281);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(57, 20);
            this.FacultyLabel.TabIndex = 3;
            this.FacultyLabel.Text = "Faculty:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(129, 182);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(279, 27);
            this.FullNameTextBox.TabIndex = 5;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(71, 251);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(53, 20);
            this.GroupLabel.TabIndex = 2;
            this.GroupLabel.Text = "Group:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(45, 185);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // RecordNumberLabel
            // 
            this.RecordNumberLabel.AutoSize = true;
            this.RecordNumberLabel.Location = new System.Drawing.Point(7, 218);
            this.RecordNumberLabel.Name = "RecordNumberLabel";
            this.RecordNumberLabel.Size = new System.Drawing.Size(117, 20);
            this.RecordNumberLabel.TabIndex = 1;
            this.RecordNumberLabel.Text = "Record Number:";
            // 
            // AddStudentPictureBox
            // 
            this.AddStudentPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.AddStudentPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddStudentPictureBox.Image")));
            this.AddStudentPictureBox.Location = new System.Drawing.Point(12, 402);
            this.AddStudentPictureBox.Name = "AddStudentPictureBox";
            this.AddStudentPictureBox.Size = new System.Drawing.Size(54, 50);
            this.AddStudentPictureBox.TabIndex = 4;
            this.AddStudentPictureBox.TabStop = false;
            this.AddStudentPictureBox.Click += new System.EventHandler(this.AddStudentPictureBox_Click);
            this.AddStudentPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddStudentPictureBox_MouseDown);
            this.AddStudentPictureBox.MouseEnter += new System.EventHandler(this.AddStudentPictureBox_MouseEnter);
            this.AddStudentPictureBox.MouseLeave += new System.EventHandler(this.AddStudentPictureBox_MouseLeave);
            this.AddStudentPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddStudentPictureBox_MouseUp);
            // 
            // DeleteStudentPictureBox
            // 
            this.DeleteStudentPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteStudentPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DeleteStudentPictureBox.Image")));
            this.DeleteStudentPictureBox.Location = new System.Drawing.Point(72, 402);
            this.DeleteStudentPictureBox.Name = "DeleteStudentPictureBox";
            this.DeleteStudentPictureBox.Size = new System.Drawing.Size(54, 50);
            this.DeleteStudentPictureBox.TabIndex = 5;
            this.DeleteStudentPictureBox.TabStop = false;
            this.DeleteStudentPictureBox.Click += new System.EventHandler(this.DeleteStudentPictureBox_Click);
            this.DeleteStudentPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteStudentPictureBox_MouseDown);
            this.DeleteStudentPictureBox.MouseEnter += new System.EventHandler(this.DeleteStudentPictureBox_MouseEnter);
            this.DeleteStudentPictureBox.MouseLeave += new System.EventHandler(this.DeleteStudentPictureBox_MouseLeave);
            this.DeleteStudentPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DeleteStudentPictureBox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 462);
            this.Controls.Add(this.DeleteStudentPictureBox);
            this.Controls.Add(this.AddStudentPictureBox);
            this.Controls.Add(this.StudentGroupBox);
            this.Controls.Add(this.StudentsListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.StudentGroupBox.ResumeLayout(false);
            this.StudentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteStudentPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.GroupBox StudentGroupBox;
        private System.Windows.Forms.Label RecordNumberLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label EducationFormLabel;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.TextBox RecordNumberTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.ComboBox EducationFormComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.CheckBox HighlightCheckBox;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.PictureBox AddStudentPictureBox;
        private System.Windows.Forms.PictureBox DeleteStudentPictureBox;
        private System.Windows.Forms.PictureBox DeleteAvatarPictureBox;
        private System.Windows.Forms.PictureBox AddAvatarPictureBox;
    }
}

