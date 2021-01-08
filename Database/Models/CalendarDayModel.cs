using System;
using System.Collections.Generic;

namespace Hospital.Database.Models
{ 
    [Table("calendar")]
    public class Calendar
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Day { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
    }
    
    public class CalendarModel : BaseModel
    {
        public List<Calendar> GetAllCalendars()
        {
            return _connection.Table<Calendar>().ToList();
        }
        public List<Calendar> GetByUserId(int id)
        {
            return _connection.Table<Calendar>().Where(calendar => calendar.UserId == id).ToList();
        }
    }
}