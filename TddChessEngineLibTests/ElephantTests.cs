using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class ElephantTests
    {
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
            Elephant el = new Elephant("E2");
            Assert.Equal("E2", el.CurrentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Elephant("E9"));
        }
        [Fact]
        public void WhenTryCreatingElephantOnP2_ThenItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Elephant("P2"));
        }

    }
}