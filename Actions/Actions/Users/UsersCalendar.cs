using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;
using Hospital.Actions.Classes;
using Hospital.Database.Models;

namespace Hospital.Actions.Actions.Users
{
    public class UsersCalendar
    {
        public void Handle(int id)
        {
            Console.Clear();
            User user = new UserModel().GetUserById(id);
            List<Calendar> days = new CalendarModel().GetByUserId(id);
            Console.WriteLine("Showing Calendar of: {0} {1}", user.Firstname, user.Lastname );
            var table = new ConsoleTable("Date");
            foreach (var day in days)
            {
                table.AddRow(day.Day);
            }
            table.Write(Format.Alternative);
        }
    }
}