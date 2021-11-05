using System;
using System.Collections.Generic;
using System.Text;

namespace Simply_Football
{
    /// <summary>
    /// Class to create a player profile
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Declares private variable s
        /// </summary>
        private int profileNum;
        private SkillSet skills;
        private string comment;
        private Person person;
        private int season;

        /// <summary>
        /// read only accessor method for skills
        /// </summary>
        public SkillSet Skills
        {
            get
            {
                return skills;
            }
        }

        /// <summary>
        /// read/write accessor method for comment
        /// </summary>
        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }
        }

        /// <summary>
        /// read/write accessor method for season
        /// </summary>
        public int Season
        {
            get
            {
                return season;
            }
            set
            {
                season = value;
            }
        }

        /// <summary>
        /// read/write accessor method for profile number
        /// </summary>
        public int ProfileNum
        {
            get { return profileNum; }
            set { profileNum = value; }
        }

        /// <summary>
        /// read/write accessor method for oerson
        /// </summary>
        public Person persons
        {
            get { return person; }
            set { person = value; }
        }


        /// <summary>
        /// setter method for skills
        /// </summary>
        /// <param name="headLvl">heading level</param>
        /// <param name="shootLvl">shooting level</param>
        /// <param name="dribLvl">dribbling level</param>
        /// <param name="passLvl">passing level</param>
        /// <param name="tackleLvl">tackle level</param>
        public void setSkills(int headLvl, int shootLvl, int dribLvl, int passLvl, int tackleLvl)
        {
            skills.Heading = headLvl;
            skills.Shooting = shootLvl;
            skills.Dribble = dribLvl;
            skills.Pass = passLvl;
            skills.Tackle = tackleLvl;
        }


        /// <summary>
        /// Default constructor for profile
        /// sets values to default
        /// </summary>
        public Profile()
        {
            ProfileNum = 0;
            skills = new SkillSet();
            setSkills(0, 0, 0, 0, 0);
            Comment = "No Comment";
            person = null;
            Season = 0;
        }


        /// <summary>
        /// overidden constructor
        /// </summary>
        /// <param name="proNum">profile number</param>
        /// <param name="headLvl">heading level</param>
        /// <param name="shootLvl">shooting level</param>
        /// <param name="dribLvl">dribbling level</param>
        /// <param name="passLvl">passing level</param>
        /// <param name="tackleLvl">tackle level</param>
        /// <param name="desc">comment</param>
        /// <param name="p">person instance</param>
        /// <param name="seas">season</param>
        public Profile(int proNum, int headLvl, int shootLvl, int dribLvl, int passLvl, int tackleLvl, string desc, Person p, int seas)
        {

            ProfileNum = proNum;
            person = p;
            skills = new SkillSet();
            setSkills(headLvl, shootLvl, dribLvl, passLvl, tackleLvl);
            Comment = desc;
            Season = seas;
        }


        /// <summary>
        /// overriden to string method 
        /// </summary>
        /// <returns>string representing profile</returns>
        public override string ToString()
        {
            string strout;
            strout = "Profile number : " + ProfileNum +
                "\n" + "Season: " + Season +
                "\n" + "Name: " + person.Name +
                "\n" + "Comments: " + Comment + "\n";
            strout = strout + "\n" + Skills;
            return strout;
        }
    }
}

