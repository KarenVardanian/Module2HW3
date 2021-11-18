using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
   public abstract class WithSugar:Product
    {
       public double _shugarPercent { set; get; }
        public WithSugar(string name, double weight, double shugarPercent) : base(name, weight)
        {
            _shugarPercent = shugarPercent;
        }

        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n";
        }
    }
 }
   
    
        

