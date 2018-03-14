using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustePrix
{
    class RPScore : IComparable<RPScore>
    {
        private RPPlayer _player;
        private int _attempts;
        private DateTime _date;

        public RPPlayer Player { get => _player; set => _player = value; }
        public int Attempts { get => _attempts; set => _attempts = value; }
        public DateTime Date { get => _date; set => _date = value; }

        public RPScore(RPPlayer player, int attempts, DateTime date)
        {
            Player = player;
            Attempts = attempts;
            Date = date;
        }
        private class sortAttempsAscendingHelper : IComparer<RPScore>
        {

            public int Compare(RPScore x, RPScore y)
            {
                RPScore s1 = x;
                RPScore s2 = y;
                if (s1.Attempts > s2.Attempts)
                    return 1;
                if (s1.Attempts < s2.Attempts)
                    return -1;
                else
                    return 0;
            }
        }

        public int CompareTo(RPScore other)
        {
            RPScore s = (RPScore)other;
            return String.Compare(this.Attempts.ToString(), s.Attempts.ToString());
        }

        public static IComparer<RPScore> sortAttempsAscending()
        {
            return (IComparer<RPScore>)new sortAttempsAscendingHelper();
        }
    }
}
