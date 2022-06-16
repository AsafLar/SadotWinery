/*
 * Employee class code
 * class of employee properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private int status;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Employee()
        {
            id = -1;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Employee(int e_id, string e_firstName, string e_lastName, int e_status)
        {
            id = e_id;
            firstName = e_firstName;
            lastName = e_lastName;
            status = e_status;
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
        /// FirstName ( get , set )
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// LastName ( get , set )
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// Status ( get , set )
        /// </summary>
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// method wich returns the employee full name
        /// </summary>
        /// <returns>string - employee full name</returns>
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        /// <summary>
        /// ToString method
        /// </summary>
        public override string ToString()
        {
            string resString = id + "  |  " + firstName + " " + lastName;
            if (status == 0)
                resString += "  -  לא פעיל";
            return resString;
        }
    }
}