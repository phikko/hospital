using System;
using Hospital.Menu.Interfaces;

namespace Hospital.Menu.MenuItems
{
    public class UserCreateItem : IMenuItem
    {
        public string label => "Create new user";

        public void Handle()
        {
            Console.Clear();
            Console.WriteLine("Create user - menu handle");
        }
    }
}