using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    class Nuts_candy:Chocolate
    {
        public string _nutName { set; get; }
        public Nuts_candy(string name, double weight, double shugarPercent, string form, string chocolateType,string nutName)
            : base(name, weight, shugarPercent, form, chocolateType)
        {
            _nutName = nutName;
        }

        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n _chocolateType {_chocolateType} Nut {_nutName}";
        }
    }
}
