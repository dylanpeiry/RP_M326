using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustePrix
{
    public class RPPlayer
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public RPPlayer(string name)
        {
            Name = name;
        }
    }
}
