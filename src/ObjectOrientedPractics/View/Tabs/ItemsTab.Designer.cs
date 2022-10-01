namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.SelectedItemPanel = new System.Windows.Forms.Panel();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.ItemsPanel.SuspendLayout();
            this.SelectedItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.ItemsPanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.SelectedItemPanel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(736, 447);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsPanel.Controls.Add(this.DeleteButton);
            this.ItemsPanel.Controls.Add(this.AddButton);
            this.ItemsPanel.Controls.Add(this.ItemsListBox);
            this.ItemsPanel.Controls.Add(this.ItemsLabel);
            this.ItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(362, 441);
            this.ItemsPanel.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(103, 409);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(3, 409);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 23);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(356, 384);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(45, 20);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // SelectedItemPanel
            // 
            this.SelectedItemPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectedItemPanel.Controls.Add(this.InfoTextBox);
            this.SelectedItemPanel.Controls.Add(this.NameTextBox);
            this.SelectedItemPanel.Controls.Add(this.CostTextBox);
            this.SelectedItemPanel.Controls.Add(this.IDTextBox);
            this.SelectedItemPanel.Controls.Add(this.InfoLabel);
            this.SelectedItemPanel.Controls.Add(this.NameLabel);
            this.SelectedItemPanel.Controls.Add(this.CostLabel);
            this.SelectedItemPanel.Controls.Add(this.IDLabel);
            this.SelectedItemPanel.Controls.Add(this.SelectedItemLabel);
            this.SelectedItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemPanel.Location = new System.Drawing.Point(371, 3);
            this.SelectedItemPanel.Name = "SelectedItemPanel";
            this.SelectedItemPanel.Size = new System.Drawing.Size(362, 441);
            this.SelectedItemPanel.TabIndex = 1;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(3, 267);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(356, 120);
            this.InfoTextBox.TabIndex = 11;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(3, 115);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(356, 120);
            this.NameTextBox.TabIndex = 10;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(88, 56);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(125, 27);
            this.CostTextBox.TabIndex = 6;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(88, 23);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(125, 27);
            this.IDTextBox.TabIndex = 5;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(3, 244);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(38, 20);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Info:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 92);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 59);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(41, 20);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 26);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 20);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(100, 20);
            this.SelectedItemLabel.TabIndex = 0;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(736, 447);
            this.TableLayoutPanel.ResumeLayout(false);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.SelectedItemPanel.ResumeLayout(false);
            this.SelectedItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Panel ItemsPanel;
        private Button DeleteButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private Panel SelectedItemPanel;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label InfoLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IDLabel;
        private Label SelectedItemLabel;
        private TextBox InfoTextBox;
        private TextBox NameTextBox;
    }
}
