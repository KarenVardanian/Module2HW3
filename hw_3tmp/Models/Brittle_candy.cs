using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    class Brittle_candy:Chocolate
    {
        public string _btittleType { get; set; }
        public Brittle_candy(string name, double weight, double shugarPercent, string form, string chocolateType,string btittleType)
            :base(name, weight, shugarPercent,form,chocolateType)
        {
            _btittleType = btittleType;
        }

        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n _chocolateType {_chocolateType}\n btittleType {_btittleType}";
        }
    }
}
