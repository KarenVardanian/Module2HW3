using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    public abstract class Buisquit:WithSugar
    {
       public string _flourType { get; set; }
       public Buisquit(string name, double weight, double shugarPercent, string flourType)
            : base(name, weight, shugarPercent)
        {
            _flourType = flourType;
        }
        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n _flourType{_flourType} "; 
        }
    }
}
