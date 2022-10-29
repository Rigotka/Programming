namespace ObjectOrientedPractics
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CUstomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.TabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CUstomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.CUstomersTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.MinimumSize = new System.Drawing.Size(948, 489);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(948, 489);
            this.TabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(940, 456);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(934, 450);
            this.ItemsTab.TabIndex = 0;
            // 
            // CUstomersTabPage
            // 
            this.CUstomersTabPage.Controls.Add(this.CustomersTab);
            this.CUstomersTabPage.Location = new System.Drawing.Point(4, 29);
            this.CUstomersTabPage.Name = "CUstomersTabPage";
            this.CUstomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CUstomersTabPage.Size = new System.Drawing.Size(940, 456);
            this.CUstomersTabPage.TabIndex = 1;
            this.CUstomersTabPage.Text = "Customers";
            this.CUstomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersTab.Location = new System.Drawing.Point(3, 3);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(934, 450);
            this.CustomersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 489);
            this.Controls.Add(this.TabControl);
            this.MinimumSize = new System.Drawing.Size(966, 536);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CUstomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private TabPage CUstomersTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;

        #endregion
        // private View.Tabs.ItemsTab itemsTab1;
    }
}