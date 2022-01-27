using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExersize2
{
    internal class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
            LoadData();
            SaveData();
        }
        public List<Product> LoadData()
        {
            Console.WriteLine("i am reading this from a list database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("i am saving data to a list database");
        }
    }
}
