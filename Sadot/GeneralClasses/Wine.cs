/*
 * Wine class code
 * class of wine properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    public class Wine
    {
        private int wineID;
        private string name;
        private string year;
        private int priceBottle;
        private int priceGlass;
        private bool status;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Wine(int wID, string wName, string wYear ,  int wPriceBottle , int wPriceGlass , bool wStatus)
        {
            wineID = wID;
            name = wName;
            year = wYear;
            priceBottle = wPriceBottle;
            priceGlass = wPriceGlass;
            status = wStatus;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Wine()
        {
            wineID = -1;
        }


        /// <summary>
        /// WineID ( get , set )
        /// </summary>
        public int WineID
        {
            get { return wineID; }
            set { wineID = value; }
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
        /// Year ( get , set )
        /// </summary>
        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        /// <summary>
        /// PriceBottle ( get , set )
        /// </summary>
        public int PriceBottle
        {
            get { return priceBottle; }
            set { priceBottle = value; }
        }

        /// <summary>
        /// PriceGlass ( get , set )
        /// </summary>
        public int PriceGlass
        {
            get { return priceGlass; }
            set { priceGlass = value; }
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
        /// ToString method
        /// </summary>
        public override string ToString()
        {
            string res = wineID + "  |  " + year + "  |  " + name;
            res += (status == true) ? "" : "  -  לא בתפריט";
            return res;
        }
    }
}
