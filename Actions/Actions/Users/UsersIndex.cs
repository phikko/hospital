using System;
using System.Collections.Generic;
using Hospital.Actions.Classes;
using Hospital.Database.Models;

namespace Hospital.Actions.Actions.Users
{
    public class UsersIndex : BaseAction
    {
        public override void Handle()
        {
            Console.Clear();
            Console.WriteLine("LISTING ALL USERS");
            List<User> users = new UserModel().GetAllUsers();
            foreach (var user in users)
            {
                Console.WriteLine("#{0} | {1} {2} | {3} | {4}", user.Id, user.Firstname, user.Lastname, user.Pesel, user.Username);
            }
        }
    }
}