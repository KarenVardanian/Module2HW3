using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public class NutsСandy:Chocolate
    {
        public string _nutName { set; get; }
        public NutsСandy(string name, double weight, double shugarPercent, string form, string chocolateType,string nutName)
            : base(name, weight, shugarPercent, form, chocolateType)
        {
            _nutName = nutName;
        }

        
    }
}
