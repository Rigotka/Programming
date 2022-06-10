
namespace Programming.View.Controls
{
    partial class AllEnumerationsControl
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
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesListsLabel = new System.Windows.Forms.Label();
            this.EnumListLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(344, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(68, 20);
            this.IntValueLabel.TabIndex = 11;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesListsLabel
            // 
            this.ValuesListsLabel.AutoSize = true;
            this.ValuesListsLabel.Location = new System.Drawing.Point(172, 0);
            this.ValuesListsLabel.Name = "ValuesListsLabel";
            this.ValuesListsLabel.Size = new System.Drawing.Size(104, 20);
            this.ValuesListsLabel.TabIndex = 10;
            this.ValuesListsLabel.Text = "Choose  value:";
            // 
            // EnumListLabel
            // 
            this.EnumListLabel.AutoSize = true;
            this.EnumListLabel.Location = new System.Drawing.Point(0, 0);
            this.EnumListLabel.Name = "EnumListLabel";
            this.EnumListLabel.Size = new System.Drawing.Size(149, 20);
            this.EnumListLabel.TabIndex = 9;
            this.EnumListLabel.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(344, 23);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(166, 27);
            this.IntValueTextBox.TabIndex = 8;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(172, 23);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(166, 224);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(0, 23);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(166, 224);
            this.EnumsListBox.TabIndex = 6;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.ValuesListsLabel);
            this.Controls.Add(this.EnumListLabel);
            this.Controls.Add(this.IntValueTextBox);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.EnumsListBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(519, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ValuesListsLabel;
        private System.Windows.Forms.Label EnumListLabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
    }
}
