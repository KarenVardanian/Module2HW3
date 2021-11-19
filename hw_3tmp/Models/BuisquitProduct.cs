using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
   public abstract class BuisquitProduct:Buisquit
    {
         public string _filer { get; set; }
       public BuisquitProduct(string name, double weight, double shugarPercent, string flourType,string filler)
            : base(name, weight, shugarPercent, flourType)
        {
            _filer = filler;
        }

        
    }
}
