using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2 //hw_3tmp
{
    public class Shortbread : Buisquit
    {


        public string _form { set; get; }
        public Shortbread(string name, double weight, double shugarPercent, string flourType, string form)
        : base(name, weight, shugarPercent, flourType)
        {
            _form = form;
        }

       
    }
}
