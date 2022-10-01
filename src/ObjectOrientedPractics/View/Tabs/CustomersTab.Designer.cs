namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomerSelectedPanel = new System.Windows.Forms.Panel();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.CustomerSelectedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.CustomersPanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.CustomerSelectedPanel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(736, 447);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomersPanel.Controls.Add(this.DeleteButton);
            this.CustomersPanel.Controls.Add(this.AddButton);
            this.CustomersPanel.Controls.Add(this.CustomersListBox);
            this.CustomersPanel.Controls.Add(this.CustomersLabel);
            this.CustomersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersPanel.Location = new System.Drawing.Point(3, 3);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(362, 441);
            this.CustomersPanel.TabIndex = 0;
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
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 23);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(356, 384);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Location = new System.Drawing.Point(3, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(78, 20);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomerSelectedPanel
            // 
            this.CustomerSelectedPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerSelectedPanel.Controls.Add(this.AddressTextBox);
            this.CustomerSelectedPanel.Controls.Add(this.FullNameTextBox);
            this.CustomerSelectedPanel.Controls.Add(this.IDTextBox);
            this.CustomerSelectedPanel.Controls.Add(this.AddressLabel);
            this.CustomerSelectedPanel.Controls.Add(this.FullNameLabel);
            this.CustomerSelectedPanel.Controls.Add(this.IDlabel);
            this.CustomerSelectedPanel.Controls.Add(this.SelectedCustomerLabel);
            this.CustomerSelectedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerSelectedPanel.Location = new System.Drawing.Point(371, 3);
            this.CustomerSelectedPanel.Name = "CustomerSelectedPanel";
            this.CustomerSelectedPanel.Size = new System.Drawing.Size(362, 441);
            this.CustomerSelectedPanel.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(3, 115);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(356, 120);
            this.AddressTextBox.TabIndex = 6;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(88, 56);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(271, 27);
            this.FullNameTextBox.TabIndex = 5;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(88, 23);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(125, 27);
            this.IDTextBox.TabIndex = 4;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(3, 92);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 20);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "Address:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(3, 56);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(3, 23);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(27, 20);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(133, 20);
            this.SelectedCustomerLabel.TabIndex = 0;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(736, 447);
            this.TableLayoutPanel.ResumeLayout(false);
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.CustomerSelectedPanel.ResumeLayout(false);
            this.CustomerSelectedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Panel CustomersPanel;
        private Panel CustomerSelectedPanel;
        private Label CustomersLabel;
        private ListBox CustomersListBox;
        private Button DeleteButton;
        private Button AddButton;
        private Label IDlabel;
        private Label SelectedCustomerLabel;
        private Label FullNameLabel;
        private Label AddressLabel;
        private TextBox AddressTextBox;
        private TextBox FullNameTextBox;
        private TextBox IDTextBox;
    }
}
