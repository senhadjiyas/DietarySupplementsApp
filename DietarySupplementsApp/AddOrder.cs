using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietarySupplementsApp
{
    public partial class AddOrder : Form
    {
        private OrdersList _ordersListing;
        private readonly bool isEditMode;
        private readonly DietarySupplementsEntities _db;
        public AddOrder(OrdersList orderListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Order";
            this.Text = "Add New Order";
            _ordersListing = orderListing;
            _db = new DietarySupplementsEntities();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void PopulateFields(Order order)
        {
            tbProductName.Text = order.productname.ToString();
            tbQuantity.Text = order.quantity.ToString();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }
    }
}