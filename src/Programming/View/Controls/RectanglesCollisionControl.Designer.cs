
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.AddRectanglesPictureBox = new System.Windows.Forms.PictureBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabelRectangles = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RemoveRectanglePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddRectanglesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRectanglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.AutoSize = true;
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(306, 23);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(451, 381);
            this.CanvasPanel.TabIndex = 31;
            this.CanvasPanel.Resize += new System.EventHandler(this.CanvasPanel_Resize);
            // 
            // AddRectanglesPictureBox
            // 
            this.AddRectanglesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddRectanglesPictureBox.Image")));
            this.AddRectanglesPictureBox.Location = new System.Drawing.Point(0, 193);
            this.AddRectanglesPictureBox.Name = "AddRectanglesPictureBox";
            this.AddRectanglesPictureBox.Size = new System.Drawing.Size(94, 29);
            this.AddRectanglesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddRectanglesPictureBox.TabIndex = 0;
            this.AddRectanglesPictureBox.TabStop = false;
            this.AddRectanglesPictureBox.Click += new System.EventHandler(this.AddRectanglesPictureBox_Click);
            this.AddRectanglesPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddRectanglesPictureBox_MouseDown);
            this.AddRectanglesPictureBox.MouseEnter += new System.EventHandler(this.AddRectanglesPictureBox_MouseEnter);
            this.AddRectanglesPictureBox.MouseLeave += new System.EventHandler(this.AddRectanglesPictureBox_MouseLeave);
            this.AddRectanglesPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddRectanglesPictureBox_MouseUp);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(90, 380);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(125, 27);
            this.HeightTextBox.TabIndex = 30;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(90, 347);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 29;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(90, 314);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(125, 27);
            this.YTextBox.TabIndex = 28;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(90, 281);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(125, 27);
            this.XTextBox.TabIndex = 27;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(90, 248);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdTextBox.TabIndex = 26;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // HeightLabelRectangles
            // 
            this.HeightLabelRectangles.AutoSize = true;
            this.HeightLabelRectangles.Location = new System.Drawing.Point(27, 383);
            this.HeightLabelRectangles.Name = "HeightLabelRectangles";
            this.HeightLabelRectangles.Size = new System.Drawing.Size(57, 20);
            this.HeightLabelRectangles.TabIndex = 25;
            this.HeightLabelRectangles.Text = "Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(32, 350);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 24;
            this.WidthLabel.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(64, 317);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(20, 20);
            this.YLabel.TabIndex = 23;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(63, 284);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(21, 20);
            this.XLabel.TabIndex = 22;
            this.XLabel.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(57, 251);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 21;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(0, 225);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 20;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(0, 23);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(300, 164);
            this.RectanglesListBox.TabIndex = 17;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(0, 0);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(84, 20);
            this.RectanglesLabel.TabIndex = 16;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RemoveRectanglePictureBox
            // 
            this.RemoveRectanglePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RemoveRectanglePictureBox.Image")));
            this.RemoveRectanglePictureBox.Location = new System.Drawing.Point(206, 193);
            this.RemoveRectanglePictureBox.Name = "RemoveRectanglePictureBox";
            this.RemoveRectanglePictureBox.Size = new System.Drawing.Size(94, 29);
            this.RemoveRectanglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveRectanglePictureBox.TabIndex = 0;
            this.RemoveRectanglePictureBox.TabStop = false;
            this.RemoveRectanglePictureBox.Click += new System.EventHandler(this.RemoveRectanglePictureBox_Click);
            this.RemoveRectanglePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoveRectanglePictureBox_MouseDown);
            this.RemoveRectanglePictureBox.MouseEnter += new System.EventHandler(this.RemoveRectanglePictureBox_MouseEnter);
            this.RemoveRectanglePictureBox.MouseLeave += new System.EventHandler(this.RemoveRectanglePictureBox_MouseLeave);
            this.RemoveRectanglePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveRectanglePictureBox_MouseUp);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeightLabelRectangles);
            this.Controls.Add(this.RemoveRectanglePictureBox);
            this.Controls.Add(this.AddRectanglesPictureBox);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Controls.Add(this.RectanglesLabel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(765, 419);
            ((System.ComponentModel.ISupportInitialize)(this.AddRectanglesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRectanglePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label HeightLabelRectangles;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.PictureBox AddRectanglesPictureBox;
        private System.Windows.Forms.PictureBox RemoveRectanglePictureBox;
    }
}
