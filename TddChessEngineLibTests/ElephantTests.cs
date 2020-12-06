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
            Elephant el = new Elephant();
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {

        }
    }
}