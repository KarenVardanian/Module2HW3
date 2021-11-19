using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public abstract class Buisquit:WithSugar
    {
       public string _flourType { get; set; }
       public Buisquit(string name, double weight, double shugarPercent, string flourType)
            : base(name, weight, shugarPercent)
        {
            _flourType = flourType;
        }
        
    }
}
