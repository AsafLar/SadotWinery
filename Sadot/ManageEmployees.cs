/*
 * ManageEmployess form code
 * class with the code of the form of employees management options for the admin
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
    public partial class ManageEmployees : Form
    {
        private DBSQL db = new DBSQL();
        private Employee[] employees;
        private Employee employee;

        /// <summary>
        /// form constractor
        /// </summary>
        public ManageEmployees()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when manage employees form load
        /// </summary>
        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            btnUpdateEmployee.Enabled = false;
            employees = db.GetEmployeesData();
            cboParameterToSearch.Text = "שם פרטי";
        }

        /// <summary>
        /// method wich get all the employees details from the data base and fill
        /// the employees list with the details
        /// </summary>
        public void FillEmployeesList()
        {
            lstEmployees.Items.Clear();
            employees = db.GetEmployeesData();
            for (int i = 0; i < employees.Length; i++)
                lstEmployees.Items.Add(employees[i].ToString());
        }

        /// <summary>
        /// method wich fill the fields of first name, last name and status of the
        /// chosen employee from the list
        /// </summary>
        public void FillSelectedEmployeeData()
        {
            string[] words = lstEmployees.SelectedItem.ToString().Split('|');
            int chosenEmployeeId = int.Parse(words[0]);
            bool flag = true;

            for (int i = 0; i < employees.Length && flag; i++)
            {
                if (employees[i].ID == chosenEmployeeId)
                {
                    employee = employees[i];
                    flag = false;
                }
            }
            txtEmployeeName.Text = employee.FirstName;
            txtEmployeeLname.Text = employee.LastName;

            cbEmployeeStatus.Checked = (employee.Status == 1) ? true : false;
        }

        /// <summary>
        /// method to check if the user put correct input in the employee fields
        /// </summary>
        /// <returns>
        /// res = true - all inputs correct
        /// res = false - one or more from the inputs is incorrect
        /// </returns>
        public bool inputChecks()
        {
            bool res = true;
            if (Checks.IsEmptyString(txtEmployeeLname.Text) || Checks.IsEmptyString(txtEmployeeName.Text))
            {
                res = false;
                MessageBox.Show("אחד או יותר מהשדות ריקים!", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checks.IsStringIsContainLettersOrNumbers(txtEmployeeName.Text))
            {
                res = false;
                MessageBox.Show("שם פרטי יכול להכיל רק אותיות בעברית!", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

        /// <summary>
        /// mehtod wich clean all the fields in the form
        /// </summary>
        public void CleanFields()
        {
            FillEmployeesList();
            txtEmployeeName.Text = string.Empty;
            txtEmployeeLname.Text = string.Empty;
            cbEmployeeStatus.Checked = false;
            btnUpdateEmployee.Enabled = false;
            btnAddEmployee.Enabled = true;
        }

        /// <summary>
        /// method wich fill the emloyee object with the details from the fields
        /// </summary>
        private void FillDataToUpdateEmployee()
        {
            employee.FirstName = txtEmployeeName.Text;
            employee.LastName = txtEmployeeLname.Text;
            employee.Status = (cbEmployeeStatus.Checked) ? 1 : 0;
        }

        /// <summary>
        /// method wich works when the user press on "show all employess" button
        /// the method will fill the employess list with the employees details
        /// </summary>
        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            FillEmployeesList();
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
        /// method wich works when the user press on "clean fields" button
        /// the method clean all the fields in the form
        /// </summary>
        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        /// <summary>
        /// method wich works when the user select employee from the employees list
        /// the method will fill all the fields with the selected emplyee details
        /// </summary>
        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Checks.IsItemSelected(lstEmployees))
            {
                btnUpdateEmployee.Enabled = true;
                btnAddEmployee.Enabled = false;
                FillSelectedEmployeeData();
            }
            
        }

        /// <summary>
        /// method wich works when the user press on "add employee" button
        /// the method will check the inputs and insert the new employee to data base
        /// </summary>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (inputChecks())
            {
                employee = new Employee();
                employee.FirstName = txtEmployeeName.Text;
                employee.LastName = txtEmployeeLname.Text;
                employee.Status = 1;
                db.InsertNewEmployee(employee);
                MessageBox.Show("העובד התווסף בהצלחה!", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanFields();
            }
        }

        /// <summary>
        /// method wich works when the user press on "update employee" button
        /// the method will check the inputs and update the spcific employee details
        /// </summary>
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (inputChecks())
            {
                FillDataToUpdateEmployee();
                db.UpdateEmployee(employee);
                MessageBox.Show("פרטי העובד עודכנו בהצלחה!", " הודעת מערכת ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanFields();
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
            string res = string.Empty;
            if (parameterToSearch == "שם פרטי")
                res = "firstName";
            if (parameterToSearch == "שם משפחה")
                res = "lastName";
            return res;
        }

        /// <summary>
        /// method wich works when the user write on search txt
        /// the method will get the text and search the employess by the right parameter
        /// </summary>
        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            string querry = string.Empty;
            querry = "SELECT * FROM `employees` WHERE " + "`" + ParameterToColumnName(cboParameterToSearch.Text) + "`" + " LIKE '" + txtSearchEmployee.Text + "%'";
            Employee[] searcEmployees = db.GetEmployeeDataSearch(querry);//get the customers data

            lstEmployees.Items.Clear();
            for (int i = 0; i < searcEmployees.Length; i++)
            {
                lstEmployees.Items.Add(searcEmployees[i].ToString());
            }
        }
    }
}
