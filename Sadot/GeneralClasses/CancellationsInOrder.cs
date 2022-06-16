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

        public string printName()
        {
            return this.productName + "(בוטל)";
        }

        //public string printNameForRecipt(DBSQL db)
        //{
        //    if (this.ProductId > 4000 && this.ProductId < 6000)
        //        this.
        //    Product canceledProdcut = db.GetProductById(this.ProductId);

        //    if("Dish" == canceledProdcut.Type)
        //       return canceledProdcut.Name + "-בוטל";
        //    else
        //       return this.productName + "-בוטל";
        //}

        public string printNameForRecipt(DBSQL db)
        {
            Product canceledProdcut;
            string result = string.Empty;

            if (this.ProductId > 4000 && this.ProductId < 6000)
                this.ProductId -= 4000;
            if (this.ProductId > 6000)
                this.ProductId -= 6000;

            canceledProdcut = db.GetProductById(this.ProductId);

            if ("Dish" == canceledProdcut.Type)
                result = canceledProdcut.Name + "-בוטל";
            else if ("Wine" == canceledProdcut.Type)
            {
                string[] str = this.ProductName.Split('-');
                if(str[1] == "בקבוק לקחת")
                    result = str[0] + "\n" + str[1] + "\n" + "בוטל";
                else
                    result = str[0] + "\n" + str[1] + "-בוטל";
            }
            else
                result = this.productName + "-בוטל";

            return result;
        }
    }
}
