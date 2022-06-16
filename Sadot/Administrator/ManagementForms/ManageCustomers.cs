/*
 * ManageCustomers form code
 * class with the code of the form of customers management options for the admin
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class ManageCustomers : Form
    {
        private DBSQL db = new DBSQL();
        private Customer[] customers;
        private Customer customer;

        /// <summary>
        /// form constractor
        /// </summary>
        public ManageCustomers()
        {
            InitializeComponent();
            btnUpdateCustoemr.Enabled = false;
            dtpCustomerAnniversary.Hide();
            lblAnniversary.Hide();
        }

        /// <summary>
        /// method wich works when manage customers form load
        /// </summary>
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            customers = db.GetCustomersData();
            cboParameterToSearch.Text = "שם פרטי";
        }

        /// <summary>
        /// method wich get all the customers details from the data base and fill
        /// the customers list with the details
        /// </summary>
        public void FillCustomersList()
        {
            lstCustomers.Items.Clear();
            customers = db.GetCustomersData();
            for (int i = 0; i < customers.Length; i++)
                lstCustomers.Items.Add(customers[i].ToString());
        }

        /// <summary>
        /// method wich fill the fields of the
        /// chosen customer of the user
        /// </summary>
        public void FillSelectedCustomerData()
        {
            string[] words = lstCustomers.SelectedItem.ToString().Split('|');
            int chosenCustomerId = int.Parse(words[0]);
            bool flag = true;
            //loop to pass on customers array
            for (int i = 0; i < customers.Length && flag; i++)
            {
                if (customers[i].CustomerId == chosenCustomerId)
                {
                    customer = customers[i];
                    flag = false;
                }
            }
            txtCustomerFname.Text = customer.FirstName;
            txtCustomerLname.Text = customer.LastName;
            txtCustomerEmail.Text = customer.Email;
            txtCustomerPhone.Text = customer.Phone;
            dtpCustomerBirthday.Value = DateTime.ParseExact(customer.DateOfBirth, "dd/M/yyyy", CultureInfo.InvariantCulture);
            if (customer.Anniversary == "single")
                cbIsMarrid.Checked = false;
            else
            {
                cbIsMarrid.Checked = true;
                dtpCustomerAnniversary.Value = DateTime.ParseExact(customer.Anniversary, "dd/M/yyyy", CultureInfo.InvariantCulture);
            }

            cbCustomerStatus.Checked = (customer.Status == 1) ? true : false;
        }

        /// <summary>
        /// method wich works when the user press on "show all customers" button
        /// the method will fill the customers list with the customers details from data base
        /// </summary>
        private void btnShowAllCustomers_Click(object sender, EventArgs e)
        {
            FillCustomersList();
        }

        /// <summary>
        /// method wich works when the user select customer from the customers list
        /// the method will fill all the fields with the selected customer details
        /// </summary>
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Checks.IsItemSelected(lstCustomers))
            {
                btnUpdateCustoemr.Enabled = true;
                btnAddCustomer.Enabled = false;
                FillSelectedCustomerData();
            }
        }

        /// <summary>
        /// method wich works when the user change the checked of the marrid check box
        /// if checked show the date field
        /// if uncheck hide the date field
        /// </summary>
        private void cbIsMarrid_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsMarrid.Checked == true)
            {
                dtpCustomerAnniversary.Enabled = true;
                dtpCustomerAnniversary.Show();
                lblAnniversary.Show();
            }
            else
            {
                dtpCustomerAnniversary.Enabled = false;
                dtpCustomerAnniversary.Hide();
                lblAnniversary.Hide();
            }
                
        }

        /// <summary>
        /// method wich works when the user press on "back to main page" button
        /// the method will close the current form and back to the admin home page
        /// </summary>
        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// mehtod wich clean all the fields in the form
        /// </summary>
        public void CleanFields()
        {
            FillCustomersList();
            txtCustomerFname.Text = string.Empty;
            txtCustomerLname.Text = string.Empty;
            txtCustomerEmail.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtSearchCustomer.Text = string.Empty;
            cbIsMarrid.Checked = false;
            btnAddCustomer.Enabled = true;
            btnUpdateCustoemr.Enabled = false;
            dtpCustomerAnniversary.Hide();
            lblAnniversary.Hide();
        }

        /// <summary>
        /// method wich works when the user press on "clean fields" button
        /// the method clean all the fields in the form
        /// </summary>
        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        /// <summary>
        /// method wich works when the user press on "add customer" button
        /// the method will check the inputs and insert the new customer to data base
        /// </summary>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (inputChecks())
            {
                customer = new Customer();
                customer.FirstName = txtCustomerFname.Text;
                customer.LastName = txtCustomerLname.Text;
                customer.Email = txtCustomerEmail.Text;
                customer.Phone = txtCustomerPhone.Text;
                customer.DateOfBirth = dtpCustomerBirthday.Text;
                customer.Anniversary = (cbIsMarrid.Checked) ? dtpCustomerAnniversary.Text : "single";
                customer.Status = 1;
                db.InsertNewCustomer(customer);
                MessageBox.Show("הלקוח התווסף בהצלחה!");
                CleanFields();
            }
        }

        /// <summary>
        /// method to check if the user put correct input in the customer fields
        /// </summary>
        /// <returns>
        /// res = true - all inputs correct
        /// res = false - one or more from the inputs is incorrect
        /// </returns>
        public bool inputChecks()
        {
            bool res = true;
            if(Checks.IsEmptyString(txtCustomerFname.Text) || Checks.IsEmptyString(txtCustomerLname.Text) 
                || Checks.IsEmptyString(txtCustomerPhone.Text) || Checks.IsEmptyString(txtCustomerEmail.Text))
            {
                res = false;
                MessageBox.Show("אחד או יותר מהשדות ריקים!");
            }
            else if (!Checks.IsStringIsContainLettersOrNumbers(txtCustomerFname.Text))
            {
                res = false;
                MessageBox.Show("שם פרטי יכול להכיל רק אותיות בעברית!");
            }
            else if (!Checks.IsStringIsContainLettersOrNumbers(txtCustomerLname.Text))
            {
                res = false;
                MessageBox.Show("שם משפחה יכול להכיל רק אותיות בעברית!");
            }
            else if (!Checks.IsValidEmail(txtCustomerEmail.Text))
            {
                res = false;
                MessageBox.Show("אימייל לא חוקי!");
            }
            else if(!Checks.IsValidPhone(txtCustomerPhone.Text))
            {
                res = false;
                MessageBox.Show("טלפון לא חוקי !");
            }
            return res;
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
            string res = string.Empty;
            if (parameterToSearch == "שם פרטי")
                res =  "firstName";
            if(parameterToSearch == "שם משפחה")
                res = "lastName";
            return res;
        }

        /// <summary>
        /// method wich works when the user write on search txt
        /// the method will get the text and search the customers by the right parameter
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
        /// method wich works when the user press on "update customer" button
        /// the method will check the inputs and update the spcific customer details
        /// </summary>
        private void btnUpdateCustoemr_Click(object sender, EventArgs e)
        {
            if(inputChecks())
            {
                FillDataToUpdateCustomer();
                db.UpdateCustomer(customer);
                MessageBox.Show(" הלקוח עודכן בהצלחה ");
                CleanFields();
            }
        }

        /// <summary>
        /// method wich fill the customer object with the details from the fields
        /// </summary>
        private void FillDataToUpdateCustomer()
        {
            customer.FirstName = txtCustomerFname.Text;
            customer.LastName = txtCustomerLname.Text;
            customer.Email = txtCustomerEmail.Text;
            customer.Phone = txtCustomerPhone.Text;
            customer.DateOfBirth = dtpCustomerBirthday.Text;
            customer.Anniversary = (cbIsMarrid.Checked) ? dtpCustomerAnniversary.Text : "single";
            customer.Status = (cbCustomerStatus.Checked) ? 1 : 0;
        }
    }
}
