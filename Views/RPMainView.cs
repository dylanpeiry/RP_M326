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
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            RPAddItemView _view = new RPAddItemView(Controller);
            _view.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            RPGameView _view = new RPGameView(Controller);
            _view.ShowDialog();
        }

        private void tbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = tbxPlayerName.Text != String.Empty ? true : false;
        }
    }
}
