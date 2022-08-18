using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_for_Inventory_Management
{
    public class InventoryManager
    {

        //Fields for InventoryManager class
        private List<Item> _items;

        public InventoryManager()
        {
            _items = new List<Item>();
            _items.Add( new Item(149200, 289.99m, "Arndale Armchair", "Seating", 3));
            _items.Add( new Item(149201, 399.99m, "Arndale Loveseat", "Seating", 2));
            _items.Add( new Item(149202, 589.99m, "Arndale Sectional", "Seating", 1));
            _items.Add( new Item(678254, 149.99m, "Carol Heights Coffee Table", "Table", 3));
            _items.Add( new Item(7484, 1495.99m, "Samsung 28.2cu-ft French Door Refrigerator", "Appliance", 2));
            _items.Add( new Item(977448, 520.00m, "48\" Samsung Flatscreen TV", "Electronics", 0));
            
        }

        //Method to add item
        public void AddNewItem(Item item)
        {
            _items.Add(item);
        }


        //Method to remove item
        public bool RemoveItem(Item item)
        {
            return _items.Remove(item);
        }
        
        //Method to return item (for detail display)
        public Item GetItem(string itemString)
        {
            foreach (Item item in _items)
            {
                if (item.ToString().Equals(itemString))
                {
                    return item;
                }
            }
            return null;
        }


        //Method to increase quantity of item
        public void RestockItem(Item item, int qty)
        {
            item.Quantity += qty;
        }

        //Method to search for items using SKU or Description
        public List<Item> SearchItems(string val)
        {
            //Create new list to return
            List<Item> searchResult = new List<Item>();
            foreach (Item item in _items)
            {
                //Check if SKU contains search string
                if (item.SKU.ToString().Contains(val))
                {
                    searchResult.Add(item);
                }
                //Check if Description contains search string
                else if (item.Description.ToLower().Contains(val.ToLower()))
                {
                    searchResult.Add(item);
                }
            }
            
            return searchResult;

        }

        //Method to trim array for displaying in listbox
        public List<Item> GetList()
        {
            return _items;
        }
    }
}
