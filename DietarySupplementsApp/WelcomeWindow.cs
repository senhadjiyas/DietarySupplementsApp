using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DietarySupplementsApp;

namespace DietarySupplementsApp
{
    public partial class WelcomeForm : Form
    {
        private Signin _signin;
        public User _user;
 

        public WelcomeForm()
        {
            InitializeComponent();
        }

      

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("Signin"))
            {
                var signin = new Signin();
                signin.ShowDialog();
            
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this._user);
                addUser.ShowDialog();
               
            }
            
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("RequestsList"))
            {
                var requestsList = new RequestsList();
                requestsList.ShowDialog();
            }
        }
        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }


    }
}
