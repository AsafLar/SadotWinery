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
        private string m_orderState;
        private DateTime m_timeOfOrder;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Table(int id , string status, string orderState, DateTime timeOfOrder)
        {
            tableID = id;
            tableStatus = status;
            m_orderState = orderState;
            m_timeOfOrder = timeOfOrder;
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
            get { return m_orderState; }
            set { m_orderState = value; }
        }

        public DateTime TimeOfOrder
        {
            get { return m_timeOfOrder; }
            set { m_timeOfOrder = value; }
        }

    }
}
