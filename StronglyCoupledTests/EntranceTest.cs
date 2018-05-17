using StronglyCoupled;
using System;
using Xunit;

namespace StronglyCoupledTests
{
    public class EntranceTest
    {
        private readonly Entrance _entrance;

        public EntranceTest() => _entrance = new Entrance();

        [Theory]
        [InlineData("123456789")]
        public void AmIAdult_Test(string cpf)
        {
            var isAdult = _entrance.AmIAdult(cpf);
            Assert.True(isAdult);
        }
    }
}
