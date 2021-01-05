using System;
using System.Reflection.Metadata;
using Hospital.Actions.Classes;

namespace Hospital.Actions.Actions.Users
{
    public class UsersIndex : BaseAction
    {
        public override void Handle()
        {
            Console.Clear();
            Console.WriteLine("Users Index Action");
        }
    }
}