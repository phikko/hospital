using System;
using System.Collections.Generic;

namespace Hospital.Database.Models
{ 
    [Table("admins")]
    public class Admin
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
    }
    
    public class AdminModel : BaseModel
    {
        public List<Admin> GetAllAdmins()
        {
            return _connection.Table<Admin>().ToList();
        }
        public Admin GetByUserId(int id)
        {
            return _connection.Table<Admin>().Where(user => user.Id == id).First();
        }
        
        public Admin CreateAdmin(Admin admin)
        {
            int id = _connection.Insert(admin);
            return _connection.Table<Admin>().Where(row => row.Id == id).First();
        }
    }
}