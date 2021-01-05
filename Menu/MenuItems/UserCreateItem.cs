using System;
using Hospital.Actions.Actions.Users;
using Hospital.Menu.Interfaces;

namespace Hospital.Menu.MenuItems
{
    public class UserCreateItem : IMenuItem
    {
        public string label => "Create new user";

        public void Handle()
        {
            new UsersCreate().Handle();
        }
    }
}