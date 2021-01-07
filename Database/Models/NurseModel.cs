using System;
using System.Collections.Generic;

namespace Hospital.Database.Models
{ 
    [Table("nurses")]
    public class Nurse
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
    }
    
    public class NurseModel : BaseModel
    {
        public Nurse GetByUserId(int id)
        {
            return _connection.Table<Nurse>().Where(user => user.Id == id).First();
        }
        
        public Nurse CreateNurse(Nurse nurse)
        {
            int id = _connection.Insert(nurse);
            return _connection.Table<Nurse>().Where(row => row.Id == id).First();;
        }
    }
}