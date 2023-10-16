using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am loading from a SQL database");
            List<Product> products = new List<Product>();
            products.Add(new Product());
            products.Add(new Product());
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }
    }
}
