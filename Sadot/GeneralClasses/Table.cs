/*
 * Table class code
 * class of table properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    public class Table
    {
        private int tableID;
        private string tableStatus;
        private string orderState;
        private DateTime timeOfOrder;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Table(int id, string status, string orderState, DateTime timeOfOrder)
        {
            tableID = id;
            tableStatus = status;
            OrderState = orderState;
            TimeOfOrder = timeOfOrder;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Table()
        {
            tableID = -1;
        }

        /// <summary>
        /// TableID property ( get , set )
        /// </summary>
        public int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }

        /// <summary>
        /// TableStatus property ( get , set )
        /// </summary>
        public string TableStatus
        {
            get { return tableStatus; }
            set { tableStatus = value; }
        }

        public string OrderState
        {
            get { return orderState; }
            set { orderState = value; }
        }

        public DateTime TimeOfOrder
        {
            get { return timeOfOrder; }
            set { timeOfOrder = value; }
        }

        public bool OrderInProcess()
        {
            return (OrderState == "הזמנה בהכנה");
        }

        public bool OrderStateNotExists()
        {
            return (OrderState == "לא קיימת הזמנה");
        }

        public bool IsTableAvailable()
        {
            return (TableStatus == "פנוי");
        }

        public bool IsTableInBill()
        {
            return (TableStatus == "בחשבון");
        }

        public DateTime GetTimeOfOrderCalculation()
        {
            DateTime result = TimeOfOrder;

            if (OrderInProcess())
            {
                result = DateTime.Now - TimeOfOrder.TimeOfDay;
            }

            return result;
        }
    }
}
