namespace Lrc.Sudokit
{
    using System;
    using Lrc.Sudokit;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        [Owner("LRC")]
        public void CanInstantiateBoard_Default()
        {
            var board = new Board();
            Assert.IsInstanceOfType(board, typeof(Board));
        }

        [TestMethod]
        [Owner("LRC")]
        public void CellsHasCorrectLengthWhenInstantiated()
        {
            var board = new Board();
            Assert.AreEqual(board.MaxCellCount, board.Cells.Length);
        }

        [TestMethod]
        [Owner("LRC")]
        public void AllCellsHaveCorrectLengthsWhenInstantiated()
        {
            var board = new Board();
            foreach (var cell in board.Cells)
            {
                Assert.AreEqual(0, cell.Values.Count);
            }
        }
        
        [TestMethod]
        [Owner("LRC")]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PopulateByPositionFailsForNegativePosition()
        {
            var board = new Board();
            int testValue = 3;
            int testPosition = -1;
            Assert.IsTrue(board.PopulateByPosition(testValue, testPosition));
        }

        [TestMethod]
        [Owner("LRC")]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PopulateByPositionFailsForPositionBeyondMaximumSize()
        {
            var board = new Board();
            int testValue = 3;
            int testPosition = 999;
            Assert.IsTrue(board.PopulateByPosition(testValue, testPosition));
        }

        [TestMethod]
        [Owner("LRC")]
        public void PopulateByPositionFailsForValueBeyondMaximumCellValue()
        {
            var board = new Board();
            int testValue = Cell.MaxValue + 1;
            int testPosition = 3;
            Assert.IsFalse(board.PopulateByPosition(testValue, testPosition));
        }
    }
}
