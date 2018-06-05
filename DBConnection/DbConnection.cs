using System;

namespace DBConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace (connectionString))
            {
                _connectionString = connectionString;
            }
          

            else
            {
                throw new InvalidOperationException("Connection string can't be empty");


            }
        }

        public TimeSpan Timeout { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();



  
    }
}
