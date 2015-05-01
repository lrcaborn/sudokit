using System;
using lrc.sudokit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lrc.sudokit
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        [Owner("LRC")]
        public void CanInstantiate()
        {
            var cell = new Cell();
            Assert.IsInstanceOfType(cell, typeof(Cell));
        }

        [TestMethod]
        [Owner("LRC")]
        public void ValuesEmptyWhenInstantiated()
        {
            var cell = new Cell();
            Assert.IsTrue(cell.Values.Length == 9);
        }

    }
}
