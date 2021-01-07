using System;
using System.Collections.Generic;

namespace Hospital.Database.Models
{ 
    [Table("doctors")]
    public class Doctor
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
    }
    
    public class DoctorModel : BaseModel
    {
        public Doctor GetByUserId(int id)
        {
            return _connection.Table<Doctor>().Where(user => user.Id == id).First();
        }
        
        public Doctor CreateDoctor(Doctor doctor)
        {
            int id = _connection.Insert(doctor);
            return _connection.Table<Doctor>().Where(row => row.Id == id).First();
        }
    }
}