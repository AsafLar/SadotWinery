/*
 * MyBtn class code
 * class of special button with the id of the product pressed
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class MyBtn : System.Windows.Forms.Button
    {
        private int id;

        /// <summary>
        /// ID property (get , set)
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
