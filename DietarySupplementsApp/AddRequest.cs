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
    public partial class AddRequest : Form
    {
        private RequestsList _requestsListing;
        private readonly bool isEditMode;
        private readonly DietarySupplementsEntities _db;
        public AddRequest(RequestsList requestListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Request";
            this.Text = "Add New Request";
            _requestsListing = requestListing;
            _db = new DietarySupplementsEntities();
        }

        public AddRequest(Request requestToEdit, RequestsList requestListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Product";
            this.Text = "Edit Product";
            _requestsListing = requestListing;
            if (requestToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new DietarySupplementsEntities();
                PopulateFields(requestToEdit);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(tbName.Text) ||
                        string.IsNullOrWhiteSpace(tbType.Text))
                {
                    MessageBox.Show("Please ensure that you provide a name and a type");
                }
                else
                {

                    var newRequest = new Request
                    {
                         product_name = tbName.Text,
                         type = tbType.Text,
                         brand = tbBrand.Text,
                         format = tbFormat.Text,
                         importance = cbImportance.Text
            
                    };

                _db.Requests.Add(newRequest);

                _db.SaveChanges();
                MessageBox.Show("Operation Completed. Refresh Grid To see Changes");
                Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }  
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void PopulateFields(Request request)
        {
            tbName.Text = request.id.ToString();
            tbType.Text = request.type;
            tbBrand.Text = request.brand;
            tbFormat.Text = request.format;
            cbImportance.Text = request.importance;
        }

    }
}
