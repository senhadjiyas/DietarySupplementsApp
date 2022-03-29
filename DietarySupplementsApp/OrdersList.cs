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
    public partial class OrdersList : Form
    {
        private readonly DietarySupplementsEntities _db;
        public OrdersList()
        {
            InitializeComponent();
            _db = new DietarySupplementsEntities();
        }

        public void PopulateGrid()
        {
            var orders = _db.Orders
                .Select(q => new
                {
                    Name = q.productname,
                    Pid = q.productid,
                    Quantity = q.quantity,
                    q.id
                })
                .ToList();
            gvOrdersList.DataSource = orders;
            gvOrdersList.Columns["Id"].Visible = false;
            gvOrdersList.Columns["PId"].Visible = false;
        }

        private void gvProductsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddOrder"))
            {
                var addOrder = new AddOrder();
                addOrder.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void OrdersList_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}