using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExersize2
{
    internal class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
            LoadData();
            SaveData();
        }
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading this from SQL database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
