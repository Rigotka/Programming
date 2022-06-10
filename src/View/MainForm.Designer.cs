
namespace Programming.View
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
            this.ProgrammingTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonsControl = new Programming.View.Controls.SeasonsControl();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl = new Programming.View.Controls.WeekdayParsingControl();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.allEnumerationsControl = new Programming.View.Controls.AllEnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesControl1 = new Programming.View.Controls.MoviesControl();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.SettingTabPage = new System.Windows.Forms.TabPage();
            this.MusicCheckBox = new System.Windows.Forms.CheckBox();
            this.textBo = new System.Windows.Forms.TextBox();
            this.ProgrammingTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SettingTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgrammingTabControl
            // 
            this.ProgrammingTabControl.Controls.Add(this.EnumsTabPage);
            this.ProgrammingTabControl.Controls.Add(this.ClassesTabPage);
            this.ProgrammingTabControl.Controls.Add(this.RectanglesTabPage);
            this.ProgrammingTabControl.Controls.Add(this.SettingTabPage);
            this.ProgrammingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgrammingTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProgrammingTabControl.Name = "ProgrammingTabControl";
            this.ProgrammingTabControl.SelectedIndex = 0;
            this.ProgrammingTabControl.Size = new System.Drawing.Size(786, 447);
            this.ProgrammingTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(778, 414);
            this.EnumsTabPage.TabIndex = 1;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.seasonsControl);
            this.SeasonGroupBox.Location = new System.Drawing.Point(391, 293);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(379, 107);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // seasonsControl
            // 
            this.seasonsControl.Location = new System.Drawing.Point(6, 23);
            this.seasonsControl.Name = "seasonsControl";
            this.seasonsControl.Size = new System.Drawing.Size(367, 78);
            this.seasonsControl.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.weekdayParsingControl);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 293);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(382, 107);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayParsingControl
            // 
            this.weekdayParsingControl.Location = new System.Drawing.Point(6, 23);
            this.weekdayParsingControl.Name = "weekdayParsingControl";
            this.weekdayParsingControl.Size = new System.Drawing.Size(376, 78);
            this.weekdayParsingControl.TabIndex = 0;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.allEnumerationsControl);
            this.EnumsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(767, 286);
            this.EnumsGroupBox.TabIndex = 0;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // allEnumerationsControl
            // 
            this.allEnumerationsControl.Location = new System.Drawing.Point(6, 20);
            this.allEnumerationsControl.Name = "allEnumerationsControl";
            this.allEnumerationsControl.Size = new System.Drawing.Size(649, 260);
            this.allEnumerationsControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(778, 414);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.moviesControl1);
            this.MoviesGroupBox.Location = new System.Drawing.Point(385, 3);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(385, 397);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(6, 25);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(373, 365);
            this.moviesControl1.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.rectanglesControl1);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(376, 397);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(6, 26);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(365, 364);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(778, 414);
            this.RectanglesTabPage.TabIndex = 4;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.AutoSize = true;
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(772, 408);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // SettingTabPage
            // 
            this.SettingTabPage.Controls.Add(this.MusicCheckBox);
            this.SettingTabPage.Location = new System.Drawing.Point(4, 29);
            this.SettingTabPage.Name = "SettingTabPage";
            this.SettingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingTabPage.Size = new System.Drawing.Size(778, 414);
            this.SettingTabPage.TabIndex = 3;
            this.SettingTabPage.Text = "Setting";
            this.SettingTabPage.UseVisualStyleBackColor = true;
            // 
            // MusicCheckBox
            // 
            this.MusicCheckBox.AutoSize = true;
            this.MusicCheckBox.Location = new System.Drawing.Point(317, 149);
            this.MusicCheckBox.Name = "MusicCheckBox";
            this.MusicCheckBox.Size = new System.Drawing.Size(69, 24);
            this.MusicCheckBox.TabIndex = 0;
            this.MusicCheckBox.Text = "music";
            this.MusicCheckBox.UseVisualStyleBackColor = true;
            this.MusicCheckBox.CheckedChanged += new System.EventHandler(this.MusicCheckBox_CheckedChanged);
            // 
            // textBo
            // 
            this.textBo.Location = new System.Drawing.Point(248, 305);
            this.textBo.Name = "textBo";
            this.textBo.Size = new System.Drawing.Size(125, 27);
            this.textBo.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(786, 447);
            this.Controls.Add(this.ProgrammingTabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.ProgrammingTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.SettingTabPage.ResumeLayout(false);
            this.SettingTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProgrammingTabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.TabPage SettingTabPage;
        private System.Windows.Forms.CheckBox MusicCheckBox;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.TextBox textBo;
        private Controls.AllEnumerationsControl allEnumerationsControl;
        private Controls.WeekdayParsingControl weekdayParsingControl;
        private Controls.SeasonsControl seasonsControl;
        private Controls.RectanglesControl rectanglesControl1;
        private Controls.MoviesControl moviesControl1;
        private Controls.RectanglesCollisionControl rectanglesCollisionControl1;
    }
}

