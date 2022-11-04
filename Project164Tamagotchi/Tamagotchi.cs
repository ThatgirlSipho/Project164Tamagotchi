using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Project164Tamagotchi
{
    [Serializable]
    public class Tamagotchi
    {
        // Data Members
        private int mSleep;
        private int mHealth;
        private int mCredit;
        private string mCharacter;

        //Constructor 1
        public Tamagotchi(int sleep, int health, int credit, string character)
        {
            mSleep = sleep;
            mHealth = health;
            mCredit = credit;
            mCharacter = character;
        }

        // Constructor 2
        public Tamagotchi()
        {
            mSleep = 100;
            mHealth = 0;
            mCredit = 0;
        }

        //Properties 
        public int Sleep
        {
            get { return mSleep; }
            set { mSleep = value; }
        }
        public int Health
        {
            get { return mHealth; }
            set { mHealth = value; }
        }
        public string Character
        {
            get { return mCharacter; }
            set { mCharacter = value; }
        }
        public int Credit
        {
            get { return mCredit; }
            set { mCredit = value; }
        }

       

    }
}
