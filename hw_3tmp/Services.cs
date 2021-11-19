using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2Hw2.Models;
namespace Module2Hw2.Models
{
    public class Services:ISerachByName,IComparer<Product>
    {
        private readonly Product[] _data;
        public Services()
        {
            var a = new NutsСandy("karkum", 42, 12, "paper", "black", "peanut");
            var shortBread = new Shortbread("Maria", 21, 4, "white", "plastic");
            var drf = new DriedFruits("apple", 31, 12, "Ukraine");
            
            _data = new Product[] { a, shortBread, drf };

        }
        public int Compare(Product o1, Product o2)
        {
            if (o1._weight > o2._weight)
                return 1;
            else if (o1._weight > o2._weight)
                return -1;
            else
                return 0;
        }

        public void sortByWeight(){
            Array.Sort(_data, new Services());
        }
        public Product[] SerachByName(string name)
        {
            Product[] tmpData = new Product[_data.Length];
            int[] indexes = new int[_data.Length];
             int index = 0;
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i]._name.Contains(name)){
                    indexes[index] = i;
                    tmpData[index] = _data[i];
                    index++;
                }
            }

            Array.Resize(ref tmpData, index);
 
            return tmpData;
        }

        public void show()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item._weight);
            }
        }
    }
}
