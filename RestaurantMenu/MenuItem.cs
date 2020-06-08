using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.IsNew = isNew;
        }

        public MenuItem(string name, double price, string description, string category)
            : this(name, price, description, category, false) { }

    }
}
