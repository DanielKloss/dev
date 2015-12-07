using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //OracleDatabaseConnection connection = new OracleDatabaseConnection();
            //connection.ConnectToDatabase("db.fdmgroup.com");

            //MicrosoftDatabaseConnection connection = new MicrosoftDatabaseConnection();
            //connection.ConnectToDatabase("db.fdmgroup.com");

            DatabaseConnection connection = new MicrosoftDatabaseConnection();
            connection.ConnectToDatabase("db.fdmgroup.com");

            Console.ReadLine();
        }
    }
}
