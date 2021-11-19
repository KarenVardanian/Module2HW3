using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
   public class Nuts : WithoutShugar
    {
       public bool _isFried { set; get; }
       public Nuts(string name, double weight, double shugarPercent,bool isFried)
            : base(name, weight, shugarPercent)
        {
            _isFried = isFried;
        }
    }
}
