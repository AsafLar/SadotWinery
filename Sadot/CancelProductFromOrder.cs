/*
 * CancelProductFromOrder form code
 * class with the code of the form of cancle product from order details this form shows when the user press on "cancle product" button
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class CancelProductFromOrder : Form
    {

        public string cancellationReason;

        /// <summary>
        /// form constractor
        /// </summary>
        public CancelProductFromOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CancellationReason propertty ( get , set )
        /// </summary>
        public string CancellationReason
        {
            get { return cancellationReason; }
            set { cancellationReason = value; }
        }

        /// <summary>
        /// method wich works when the user press on "cancle product" button
        /// the method will save the cancle details (rason and if provided)
        /// and bring back the information to the order object
        /// </summary>
        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            if (Checks.IsEmptyString(rtbReasonForCancellation.Text))
            {
                MessageBox.Show("לא נרשמה סיבת הביטול!!");
            }
            if (rbProvided.Checked == false && rbNotProvided.Checked == false)
            {
                MessageBox.Show("יש לבחור המוצר סופק או המוצר לא סופק");
            }
            else
            {
                btnCancelProduct.DialogResult = DialogResult.OK;
                btnCancelProduct.Enabled = true;
                if (rbProvided.Checked == true)
                    CancellationReason = rtbReasonForCancellation.Text + " " + rbProvided.Text;
                else
                    CancellationReason = rtbReasonForCancellation.Text + " " + rbNotProvided.Text;
            }
        }


    }
}
