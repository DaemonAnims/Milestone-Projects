/*
 * 
 * Code created and designed by Chance Anderson,
 * for the express purpose of completing assignment
 * for CST-150 class at Grand Canyon University.
 * 
 */

namespace Prototype_for_Inventory_Management
{
    public partial class InventoryManagerScreen : Form
    {

        InventoryManager invMan;

        public InventoryManagerScreen()
        {
            InitializeComponent();
            //intitialize inventory manager
            invMan = new InventoryManager();
            //Display Items
            DisplayItems(invMan.TrimAndGetArray());
        }

        private void itemDetailButton_Click(object sender, EventArgs e)
        {
            try 
            {
                //Get item 
                Item item = invMan.GetItem(currentInventoryListBox.SelectedItem.ToString());
                //fill in item values on screen
                skuTextBox.Text = item.SKU.ToString();
                basePriceTextbox.Text = item.Price.ToString("c");
                descriptionTextbox.Text = item.Description;
                furnitureTypeTextbox.Text = item.Type;
                warrantyListBox.Items.Clear();
                if (item.Quantity == 0)
                {
                    qtyTextBox.ForeColor = Color.Red;
                    qtyTextBox.Text = "OUT OF STOCK";
                }
                else
                {
                    qtyTextBox.ForeColor = Color.Black;
                    qtyTextBox.Text = item.Quantity.ToString();
                }
                //loop for warranties
                foreach (Warranty warranty in item.Warranties)
                {
                    warrantyListBox.Items.Add(warranty.ToString());
                }
            } 
            catch //Catch exception for no item selected
            {
                MessageBox.Show("Please select an item to view details");
            }
        }

        private void newInvButton_Click(object sender, EventArgs e)
        {
            NewItemForm newItemForm = new();
            newItemForm.ShowDialog();
            int sku = int.Parse(newItemForm.skuTextBox.Text);
            decimal price = newItemForm.priceCounter.Value;
            string desc = newItemForm.descriptionTextbox.Text;
            string type = newItemForm.furnitureTypeSelector.SelectedItem.ToString();
            int quantity = (int)newItemForm.qtyCounter.Value;
            Item toAdd = new Item(sku, price, desc, type, quantity);
            invMan.AddNewItem(toAdd);
            DisplayItems(invMan.TrimAndGetArray());
        }

        private void DisplayItems(Item[] items)
        {
            //clear base test file
            currentInventoryListBox.Items.Clear();
            foreach (Item item in items)
            {
                currentInventoryListBox.Items.Add(item.ToString());
            }
        }

        private void restockItemButton_Click(object sender, EventArgs e)
        {
            if ((int)restockCounter.Value != 0)
            {
                invMan.RestockItem(currentInventoryListBox.SelectedItem.ToString(), (int)restockCounter.Value);
                MessageBox.Show("Restocked! Please hit View Item Details to update!");
            }
            else
            {
                MessageBox.Show("Please select a value to restock by below the Restock Button!");
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            invMan.RemoveItem(invMan.GetItem(currentInventoryListBox.SelectedItem.ToString()));
            DisplayItems(invMan.TrimAndGetArray());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Please input something to search");
            }
            else
            {
                Item[] results = invMan.SearchItems(searchTextBox.Text);
                DisplayItems(results);
            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            DisplayItems(invMan.TrimAndGetArray());
        }
    }
}