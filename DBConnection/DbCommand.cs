using System;

namespace DBConnection
{
    public class DbCommand
    {
        private readonly DbConnection _connenction;
        private readonly string _dbInstructions;

        public DbCommand(DbConnection connection , string dbInstructions)
        {
            if (string.IsNullOrWhiteSpace(dbInstructions))
            {
                _dbInstructions = dbInstructions;

            }
            _connenction = connection;
           
        }

        public void Excute()
        {
            _connenction.OpenConnection();
            Console.WriteLine("Excuting Instructions: " + _dbInstructions);
            _connenction.CloseConnection();
        }
    }
}
