using System;
using System.Collections.Generic;
using System.Text;

namespace Simply_Football
{
    /// <summary>
    /// SkillSet class
    /// simple skills that are determined by level
    public class SkillSet
    {
        /// <summary>
        /// Private varibales that determine each skill
        /// </summary>
        private int head;
        private int shoot;
        private int dribble;
        private int pass;
        private int tackle;

        /// <summary>
        /// read/write property for heading
        /// </summary>
        public int Heading
        {
            get { return head; }
            set { head = value; }
        }

        /// <summary>
        /// read/write property for shooting
        /// </summary>
        public int Shooting
        {
            get { return shoot; }
            set { shoot = value; }
        }

        /// <summary>
        /// read/write property for dribbling
        /// </summary>
        public int Dribble
        {
            get { return dribble; }
            set { dribble = value; }
        }

        /// <summary>
        /// read/write property for passing
        /// </summary>
        public int Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        /// <summary>
        /// read/write property for tackling
        /// </summary>
        public int Tackle
        {
            get { return tackle; }
            set { tackle = value; }
        }


        /// <summary>
        /// overriden ToString method
        /// </summary>
        /// <returns>string representation of skillSet</returns>
        public override string ToString()
        {
            string strout;
            strout = "Heading: " + head + "\n" +"Shooting: " + shoot + "\n" + "Dribbling: " + dribble + "\n" + "Passing: " + pass + "\n" + "Tackling: " + tackle + "\n";
            return strout;
        }
    }
}
