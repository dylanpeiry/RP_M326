using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustePrix
{
    class RPScore
    {
        private RPPlayer _player;
        private int _attempts;
        private DateTime _date;

        public RPPlayer Player { get => _player; set => _player = value; }
        public int Attempts { get => _attempts; set => _attempts = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public RPScore(RPPlayer player,int attempts, DateTime date)
        {
            Player = player;
            Attempts = attempts;
            Date = date;
        }
    }
}
