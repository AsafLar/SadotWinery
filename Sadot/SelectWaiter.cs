/*
 * SelectWaiter form code
 * class with the code of the form of chossing employee to spcific order when press on table for the first time
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
    public partial class SelectWaiter : Form
    {
        private DBSQL db = new DBSQL();
        private Employee[] employees;
        public Employee selctedWaiter;

        /// <summary>
        /// form constractor
        /// </summary>
        public SelectWaiter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when SelectWaiter form load
        /// the method will fill the panel with buttons with the waiters names
        /// </summary>
        private void SelectWaiter_Load(object sender, EventArgs e)
        {
            FillWaitersButtons(mainPanelWaiter);
        }

        /// <summary>
        /// method to fill the panel with the buttons with the waiters names
        /// </summary>
        /// <param name="currPanel">the panel to put the buttons in</param>
        public void FillWaitersButtons(Panel currPanel)
        {
            employees = db.GetActiveEmployeesData();
            int cols = 4;
            int rows = employees.Length / 4; // 3 buttons per line
            if (employees.Length % 4 > 0)//check if thers need in one more row
                rows++;

            int dif = 20;
            int width = 80; //set width of the button
            int height = 130;//set height of the button

            int top = dif;
            int left = currPanel.Left + dif;
            int k = 0;// index of the spicific product in the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols && k < employees.Length; j++, k++)
                {
                    MyBtn newBtn = new MyBtn();
                    newBtn.Text = employees[k].FirstName + " " + employees[k].LastName;
                    newBtn.ID = employees[k].ID;
                    newBtn.Left = left;
                    newBtn.Top = top;
                    newBtn.Width = width;
                    newBtn.Height = height;
                    newBtn.FlatStyle = FlatStyle.Popup;
                    newBtn.Font = new Font("Microsoft Sans Serif", 16);
                    left = width * (j + 1) + (dif * (j + 2));
                    newBtn.Click += new EventHandler(btnWaiter_Click);
                    currPanel.Controls.Add(newBtn);
                }
                top = height * (i + 1) + (dif * (i + 2));
                left = mainPanelWaiter.Left + dif;
            }
        }

        /// <summary>
        /// method wich works when the user press on one of ther waiters buttons
        /// the method set the selected waiter property and close the form
        /// </summary>
        private void btnWaiter_Click(object sender, EventArgs e)
        {
            selctedWaiter = new Employee();
            selctedWaiter.ID = ((MyBtn)sender).ID;
            selctedWaiter.FirstName = ((MyBtn)sender).Text;
            this.Close();
        }
    }
}
