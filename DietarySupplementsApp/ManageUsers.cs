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
    public partial class ManageUsers : Form
    {
        private readonly DietarySupplementsEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new DietarySupplementsEntities();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser();
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
         {
             try
             {
                 // get Id of selected row
                 var id = (int)gvUsersList.SelectedRows[0].Cells["id"].Value;

                 //query database for record
                 var user = _db.Users.FirstOrDefault(q => q.id == id);

                 var hashed_password = Utils.DefaultHashedPassword();
                 user.password = hashed_password;
                 _db.SaveChanges();

                 MessageBox.Show($"{user.username}'s Password has been reset!");
                 PopulateGrid();
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error: {ex.Message}");
             }
         }


        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {

            var users = _db.Users
                .Select(q => new
                {
                    q.id,
                    q.username,
                    q.isActive
                })
                .ToList();
            
            gvUsersList.DataSource = users;
            gvUsersList.Columns["username"].HeaderText = "Username";
            gvUsersList.Columns["isActive"].HeaderText = "Active";


            gvUsersList.Columns["id"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
