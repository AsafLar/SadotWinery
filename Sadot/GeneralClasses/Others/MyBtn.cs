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

        public MyBtn() {}

        public MyBtn(int id, System.EventHandler onClickEvent)
        {
            ID = id;
            BackColor = System.Drawing.Color.White;
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            Name = "btnTable" + id;
            Text = id.ToString();
            UseVisualStyleBackColor = false;
            Click += onClickEvent;
        }

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
