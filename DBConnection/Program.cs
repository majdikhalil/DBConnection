using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                var dbCommand = new DbCommand(new SqlConnection("TestConnection") , "Testing sql connection");
                dbCommand.Excute();
                var dbCommand2 = new DbCommand(new OracleConnection(""), "Testing oracle connection");
                dbCommand2.Excute();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured : " + ex.Message);
            }
           
        }
    }
}
