using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<MenuItem> CurrentMenuItems { get; set; } //= new List<MenuItem>();
        public static DateTime lastUpdated = new DateTime(2020, 6, 5);

        public Menu(List<MenuItem> currentMenuItems)
        {
            this.CurrentMenuItems = currentMenuItems;
        }

        public void UpdateMenu(MenuItem item, string action)
        {
            if (action == "add")
            {
                item.IsNew = true;
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
            Console.WriteLine("Welcome to Elefante!\n*****\n");
            string userChoice = "";
            int counter = 0;

            while (userChoice != "3")
            {
                string formattedMenu = "";
                Console.WriteLine("1 - View a sample menu item\n2 - View the whole menu\n3 - Quit");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("********************");
                    Random rand = new Random();
                    int menuIndex = rand.Next(CurrentMenuItems.Count);
                    MenuItem item = CurrentMenuItems[menuIndex];
                    formattedMenu += $"{item.Name} -- ${item.Price}\n" +
                        $"Category: {item.Category}\n" +
                        $"{item.Description}\n*****\n";
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("********************");
                    foreach (MenuItem item in CurrentMenuItems)
                    {
                        counter++;
                        if (item.IsNew)
                        {
                            formattedMenu += "NEW ITEM!\n";
                        }
                        formattedMenu += $"{counter}.) {item.Name} -- ${item.Price}\n" +
                            $"Category: {item.Category}\n" +
                            $"{item.Description}\n*****\n";
                    }
                }
                Console.WriteLine(formattedMenu);
            }
            return "";
        }
    }
}
