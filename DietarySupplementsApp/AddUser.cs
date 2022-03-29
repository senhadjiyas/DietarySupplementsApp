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
    public partial class AddUser : Form
    {
        private readonly DietarySupplementsEntities _db;
        private User _user;


        public AddUser()
        {
            InitializeComponent();
            _db = new DietarySupplementsEntities();
        }
        public AddUser(User user)
        {
            InitializeComponent();
            _db = new DietarySupplementsEntities();
            _user = user;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                var username = tbUsername.Text;
                var password = Utils.DefaultHashedPassword();
                var user = new User
                {
                    username = username,
                    password = password,
                    isActive = true
                };
                _db.Users.Add(user);
                _db.SaveChanges();

                var userid = user.id;

                MessageBox.Show("New User Added Successfully.");
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An Error Has Occured");
            }
        }

    }
}