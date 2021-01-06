using System;
using Hospital.Actions.Classes;
using Hospital.Database.Models;

namespace Hospital.Actions.Actions.Users
{
    public class UsersCreate : BaseAction
    {
        public override void Handle()
        {
            Console.Clear();
            Console.WriteLine("CREATE NEW USER");
            User user = new User();
            
            Console.Write("First name: ");
            user.Firstname = Console.ReadLine();
            Console.Write("Last name: ");
            user.Lastname = Console.ReadLine();
            Console.Write("PESEL: ");
            user.Pesel = Console.ReadLine();
            Console.Write("Username: ");
            user.Username = Console.ReadLine();
            Console.Write("Password: ");
            user.Password = Console.ReadLine();

            try
            {
                new UserModel().CreateUser(user);
                Console.Clear();
                Console.WriteLine("New user has been added to the database.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops! Something went wrong while creating a user!");
            }
        }
    }
}