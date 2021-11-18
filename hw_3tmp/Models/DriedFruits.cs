using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    class DriedFruits : WithoutShugar
    {
        public string _fruitName { set; get; }
        public DriedFruits(string name, double weight, double shugarPercent,string fruitName):
            base(name, weight, shugarPercent)
        {
            _fruitName = fruitName;
        }
        public override string ToString()
        {
          return $"Name {_name}\n Wright {_weight}\n _fructosePercent {_fructosePercent}\n _fruitName {_fruitName}"; 
        }
    }
}
