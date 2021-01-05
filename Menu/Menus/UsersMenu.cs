using System.Collections.Generic;
using System.Data.SqlTypes;
using Hospital.Menu.Classes;
using Hospital.Menu.Interfaces;
using Hospital.Menu.MenuItems;
using Hospital.Menu.MenuItems.Users;

namespace Hospital.Menu.Menus
{
    public class UsersMenu : BaseMenu
    {
        public override List<IMenuItem> items => new List<IMenuItem>()
        {
            new GoBackItem(),
            new UsersIndexItem(),
            new UsersCreateItem()
        };
    }
}