using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> CurrentMenuItems { get; set; } //= new List<MenuItem>();
        private static DateTime lastUpdated = new DateTime(2020, 6, 5);

        public Menu(List<MenuItem> currentMenuItems)
        {
            this.CurrentMenuItems = currentMenuItems;
        }

        public void UpdateMenu(MenuItem item, string action)
        {
            if (action == "add")
            {
                CurrentMenuItems.Add(item);
            }
            else if (action == "remove")
            {
                CurrentMenuItems.Remove(item);
            }
            lastUpdated = DateTime.Today;
        }

        public override string ToString()
        {
            string formattedMenu = "";
            int counter = 0;
            foreach (MenuItem item in CurrentMenuItems)
            {
                counter++;
                if (item.IsNew)
                {
                    formattedMenu += "NEW ITEM!\n";
                }
                formattedMenu += $"{counter}.) {item.Name} -- ${item.Price}\n" +
                    $"Category: {item.Category}\n" +
                    $"{item.Description}\n";
            }
            return formattedMenu;
        }
    }
}
