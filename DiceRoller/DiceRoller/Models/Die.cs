using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller.Models
{
    public class Die
    {
        // name,type, or colour of the die
        public String Name { get; set; }
        //how many sides are the die
        public int NumSides { get; set; }
        //which number is currently up
        public int CurrentSide { get; set; }

        public Die()
        {
            NumSides = 6;
            Name = "d6";
            Roll();
        }

        public Die(int numSides)
        {
            NumSides = numSides;
            Name = "d" + numSides;
            Roll();
        }

        public void Roll()
        {
            Random random = new Random();
            CurrentSide = random.Next(NumSides) + 1;
        }

        public int SetSideUp(int newSideUp)
        {
            if (newSideUp >= 1 && newSideUp <= NumSides)
                this.CurrentSide = newSideUp;
            return newSideUp;
        }
    }
}
