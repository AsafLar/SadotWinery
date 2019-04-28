/*
 * Ingredients class code
 * class of ingredients properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class Ingredients
    {
        private int id;
        private string name;
        private int quantity;


        /// <summary>
        /// Constractor function 
        /// </summary>
        /// <param name="diID"></param>
        /// <param name="diName"></param>
        /// <param name="diQuantity"></param>
        public Ingredients(int diID, string diName, int diQuantity)
        {
            id = diID;
            name = diName;
            quantity = diQuantity;
        }

        /// <summary>
        /// Constractor
        /// </summary>
        public Ingredients()
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
        /// Quantity ( get , set )
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
