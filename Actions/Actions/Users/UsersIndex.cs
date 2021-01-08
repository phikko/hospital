using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;
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
            Dictionary<int, User> users = new UserModel().GetAllUsers().ToDictionary(user => user.Id);
            List<Admin> admins = new AdminModel().GetAllAdmins().ToList();
            List<Nurse> nurses = new NurseModel().GetAllNurses().ToList();
            List<Doctor> doctors = new DoctorModel().GetAllDoctors().ToList();
            
            Console.WriteLine("ADMINS");
            var tableAdmin = new ConsoleTable("#", "Last name", "First name", "PESEL", "Username");
            foreach (var admin in admins)
            {
                var currentUser = users[admin.UserId];
                tableAdmin.AddRow(currentUser.Id, currentUser.Lastname, currentUser.Firstname, currentUser.Pesel, currentUser.Username);
            }
            tableAdmin.Write(Format.Alternative);
            
            var tableNurse = new ConsoleTable("#", "Last name", "First name", "PESEL", "Username");
            Console.WriteLine("NURSES");
            foreach (var nurse in nurses)
            {
                var currentUser = users[nurse.UserId];
                tableNurse.AddRow(currentUser.Id, currentUser.Lastname, currentUser.Firstname, currentUser.Pesel, currentUser.Username);
            }
            tableNurse.Write(Format.Alternative);
            
            Console.WriteLine("DOCTORS");
            var tableDoctor = new ConsoleTable("#", "Last name", "First name", "PESEL", "Username", "Speciality", "PWZ");
            foreach (var doctor in doctors)
            {
                var currentUser = users[doctor.UserId];
                tableDoctor.AddRow(currentUser.Id, currentUser.Lastname, currentUser.Firstname, currentUser.Pesel, currentUser.Username, doctor.Speciality, doctor.Pwz);
            }
            tableDoctor.Write(Format.Alternative);
            
            Console.WriteLine("If you want to see user's calendar type ID here (leave blank to exit): ");
            int input = 0;
            if (int.TryParse(Console.ReadLine(), out input) && input > 0)
            {
                new UsersCalendar().Handle(input);
            }
        }
    }
}