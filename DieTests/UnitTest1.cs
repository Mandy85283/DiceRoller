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
        public void RollSetsSideCorrectly()
        {


            for (int i = 0; i < 100; i++)
            {
                def.Roll();
                def.CurrentSide.Should().BeInRange(1, 6);
            }
        }
    }
}
