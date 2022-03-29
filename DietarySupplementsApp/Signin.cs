using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using DietarySupplementsApp;

namespace DietarySupplementsApp
{
    public partial class Signin : Form
    {
        private readonly DietarySupplementsEntities _db;
        public Signin()
        {
            InitializeComponent();
            _db = new DietarySupplementsEntities();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                var hashed_password = Utils.HashPassword(password);

                //Check for matching username, password and active flag
                var user = _db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password
                            && q.isActive == true);
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var productlist = new ProductsList();
                    productlist.ShowDialog();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again");
            }

        }
    }
}
