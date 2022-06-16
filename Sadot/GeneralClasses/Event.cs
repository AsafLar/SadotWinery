/*
 * Event class code
 * class of event properties and functions
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadot
{
    class Event
    {
        private int eventId;
        private string eventType;
        private DateTime eventDate;
        private DateTime eventTime;
        private int numOfParticipants;
        private string ownerFname;
        private string ownerLname;
        private string ownerEmail;
        private string ownerPhone;
        private string eventNotes;

        /// <summary>
        /// Constractor function
        /// </summary>
        public Event(int eID, string eType, DateTime eDate, DateTime eTime, int participants, string fname, string lname, string email, string phone, string notes)
        {
            eventId = eID;
            eventType = eType;
            eventDate = eDate;
            eventTime = eTime;
            numOfParticipants = participants;
            ownerFname = fname;
            ownerLname = lname;
            ownerEmail = email;
            ownerPhone = phone;
            eventNotes = notes;
        }

        /// <summary>
        /// Constractor function
        /// </summary>
        public Event()
        {
            eventId = -1;
        }

        /// <summary>
        /// EventId ( get , set )
        /// </summary>
        public int EventId
        {
            get { return eventId; }
            set { eventId = value; }
        }

        /// <summary>
        /// EventType ( get , set )
        /// </summary>
        public string EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }

        /// <summary>
        /// EventDate ( get , set )
        /// </summary>
        public DateTime EventDate
        {
            get { return eventDate; }
            set { eventDate = value; }
        }

        /// <summary>
        /// EventTime ( get , set )
        /// </summary>
        public DateTime EventTime
        {
            get { return eventTime; }
            set { eventTime = value; }
        }

        /// <summary>
        /// NumOfParticipants ( get , set )
        /// </summary>
        public int NumOfParticipants
        {
            get { return numOfParticipants; }
            set { numOfParticipants = value; }
        }

        /// <summary>
        /// OwnerFname ( get , set )
        /// </summary>
        public string OwnerFname
        {
            get { return ownerFname; }
            set { ownerFname = value; }
        }

        /// <summary>
        /// OwnerLname ( get , set )
        /// </summary>
        public string OwnerLname
        {
            get { return ownerLname; }
            set { ownerLname = value; }
        }

        /// <summary>
        /// OwnerEmail ( get , set )
        /// </summary>
        public string OwnerEmail
        {
            get { return ownerEmail; }
            set { ownerEmail = value; }
        }

        /// <summary>
        /// OwnerPhone ( get , set )
        /// </summary>
        public string OwnerPhone
        {
            get { return ownerPhone; }
            set { ownerPhone = value; }
        }

        /// <summary>
        /// EventNotes ( get , set )
        /// </summary>
        public string EventNotes
        {
            get { return eventNotes; }
            set { eventNotes = value; }
        }

        /// <summary>
        /// ToString method
        /// </summary>
        public override string ToString()
        {
            return EventType + " | " + eventTime.ToString("HH:mm") + " | " + OwnerFname + " " + OwnerLname;
        }

    }
}
