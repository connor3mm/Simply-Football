using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Simply_Football
{
    /// <summary>
    /// Person class to hold players and youth players
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Declares private variables
        /// </summary>
        protected int personID;
        protected string name;
        protected int yearOfBirth;
        protected Address address;
        protected string telNum;
        protected string mobileNum;
        protected string email;
        protected string position;
        protected string doctor;


        /// <summary>
        /// read/write property for attribute name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// read/write property for attribute year
        /// </summary>
        public int Year
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                yearOfBirth = value;
            }
        }


        /// <summary>
        /// read only accessor method for address
        /// </summary>
        public Address Address
        {
            get
            {
                return address;
            }
        }

        /// <summary>
        /// read/write accessor method for telephone number
        /// </summary>
        public string TelNum
        {
            get
            {
                return telNum;
            }
            set
            {
                telNum = value;
            }
        }

        /// <summary>
        /// read/write accessor method for mobile
        /// </summary>
        public string Mobile
        {
            get
            {
                return mobileNum;
            }
            set
            {
                mobileNum = value;
            }
        }

        /// <summary>
        /// read/write accessor method for email
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        /// <summary>
        /// read/write accessor method for SFA id
        /// </summary>
        public int SFAid
        {
            get { return personID; }
            set { personID = value; }
        }

        /// <summary>
        /// read/write accessor method for position
        /// </summary>
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        /// <summary>
        /// read/write accessor method for Doctor
        /// </summary>
        public string Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }


        /// <summary>
        /// Setter method for Address
        /// currently has no protection
        /// </summary>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postcode</param>
        public void setAddress(string strst, string strtwn, string
       strpc)
        {
            address.Street = strst;
            address.Town = strtwn;
            address.Postcode = strpc;
        }


        /// <summary>
        /// default Person constructor
        /// sets all variables to default
        /// </summary>
        public Person()
        {
            SFAid = 0;
            address = new Address();
            setAddress("unknown", "unknown", "unknown");
            Year = 0;
            Name = "No name";
            TelNum = "no number";
            Mobile = "No number";
            Email = "No Email";
            Position = "Unknown";
            Doctor = "Unknown";
        }


        /// <summary>
        /// overriden constructor
        /// </summary>
        /// <param name="id">identification</param>
        /// <param name="strn">name</param>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postcode</param>
        /// <param name="yr">year</param>
        /// <param name="tel">telephone</param>
        /// <param name="mob">mobile</param>
        /// <param name="mail">email</param>
        /// <param name="pos">postion</param>
        /// <param name="doc">doctor</param>
        public Person(int id, String strn, string strst, string strtwn, string
        strpc, int yr, string tel, string mob, string mail, string pos, string doc)
        {
            SFAid = id;
            address = new Address();
            setAddress(strst, strtwn, strpc);
            Year = yr;
            Name = strn;
            TelNum = tel;
            Mobile = mob;
            Email = mail;
            Position = pos;
            Doctor = doc;
        }


        /// <summary>
        /// overriden ToString method
        /// </summary>
        /// <returns>string representation of person</returns>
        public override string ToString()
        {
            string strout = SFAid + "\n" + Name + "\n" + Year + "\n"
                + TelNum + "\n" + Mobile + "\n" + Email + "\n"
                + Position + "\n" + Doctor;
            strout = strout + address;
            return strout;
        }
    }



    /// <summary>
    /// player class that holds player attributes
    /// </summary>
    class Player : Person
    {
        /// <summary>
        /// private variables for player
        /// </summary>
        private string nextOfKin;
        private string kinTele;

        /// <summary>
        /// get/set for next of kin
        /// </summary>
        public string NextOfKin
        {
            get { return nextOfKin; }
            set { nextOfKin = value; }
        }

        /// <summary>
        /// get/set for next of kin phone number
        /// </summary>
        public string KinTele
        {
            get { return kinTele; }
            set { kinTele = value; }
        }


        /// <summary>
        /// calls base constructor
        /// sets attributes to default
        /// </summary>
        public Player() : base()
        {
            NextOfKin = "Unknown";
            KinTele = "no number";
        }


        /// <summary>
        /// overridden constructor
        /// </summary>
        /// <param name="id">identification</param>
        /// <param name="strn">name</param>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postcode</param>
        /// <param name="yr">year</param>
        /// <param name="tel">telephone</param>
        /// <param name="mob">mobile</param>
        /// <param name="mail">email</param>
        /// <param name="pos">position</param>
        /// <param name="doc">doctor</param>
        /// <param name="nxtKin">next of kin</param>
        /// <param name="kinNum">kin number</param>
        public Player(int id, String strn, string strst, string strtwn, string
        strpc, int yr, string tel, string mob, string mail, string pos, string doc, string nxtKin, string kinNum) : base(id, strn, strst, strtwn,
        strpc, yr, tel, mob, mail, pos, doc)
        {
            NextOfKin = nxtKin;
            KinTele = kinNum;
        }


        /// <summary>
        /// overriden to string method 
        /// </summary>
        /// <returns>string represting player</returns>
        public override string ToString()
        {
            string strout = SFAid + "\n" + Name + "\n" + Year + "\n"
                + TelNum + "\n" + Mobile + "\n" + Email + "\n"
                + Position + "\n" + Doctor + "\n" + NextOfKin + "\n" + KinTele;
            strout = strout + "\n" + Address;
            return strout;
        }
    }



    /// <summary>
    /// youth class that holds youth attributes
    /// </summary>
    class Youth : Person
    {
        /// <summary>
        /// private variables
        /// </summary>
        private String guardianName;
        private string relationship;
        private string guardiantele;


        /// <summary>
        /// get/set for guardians name
        /// </summary>
        public string GuardianName
        {
            get { return guardianName; }
            set { guardianName = value; }
        }

        /// <summary>
        /// get/set for guardians relationship
        /// </summary>
        public string Relationship
        {
            get { return relationship; }
            set { relationship = value; }
        }

        /// <summary>
        /// get/set for guardian telephone num
        /// </summary>
        public string Guardiantele
        {
            get { return guardiantele; }
            set { guardiantele = value; }
        }


        /// <summary>
        /// overridden constructor for youth
        /// </summary>
        /// <param name="id">identification</param>
        /// <param name="strn">name</param>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postcode</param>
        /// <param name="yr">year</param>
        /// <param name="tel">telephone</param>
        /// <param name="mob">mobile</param>
        /// <param name="mail">email</param>
        /// <param name="pos">postion</param>
        /// <param name="doc">doctor</param>
        /// <param name="guardNm">guardian name</param>
        /// <param name="rel">relationship</param>
        /// <param name="guardNum">guardian number</param>
        public Youth(int id, String strn, string strst, string strtwn, string
        strpc, int yr, string tel, string mob, string mail, string pos, string doc, string guardNm, String rel, string guardNum) : base(id, strn, strst, strtwn,
        strpc, yr, tel, mob, mail, pos, doc)
        {
            GuardianName = guardNm;
            Relationship = rel;
            Guardiantele = guardNum;
        }


        /// <summary>
        /// overriden to string method 
        /// </summary>
        /// <returns>string representing youth player</returns>
        public override string ToString()
        {
            string strout = SFAid + "\n" + Name + "\n" + Year + "\n"
                + TelNum + "\n" + Mobile + "\n" + Email + "\n"
                + Position + "\n" + Doctor + "\n" + GuardianName + "\n" + Relationship + "\n" + Guardiantele;
            strout = strout + "\n" + Address;
            return strout;
        }
    }
}


