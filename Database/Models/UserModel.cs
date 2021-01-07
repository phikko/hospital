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
        [Column("typable_id")]
        public int TypableId { get; set; }
        [Column("typable_type")]
        public string TypableType { get; set; }
    }
    
    public class UserModel : BaseModel
    {
        public List<User> GetAllUsers()
        {
            return _connection.Table<User>().ToList();
        }

        public User CreateUser(User user)
        {
            int id = _connection.Insert(user);
            return _connection.Table<User>().Where(row => row.Id == id).First();;
        }
        
        public User UpdateUser(User user)
        {
            int id = _connection.Update(user);
            return _connection.Table<User>().Where(row => row.Id == id).First();;
        }

        public User GetUserByUsername(string username)
        {
            return _connection.Table<User>().Where(user => user.Username == username).First();
        }
    }
}