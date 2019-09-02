/*
 * LinesInOrder class code
 * class of line in order properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    public class LinesInOrder
    {
        private int orderID;
        private int productID;
        private string productName;
        private int amount;
        private int totalPrice;
        private string notes;

        /// <summary>
        /// Constractor function
        /// </summary>
        public LinesInOrder()
        {
            orderID = -1;
            amount = 1;
            totalPrice = -1;
            notes = "";
        }

        /// <summary>
        /// OrderID ( get , set )
        /// </summary>
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        /// <summary>
        /// ProductID ( get , set )
        /// </summary>
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        /// <summary>
        /// ProductName ( get , set )
        /// </summary>
        public string ProductName
        {
            get { return productName; }
            set { productName = value;}
        }

        /// <summary>
        /// Amount ( get , set )
        /// </summary>
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// TotalPrice ( get , set )
        /// </summary>
        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        /// <summary>
        /// Notes ( get , set )
        /// </summary>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
    }
}
