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

        List<Item> items = new List<Item>();

        public InventoryManagerScreen()
        {
            InitializeComponent();
            items.Add(new Item(149200, 289.99m, "Arndale Armchair", "Seating"));
            items.Add(new Item(149201, 399.99m, "Arndale Loveseat", "Seating"));
            items.Add(new Item(149202, 589.99m, "Arndale Sectional", "Seating"));
            items.Add(new Item(678254, 149.99m, "Carol Heights Coffee Table", "Table"));
            items.Add(new Item(7484, 1495.99m, "Samsung 28.2cu-ft French Door Refrigerator", "Appliance"));
            items.Add(new Item(977448, 520.00m, "48\" Samsung Flatscreen TV", "Electronics"));
            currentInventoryListBox.Items.Clear();
            foreach (Item item in items)
            {
                currentInventoryListBox.Items.Add(item.ToString());
            }
        }

        private void itemDetailButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                string selected = currentInventoryListBox.SelectedItem.ToString();
                foreach (Item item in items)
                {
              
                    if (selected.CompareTo(item.ToString()) == 0)
                    {
                        skuTextBox.Text = item.SKU.ToString();
                        basePriceTextbox.Text = item.Price.ToString("c");
                        descriptionTextbox.Text = item.Description;
                        furnitureTypeTextbox.Text = item.Type;
                        warrantyListBox.Items.Clear();
                        foreach (Warranty warranty in item.Warranties) 
                        { 
                            warrantyListBox.Items.Add(warranty.ToString());
                        }
                        break;
                    }

                }
            } catch 
            {
                MessageBox.Show("Please select an item to view details");
            }
        }
    }
}