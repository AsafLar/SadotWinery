/*
 * GlassOrBottle form code
 * class with the code of the form of glass/bottle/bottle take away when the user add wine to order
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
    public partial class GlassOrBottle : Form
    {

        public string result;

        /// <summary>
        ///  form Constructor
        /// </summary>
        /// <param name="glassPrice">the spcific wine glass price to check if equal to 0</param>
        public GlassOrBottle(int glassPrice)
        {
            InitializeComponent();
            result = null;
            if (glassPrice == 0) //if the price is 0 the bottle is not possible to order glass from
                btnGlass.Enabled = false;
        }

        /// <summary>
        /// Result property (get , set)
        /// </summary>
        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        /// <summary>
        /// method wich works when the user press on "glass" button
        /// the method will put in result that glass is ordered
        /// </summary>
        private void btnGlass_Click(object sender, EventArgs e)
        {
            Result = btnGlass.Text;
        }

        /// <summary>
        /// method wich works when the user press on "bottle" button
        /// the method will put in result that bottle is ordered
        /// </summary>
        private void btnBottle_Click(object sender, EventArgs e)
        {
            Result = btnBottle.Text;
        }

        /// <summary>
        /// method wich works when the user press on "bottle to take" button
        /// the method will put in result that bottle to take is ordered
        /// </summary>
        private void btnToTake_Click(object sender, EventArgs e)
        {
            Result = btnToTake.Text;
        }
    }
}
