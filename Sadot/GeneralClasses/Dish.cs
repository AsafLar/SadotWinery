/*
 * Dish class code
 * class of dish properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class Dish
    {
        private int id;
        private string name;
        private int price;
        private int status;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Dish(int dID, string dName, int dPrice , int dStatus)
        {
            id = dID;
            name = dName;
            price = dPrice;
            status = dStatus;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Dish()
        {
            id = -1;
        }

        /// <summary>
        /// ID ( get , set )
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Name ( get , set )
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
        /// Status ( get , set )
        /// </summary>
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        
    }
}
