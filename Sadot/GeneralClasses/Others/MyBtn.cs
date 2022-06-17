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

        public MyBtn()
        {

        }

        public MyBtn(int id, System.EventHandler onClickEvent)
        {
            this.id = id;
            this.BackColor = System.Drawing.Color.White;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "btnTable" + id;
            this.Text = id.ToString();
            this.UseVisualStyleBackColor = false;
            this.Click += onClickEvent;
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
