using System;
using System.Collections.Generic;
using System.Linq;
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
            Dictionary<int, Admin> admins = new AdminModel().GetAllAdmins().ToDictionary(admin => admin.Id);
            Dictionary<int, Nurse> nurses = new NurseModel().GetAllNurses().ToDictionary(nurse => nurse.Id);
            Dictionary<int, Doctor> doctors = new DoctorModel().GetAllDoctors().ToDictionary(doctor => doctor.Id);
            foreach (var user in users)
            {
                switch (user.TypableType)
                {
                    case "admin":
                        Console.WriteLine(admins[user.TypableId].UserId);
                        break;
                    case "nurse":
                        Console.WriteLine(nurses[user.TypableId].UserId);
                        break;
                    case "doctor":
                        Console.WriteLine(doctors[user.TypableId].UserId);
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
        }
    }
}