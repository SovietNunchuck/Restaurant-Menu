using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string category, bool isNew)
        {
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.IsNew = isNew;
        }

    }
}
