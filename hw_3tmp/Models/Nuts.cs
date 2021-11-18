using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    class Nuts : WithSugar
    {
       public string _nutName { set; get; }
       public Nuts(string name, double weight, double shugarPercent,string Nutname)
            : base(name, weight, shugarPercent)
        {
            _nutName = Nutname;
        }
    }
}
