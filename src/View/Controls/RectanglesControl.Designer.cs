
namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.FIndRectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(204, 23);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdTextBox.TabIndex = 27;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(204, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 26;
            this.IdLabel.Text = "ID:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(269, 256);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(20, 20);
            this.YLabel.TabIndex = 25;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(204, 256);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(21, 20);
            this.XLabel.TabIndex = 24;
            this.XLabel.Text = "X:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(269, 279);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(60, 27);
            this.YTextBox.TabIndex = 23;
            this.YTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YTextBox_KeyPress);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(204, 279);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(60, 27);
            this.XTextBox.TabIndex = 22;
            this.XTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XTextBox_KeyPress);
            // 
            // FIndRectangleButton
            // 
            this.FIndRectangleButton.Location = new System.Drawing.Point(204, 335);
            this.FIndRectangleButton.Name = "FIndRectangleButton";
            this.FIndRectangleButton.Size = new System.Drawing.Size(125, 29);
            this.FIndRectangleButton.TabIndex = 21;
            this.FIndRectangleButton.Text = "Find";
            this.FIndRectangleButton.UseVisualStyleBackColor = true;
            this.FIndRectangleButton.Click += new System.EventHandler(this.FIndButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(204, 215);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(125, 27);
            this.ColorTextBox.TabIndex = 20;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(204, 151);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 19;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(204, 87);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(125, 27);
            this.LengthTextBox.TabIndex = 18;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(204, 192);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 20);
            this.ColorLabel.TabIndex = 17;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(204, 128);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 16;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(204, 64);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(57, 20);
            this.LengthLabel.TabIndex = 15;
            this.LengthLabel.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(198, 364);
            this.RectanglesListBox.TabIndex = 14;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.FIndRectangleButton);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(354, 382);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Button FIndRectangleButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
