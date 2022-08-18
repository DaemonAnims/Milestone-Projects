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
        List<Item> cart;

        public InventoryManagerScreen()
        {
            InitializeComponent();
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
                UpdateItemQty(item);
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

        private void UpdateItemQty(Item item)
        {
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
            DisplayItems(invMan.GetList());
        }

        private void DisplayItems(List<Item> items)
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
                Item item = invMan.GetItem(currentInventoryListBox.SelectedItem.ToString());
                invMan.RestockItem(item, (int)restockCounter.Value);
                UpdateItemQty(item);
            }
            else
            {
                MessageBox.Show("Please select a value to restock by below the Restock Button!");
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            invMan.RemoveItem(invMan.GetItem(currentInventoryListBox.SelectedItem.ToString()));
            DisplayItems(invMan.GetList());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Please input something to search");
            }
            else
            {
                List<Item> results = invMan.SearchItems(searchTextBox.Text);
                DisplayItems(results);
            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            DisplayItems(invMan.GetList());
        }

        private void InventoryManagerScreen_Load(object sender, EventArgs e)
        {
            //intitialize inventory manager
            invMan = new InventoryManager();
            //Display Items
            DisplayItems(invMan.GetList());
            cart = new List<Item>();
        }

        private void addCartButton_Click(object sender, EventArgs e)
        {
            Item item = invMan.GetItem(currentInventoryListBox.SelectedItem.ToString());
            if (item.Quantity == 0)
            {
                MessageBox.Show("Apologies, there is no more of this item available.");
            }
            else
            {
                cart.Add(item);
                if (warrantyListBox.SelectedIndex != -1)
                {
                    Warranty[] warranties = item.Warranties;
                    int index = warrantyListBox.SelectedIndex;
                    Item warrantyItem = new Item(warrantyListBox.SelectedItem.ToString(), warranties[index].Price);
                    cart.Add(warrantyItem);
                }
                item.Quantity -= 1;
                UpdateItemQty(item);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //Create new form 
            CheckoutCart cartForm = new CheckoutCart();
            //get exact amount of items in cart
            int itemAmount = cart.Count;
            //check to make sure amount of items in cart is less than 8 due to size constraints
            if (itemAmount <= 8)
            {
                //loop through all items, only going up to proper amount that is in cart
                for (int i = 0; i < itemAmount; i++)
                {
                    //do if statements to properly place labels
                    if (i == 0)
                    {
                        cartForm.item1Label.Text = cart[i].ToString();
                        cartForm.price1Label.Text = cart[i].Price.ToString("c");
                    }
                    if (i == 1)
                    {
                        cartForm.item2Label.Text = cart[i].ToString();
                        cartForm.price2Label.Text = cart[i].Price.ToString("c");
                    }
                    if (i == 2)
                    {
                        cartForm.item3Label.Text = cart[i].ToString();
                        cartForm.price3Label.Text = cart[i].Price.ToString("c");
                    }
                    if (i == 3)
                    {
                        cartForm.item4Label.Text = cart[i].ToString();
                        cartForm.price4Label.Text = cart[i].Price.ToString("c");
                    }
                    if (i == 4)
                    {
                        cartForm.item5Label.Text = cart[i].ToString();
                        cartForm.price5Label.Text = cart[i].Price.ToString("c");
                    }
                    if (i == 5)
                    {
                        cartForm.item6Label.Text = cart[i].ToString();
                        cartForm.price6Label.Text = cart[i].Price.ToString("c");
                    }
                    if (i == 6)
                    {
                        cartForm.item7Label.Text = cart[i].ToString();
                        cartForm.price7Label.Text = cart[i].Price.ToString("c");
                    }
                    if (i == 7)
                    {
                        cartForm.item8Label.Text = cart[i].ToString();
                        cartForm.price8Label.Text = cart[i].Price.ToString("c");
                    }
                }

                //Add prices up for subtotal
                decimal subtotal = 0.0m;
                foreach (Item item in cart)
                   subtotal += item.Price;
                cartForm.subtotalPriceLabel.Text = subtotal.ToString("c");

                //determine tax
                decimal tax = subtotal * 0.065m;
                cartForm.taxPriceLabel.Text = tax.ToString("c");

                //get full total
                decimal total = subtotal + tax;
                cartForm.totalPriceLabel.Text = total.ToString("c");

                cartForm.ShowDialog();
                cart.Clear();
                
            }
        }
    }
}