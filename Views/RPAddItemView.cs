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
    public partial class RPAddItemView : Form
    {
        RPController _controller;
        public RPController Controller { get => _controller; set => _controller = value; }

        public RPAddItemView(RPController controller)
        {
            InitializeComponent();
            Controller = controller;
        }


        public void TextChanged_Custom(object sender, EventArgs e)
        {
            btnAdd.Enabled = ((tbxName.Text != String.Empty) && (tbxPrice.Text != String.Empty)) ? true : false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int price = Convert.ToInt32(tbxPrice.Text);
            Controller.AddItem(name, price);
            if (cbxAddMore.Checked) {
                tbxName.Clear();
                tbxPrice.Clear();
            }
            else
            {
                this.Close();
            }
        }
    }

}
