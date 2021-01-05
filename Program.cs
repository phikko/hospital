using System;
using Hospital.Menu.Menus;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                new MainMenu().Render();   
            }
        }
    }
}