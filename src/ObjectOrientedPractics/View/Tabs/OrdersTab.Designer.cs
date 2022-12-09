namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            ObjectOrientedPractics.Model.Address address2 = new ObjectOrientedPractics.Model.Address();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersPanel = new System.Windows.Forms.Panel();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.SelectedOrderPanel = new System.Windows.Forms.Panel();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountValueLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.AddressControl = new ObjectOrientedPractics.View.Control.AddressControl();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IDLAbel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.OrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.SelectedOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.14F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.86F));
            this.TableLayoutPanel.Controls.Add(this.OrdersPanel, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.SelectedOrderPanel, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(938, 461);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.Controls.Add(this.OrdersDataGrid);
            this.OrdersPanel.Controls.Add(this.OrderLabel);
            this.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersPanel.Location = new System.Drawing.Point(3, 3);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(332, 455);
            this.OrdersPanel.TabIndex = 0;
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.AllowUserToAddRows = false;
            this.OrdersDataGrid.AllowUserToDeleteRows = false;
            this.OrdersDataGrid.AllowUserToResizeColumns = false;
            this.OrdersDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.OrdersDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.OrdersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGrid.ColumnHeadersHeight = 29;
            this.OrdersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.created,
            this.orderStatus,
            this.deliveryAddress,
            this.customerFullName,
            this.amount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.OrdersDataGrid.Location = new System.Drawing.Point(3, 23);
            this.OrdersDataGrid.MultiSelect = false;
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.ReadOnly = true;
            this.OrdersDataGrid.RowHeadersVisible = false;
            this.OrdersDataGrid.RowHeadersWidth = 51;
            this.OrdersDataGrid.RowTemplate.Height = 29;
            this.OrdersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGrid.Size = new System.Drawing.Size(326, 429);
            this.OrdersDataGrid.TabIndex = 1;
            this.OrdersDataGrid.SelectionChanged += new System.EventHandler(this.OrdersDataGrid_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 2;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 45;
            // 
            // created
            // 
            this.created.HeaderText = "Created";
            this.created.MinimumWidth = 6;
            this.created.Name = "created";
            this.created.ReadOnly = true;
            this.created.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.created.Width = 140;
            // 
            // orderStatus
            // 
            this.orderStatus.HeaderText = "Order Status";
            this.orderStatus.MinimumWidth = 6;
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            this.orderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.orderStatus.Width = 125;
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.HeaderText = "Delivery Address";
            this.deliveryAddress.MinimumWidth = 6;
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.ReadOnly = true;
            this.deliveryAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deliveryAddress.Width = 125;
            // 
            // customerFullName
            // 
            this.customerFullName.HeaderText = "Customer Full Name";
            this.customerFullName.MinimumWidth = 6;
            this.customerFullName.Name = "customerFullName";
            this.customerFullName.ReadOnly = true;
            this.customerFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.customerFullName.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 125;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderLabel.Location = new System.Drawing.Point(3, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(60, 20);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Orders:";
            // 
            // SelectedOrderPanel
            // 
            this.SelectedOrderPanel.Controls.Add(this.ItemsListBox);
            this.SelectedOrderPanel.Controls.Add(this.AmountValueLabel);
            this.SelectedOrderPanel.Controls.Add(this.AmountLabel);
            this.SelectedOrderPanel.Controls.Add(this.OrderItemsLabel);
            this.SelectedOrderPanel.Controls.Add(this.AddressControl);
            this.SelectedOrderPanel.Controls.Add(this.StatusComboBox);
            this.SelectedOrderPanel.Controls.Add(this.CreatedTextBox);
            this.SelectedOrderPanel.Controls.Add(this.IDTextBox);
            this.SelectedOrderPanel.Controls.Add(this.StatusLabel);
            this.SelectedOrderPanel.Controls.Add(this.CreatedLabel);
            this.SelectedOrderPanel.Controls.Add(this.IDLAbel);
            this.SelectedOrderPanel.Controls.Add(this.SelectedOrderLabel);
            this.SelectedOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrderPanel.Location = new System.Drawing.Point(341, 3);
            this.SelectedOrderPanel.Name = "SelectedOrderPanel";
            this.SelectedOrderPanel.Size = new System.Drawing.Size(594, 455);
            this.SelectedOrderPanel.TabIndex = 1;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 316);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(588, 84);
            this.ItemsListBox.TabIndex = 11;
            // 
            // AmountValueLabel
            // 
            this.AmountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountValueLabel.AutoSize = true;
            this.AmountValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountValueLabel.Location = new System.Drawing.Point(568, 423);
            this.AmountValueLabel.Name = "AmountValueLabel";
            this.AmountValueLabel.Size = new System.Drawing.Size(24, 28);
            this.AmountValueLabel.TabIndex = 10;
            this.AmountValueLabel.Text = "0";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(526, 403);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 9;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Location = new System.Drawing.Point(3, 292);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(87, 20);
            this.OrderItemsLabel.TabIndex = 8;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // AddressControl
            // 
            address2.Apartment = "-";
            address2.Building = "-";
            address2.City = "-";
            address2.Country = "-";
            address2.Index = 100000;
            address2.Street = "-";
            this.AddressControl.Address = address2;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(3, 126);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(588, 163);
            this.AddressControl.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(88, 89);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(151, 28);
            this.StatusComboBox.TabIndex = 6;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(88, 56);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(151, 27);
            this.CreatedTextBox.TabIndex = 5;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(88, 23);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(60, 27);
            this.IDTextBox.TabIndex = 4;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(3, 92);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 20);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(3, 59);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(64, 20);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Created:";
            // 
            // IDLAbel
            // 
            this.IDLAbel.AutoSize = true;
            this.IDLAbel.Location = new System.Drawing.Point(3, 26);
            this.IDLAbel.Name = "IDLAbel";
            this.IDLAbel.Size = new System.Drawing.Size(27, 20);
            this.IDLAbel.TabIndex = 1;
            this.IDLAbel.Text = "ID:";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(111, 20);
            this.SelectedOrderLabel.TabIndex = 0;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(938, 461);
            this.TableLayoutPanel.ResumeLayout(false);
            this.OrdersPanel.ResumeLayout(false);
            this.OrdersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            this.SelectedOrderPanel.ResumeLayout(false);
            this.SelectedOrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private Panel OrdersPanel;
        private Label OrderLabel;
        private Panel SelectedOrderPanel;
        private DataGridView OrdersDataGrid;
        private Control.AddressControl AddressControl;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IDTextBox;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IDLAbel;
        private Label SelectedOrderLabel;
        private Label AmountValueLabel;
        private Label AmountLabel;
        private Label OrderItemsLabel;
        private ListBox ItemsListBox;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn created;
        private DataGridViewTextBoxColumn orderStatus;
        private DataGridViewTextBoxColumn deliveryAddress;
        private DataGridViewTextBoxColumn customerFullName;
        private DataGridViewTextBoxColumn amount;
    }
}
