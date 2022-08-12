using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_for_Inventory_Management
{
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (ValidateSKU())
                this.Close();
            else
                MessageBox.Show("Please enter a valid SKU #!");
        }

        private bool ValidateSKU()
        {
            int sku;
            if (int.TryParse(skuTextBox.Text, out sku))
                return true;
            else
                return false;

        }
    }
}
