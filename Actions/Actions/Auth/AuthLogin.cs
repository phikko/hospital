using System;
using Hospital.Actions.Classes;
using Hospital.Database.Models;

namespace Hospital.Actions.Actions.Auth
{
    public class AuthLogin : BaseAction
    {
        public override void Handle()
        {
            bool loggedIn = false;
            while (!loggedIn)
            {
                Console.WriteLine("LOGIN PAGE");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                try
                {
                    User user = new UserModel().GetUserByUsername(username);
                    if (user.Password == password)
                    {
                        Hospital.Auth.Auth.User = user;
                        loggedIn = true;
                    }
                    else
                    {
                        throw new Exception("Wrong credentials!");
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong credentials!");
                }
            }
        }
    }
}