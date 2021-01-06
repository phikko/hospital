namespace Hospital.Database
{
    public class BaseModel
    {
        protected SQLiteConnection _connection;

        public BaseModel() 
        {
            SQLiteConnectionString options = new SQLiteConnectionString("database.sqlite", false);

            _connection = new SQLiteConnection(options);
        }
        
        ~BaseModel() 
        {
            _connection.Close();
        }
    }
}