using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustePrix
{
    public class RPController
    {
        private List<RPItem> _items;
        private List<RPScore> _scores;
        private RPItem _currentItem;
        private RPPlayer _currentPlayer;
        private Random rdm;
        public List<RPItem> Items { get => _items; set => _items = value; }
        public RPItem CurrentItem { get => _currentItem; set => _currentItem = value; }
        public Random Rdm { get => rdm; set => rdm = value; }
        internal List<RPScore> Scores { get => _scores; set => _scores = value; }
        public RPPlayer CurrentPlayer { get => _currentPlayer; set => _currentPlayer = value; }

        public RPController()
        {
            Items = new List<RPItem>() { }; //init$
            Scores = new List<RPScore>() { };
            Rdm = new Random();
        }

        public void AddItem(string name, int price)
        {
            Items.Add(new RPItem(name, price));
        }

        public int CheckItemPrice(int price)
        {
            return CurrentItem.Price == price ? 0 : CurrentItem.Price > price ? 1 : -1;
        }

        public RPItem SetRandomItem()
        {
            int length = Items.Count;
            int index = rdm.Next(0, length);
            return Items[index];
        }

        public int GetItemsCount()
        {
            return Items.Count;
        }

        public void AddScore(RPPlayer player, int attempts, DateTime date)
        {
            Scores.Add(new RPScore(player, attempts, date));
        }
    }
}
