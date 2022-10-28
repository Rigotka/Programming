namespace ObjectOrientedPractics.View.Control
{
    partial class AddressControl
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
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLlabel = new System.Windows.Forms.Label();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Location = new System.Drawing.Point(85, 23);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(60, 27);
            this.PostIndexTextBox.TabIndex = 0;
            this.PostIndexTextBox.Text = "123456";
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(85, 56);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(226, 27);
            this.CountryTextBox.TabIndex = 1;
            this.CountryTextBox.Text = "Объединенные Арабские Эмираты";
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(390, 56);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(226, 27);
            this.CityTextBox.TabIndex = 2;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(85, 89);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(531, 27);
            this.StreetTextBox.TabIndex = 3;
            this.StreetTextBox.Text = "11111111111111111111111111111111111111111111111111111111111111111";
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(85, 122);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(125, 27);
            this.BuildingTextBox.TabIndex = 4;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(390, 118);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(125, 27);
            this.ApartmentTextBox.TabIndex = 5;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(0, 0);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(120, 20);
            this.DeliveryAddressLabel.TabIndex = 6;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Location = new System.Drawing.Point(0, 26);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(79, 20);
            this.PostIndexLabel.TabIndex = 7;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(0, 59);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(63, 20);
            this.CountryLabel.TabIndex = 8;
            this.CountryLabel.Text = "Country:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(347, 59);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(37, 20);
            this.CityLabel.TabIndex = 9;
            this.CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(0, 92);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(51, 20);
            this.StreetLabel.TabIndex = 10;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLlabel
            // 
            this.BuildingLlabel.AutoSize = true;
            this.BuildingLlabel.Location = new System.Drawing.Point(0, 125);
            this.BuildingLlabel.Name = "BuildingLlabel";
            this.BuildingLlabel.Size = new System.Drawing.Size(67, 20);
            this.BuildingLlabel.TabIndex = 11;
            this.BuildingLlabel.Text = "Building:";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(301, 121);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(83, 20);
            this.ApartmentLabel.TabIndex = 12;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApartmentLabel);
            this.Controls.Add(this.BuildingLlabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.PostIndexLabel);
            this.Controls.Add(this.DeliveryAddressLabel);
            this.Controls.Add(this.ApartmentTextBox);
            this.Controls.Add(this.BuildingTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.PostIndexTextBox);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(618, 152);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private Label CountryLabel;
        private Label CityLabel;
        private Label StreetLabel;
        private Label BuildingLlabel;
        private Label ApartmentLabel;
    }
}
