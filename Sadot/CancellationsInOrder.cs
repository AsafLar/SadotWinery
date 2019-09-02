using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class CancellationsInOrder
    {
        private int cancleId;
        private int orderId;
        private int productId;
        private string productName;
        private int priceToSub;

        /// <summary>
        /// Constractor function
        /// </summary>
        public CancellationsInOrder()
        {
            cancleId = -1;
        }

        /// <summary>
        /// CustomerId ( get , set )
        /// </summary>
        public int CancleId
        {
            get { return cancleId; }
            set { cancleId = value; }
        }

        /// <summary>
        /// CustomerId ( get , set )
        /// </summary>
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        /// <summary>
        /// CustomerId ( get , set )
        /// </summary>
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        /// <summary>
        /// FirstName ( get , set )
        /// </summary>
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        /// <summary>
        /// Status (get , set)
        /// </summary>
        public int PriceToSub
        {
            get { return priceToSub; }
            set { priceToSub = value; }
        }
    }
}
