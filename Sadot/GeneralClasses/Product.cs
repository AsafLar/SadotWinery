/*
 * Product class code
 * class of product properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
     class Product
    {

        private int productID;
        private string name;
        private int price;
        private string type;
        private string department;
        private bool status;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Product(int id, string pName, int pPrice, string pType , string pDepartment , bool pStatus)
        {
            productID = id;
            name = pName;
            price = pPrice;
            type = pType;
            department = pDepartment;
            status = pStatus;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Product()
        {
            productID = -1;
        }

        /// <summary>
        /// ProductId ( get , set )
        /// </summary>
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        /// <summary>
        /// Type ( get , set )
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Price ( get , set )
        /// </summary>
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Type ( get , set )
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Department ( get , set )
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        /// <summary>
        /// Status ( get , set )
        /// </summary>
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// ToString mehtod
        /// </summary>
        public override string ToString()
        {
            string res = productID + "  |  " + name + "  |  " + price + "  |  " + department;
            res += (status == true) ? "" : "  -  לא בתפריט";
            return res;
        }
    }
}
