using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    public abstract class Chocolate : Candy
    {
        public string _chocolateType { get; set; }
        public Chocolate(string name, double weight, double shugarPercent, string form,string chocolateType)
             : base(name, weight, shugarPercent,form)
        {
            _chocolateType = chocolateType;
        }

        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n _chocolateType {_chocolateType}";
        }
    }
}
