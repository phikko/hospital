using System;
using System.Collections.Generic;
using Hospital.Menu.Interfaces;
using Hospital.Menu.MenuItems;

namespace Hospital.Menu.Classes
{
    public class BaseMenu : IMenu
    {
        public virtual List<IMenuItem> items => new List<IMenuItem>() { };

        public void Render()
        {
            Console.Clear();
            bool isFirstItemBackItem = false;
            int index = 1;
            if (items.Count > 0 && items[0].GetType().Name == "GoBackItem")
            {
                isFirstItemBackItem = true;
                index = 0;
            }
            foreach (IMenuItem item in items)
            {
                Console.WriteLine("{0}. {1}", index, item.label);
                index++;
            }
            Console.Write("Choose option: ");
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Wrong option!");
            }
            try
            {
                items[isFirstItemBackItem ? input : input - 1].Handle();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Wrong option!");
            }

            if (isFirstItemBackItem)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();   
            }
        }
    }
}