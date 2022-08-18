using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_for_Inventory_Management
{
    public partial class CheckoutCart : Form
    {
        public CheckoutCart()
        {
            InitializeComponent();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
