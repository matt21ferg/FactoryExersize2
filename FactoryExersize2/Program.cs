using System;

namespace FactoryExersize2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what database they want to use: a List, SQL, or Mongo");
            var databaseType = Console.ReadLine();
            DataAccessFactory.GetDataAccessType(databaseType);
            
            
           

        }
    }
}
