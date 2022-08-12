namespace Prototype_for_Inventory_Management
{
    partial class NewItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.furnitureTypeLabel = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.furnitureTypeSelector = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qtyCounter = new System.Windows.Forms.NumericUpDown();
            this.addItemButton = new System.Windows.Forms.Button();
            this.priceCounter = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.priceCounter);
            this.panel1.Controls.Add(this.addItemButton);
            this.panel1.Controls.Add(this.qtyCounter);
            this.panel1.Controls.Add(this.furnitureTypeSelector);
            this.panel1.Controls.Add(this.qtyLabel);
            this.panel1.Controls.Add(this.furnitureTypeLabel);
            this.panel1.Controls.Add(this.descriptionTextbox);
            this.panel1.Controls.Add(this.descLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.skuTextBox);
            this.panel1.Controls.Add(this.skuLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 313);
            this.panel1.TabIndex = 0;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.qtyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qtyLabel.Location = new System.Drawing.Point(13, 65);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(90, 17);
            this.qtyLabel.TabIndex = 28;
            this.qtyLabel.Text = "Initial Quantity";
            // 
            // furnitureTypeLabel
            // 
            this.furnitureTypeLabel.AutoSize = true;
            this.furnitureTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.furnitureTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.furnitureTypeLabel.Location = new System.Drawing.Point(13, 178);
            this.furnitureTypeLabel.Name = "furnitureTypeLabel";
            this.furnitureTypeLabel.Size = new System.Drawing.Size(106, 17);
            this.furnitureTypeLabel.TabIndex = 27;
            this.furnitureTypeLabel.Text = "Type of Furniture";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(13, 141);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(225, 23);
            this.descriptionTextbox.TabIndex = 26;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descLabel.Location = new System.Drawing.Point(13, 121);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(103, 17);
            this.descLabel.TabIndex = 25;
            this.descLabel.Text = "Item Description";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(133, 10);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(67, 17);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "Base Price";
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(12, 30);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(100, 23);
            this.skuTextBox.TabIndex = 22;
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skuLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skuLabel.Location = new System.Drawing.Point(13, 10);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(44, 17);
            this.skuLabel.TabIndex = 21;
            this.skuLabel.Text = "SKU #";
            // 
            // furnitureTypeSelector
            // 
            this.furnitureTypeSelector.FormattingEnabled = true;
            this.furnitureTypeSelector.Items.AddRange(new object[] {
            "Appliance",
            "Bedding",
            "Decor",
            "Electronics",
            "LightFixture",
            "Seating",
            "Table"});
            this.furnitureTypeSelector.Location = new System.Drawing.Point(12, 198);
            this.furnitureTypeSelector.Name = "furnitureTypeSelector";
            this.furnitureTypeSelector.Size = new System.Drawing.Size(168, 23);
            this.furnitureTypeSelector.TabIndex = 30;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Prototype_for_Inventory_Management.Item);
            // 
            // qtyCounter
            // 
            this.qtyCounter.Location = new System.Drawing.Point(13, 85);
            this.qtyCounter.Name = "qtyCounter";
            this.qtyCounter.Size = new System.Drawing.Size(120, 23);
            this.qtyCounter.TabIndex = 31;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(13, 227);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(106, 23);
            this.addItemButton.TabIndex = 32;
            this.addItemButton.Text = "Add Item!";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // priceCounter
            // 
            this.priceCounter.DecimalPlaces = 2;
            this.priceCounter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceCounter.Location = new System.Drawing.Point(133, 31);
            this.priceCounter.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            131072});
            this.priceCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceCounter.Name = "priceCounter";
            this.priceCounter.Size = new System.Drawing.Size(120, 23);
            this.priceCounter.TabIndex = 33;
            this.priceCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(295, 307);
            this.Controls.Add(this.panel1);
            this.Name = "NewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label qtyLabel;
        private Label furnitureTypeLabel;
        private Label descLabel;
        private Label priceLabel;
        private Label skuLabel;
        private BindingSource itemBindingSource;
        private Button addItemButton;
        public ComboBox furnitureTypeSelector;
        public TextBox descriptionTextbox;
        public TextBox skuTextBox;
        public NumericUpDown priceCounter;
        public NumericUpDown qtyCounter;
    }
}