using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public class lollipops:Candy
    {
        public string _color { set; get; }
        public lollipops(string name, double weight, double shugarPercent, string form,string color)
             : base(name, weight, shugarPercent,form)
        {
            _color = color;
        }

        
    }
}
