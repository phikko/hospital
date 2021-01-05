using System;
using Hospital.Menu.Interfaces;
using Hospital.Menu.Menus;

namespace Hospital.Menu.MenuItems
{
    public class GoBackItem : IMenuItem
    {
        public string label => "Go back to main menu";

        public void Handle()
        {
            Console.Clear();
            new MainMenu().Render();
        }
    }
}