using System;

namespace DBConnection
{
    public class OracleConnection : DbConnection

    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {

        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection Open");
        }
    }
}
