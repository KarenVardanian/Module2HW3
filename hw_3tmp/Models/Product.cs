using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
   public abstract class Product
    {
        public string _name { get; set; }
        public double _weight { set; get; }
        public Product(string name,double weight)
        {
            _name = name;
            _weight = weight;
        }

       
    }
}
