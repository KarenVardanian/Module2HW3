using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
   public abstract class BuisquitProduct:Buisquit
    {
         public string _filer { get; set; }
       public BuisquitProduct(string name, double weight, double shugarPercent, string flourType,string filler)
            : base(name, weight, shugarPercent, flourType)
        {
            _filer = filler;
        }

        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n _flourType{_flourType} _filer{_filer} ";
        }
    }
}
