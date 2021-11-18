using hw_3tmp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw_3tmp
{
    class Starter
    {
       public void Run()
        {
            lollipops l = new lollipops("Tik", 11, 9, "circle", "red");
            Nuts_candy nc = new Nuts_candy("Gorix", 26, 12, "square", "blecc", "brazilian");

            Product[] pr = new Product[] {  l, nc };
            Array.Sort(pr, new PeopleComparer());

            foreach (var item in pr)
            {
                item.searchByName("Tik");
                Console.WriteLine(item);
            }
        }
       
           
    }
}
