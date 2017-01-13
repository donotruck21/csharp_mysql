using System;
using DbConnection;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DbConnector.ExecuteQuery("SELECT * from USERS");
        }
    }
}
