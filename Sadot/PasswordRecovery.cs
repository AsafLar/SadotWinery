/*
 * PasswordRecovery form code
 * class with the code of the form of password revovery when use press on "forgot password" label
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
    public partial class PasswordRecovery : Form
    {
        private DBSQL db = new DBSQL();
        private User[] users;
        private User tmpUser;

        /// <summary>
        /// form constractor
        /// </summary>
        public PasswordRecovery()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';//Display asterisks while typing the password
            txtConfirmPassword.PasswordChar = '*';//Display asterisks while typing the confirm password
        }

        /// <summary>
        /// method wich works when PasswordRecovery form load
        /// the method will get all the users from data base to the users array
        /// </summary>
        private void AdminPasswordRecovery_Load(object sender, EventArgs e)
        {
            users = db.GetUsersData();
            pnlNewPass.Enabled = false;
            cboPermission.Text = "משתמש";
        }

        /// <summary>
        /// method wich check if the user name and the permission the user enters
        /// match to one of the users in the users array
        /// </summary>
        /// <returns>
        /// bool true - match
        /// bool false - not match
        /// </returns>
        private bool CheckIfUserExists()
        {
            bool userExists = false;

            for (int i = 0; i < users.Length && !userExists; i++)
            {
                if (txtUserName.Text == users[i].UserName && cboPermission.Text == users[i].Permission)
                {
                    tmpUser = users[i];
                    userExists = true;
                }
            }
            return userExists;
        }

        /// <summary>
        /// method wich works when the user press on "pass to set password"
        /// the method check if thers a user with this username and permission
        /// if thers user with those details the method will make the panel of choose new password to enable
        /// </summary>
        private void btnPassToSetPassword_Click(object sender, EventArgs e)
        {
            if (CheckIfUserExists())
            {
                MessageBox.Show("הכנס סיסמא חדשה", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlNewPass.Enabled = true;
                pnlEnterUserDetails.Enabled = false;
            }
            else
            {
                MessageBox.Show("משתמש זה לא קיים", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// method wich works when the user press on "update password"
        /// the method check if the passwords fields not empty and match and if all ok update to the new password
        /// </summary>
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (Checks.IsEmptyString(txtPassword.Text) || Checks.IsEmptyString(txtConfirmPassword.Text))
            {
                MessageBox.Show("אחד או יותר משדות הסיסמא ריקים ", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("השדות סיסמא ואימות סיסמא לא תואמים", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tmpUser.Password = Eramake.eCryptography.Encrypt(txtPassword.Text);//Encrypt password
                db.UpdateUserPassword(tmpUser);
                MessageBox.Show("המשתמש עודכן בהצלחה", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
