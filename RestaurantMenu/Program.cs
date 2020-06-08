using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem MozzarellaSticks = new MenuItem("Mozzarella Sticks", 7.99, "The best dang appetizer in the world.", "Appetizer");
            MenuItem Spaghetti = new MenuItem("Spaghetti", 11.99, "Simply delicious.", "Main Course");
            MenuItem Pizza = new MenuItem("Pizza", 14.99, "It's a good a pizza.", "Main Course");

            List<MenuItem> ElefanteItems = new List<MenuItem> { MozzarellaSticks, Spaghetti, Pizza };

            Menu ElefanteMenu = new Menu(ElefanteItems);

            //TESTING CREATION OF THE MENU
            //Console.WriteLine(ElefanteMenu.ToString());

            //LINES 22-24 TESTING ADD MENU ITEM FEATURE
            MenuItem PresidenteMargarita = new MenuItem("Presidente Margarita", 9.99, "Take a load off.", "Drink");
            ElefanteMenu.UpdateMenu(PresidenteMargarita, "add");
            //Console.WriteLine(ElefanteMenu.ToString());

            //UNCOMMMENT THE NEXT TWO LINES TO REMOVE AN ITEM FROM THE MENU USING THE SAME METHOD
            //ElefanteMenu.UpdateMenu(Pizza, "remove");
            Console.WriteLine(ElefanteMenu.ToString());


        }
    }
}
