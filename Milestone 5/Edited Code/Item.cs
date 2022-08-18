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
    public class Item
    {
        //Enum type for furniture types
        public enum furnitureType { Appliance, Bedding, Decor, Electronics, LightFixture, Seating, Table }

        //Fields for Item class
        private int _sku;
        private decimal _price;
        private string _description;
        private furnitureType _type;
        private Warranty[] _warranties;
        private int _quantity;

        public Item(int sku, decimal price, string desc, string type, int quantity)
        {
            this.SKU = sku;
            this.Price = price;
            this.Description = desc;
            this.Type = type;
            this.Warranties = new Warranty(this).Warranties;
            this.Quantity = quantity;
        }

        public Item(string warrantyDescription, decimal price)
        {
            this.SKU = 0;
            this.Description = warrantyDescription;
            this.Price = price;
        }

        //Getters and Setters for simple fields
        public int SKU { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Warranty[] Warranties { get; set; }
        public int Quantity { get; set; }

        //Specific getter and setter for furnitureType, translating from string input and to string output
        public string Type
        {
            get
            {
                return _type.ToString();
            }

            set
            {
                switch (value)
                {
                    case "Appliance": _type = furnitureType.Appliance; break;
                    case "Bedding": _type = furnitureType.Bedding; break;
                    case "Decor": _type = furnitureType.Decor; break;
                    case "Electronics": _type = furnitureType.Electronics; break;
                    case "LightFixture": _type = furnitureType.LightFixture; break;
                    case "Seating": _type = furnitureType.Seating; break;
                    case "Table": _type = furnitureType.Table; break;
                }
            }
        }

        //Specific Getter for Enumeration of furnitureType (used for Warranty Purpose)
        public furnitureType TypeEnum
        {
            get
            {
                return _type;
            }
        }

        public override string ToString()
        {
            return SKU + ": " + Description;
        }

    }
}
