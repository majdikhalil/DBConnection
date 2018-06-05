using System;

namespace DBConnection
{
    public class SqlConnection : DbConnection
       
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql Opening Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("sql Closing Connection");
        }


    }
}
