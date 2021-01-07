using System;
using Hospital.Actions.Classes;
using Hospital.Database;
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

            Console.Write("USER TYPE");
            Console.Write("1. Admin");
            Console.Write("2. Nurse");
            Console.Write("3. Doctor");
            int input = 0;
            User userFromDb = null;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Wrong Input!");
            }
            switch (input)
            {
                case 1:
                    userFromDb = new UserModel().CreateUser(user);
                    new AdminModel().CreateAdmin(new Admin {Id = userFromDb.Id});
                    break;
                case 2:
                    userFromDb = new UserModel().CreateUser(user);
                    new NurseModel().CreateNurse(new Nurse {Id = userFromDb.Id});
                    break;
                case 3:
                    Doctor doctor = new Doctor();
                    Console.Write("Speciality: ");
                    doctor.Speciality = Console.ReadLine();
                    Console.Write("PWZ: ");
                    doctor.Pwz = Console.ReadLine();
                    userFromDb = new UserModel().CreateUser(user);
                    doctor.UserId = userFromDb.Id;
                    new DoctorModel().CreateDoctor(doctor);
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    break;
            }
            Console.WriteLine("User succesfully added!");
        }
    }
}