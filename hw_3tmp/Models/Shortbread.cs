using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    public class Shortbread : Buisquit
    {


        public string _form { set; get; }
        public Shortbread(string name, double weight, double shugarPercent, string flourType, string form)
        : base(name, weight, shugarPercent, flourType)
        {
            _form = form;
        }

        public override string ToString()
        {
          return  $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n _flourType{_flourType}\n _form{_flourType} ";
        }
    }
}
