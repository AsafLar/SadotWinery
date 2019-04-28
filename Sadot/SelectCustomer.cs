/*
 * SelectCustomer form code
 * class with the code of the form of chossing customer to spcific order
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class SelectCustomer : Form
    {
        private DBSQL db = new DBSQL();
        private Customer[] customers;
        public Customer selctedCustomer;

        /// <summary>
        /// form constractor
        /// </summary>
        public SelectCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when SelectCustomer form load
        /// the method will get customers data from the data base to customers array
        /// </summary>
        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            customers = db.GetActiveCustomersData();
            cboParameterToSearch.Text = "מספר נייד";
        }

        /// <summary>
        /// method wich works when the user write text in the search text box
        /// the method will get the customers details by the text and the search parameter
        /// </summary>
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string querry = string.Empty;
            querry = "SELECT * FROM `customers` WHERE " + "`" + ParameterToColumnName(cboParameterToSearch.Text) + "`" + " LIKE '" + txtSearchCustomer.Text + "%'";
            Customer[] searcCustomers = db.GetCustomerDataSearch(querry);//get the customers data

            lstCustomers.Items.Clear();
            for (int i = 0; i < searcCustomers.Length; i++)
            {
                lstCustomers.Items.Add(searcCustomers[i].ToString());
            }
        }

        /// <summary>
        /// method of the search option
        /// the method will check by which parameter the user want to srearch
        /// </summary>
        /// <param name="parameterToSearch">the chosen paramter from the combo box</param>
        /// <returns>
        /// res - the parameter to search by
        /// </returns>
        public string ParameterToColumnName(string parameterToSearch)
        {
            if (parameterToSearch == "מספר נייד")
                return "phoneNumber";
            if (parameterToSearch == "שם פרטי")
                return "firstName";
            return "lastName";
        }

        /// <summary>
        /// method wich works when the uset chose customer from the list
        /// the method will set the selected customer properrty to the chosen one and close the form
        /// </summary>
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Checks.IsItemSelected(lstCustomers))
            {
                string[] words = lstCustomers.SelectedItem.ToString().Split('|');
                int chosenCustomerId = int.Parse(words[0]);
                bool flag = true;

                for (int i = 0; i < customers.Length && flag; i++)
                {
                    if (customers[i].CustomerId == chosenCustomerId)
                    {
                        selctedCustomer = customers[i];
                        flag = false;
                    }
                }
                this.Close();
            }
        }
    }
}
