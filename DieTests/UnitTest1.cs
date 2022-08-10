using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using DiceRoller.Models;

namespace DieTests
{
    [TestClass]
    public class UnitTest1
    {
        Die def = new Die();
        [TestMethod]
        public void DieNotNull()
        {
            def.Should().NotBeNull();
        }

        [TestMethod]
        public void DieHasAllDefaultValues()
        {
            /*
             Default values should be:
            name: d6
            numsides: 6*/

            def.Name.Should().Be("d6");
            def.NumSides.Should().Be(6);
            def.CurrentSide.Should().BeInRange(1, 6);

        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(12)]
        [DataRow(20)]
        public void RollSetsSideCorrectlyForCustomSides(int sides)
        {
            Die d = new Die(sides);

            for (int i = 0; i < 100; i++)
            {
                d.Roll();
                d.CurrentSide.Should().BeInRange(1, sides);
            }



        }

        [TestMethod]
        public void RollSetsSideCorrectly()
        {
            for (int i = 0; i < 100; i++)
            {
                def.Roll();
                def.CurrentSide.Should().BeInRange(1, 6);
            }
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(10)]
        [DataRow(12)]
        [DataRow(20)]

        public void DieHasCustomSides(int sides)
        {
            Die d = new Die(sides);
            d.Name.Should().Be("d" + sides);
            d.NumSides.Should().Be(sides);
            d.CurrentSide.Should().BeInRange(1, sides);
        }


        [TestMethod]
        [DataRow(3, "d3")]
        [DataRow(4, "d4")]
        [DataRow(8, "d8")]
        [DataRow(10, "d10")]
        [DataRow(12, "d12")]
        [DataRow(20, "d20")]
        public void DieHasCustomName(int sides, string name)
        {

            Die d = new Die(sides);
            d.Name.Should().Be(name);
        }

        [TestMethod]
        [DataRow(6, 5)]
        [DataRow(10, 2)]
        [DataRow(8, 5)]

        public void SetSideUpChangesSide(int sides, int setSide)
        {

            Die dice = new Die(sides);
            int result = dice.SetSideUp(setSide);
            result.Should().Be(setSide);

        }
    }
}
