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
        /// Copy Constractor function
        /// </summary>
        public LinesInOrder(LinesInOrder instance_of)
        {
            this.orderID = instance_of.orderID;
            this.productID = instance_of.productID;
            this.productName = instance_of.productName;
            this.amount = instance_of.amount;
            this.totalPrice = instance_of.totalPrice;
            this.notes = instance_of.notes;
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

        public bool isLineGlass()
        {
            return (this.Notes == "כוס");
        }

        public bool isLineTakeAwayBottle()
        {
            return (this.Notes == "בקבוק לקחת");
        }

        public bool isLineBottle()
        {
            return (this.Notes != "none" && this.Notes != "" && this.Notes != "כוס" && this.Notes != "בקבוק לקחת" && this.Notes.All(char.IsNumber));

            //return (this.Notes.All(char.IsNumber) || (this.Notes != "none" && this.Notes != "" && this.Notes != "כוס"));

        }

        public int getProductPrice()
        {
            int retVal = 0;
            if(TotalPrice != 0)
            {
                retVal = this.TotalPrice / this.Amount;
            }
            return retVal;
        }
    }
}
