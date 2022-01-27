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
        public void LoadData()
        {
            Console.WriteLine("I am reading this from SQL database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
