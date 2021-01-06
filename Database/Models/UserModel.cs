using System;
using System.Collections.Generic;

namespace Hospital.Database.Models
{
    [Table("users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Pesel { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
    public class UserModel : BaseModel
    {
        public List<User> GetAllUsers()
        {
            return _connection.Table<User>().ToList();
        }

        public User CreateUser(User user)
        {
            _connection.Insert(user);
            Console.Write("tyes");
            return user;
        }

        public User GetUserByUsername(string username)
        {
            return _connection.Table<User>().Where(user => user.Username == username).First();
        }
    }
}