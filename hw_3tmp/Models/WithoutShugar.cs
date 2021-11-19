using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public abstract class WithoutShugar: Product
    {
        public double _fructosePercent { set; get; }
        public WithoutShugar(string name,double weight,double fructosePercent) : base(name, weight)
        {
            _fructosePercent = fructosePercent;
        }
     
    }
}
