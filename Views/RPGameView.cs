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
    public partial class RPGameView : Form
    {
        private RPController _controller;
        private int _attempts;
        public RPController Controller { get => _controller; set => _controller = value; }
        public int Attempts { get => _attempts; set => _attempts = value; }

        public RPGameView(RPController controller)
        {
            InitializeComponent();
            Controller = controller;
            Attempts = 0;
            Controller.CurrentItem = Controller.SetRandomItem();
            lblItemToEvaluate.Text = Controller.CurrentItem.Name;
            lblResult.Text = String.Empty;
            lblAttempts.Text = String.Format("{0} essais", Attempts);
        }

        private void tbxPriceEstimated_TextChanged(object sender, EventArgs e)
        {
            btnValidate.Enabled = tbxPriceEstimated.Text != String.Empty ? true : false;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(tbxPriceEstimated.Text);
            int result = Controller.CheckItemPrice(price);
            switch (result)
            {
                case 0:
                    lblResult.Text = "Juste prix";
                    btnValidate.Enabled = false;
                    tbxPriceEstimated.Enabled = false;
                    Controller.AddScore()
                    break;
                case 1:
                    lblResult.Text = "Supérieur";
                    Attempts++;
                    break;
                case -1:
                    lblResult.Text = "Inférieur";
                    Attempts++;
                    break;
            }
            lblAttempts.Text = String.Format("{0} essai(s)", Attempts);
        }
    }
}
