using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> ElefanteItems = new List<MenuItem>();
            ElefanteItems.Add(new MenuItem("Spaghetti", 11.99, "Simply delicious.", "Main Course", true));

            Menu ElefanteMenu = new Menu(ElefanteItems);

            Console.WriteLine(ElefanteMenu.ToString());
        }
    }
}
