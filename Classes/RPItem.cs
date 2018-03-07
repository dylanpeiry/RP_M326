using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustePrix
{
    public class RPItem
    {
        private string _name;
        private int _price;

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public RPItem(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
