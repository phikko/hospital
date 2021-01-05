using System;
using Hospital.Menu.Interfaces;
using Hospital.Menu.Menus;

namespace Hospital.Menu.MenuItems
{
    public class UsersItem : IMenuItem
    {
        public string label => "Users";

        public void Handle()
        {
            new UsersMenu().Render();
        }
    }
}