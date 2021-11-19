using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2
{
    public class DriedFruits : WithoutShugar
    {
        public string _countryProducer { set; get; }
        public DriedFruits(string name, double weight, double shugarPercent,string countryProducer) :
            base(name, weight, shugarPercent)
        {
            _countryProducer = countryProducer;
        }
       
    }
}
