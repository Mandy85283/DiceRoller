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
            CurrentSide = 2;

        }
        public void Roll()
        {
           // Random random = new Random();
            //CurrentSide = random.Next(NumSides) + 1;
        }
    }
}
