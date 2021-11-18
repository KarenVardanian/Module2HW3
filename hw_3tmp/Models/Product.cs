using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
   public abstract class Product:ISerachByName
    {
        public string _name { get; set; }
        public double _weight { set; get; }
        public Product(string name,double weight)
        {
            _name = name;
            _weight = weight;
        }

        public void searchByName(string name)
        {
            if (_name == name)
            {
                Console.WriteLine($"Product with {name} found");
            }
        }

        
        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n";
        }
    }
}
