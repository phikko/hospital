using Hospital.Database.Models;

namespace Hospital.Auth
{
    public class Auth
    {
        private static User _user;

        public static User User
        {
            get => _user;
            set => _user = value;
        }
    }
}