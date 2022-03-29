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
    public partial class ProductsList : Form
    {
        private readonly DietarySupplementsEntities _db;
        public ProductsList()
        {
            InitializeComponent();
            _db = new DietarySupplementsEntities();
        }

        public void PopulateGrid()
        {
            var products = _db.Products
                .Select(q => new
                {
                    Name = q.product_name,
                    Type = q.type,
                    Brand = q.brand,
                    Format =q.format,
                    Importance = q.importance,
                    q.id
                })
                .ToList();
            gvProductsList.DataSource = products;
            gvProductsList.Columns["Id"].Visible = false;
        }


        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Request"))
            {
                var addRequest = new AddRequest();
                addRequest.ShowDialog();
                addRequest.MdiParent = this.MdiParent;
            }
        }

        private void gvProductsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsList_Load_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateGrid();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("OrdersList"))
            {
                var ordersList = new OrdersList();
                ordersList.ShowDialog();
            }
        }
    }
}