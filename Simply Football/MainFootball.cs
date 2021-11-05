using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Simply_Football
{
    public class Football
    {
        /// <summary>
        /// Singleton object
        /// </summary>
        private static Football football;

        // declares and initialises a constant
        private const string FILE_NAME = "dummyprinter.txt";


        /// <summary>
        /// Instance property returns the singleton instance
        /// </summary>
        public static Football Instance
        {
            get
            {
                if (football == null)
                    football = new Football();
                return football;
            }
        }


        /// <summary>
        /// Instance variables
        /// </summary>
        private List<Person> person;

        /// <summary>
        /// Instance variables
        /// </summary>
        private List<Profile> profile;


        /// <summary>
        /// default football constructor
        /// </summary>
        public Football()
        {
            person = new List<Person>();
            profile = new List<Profile>();

        }

        /// <summary>
        /// read only accessor method for AllPeople
        /// </summary>
        public List<Person> AllPeople
        {
            get
            {
                return person;
            }
        }

        /// <summary>
        /// read only accessor method for profiles
        /// </summary>
        public List<Profile> profiles
        {
            get
            {
                return profile;
            }
        }

        /// <summary>
        /// Calculates next person id.
        /// </summary>
        /// <returns>new person id</returns>
        public int getNextPersonNum()
        {
            int id = person.Count + 1;
            return id;
        }


        /// <summary>
        /// Setter method for addding player
        /// </summary>
        /// <param name="strn">Name of person</param>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postcode</param>
        /// <param name="yr">year of birth</param>
        /// <param name="tel">telephone</param>
        /// <param name="mob">mobile</param>
        /// <param name="mail">email</param>
        /// <param name="pos">position on pitch</param>
        /// <param name="doc">doctor</param>
        /// <param name="nxtKin">next of kin</param>
        /// <param name="kinNum">next of kin number</param>
        public void addPlayer(String strn, string strst, string strtwn, string
        strpc, int yr, string tel, string mob, string mail, string pos, string doc, string nxtKin, string kinNum)
        {
            int id = getNextPersonNum();
            Player a = new Player(id, strn, strst, strtwn, strpc, yr, tel, mob, mail, pos, doc, nxtKin, kinNum);
            person.Add(a);
        }


        /// <summary>
        /// Setter method for adding youth player
        /// </summary>
        /// <param name="strn">name</param>
        /// <param name="strst">street</param>
        /// <param name="strtwn">town</param>
        /// <param name="strpc">postcode</param>
        /// <param name="yr">year of birth</param>
        /// <param name="tel">telephone</param>
        /// <param name="mob">mobile</param>
        /// <param name="mail">email</param>
        /// <param name="pos">position on pitch</param>
        /// <param name="doc">doctor</param>
        /// <param name="guardNm">guardian number</param>
        /// <param name="rel">relationship</param>
        /// <param name="guardNum">guardian number</param>
        public void addYouth(string strn, string strst, string strtwn, string
            strpc, int yr, string tel, string mob, string mail, string pos, string doc, string guardNm, string rel, string guardNum)
        {
            int id = getNextPersonNum();
            Youth a = new Youth(id, strn, strst, strtwn, strpc, yr, tel, mob, mail, pos, doc, guardNm, rel, guardNum);
            person.Add(a);
        }


        /// <summary>
        /// Method to list all types of people in the list
        /// Throws exception if no entries 
        /// </summary>
        /// <returns>"no entries" if member count is zero
        /// if theres people in the list, lists all people</returns>
        public string getMembers()
        {
            string strPerson = "";

            if (person.Count == 0)
            {
                return "No Entries";
            }

            foreach (Person a in person)
            {
                strPerson = strPerson + a + "\n";
            }
            return "Football Members" + "\n\n" + strPerson;
        }


        /// <summary>
        /// Method to list all types of players in the list
        /// Throws exception if no entries
        /// </summary>
        /// <returns>"no entries" if member count is zero
        /// if theres players in the list, lists all players</returns>
        public string getPlayers()
        {
            string strPlayers = "";

            if (person.Count == 0)
            {
                return "No Entries";
            }

            foreach (Person a in person)
            {
                if (a is Player)
                {
                    strPlayers = strPlayers + a + "\n";
                }
            }
            return "Players: " + "\n\n" + strPlayers;
        }


        /// <summary>
        /// Method to list all types of players in the list
        /// Throws exception if no entries
        /// </summary>
        /// <returns>"no entries" if member count is zero
        /// if theres players in the list, lists all players</returns>
        public string getYouth()
        {
            string strYouth = "";

            if (person.Count == 0)
            {
                return "No Entries";
            }

            foreach (Person a in AllPeople)
            {
                if (a is Youth)
                {
                    strYouth = strYouth + a + "\n";
                }
            }
            return "Youth: " + "\n\n" + strYouth;
        }


        /// <summary>
        /// Calculates new profile id.
        /// </summary>
        /// <returns>new profile id</returns>
        public int getNextProNum()
        {
            int id = profile.Count + 1;

            return id;
        }


        /// <summary>
        /// setter method to add player profile
        /// if theres no profiles then first will be added
        /// otherwise will check if a profile for a certain person and season...
        /// already exists and throw an error message, if not, profile will be added
        /// </summary>
        /// <param name="headLvl">Heading skill level</param>
        /// <param name="shootLvl">shooting skill level</param>
        /// <param name="dribLvl">dribbling skill level</param>
        /// <param name="passLvl">passing skill level</param>
        /// <param name="tackleLvl">tackling skill level</param>
        /// <param name="comment">Overall comment on skills</param>
        /// <param name="p">Person that profile is added too</param>
        /// <param name="seas">which season it is</param>
        /// <returns>error message if profile exists
        /// success message if profile is added</returns>
        public string addProfile(int headLvl, int shootLvl, int dribLvl, int passLvl, int tackleLvl, string comment, Person p, int seas)
        {
            if (profiles.Count == 0)
            {
                int id = getNextProNum();
                Profile s = new Profile(id, headLvl, shootLvl, dribLvl, passLvl, tackleLvl, comment, p, seas);
                profile.Add(s);
            }
            else
            {
                foreach (Profile a in profiles)
                {
                    if (seas == a.Season && p == a.persons)
                    {
                        return "This player already has a profile sheet for this season.";
                    }
                }
                int id = getNextProNum();
                Profile s = new Profile(id, headLvl, shootLvl, dribLvl, passLvl, tackleLvl, comment, p, seas);
                profile.Add(s);
            }
            return "profile added";
        }


        /// <summary>
        /// finds each profile in the list
        /// </summary>
        /// <returns>error message if no profiles
        /// returns each profile if list has any</returns>
        public string getProfile()
        {
            string strProfile = "";

            if (profiles.Count == 0)
            {
                return "No Entries";
            }

            foreach (Profile a in profiles)
            {
                strProfile = strProfile + a + "\n";
            }
            return "Profile: " + "\n\n" + strProfile;
        }

        /* 
         * Didnt get to finish edit profile
         */

        ///// <summary>
        ///// method to edit player profile
        ///// </summary>
        ///// <param name="p">person</param>
        ///// <param name="season">season</param>
        ///// <returns>profile info if exists
        ///// error message if doesnt exist</returns>
        //public string editProfile(Person p, int season)
        //{
        //    string strProfile = "";
        //    foreach (Profile a in profiles)
        //    {
        //        if(p == a.persons && season == a.Season)
        //        {
        //            return strProfile = strProfile + a + "\n";
        //        } 
        //    }
        //    return "No profiles with this name and season";
        //}


        /// <summary>
        /// Find a singular profile
        /// </summary>
        /// <param name="p">person</param>
        /// <param name="season">season</param>
        /// <returns>profile, erro message</returns>
        public string findProfile(Person p, int season)
        {
            string strProfile = "";
            foreach (Profile a in profiles)
            {
                if (p == a.persons && season == a.Season)
                {
                    return strProfile = strProfile + a + "\n"; ;
                }
            }
            return "No profiles with this name and season";
        }


        /// <summary>
        /// Mehthod to delete a singular profile
        /// </summary>
        /// <param name="p">Instance of the list person</param>
        /// <param name="season">The season looking for</param>
        /// <returns>Message profile removed if successful
        /// Meesage no profiles if unsuccessful</returns>
        public string deleteProfile(Person p, int season)
        {
            foreach (Profile a in profiles)
            {
                if (p == a.persons && season == a.Season)
                {
                    profile.Remove(a);
                    return "Profile removed";
                }
            }
            return "No profiles with this name and season";
        }


        /// <summary>
        /// Creates new file to write all profiles too.
        /// </summary>
        /// <returns>File thats been written too</returns>
        public string printProfile()
        {
            //checks to see if a file already exists
            if (File.Exists(FILE_NAME))
            {
                using (StreamWriter sw = File.AppendText(FILE_NAME))
                {
                    sw.WriteLine(getProfile());
                    sw.Close();
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(FILE_NAME))
                {
                    sw.WriteLine(getProfile());
                    sw.Close();
                }
            }

            return FILE_NAME;
        }
    }
}
