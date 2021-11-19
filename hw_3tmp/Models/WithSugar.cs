using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
   public abstract class WithSugar:Product
    {
       public double _shugarPercent { set; get; }
        public WithSugar(string name, double weight, double shugarPercent) : base(name, weight)
        {
            _shugarPercent = shugarPercent;
        }

      
    }
 }
   
    
        

