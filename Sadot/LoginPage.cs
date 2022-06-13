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
                    checkMonthAndYearForStock();
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
                    this.Hide(); //TODO::YARON - 'this' is not necessary
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

        private void checkMonthAndYearForStock()
        {
            Stock[] stock;
            DateTime currentDate = DateTime.Now;
            int monthFromStock = db.GetCurrentMonth();
            int yearFromStock = db.GetCurrentyYear();
            string qurey;
            //check if this is a new month
            if (currentDate.Month != monthFromStock)
            {
                qurey = "SELECT productID, product.name , SUM(`1`+`2`+`3`+`4`+`5`+`6`+`7`+`8`+`9`+`10`+`11`+`12`+`13`+`14`+`15`+`16`+`17`+`18`+`19`+`20`+`21`+`22`+`23`+`24`+`25`+`26`+`27`+`28`+`29`+`30`+`31`) AS total FROM `stockByDate` INNER JOIN product ON stockByDate.productID = product.id WHERE 1 GROUP BY `productID` ";
                stock = db.GetStockDataBy(qurey); //TODO::YARON - Use Thread.Task with await
                //loop to pass on all the array with stock details
                for (int i = 0; i < stock.Length; i++)
                {
                    db.UpdateProductInStockByYear(monthFromStock.ToString(), stock[i].TotalAmount, stock[i].ProductID, currentDate.Month);//(string num, double amount, int productID, int currentMonth)
                }
                db.ResetStockByDate();
            }
            //check if this is a new year
            if (currentDate.Year != yearFromStock)
            {
                qurey = "SELECT productID, product.name , SUM(`1`+`2`+`3`+`4`+`5`+`6`+`7`+`8`+`9`+`10`+`11`+`12`) AS total FROM `stockByYear` INNER JOIN product ON stockByYear.productID = product.id WHERE 1 GROUP BY `productID` ";
                db.ResetStockByYear(currentDate.Year);
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
