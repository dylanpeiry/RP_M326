using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustePrix
{
    public partial class RPMainView : Form
    {
        private RPController _controller;
        internal RPController Controller { get => _controller; set => _controller = value; }

        public RPMainView()
        {
            InitializeComponent();
            Controller = new RPController();
            UpdateView();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            Controller.CurrentPlayer = new RPPlayer(tbxPlayerName.Text);
            RPAddItemView _view = new RPAddItemView(Controller);
            _view.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Controller.CurrentPlayer = new RPPlayer(tbxPlayerName.Text);
            RPGameView _view = new RPGameView(Controller,this);
            _view.ShowDialog();
        }

        private void tbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = tbxPlayerName.Text != String.Empty && Controller.Items.Count > 0 ? true : false;
        }

        private string ShowScores()
        {
            Controller.Scores.Sort(RPScore.sortAttempsAscending());
            string scores = String.Empty;
            foreach (RPScore s in Controller.Scores)
            {
                scores += String.Format("{0} : {1} essai(s) [{2}]", s.Player.Name, s.Attempts, s.Date) + Environment.NewLine;
            }
            return Controller.Scores.Count > 0 ? scores : String.Empty;
        }

        public void UpdateView()
        {
            tbxPlayerName.Clear();
            lblScores.Text = ShowScores();
        }
    }
}
