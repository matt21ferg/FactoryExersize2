using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExersize2
{
    internal class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
            LoadData();
            SaveData();
        }
        public void LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Class");
            
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }
    }
}
