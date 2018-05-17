using StronglyCoupled;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace StronglyCoupledTests
{
    [TestClass]
    public class EntranceTest
    {
        private readonly Entrance _entrance;

        public EntranceTest() => _entrance = new Entrance();

        [TestMethod]
        public void AmIAdult_Should_ReturnTrue()
        {
            var isAdult = _entrance.AmIAdult("123456789");
            isAdult.Should().BeTrue();
        }
    }
}
