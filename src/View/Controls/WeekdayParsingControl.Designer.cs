
namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.WeekdayParsinLabel = new System.Windows.Forms.Label();
            this.ParsingButton = new System.Windows.Forms.Button();
            this.WeekdayParsingResultLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WeekdayParsinLabel
            // 
            this.WeekdayParsinLabel.AutoSize = true;
            this.WeekdayParsinLabel.Location = new System.Drawing.Point(0, 0);
            this.WeekdayParsinLabel.Name = "WeekdayParsinLabel";
            this.WeekdayParsinLabel.Size = new System.Drawing.Size(158, 20);
            this.WeekdayParsinLabel.TabIndex = 7;
            this.WeekdayParsinLabel.Text = "Type value for parsing:";
            // 
            // ParsingButton
            // 
            this.ParsingButton.Location = new System.Drawing.Point(273, 21);
            this.ParsingButton.Name = "ParsingButton";
            this.ParsingButton.Size = new System.Drawing.Size(94, 29);
            this.ParsingButton.TabIndex = 6;
            this.ParsingButton.Text = "Parse";
            this.ParsingButton.UseVisualStyleBackColor = true;
            this.ParsingButton.Click += new System.EventHandler(this.ParsingButton_Click);
            // 
            // WeekdayParsingResultLabel
            // 
            this.WeekdayParsingResultLabel.AutoSize = true;
            this.WeekdayParsingResultLabel.Location = new System.Drawing.Point(0, 53);
            this.WeekdayParsingResultLabel.Name = "WeekdayParsingResultLabel";
            this.WeekdayParsingResultLabel.Size = new System.Drawing.Size(93, 20);
            this.WeekdayParsingResultLabel.TabIndex = 5;
            this.WeekdayParsingResultLabel.Text = "Enter a word";
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(0, 23);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(267, 27);
            this.WeekdayParsingTextBox.TabIndex = 4;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayParsinLabel);
            this.Controls.Add(this.ParsingButton);
            this.Controls.Add(this.WeekdayParsingResultLabel);
            this.Controls.Add(this.WeekdayParsingTextBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(380, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeekdayParsinLabel;
        private System.Windows.Forms.Button ParsingButton;
        private System.Windows.Forms.Label WeekdayParsingResultLabel;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
    }
}
