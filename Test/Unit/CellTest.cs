namespace Lrc.Sudokit
{
    using System;
    using Lrc.Sudokit;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CellTest
    {
        [TestMethod]
        [Owner("LRC")]
        public void CanInstantiateCell_Default()
        {
            var cell = new Cell();
            Assert.IsInstanceOfType(cell, typeof(Cell));
        }

        [TestMethod]
        [Owner("LRC")]
        public void ValuesListNotNullAfterInstantiation()
        {
            var cell = new Cell();
            Assert.IsNotNull(cell.Values);
        }

        [TestMethod]
        [Owner("LRC")]
        public void ValuesListEmptyAfterInstantiation()
        {
            var cell = new Cell();
            Assert.AreEqual(0, cell.Values.Count);
        }
    }
}
