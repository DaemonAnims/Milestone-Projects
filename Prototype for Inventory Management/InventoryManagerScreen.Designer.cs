/*
 * 
 * Code created and designed by Chance Anderson,
 * for the express purpose of completing assignment
 * for CST-150 class at Grand Canyon University.
 * 
 */

namespace Prototype_for_Inventory_Management
{
    partial class InventoryManagerScreen
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
            this.coloredBackPanel = new System.Windows.Forms.Panel();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.addCartButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.restockCounter = new System.Windows.Forms.NumericUpDown();
            this.restockItemButton = new System.Windows.Forms.Button();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.warrantyListBox = new System.Windows.Forms.ListBox();
            this.warrantyLabel = new System.Windows.Forms.Label();
            this.furnitureTypeTextbox = new System.Windows.Forms.TextBox();
            this.furnitureTypeLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.basePriceTextbox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.itemDetailsLabel = new System.Windows.Forms.Label();
            this.itemDetailButton = new System.Windows.Forms.Button();
            this.newInvButton = new System.Windows.Forms.Button();
            this.currInvLabel = new System.Windows.Forms.Label();
            this.currentInventoryListBox = new System.Windows.Forms.ListBox();
            this.coloredBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restockCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // coloredBackPanel
            // 
            this.coloredBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.coloredBackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coloredBackPanel.Controls.Add(this.checkoutButton);
            this.coloredBackPanel.Controls.Add(this.addCartButton);
            this.coloredBackPanel.Controls.Add(this.clearSearchButton);
            this.coloredBackPanel.Controls.Add(this.restockCounter);
            this.coloredBackPanel.Controls.Add(this.restockItemButton);
            this.coloredBackPanel.Controls.Add(this.qtyTextBox);
            this.coloredBackPanel.Controls.Add(this.qtyLabel);
            this.coloredBackPanel.Controls.Add(this.searchButton);
            this.coloredBackPanel.Controls.Add(this.searchTextBox);
            this.coloredBackPanel.Controls.Add(this.deleteItemButton);
            this.coloredBackPanel.Controls.Add(this.warrantyListBox);
            this.coloredBackPanel.Controls.Add(this.warrantyLabel);
            this.coloredBackPanel.Controls.Add(this.furnitureTypeTextbox);
            this.coloredBackPanel.Controls.Add(this.furnitureTypeLabel);
            this.coloredBackPanel.Controls.Add(this.descriptionTextbox);
            this.coloredBackPanel.Controls.Add(this.descLabel);
            this.coloredBackPanel.Controls.Add(this.basePriceTextbox);
            this.coloredBackPanel.Controls.Add(this.priceLabel);
            this.coloredBackPanel.Controls.Add(this.skuTextBox);
            this.coloredBackPanel.Controls.Add(this.skuLabel);
            this.coloredBackPanel.Controls.Add(this.itemDetailsLabel);
            this.coloredBackPanel.Controls.Add(this.itemDetailButton);
            this.coloredBackPanel.Controls.Add(this.newInvButton);
            this.coloredBackPanel.Controls.Add(this.currInvLabel);
            this.coloredBackPanel.Controls.Add(this.currentInventoryListBox);
            this.coloredBackPanel.Location = new System.Drawing.Point(12, 12);
            this.coloredBackPanel.Name = "coloredBackPanel";
            this.coloredBackPanel.Size = new System.Drawing.Size(538, 448);
            this.coloredBackPanel.TabIndex = 0;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(171, 406);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(177, 23);
            this.checkoutButton.TabIndex = 25;
            this.checkoutButton.Text = "View Cart / Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // addCartButton
            // 
            this.addCartButton.Location = new System.Drawing.Point(368, 377);
            this.addCartButton.Name = "addCartButton";
            this.addCartButton.Size = new System.Drawing.Size(99, 23);
            this.addCartButton.TabIndex = 24;
            this.addCartButton.Text = "Add To Cart";
            this.addCartButton.UseVisualStyleBackColor = true;
            this.addCartButton.Click += new System.EventHandler(this.addCartButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(126, 46);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(80, 23);
            this.clearSearchButton.TabIndex = 23;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // restockCounter
            // 
            this.restockCounter.Location = new System.Drawing.Point(248, 377);
            this.restockCounter.Name = "restockCounter";
            this.restockCounter.Size = new System.Drawing.Size(100, 23);
            this.restockCounter.TabIndex = 22;
            // 
            // restockItemButton
            // 
            this.restockItemButton.Location = new System.Drawing.Point(248, 351);
            this.restockItemButton.Name = "restockItemButton";
            this.restockItemButton.Size = new System.Drawing.Size(100, 23);
            this.restockItemButton.TabIndex = 21;
            this.restockItemButton.Text = "Restock Item";
            this.restockItemButton.UseVisualStyleBackColor = true;
            this.restockItemButton.Click += new System.EventHandler(this.restockItemButton_Click);
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(367, 114);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 23);
            this.qtyTextBox.TabIndex = 20;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qtyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qtyLabel.Location = new System.Drawing.Point(368, 94);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(56, 17);
            this.qtyLabel.TabIndex = 19;
            this.qtyLabel.Text = "Quantity";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(31, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 23);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(42, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "SKU# or Description";
            this.searchTextBox.Size = new System.Drawing.Size(153, 23);
            this.searchTextBox.TabIndex = 17;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(367, 351);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(100, 23);
            this.deleteItemButton.TabIndex = 16;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // warrantyListBox
            // 
            this.warrantyListBox.FormattingEnabled = true;
            this.warrantyListBox.ItemHeight = 15;
            this.warrantyListBox.Items.AddRange(new object[] {
            " "});
            this.warrantyListBox.Location = new System.Drawing.Point(242, 266);
            this.warrantyListBox.Name = "warrantyListBox";
            this.warrantyListBox.Size = new System.Drawing.Size(226, 79);
            this.warrantyListBox.TabIndex = 14;
            // 
            // warrantyLabel
            // 
            this.warrantyLabel.AutoSize = true;
            this.warrantyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.warrantyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.warrantyLabel.Location = new System.Drawing.Point(242, 240);
            this.warrantyLabel.Name = "warrantyLabel";
            this.warrantyLabel.Size = new System.Drawing.Size(171, 17);
            this.warrantyLabel.TabIndex = 13;
            this.warrantyLabel.Text = "Warranties Item Eligible For:";
            // 
            // furnitureTypeTextbox
            // 
            this.furnitureTypeTextbox.Location = new System.Drawing.Point(242, 204);
            this.furnitureTypeTextbox.Name = "furnitureTypeTextbox";
            this.furnitureTypeTextbox.Size = new System.Drawing.Size(226, 23);
            this.furnitureTypeTextbox.TabIndex = 12;
            // 
            // furnitureTypeLabel
            // 
            this.furnitureTypeLabel.AutoSize = true;
            this.furnitureTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.furnitureTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.furnitureTypeLabel.Location = new System.Drawing.Point(242, 184);
            this.furnitureTypeLabel.Name = "furnitureTypeLabel";
            this.furnitureTypeLabel.Size = new System.Drawing.Size(106, 17);
            this.furnitureTypeLabel.TabIndex = 11;
            this.furnitureTypeLabel.Text = "Type of Furniture";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(243, 149);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(225, 23);
            this.descriptionTextbox.TabIndex = 10;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descLabel.Location = new System.Drawing.Point(243, 129);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(103, 17);
            this.descLabel.TabIndex = 9;
            this.descLabel.Text = "Item Description";
            // 
            // basePriceTextbox
            // 
            this.basePriceTextbox.Location = new System.Drawing.Point(368, 68);
            this.basePriceTextbox.Name = "basePriceTextbox";
            this.basePriceTextbox.Size = new System.Drawing.Size(100, 23);
            this.basePriceTextbox.TabIndex = 8;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(368, 48);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(67, 17);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Base Price";
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(242, 68);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(100, 23);
            this.skuTextBox.TabIndex = 6;
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skuLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skuLabel.Location = new System.Drawing.Point(243, 48);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(44, 17);
            this.skuLabel.TabIndex = 5;
            this.skuLabel.Text = "SKU #";
            // 
            // itemDetailsLabel
            // 
            this.itemDetailsLabel.AutoSize = true;
            this.itemDetailsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemDetailsLabel.Location = new System.Drawing.Point(242, 17);
            this.itemDetailsLabel.Name = "itemDetailsLabel";
            this.itemDetailsLabel.Size = new System.Drawing.Size(92, 21);
            this.itemDetailsLabel.TabIndex = 4;
            this.itemDetailsLabel.Text = "Item Details";
            // 
            // itemDetailButton
            // 
            this.itemDetailButton.Location = new System.Drawing.Point(42, 348);
            this.itemDetailButton.Name = "itemDetailButton";
            this.itemDetailButton.Size = new System.Drawing.Size(153, 23);
            this.itemDetailButton.TabIndex = 3;
            this.itemDetailButton.Text = "View Item Details";
            this.itemDetailButton.UseVisualStyleBackColor = true;
            this.itemDetailButton.Click += new System.EventHandler(this.itemDetailButton_Click);
            // 
            // newInvButton
            // 
            this.newInvButton.Location = new System.Drawing.Point(42, 377);
            this.newInvButton.Name = "newInvButton";
            this.newInvButton.Size = new System.Drawing.Size(153, 23);
            this.newInvButton.TabIndex = 2;
            this.newInvButton.Text = "New Inventory Item";
            this.newInvButton.UseVisualStyleBackColor = true;
            this.newInvButton.Click += new System.EventHandler(this.newInvButton_Click);
            // 
            // currInvLabel
            // 
            this.currInvLabel.AutoSize = true;
            this.currInvLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.currInvLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currInvLabel.Location = new System.Drawing.Point(31, 74);
            this.currInvLabel.Name = "currInvLabel";
            this.currInvLabel.Size = new System.Drawing.Size(175, 21);
            this.currInvLabel.TabIndex = 1;
            this.currInvLabel.Text = "Current Inventory Items";
            // 
            // currentInventoryListBox
            // 
            this.currentInventoryListBox.FormattingEnabled = true;
            this.currentInventoryListBox.HorizontalScrollbar = true;
            this.currentInventoryListBox.ItemHeight = 15;
            this.currentInventoryListBox.Items.AddRange(new object[] {
            "test"});
            this.currentInventoryListBox.Location = new System.Drawing.Point(42, 98);
            this.currentInventoryListBox.Name = "currentInventoryListBox";
            this.currentInventoryListBox.Size = new System.Drawing.Size(153, 244);
            this.currentInventoryListBox.TabIndex = 0;
            // 
            // InventoryManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototype_for_Inventory_Management.Properties.Resources.chairDisplay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.coloredBackPanel);
            this.Name = "InventoryManagerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.InventoryManagerScreen_Load);
            this.coloredBackPanel.ResumeLayout(false);
            this.coloredBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restockCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel coloredBackPanel;
        private Label itemDetailsLabel;
        private Button itemDetailButton;
        private Button newInvButton;
        private Label currInvLabel;
        private ListBox currentInventoryListBox;
        private Label skuLabel;
        private TextBox skuTextBox;
        private Button deleteItemButton;
        private ListBox warrantyListBox;
        private Label warrantyLabel;
        private TextBox furnitureTypeTextbox;
        private Label furnitureTypeLabel;
        private TextBox descriptionTextbox;
        private Label descLabel;
        private TextBox basePriceTextbox;
        private Label priceLabel;
        private TextBox qtyTextBox;
        private Label qtyLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private NumericUpDown restockCounter;
        private Button restockItemButton;
        private Button clearSearchButton;
        private Button checkoutButton;
        private Button addCartButton;
    }
}