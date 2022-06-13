/*
 * User class code
 * class of user properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class User
    {
        private int userID;
        private string userName;
        private string password;
        private string permission; // TODO::YARON - Use enum

        /// <summary>
        /// Constractor function
        /// </summary>
        public User(int id, string uUserName, string uPassword)
        {
            userID = id;
            userName = uUserName;
            password = uPassword;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public User()
        {
            userID = -1;
        }

        /// <summary>
        /// UserID ( get , set )
        /// </summary>
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        ///  UserName ( get , set )
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        /// <summary>
        ///  Password ( get , set )
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        /// <summary>
        ///  Permission ( get , set )
        /// </summary>
        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }

    }
}
