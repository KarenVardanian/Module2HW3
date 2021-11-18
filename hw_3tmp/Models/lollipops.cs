using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    class lollipops:Candy
    {
        public string _color { set; get; }
        public lollipops(string name, double weight, double shugarPercent, string form,string color)
             : base(name, weight, shugarPercent,form)
        {
            _color = color;
        }

        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n color {_color}";
        }
    }
}
