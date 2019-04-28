/*
 * NumberOfGlass form code
 * class with the code of the form of number of glasses when the user add bottle of wine to order
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
    public partial class NumberOfGlass : Form
    {
        public string number;

        /// <summary>
        /// Number property (get , set)
        /// </summary>
        public string Number
        {
            get { return number; }
        }

        /// <summary>
        /// NumberOfGlass form constructor
        /// </summary>
        public NumberOfGlass()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when NumberOfGlass form loads
        /// </summary>
        private void NumberOfGlass_Load(object sender, EventArgs e)
        {
            nudMoreThan9.Visible = false;
            btnOK.Visible = false;
        }

        /// <summary>
        /// method wich works when the user press on "else" button 
        /// the method will open numeric field to enter number of glasses
        /// </summary>
        private void btnElse_Click(object sender, EventArgs e)
        {
            nudMoreThan9.Visible = true;
            btnOK.Visible = true;
        }

        /// <summary>
        /// method wich works when the user press on one of the numbers buttons
        /// the method will set the number to spcific button number
        /// </summary>
        private void btn_Click(object sender, EventArgs e)
        {
            number = ((Button)sender).Text;
        }

        /// <summary>
        /// method wich works when the user press on "ok" button 
        /// the method will set the number to spcific glasses number
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            number = nudMoreThan9.Value.ToString();
        }
    }
}
