using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs322_projekat_pharmacy
{
    public partial class FormOrder : Form
    {
        /* get a reference of Order class */
        private Order orderHelper;
        public FormOrder()
        {
            InitializeComponent();
            orderHelper = new Order();
        }

        /*
         * When form loads fill in DataGridView with content 
         */
        private void FormOrder_Load(object sender, EventArgs e)
        {
            dgv_orders.DataSource = orderHelper.getOrders();
        }

        /*
         * Close current active form
         */
        private void exitForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
