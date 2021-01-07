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

            Console.WriteLine("USER TYPE");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Nurse");
            Console.WriteLine("3. Doctor");
            int input = 0;
            User userFromDb = null;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Wrong Input!");
            }
            switch (input)
            {
                case 1:
                    user.TypableType = "admin";
                    userFromDb = new UserModel().CreateUser(user);
                    Admin adminFromDb = new AdminModel().CreateAdmin(new Admin {Id = userFromDb.Id});
                    userFromDb.TypableId = adminFromDb.Id;
                    new UserModel().UpdateUser(userFromDb);
                    break;
                case 2:
                    user.TypableType = "Nurse";
                    userFromDb = new UserModel().CreateUser(user);
                    Nurse nurseFromDb = new NurseModel().CreateNurse(new Nurse {Id = userFromDb.Id});
                    userFromDb.TypableId = nurseFromDb.Id;
                    new UserModel().UpdateUser(userFromDb);
                    break;
                case 3:
                    user.TypableType = "doctor";
                    Doctor doctor = new Doctor();
                    Console.Write("Speciality: ");
                    doctor.Speciality = Console.ReadLine();
                    Console.Write("PWZ: ");
                    doctor.Pwz = Console.ReadLine();
                    userFromDb = new UserModel().CreateUser(user);
                    doctor.UserId = userFromDb.Id;
                    Doctor doctorFromDb = new DoctorModel().CreateDoctor(doctor);
                    userFromDb.TypableId = doctorFromDb.Id;
                    new UserModel().UpdateUser(userFromDb);
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    break;
            }
            Console.WriteLine("User succesfully added!");
        }
    }
}