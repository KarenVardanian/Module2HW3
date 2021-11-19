using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public class Candy:WithSugar
    {
       public string _package { set; get; }
        public Candy(string name, double weight, double shugarPercent,string form)
            : base(name, weight, shugarPercent)
        {
            _package = form;
        }
        
    }
}
