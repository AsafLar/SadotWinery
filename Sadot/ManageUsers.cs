/*
 * ManageUsers form code
 * class with the code of the form of users management options for the admin
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
    public partial class ManageUsers : Form
    {
        private DBSQL db = new DBSQL();
        private User[] users;
        private User userToUpdate;

        /// <summary>
        /// form constractor
        /// </summary>
        public ManageUsers()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';//Display asterisks while typing the password
            txtConfirmPassword.PasswordChar = '*';
            txtPasswordUpdate.PasswordChar = '*';
            txtConfirmPasswordUpdate.PasswordChar = '*';
            cboPermissionUpdate.Text = "בחר הרשאה";
            cboPermission.Text = "משתמש";
        }

        /// <summary>
        /// method wich works when ManageUsers form load
        /// the method will get all the users from data base to the users array
        /// </summary>
        private void NewUser_Load(object sender, EventArgs e)
        {
            users = db.GetUsersData();
        }

        /// <summary>
        /// method wich works when the user press on "register user"
        /// the method will check all the fields and if all ok add the new user to the data base
        /// </summary>
        private void btnRegNewUser_Click(object sender, EventArgs e)
        {
            if (IsEmptyString())
            {
                MessageBox.Show("אחד או יותר מהשדות ריקים ", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("אימות סיסמא לא תואם לסיסמא", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (UserAlreadyExists())
            {
                MessageBox.Show("משתמש זה כבר קיים במערכת ", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FillNewUserDataAndInsert();
                MessageBox.Show("  הרישום של :  " + txtUserName.Text + "   בוצע בהצלחה    !  ", " הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearingFields();
            }
        }

        /// <summary>
        /// method wich checks if the user name allready shows in the exists users
        /// </summary>
        /// <returns>
        /// bool true - user shows
        /// bool false - user not shows
        /// </returns>
        private bool UserAlreadyExists()
        {
            bool res = false;
            //loop to pass on all the users in ther array
            for (int i = 0; i < users.Length && !res; i++)
            {
                if (users[i].UserName == txtUserName.Text)
                    res = true;
            }
            return res;
        }

        /// <summary>
        /// method wich checks if one of the fields empty
        /// </summary>
        /// <returns>
        /// bool true - at least one is empty
        /// bool false - all fields ok
        /// </returns>
        private bool IsEmptyString()
        {
            bool res = false;
            if (Checks.IsEmptyString(txtUserName.Text) || Checks.IsEmptyString(txtPassword.Text) || Checks.IsEmptyString(txtConfirmPassword.Text))
                res = true;
            return res;
        }

        /// <summary>
        /// method wich create new user object fill with the details from fields
        /// and insert the new user to data base
        /// </summary>
        private void FillNewUserDataAndInsert()
        {
            User user = new User();
            user.UserName = txtUserName.Text;
            user.Password = Eramake.eCryptography.Encrypt(txtPassword.Text);//Encrypt password
            user.Permission = cboPermission.Text;
            db.InsertNewUser(user);
        }

        /// <summary>
        /// method wich clean all the fields after register user or update user
        /// </summary>
        private void ClearingFields()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            cboPermission.Text = "משתמש";

            txtPasswordUpdate.Text = string.Empty;
            txtConfirmPasswordUpdate.Text = string.Empty;
            cboUsersNames.Text = "בחר משתמש";
            cboPermissionUpdate.Text = "בחר הרשאה";

        }

        /*
        ************************************ update user code
        */

        /// <summary>
        /// method wich works when the user press on "register new user" button
        /// the method will change the tab page to the page of register new user
        /// and refresh the users array
        /// </summary>
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpNewUser;
            users = db.GetUsersData();
        }

        /// <summary>
        /// method wich works when the user press on "update password / premission" button
        /// the method will change the tab page to the page of update user
        /// and refresh the users array
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpUpdate;
            FillUsersComboBox();
        }

        /// <summary>
        /// Method to fill user name selection list
        /// </summary>
        public void FillUsersComboBox()
        {
            users = db.GetUsersData();
            cboUsersNames.Items.Clear();
            cboUsersNames.Items.Add("בחר משתמש");
            for (int i = 0; i < users.Length; i++)
            {
                cboUsersNames.Items.Add(users[i].UserName);
            }
            cboUsersNames.Text = "בחר משתמש";
        }

        /// <summary>
        /// method wich works when the user change the user name in the combo box list
        /// the method will fill userToUpdate object with the details of the chosen user from the list
        /// </summary>
        private void cboUsersNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillUserToUpdateObject();
        }

        /// <summary>
        /// Method wich search the spcific chosen user in the users array
        /// and put in the userToUpdate object
        /// </summary>
        public void FillUserToUpdateObject()
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].UserName == cboUsersNames.Text)
                    userToUpdate = users[i];
            }
        }

        /// <summary>
        /// method wich works when the user press on "update user"
        /// the method will check all the details in the fields
        /// and if all ok will update the spcific user details in the data base
        /// </summary>
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (cboUsersNames.Text == "בחר משתמש")
            {
                MessageBox.Show("בחר משתמש מהרשימה לצורך עדכון", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cboPermissionUpdate.Text == "בחר הרשאה")
            {
                MessageBox.Show("בחר הרשאת משתמש", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Checks.IsEmptyString(txtPasswordUpdate.Text) || Checks.IsEmptyString(txtConfirmPasswordUpdate.Text))
            {
                MessageBox.Show("אחד או יותר משדות הסיסמא ריקים ", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPasswordUpdate.Text != txtConfirmPasswordUpdate.Text)
            {
                MessageBox.Show("השדות: סיסמא ואימות סיסמא לא תואמים", "הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                userToUpdate.Password = Eramake.eCryptography.Encrypt(txtPasswordUpdate.Text);//Encrypt password
                userToUpdate.Permission = cboPermissionUpdate.Text;
                db.UpdateUser(userToUpdate);
                MessageBox.Show("  המשתמש :  " + userToUpdate.UserName + "   עודכן בהצלחה    !  ", " הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearingFields();
            }
        }
    }
}
