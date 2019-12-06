using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
