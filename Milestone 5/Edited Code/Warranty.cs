/*
 * 
 * Code created and designed by Chance Anderson,
 * for the express purpose of completing assignment
 * for CST-150 class at Grand Canyon University.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_for_Inventory_Management
{
    public class Warranty
    {
        //fields for warranties
        //Top level Warranty item will never have years, price or type, just warranty[]
        private int _years;
        private decimal _price;
        private string _type;
        private Warranty[] _warranties;

        //Constructor based on item type
        public Warranty(Item item)
        {
            string desc;
            int years;
            decimal price;
            Warranty[] warranties = new Warranty[2];
            //Switch statement for different warranties for different furniture types
           
            switch(item.TypeEnum)
            {
                case Item.furnitureType.Appliance:
                    desc = "Appliance Warranty";
                    years = 3;
                    price = 97.95m;
                    warranties[0] = new Warranty(years, price, desc);
                    years = 5;
                    price = 199.95m;
                    warranties[1] = new Warranty(years, price, desc);
                    this.Warranties = warranties;
                    break;
                case Item.furnitureType.Electronics:
                    desc = "Electronic Warranty";
                    years = 2;
                    price = 79.99m;
                    warranties[0] = new Warranty(years, price, desc);
                    years = 4;
                    price = 164.99m;
                    warranties[1] = new Warranty(years, price, desc);
                    this.Warranties = warranties;
                    break;
                default:
                    desc = "General Warranty";
                    years = 1;
                    price = 29.99m;
                    warranties[0] = new Warranty(years, price, desc);
                    years = 2;
                    price = 49.99m;
                    warranties[1] = new Warranty(years, price, desc);
                    this.Warranties = warranties;
                    break;
            }
        }

        //private constructor to fill Warranty array
        private Warranty(int years, decimal price, string type)
        {
            _years = years;
            _price = price;
            _type = type;
        }

        //Getters/Setters
        public decimal Price { get { return _price; } }

        public Warranty[] Warranties { get; set; }

        //ToString override for displaying Warranty
        public override string ToString()
        {
            return _years + "YR " + _type;
        }
    }
}
