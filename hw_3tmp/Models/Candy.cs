using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_3tmp
{
    public class Candy:WithSugar
    {
       public string _form { set; get; }
        public Candy(string name, double weight, double shugarPercent,string form)
            : base(name, weight, shugarPercent)
        {
            _form = form;
        }
        public override string ToString()
        {
            return $"Name {_name}\n Wright {_weight}\n ShugarPercent {_shugarPercent}\n form {_form}";
        }
    }
}
