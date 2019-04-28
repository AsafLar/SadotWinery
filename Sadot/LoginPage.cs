/*
 * LoginPage form code
 * class with the code of the form of log in to the system admin/user
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class LoginPage : Form
    {

        private DBSQL db = new DBSQL();

        /// <summary>
        /// form constractor
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when LoginPage form load
        /// </summary>
        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        /// <summary>
        /// method wich works when the user press on "log in" button
        /// the method will check the user name and password and open the right control panel (user / admin)
        /// </summary>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("שם משתמש וסיסמא ריקים נסה שנית !! ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = string.Empty;
            }
            else
            {
                string pass = Eramake.eCryptography.Encrypt(txtPassword.Text);
                User user = db.CheckLogin(txtUserName.Text, pass);

                if (user != null)
                {
                    if (user.Permission == "מנהל")
                    {
                        AdminHomePage adminHomePage = new AdminHomePage(this);
                        adminHomePage.Show();
                    }
                    else
                    {
                        UserHomePage userHomePage = new UserHomePage(this);
                        userHomePage.Show();
                    }
                    this.Hide();
                    txtUserName.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("שם משתמש או סיסמא שגויים נסה שנית ", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// method wich works when the user press on "forgot password " label
        /// the method will open the password recovery form
        /// </summary>
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            PasswordRecovery adminPasswordRecovery = new PasswordRecovery();
            adminPasswordRecovery.ShowDialog();
        }

        /// <summary>
        /// method wich works when the user press on "X" label
        /// the method will close the log in form
        /// </summary>
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
