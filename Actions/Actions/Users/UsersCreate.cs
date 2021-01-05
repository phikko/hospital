using System;
using System.Reflection.Metadata;
using Hospital.Actions.Classes;

namespace Hospital.Actions.Actions.Users
{
    public class UsersCreate : BaseAction
    {
        public override void Handle()
        {
            Console.Clear();
            Console.WriteLine("Users Create Action");
        }
    }
}