using System;
using Hospital.Actions.Actions.Users;
using Hospital.Menu.Interfaces;

namespace Hospital.Menu.MenuItems.Users
{
    public class UsersCreateItem : IMenuItem
    {
        public string label => "Create new user";

        public void Handle()
        {
            new UsersCreate().Handle();
        }
    }
}