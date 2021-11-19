using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Hw2.Models
{
    public class PeopleComparer : IComparer<Product>
    {
       
        public int Compare(Product x, Product y)
        {
            if (x._weight > y._weight)
                return 1;
            else if (x._weight < y._weight)
                return -1;
            else
                return 0;
        }
    }
}
