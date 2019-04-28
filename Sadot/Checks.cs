/*
 * Checks class code
 * class of functions wich used to input checks
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sadot
{
    public static class Checks
    {

        /// <summary>
        /// function to check if string contains any numbers
        /// </summary>
        /// <param name="strToCheck">the string to check<</param>
        /// <returns> true if contains numbers false other</returns>
        public static bool IsStringContainNumbers(string strToCheck)
        {
            return Regex.IsMatch(strToCheck, @"\d");
        }

        /// <summary>
        /// function to check if string contains any letter or special character
        /// </summary>
        /// <param name="strToCheck">the string to check</param>
        /// <returns> true if valid false other </returns>
        public static bool IsStringIsContainLettersOrNumbers(string strToCheck)
        {
            bool res = false;
            if (!Regex.IsMatch(strToCheck, @"^[a-zA-z]+$"))
                res = true;
            if (Regex.IsMatch(strToCheck, @"\d"))
                res = true;
            return res;
        }

        /// <summary>
        /// function to check if phone is valid (contains only numbers)
        /// </summary>
        /// <param name="strToCheck">the string to check</param>
        /// <returns> true if valid false other</returns>
        public static bool IsValidPhone(string strToCheck)
        {
            return Regex.IsMatch(strToCheck, @"^\d+$");
        }

        /// <summary>
        /// function to check if string is valid email
        /// </summary>
        /// <param name="strToCheck">the string to check if valid email</param>
        /// <returns> true if valid false other </returns>
        public static bool IsValidEmail(string strToCheck)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(strToCheck);
                return addr.Address == strToCheck;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// function to check if string is an emty string
        /// </summary>
        /// <param name="strToCheck">the string to check<</param>
        /// <returns> true if empty false other</returns>
        public static bool IsEmptyString(string strToCheck)
        {
            return String.IsNullOrEmpty(strToCheck);
        }

        /// <summary>
        /// method wich checks if listbox item is selected
        /// </summary>
        /// <param name="lst">the list to check</param>
        /// <returns>true if item selected false other</returns>
        public static bool IsItemSelected(System.Windows.Forms.ListBox lst)
        {
            return (lst.SelectedItem == null) ? false : true;
        }

        /// <summary>
        /// method wich checks if item is positive number
        /// </summary>
        /// <param name="number">the number to check</param>
        /// <returns>true if positive false other</returns>
        public static bool IsNumberPositive(int number)
        {
            return (number >= 0) ? false : true;
        }

        /// <summary>
        /// method wich checks if datagrid item is selected
        /// </summary>
        /// <param name="lst">the datagrid to check</param>
        /// <returns>true if item selected false other</returns>
        public static bool IsItemSelectedInDataGridView(System.Windows.Forms.DataGridView dgv)
        {
            return (dgv.SelectedRows == null) ? false : true;
        }

    }
}
