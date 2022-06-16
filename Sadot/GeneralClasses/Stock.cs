/*
 * Stock class code
 * class of stock properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class Stock
    {
        private string date;
        private int productID;
        private string name;
        private double totalAmount;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Stock(string sDate , string sName , int sProductID , int sTotalAmount)
        {
            date = sDate;
            name = sName;
            productID = sProductID;
            totalAmount = sTotalAmount;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Stock()
        {
            productID = -1;
        }

        /// <summary>
        /// ProductID property ( get , set )
        /// </summary>
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        /// <summary>
        /// Name property ( get , set )
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Date property ( get , set )
        /// </summary>
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// TotalAmount property ( get , set )
        /// </summary>
        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
    }
}
