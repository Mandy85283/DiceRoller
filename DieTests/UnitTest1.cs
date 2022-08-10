using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using DiceRoller.Models;

namespace DieTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DieNotNull()
        {
            Die d = new Die();
            d.Should().NotBeNull();
        }
    }
}
