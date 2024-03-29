﻿namespace ObjectOrientedPractics.View.Tabs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersTab));
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.RandomButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.СontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomerSelectedPanel = new System.Windows.Forms.Panel();
            this.DiscountRemoveButton = new System.Windows.Forms.Button();
            this.DiscountAddButton = new System.Windows.Forms.Button();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.DIscountsLabel = new System.Windows.Forms.Label();
            this.PriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressControl = new ObjectOrientedPractics.View.Control.AddressControl();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.СontextMenuStrip.SuspendLayout();
            this.CustomerSelectedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.14F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.86F));
            this.TableLayoutPanel.Controls.Add(this.CustomersPanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.CustomerSelectedPanel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(938, 461);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomersPanel.Controls.Add(this.RandomButton);
            this.CustomersPanel.Controls.Add(this.CustomersListBox);
            this.CustomersPanel.Controls.Add(this.CustomersLabel);
            this.CustomersPanel.Controls.Add(this.DeleteButton);
            this.CustomersPanel.Controls.Add(this.AddButton);
            this.CustomersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersPanel.Location = new System.Drawing.Point(3, 3);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(332, 455);
            this.CustomersPanel.TabIndex = 0;
            // 
            // RandomButton
            // 
            this.RandomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomButton.Location = new System.Drawing.Point(225, 413);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(105, 29);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.ContextMenuStrip = this.СontextMenuStrip;
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 23);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(327, 384);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // СontextMenuStrip
            // 
            this.СontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.СontextMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.СontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteAllMenuItem});
            this.СontextMenuStrip.Name = "contextMenuStrip1";
            this.СontextMenuStrip.Size = new System.Drawing.Size(147, 30);
            // 
            // DeleteAllMenuItem
            // 
            this.DeleteAllMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteAllMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAllMenuItem.Image")));
            this.DeleteAllMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.DeleteAllMenuItem.Name = "DeleteAllMenuItem";
            this.DeleteAllMenuItem.Size = new System.Drawing.Size(146, 26);
            this.DeleteAllMenuItem.Text = "Очистить";
            this.DeleteAllMenuItem.Click += new System.EventHandler(this.DeleteAllMenuItem_Click);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLabel.Location = new System.Drawing.Point(3, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(84, 20);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(114, 413);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 29);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(3, 413);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomerSelectedPanel
            // 
            this.CustomerSelectedPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerSelectedPanel.Controls.Add(this.DiscountRemoveButton);
            this.CustomerSelectedPanel.Controls.Add(this.DiscountAddButton);
            this.CustomerSelectedPanel.Controls.Add(this.DiscountsListBox);
            this.CustomerSelectedPanel.Controls.Add(this.DIscountsLabel);
            this.CustomerSelectedPanel.Controls.Add(this.PriorityCheckBox);
            this.CustomerSelectedPanel.Controls.Add(this.AddressControl);
            this.CustomerSelectedPanel.Controls.Add(this.FullNameTextBox);
            this.CustomerSelectedPanel.Controls.Add(this.IDTextBox);
            this.CustomerSelectedPanel.Controls.Add(this.FullNameLabel);
            this.CustomerSelectedPanel.Controls.Add(this.IDlabel);
            this.CustomerSelectedPanel.Controls.Add(this.SelectedCustomerLabel);
            this.CustomerSelectedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerSelectedPanel.Location = new System.Drawing.Point(341, 3);
            this.CustomerSelectedPanel.Name = "CustomerSelectedPanel";
            this.CustomerSelectedPanel.Size = new System.Drawing.Size(594, 455);
            this.CustomerSelectedPanel.TabIndex = 1;
            // 
            // DiscountRemoveButton
            // 
            this.DiscountRemoveButton.Location = new System.Drawing.Point(289, 358);
            this.DiscountRemoveButton.Name = "DiscountRemoveButton";
            this.DiscountRemoveButton.Size = new System.Drawing.Size(105, 29);
            this.DiscountRemoveButton.TabIndex = 11;
            this.DiscountRemoveButton.Text = "Remove";
            this.DiscountRemoveButton.UseVisualStyleBackColor = true;
            this.DiscountRemoveButton.Click += new System.EventHandler(this.DiscountRemoveButton_Click);
            // 
            // DiscountAddButton
            // 
            this.DiscountAddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DiscountAddButton.Location = new System.Drawing.Point(289, 323);
            this.DiscountAddButton.Name = "DiscountAddButton";
            this.DiscountAddButton.Size = new System.Drawing.Size(105, 29);
            this.DiscountAddButton.TabIndex = 10;
            this.DiscountAddButton.Text = "Add";
            this.DiscountAddButton.UseVisualStyleBackColor = true;
            this.DiscountAddButton.Click += new System.EventHandler(this.DiscountAddButton_Click);
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.ItemHeight = 20;
            this.DiscountsListBox.Location = new System.Drawing.Point(3, 323);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(280, 84);
            this.DiscountsListBox.TabIndex = 9;
            // 
            // DIscountsLabel
            // 
            this.DIscountsLabel.AutoSize = true;
            this.DIscountsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DIscountsLabel.Location = new System.Drawing.Point(3, 300);
            this.DIscountsLabel.Name = "DIscountsLabel";
            this.DIscountsLabel.Size = new System.Drawing.Size(79, 20);
            this.DIscountsLabel.TabIndex = 8;
            this.DIscountsLabel.Text = "DIscounts";
            // 
            // PriorityCheckBox
            // 
            this.PriorityCheckBox.AutoSize = true;
            this.PriorityCheckBox.Location = new System.Drawing.Point(88, 89);
            this.PriorityCheckBox.Name = "PriorityCheckBox";
            this.PriorityCheckBox.Size = new System.Drawing.Size(92, 24);
            this.PriorityCheckBox.TabIndex = 7;
            this.PriorityCheckBox.Text = "Is Priority";
            this.PriorityCheckBox.UseVisualStyleBackColor = true;
            this.PriorityCheckBox.CheckedChanged += new System.EventHandler(this.PriorityCheckBox_CheckedChanged);
            // 
            // AddressControl
            // 
            address1.Apartment = "-";
            address1.Building = "-";
            address1.City = "-";
            address1.Country = "-";
            address1.Index = 100000;
            address1.Street = "-";
            this.AddressControl.Address = address1;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(3, 126);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(589, 163);
            this.AddressControl.TabIndex = 6;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(88, 56);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(502, 27);
            this.FullNameTextBox.TabIndex = 5;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(88, 23);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(60, 27);
            this.IDTextBox.TabIndex = 4;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(3, 59);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(3, 26);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(27, 20);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedCustomerLabel.TabIndex = 0;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(938, 461);
            this.TableLayoutPanel.ResumeLayout(false);
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.СontextMenuStrip.ResumeLayout(false);
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
        private TextBox FullNameTextBox;
        private TextBox IDTextBox;
        private Button RandomButton;
        private ContextMenuStrip СontextMenuStrip;
        private ToolStripMenuItem DeleteAllMenuItem;
        private Control.AddressControl AddressControl;
        private CheckBox PriorityCheckBox;
        private Label DIscountsLabel;
        private Button DiscountRemoveButton;
        private Button DiscountAddButton;
        private ListBox DiscountsListBox;
    }
}
