using Module2Hw2.Models;
using Module2Hw2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module2Hw2 //hw_3tmp
{
    public class Starter
    {
       public void Run()
        {
            var sr = new Services();
            sr.sortByWeight();
            sr.SerachByName("apple");
            
        }
    }
}
