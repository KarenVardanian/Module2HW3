using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public class Brittle_candy:Chocolate
    {
        public string _btittleType { get; set; }
        public Brittle_candy(string name, double weight, double shugarPercent, string form, string chocolateType,string btittleType)
            :base(name, weight, shugarPercent,form,chocolateType)
        {
            _btittleType = btittleType;
        }

        
    }
}
