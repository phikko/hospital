using System;
using Hospital.Actions.Actions.Users;
using Hospital.Menu.Interfaces;

namespace Hospital.Menu.MenuItems.Users
{
    public class UsersIndexItem : IMenuItem
    {
        public string label => "Show all users";

        public void Handle()
        {
            new UsersIndex().Handle();
        }
    }
}