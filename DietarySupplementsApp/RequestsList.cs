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
    public partial class RequestsList : Form
    {
        private readonly DietarySupplementsEntities _db;
        public RequestsList()
        {
            InitializeComponent();
            _db = new DietarySupplementsEntities();
        }

        public void PopulateGrid()
        {

            var requests = _db.Requests.Select(q => new
            {
                Name = q.product_name,
                Brand = q.brand,
                Type = q.type,
                Id = q.id,
                q.importance,
            }).ToList();
            gvRequestsList.DataSource = requests;
            gvRequestsList.Columns["Name"].HeaderText = "Name";
            gvRequestsList.Columns["Type"].HeaderText = "Type";
            gvRequestsList.Columns["Id"].Visible = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            PopulateGrid();

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddRequest"))
            {
                var addRequest = new AddRequest(this);
                addRequest.ShowDialog();
            }
        }

        private void gvRequestsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RequestsList_Load_1(object sender, EventArgs e)
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
    }
}