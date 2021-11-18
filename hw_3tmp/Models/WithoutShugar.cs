using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    public abstract class WithoutShugar: Product
    {
        public double _fructosePercent { set; get; }
        public WithoutShugar(string name,double weight,double fructosePercent) : base(name, weight)
        {
            _fructosePercent = fructosePercent;
        }
        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n _fructosePercent {_fructosePercent}\n";
        }
    }
}
