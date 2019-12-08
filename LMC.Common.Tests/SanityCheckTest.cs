using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LMC.Common.Tests
{
    [TestClass]
    public class SanityCheckTest
    {
        [TestMethod]
        public void AlwaysPasses()
        {
            true.Should().BeTrue();
        }
    }
}
