/*
 * Customer class code
 * class of customer properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string city;
        private string dateOfBirth;
        private string anniversary;
        private int status;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Customer(int cID, string cFirstName, string cLastName, string cEmail, string cPhone, string cCity, string cDateOfBirth, string cAnniversary, int cStatus)
        {
            customerId = cID;
            firstName = cFirstName;
            lastName = cLastName;
            email = cEmail;
            phone = cPhone;
            city = cCity;
            dateOfBirth = cDateOfBirth;
            anniversary = cAnniversary;
            status = cStatus;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Customer()
        {
            customerId = -1;
        }

        /// <summary>
        /// CustomerId ( get , set )
        /// </summary>
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
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
        /// Email ( get , set )
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Phone ( get , set )
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// City ( get , set )
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// DateOfBirth ( get , set )
        /// </summary>
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        /// <summary>
        /// Anniversary ( get , set )
        /// </summary>
        public string Anniversary
        {
            get { return anniversary; }
            set { anniversary = value; }
        }

        /// <summary>
        /// Status (get , set)
        /// </summary>
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// method wich returns the customer full name
        /// </summary>
        /// <returns>string - customer full name</returns>
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        /// <summary>
        /// ToString method
        /// </summary>
        public override string ToString()
        {
            string resString = customerId + "  |  " + firstName + " " + lastName;
            if (status == 0)
                resString += "  -  לא פעיל";
            return resString;
        }
    }
}
