/*
 * Order class code
 * class of order properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    public class Order
    {
        private int orderID;
        private int tableID;
        private int customerID;
        private int totalPrice;
        private int discount;
        private bool isPaid;
        private DateTime orderDate;
        private int employeeID;
        private string cancels;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Order(int oID, int tID, int cID, int tPrice, int oDiscount , bool paid, DateTime oDate)
        {
            orderID = oID;
            tableID = tID;
            customerID = cID;
            totalPrice = tPrice;
            discount = oDiscount;
            isPaid = paid;
            orderDate = oDate;
            cancels = "No";
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Order()
        {
            customerID = -1;
            totalPrice = 0;
            discount = 0;
            isPaid = false ;
            orderDate = DateTime.Now.Date;
            cancels = "No";
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
        /// TableID ( get , set )
        /// </summary>
        public int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }

        /// <summary>
        /// CustomerId ( get , set )
        /// </summary>
        public int CustomerId
        {
            get { return customerID; }
            set { customerID = value; }
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
        /// Discount ( get , set )
        /// </summary>
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        
        /// <summary>
        /// IsPaid ( get , set )
        /// </summary>
        public bool IsPaid
        {
            get { return isPaid; }
            set { isPaid = value; }
        }

        /// <summary>
        /// OrderDate ( get , set )
        /// </summary>
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        /// <summary>
        /// WaiterID ( get , set )
        /// </summary>
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        /// <summary>
        /// Cancels ( get , set )
        /// </summary>
        public string Cancels
        {
            get { return cancels; }
            set { cancels = value; }
        }

        public bool isCancels()
        {
            return (this.Cancels == "Yes") ? true : false;
        }

    }
}
