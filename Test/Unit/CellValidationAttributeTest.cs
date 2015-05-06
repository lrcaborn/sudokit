namespace Lrc.Sudokit
{
    using System;
    using Lrc.Sudokit;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CellValidationAttributeTest
    {
        [TestMethod]
        [Owner("LRC")]
        public void CanInstantiateCellValidationAttribute_Default()
        {
            var board = new Board();
            Assert.IsInstanceOfType(board, typeof(Board));
        }

    }
}
