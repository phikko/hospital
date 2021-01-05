using System.Collections.Generic;
using Hospital.Menu.Classes;
using Hospital.Menu.Interfaces;
using Hospital.Menu.MenuItems;

namespace Hospital.Menu.Menus
{
    public class MainMenu : BaseMenu
    {
        public override List<IMenuItem> items => new List<IMenuItem>()
        {
            new UsersItem()
        };
    }
}