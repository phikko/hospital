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
            foreach (var admin in admins)
            {
                var table = new ConsoleTable("#", "Last name", "First name", "PESEL", "Username");
                var currentUser = users[admin.UserId];
                table.AddRow(currentUser.Id, currentUser.Lastname, currentUser.Firstname, currentUser.Pesel, currentUser.Username);
                table.Write(Format.Alternative);
            }
            
            Console.WriteLine("NURSES");
            foreach (var nurse in nurses)
            {
                var table = new ConsoleTable("#", "Last name", "First name", "PESEL", "Username");
                var currentUser = users[nurse.UserId];
                table.AddRow(currentUser.Id, currentUser.Lastname, currentUser.Firstname, currentUser.Pesel, currentUser.Username);
                table.Write(Format.Alternative);
            }
            
            Console.WriteLine("DOCTORS");
            foreach (var doctor in doctors)
            {
                var table = new ConsoleTable("#", "Last name", "First name", "PESEL", "Username", "Speciality", "PWZ");
                var currentUser = users[doctor.UserId];
                table.AddRow(currentUser.Id, currentUser.Lastname, currentUser.Firstname, currentUser.Pesel, currentUser.Username, doctor.Speciality, doctor.Pwz);
                table.Write(Format.Alternative);
            }
            
            // Console.WriteLine("If you want to edit a user type ID here (leave blank to exit): ");
            // int input = 0;
            // if (int.TryParse(Console.ReadLine(), out input))
            // {
            //     Console.WriteLine("User Edit action");
            // }
        }
    }
}