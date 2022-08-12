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
        private Item[] _items;
        private int _size;

        public InventoryManager()
        {
            _items = new Item[8];
            _items[0] = new Item(149200, 289.99m, "Arndale Armchair", "Seating", 3);
            _items[1] = new Item(149201, 399.99m, "Arndale Loveseat", "Seating", 2);
            _items[2] = new Item(149202, 589.99m, "Arndale Sectional", "Seating", 1);
            _items[3] = new Item(678254, 149.99m, "Carol Heights Coffee Table", "Table", 3);
            _items[4] = new Item(7484, 1495.99m, "Samsung 28.2cu-ft French Door Refrigerator", "Appliance", 2);
            _items[5] = new Item(977448, 520.00m, "48\" Samsung Flatscreen TV", "Electronics", 0);
            _size = 6;
        }

        //Method to add item
        public void AddNewItem(Item item)
        {
            //check to make sure we can add item without index out of bounds
            EnsureCapacity();
            //add item at index equal to size
            _items[_size] = item;
            //increase size
            _size++;
            
        }


        //Method to remove item
        public bool RemoveItem(Item item)
        {
            int index = 0;
            foreach (Item i in _items)
            {
                if (i.ToString().Equals(item.ToString()))
                   break;
                index++;
            }
            //make sure if array is full to double array beforehand so no index out of bound
            EnsureCapacity();
            //loop through starting at index, moving all items down one index space
            for (int i = index; i < _size; i++)
            {
                _items[i] = _items[i + 1];
            }
            //lower size to match
            _size--;
            return true;
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
        public void RestockItem(string itemString, int qty)
        {
            Item item = GetItem(itemString);
            item.Quantity += qty;
        }

        //Method to search for items using SKU or Description
        public Item[] SearchItems(string val)
        {
            //Create new item[] equal to previous size for storage reasons
            Item[] searchResult = new Item[_size];
            //loop through each item
            int searchCount = 0;
            for (int i = 0; i < _size; i++)
            {
                //Check if SKU contains search string
                if (_items[i].SKU.ToString().Contains(val))
                {
                    searchResult[searchCount] = _items[i];
                    searchCount++;
                }
                //Check if Description contains search string
                else if (_items[i].Description.ToLower().Contains(val.ToLower()))
                {
                    searchResult[searchCount] = _items[i];
                    searchCount++;
                }
            }

            //After searching, trim array and return
            Item[] result = new Item[searchCount];
            for (int i = 0; i < searchCount; i++)
            {
                result[i] = searchResult[i];
            }

            return result;

        }

        //Method to trim array for displaying in listbox
        public Item[] TrimAndGetArray()
        {
            //create new array based on actual amount of items
            Item[] trim = new Item[_size];
            //loop through adding items to new array
            for (int i = 0; i < trim.Length; i++)
                trim[i] = _items[i];
            //return trimmed array
            return trim;
        }

        //Method to increase array size if necessary
        private void EnsureCapacity()
        {
            //Check if size value is equal to array length
            //If size is smaller than array, exit method
            if (_size < _items.Length)
                return;
            //create new Item[] twice as large
            Item[] newSize = new Item[2 * _items.Length];
            //copy old values into new array
            for (int i = 0; i < _items.Length; i++)
                newSize[i] = _items[i];
            //assign original item array to new array
            _items = newSize;
        }
    }
}
