using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public abstract class Chocolate : Candy
    {
        public string _chocolateType { get; set; }
        public Chocolate(string name, double weight, double shugarPercent, string form,string chocolateType)
             : base(name, weight, shugarPercent,form)
        {
            _chocolateType = chocolateType;
        }

       
    }
}
