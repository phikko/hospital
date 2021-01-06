using System;
using Hospital.Actions.Actions.Auth;
using Hospital.Menu.Menus;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            new AuthLogin().Handle();
            while (true)
            {
                new MainMenu().Render();   
            }
        }
    }
}