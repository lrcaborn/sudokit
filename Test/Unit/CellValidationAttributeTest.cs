namespace Lrc.Sudokit
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Lrc.Sudokit;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CellValidationAttributeTest
    {
        [TestMethod]
        [Owner("LRC")]
        public void CanInstantiateCellValidationAttribute_Default()
        {
            var cellValidationAttribute = new CellValidationAttribute();
            Assert.IsInstanceOfType(cellValidationAttribute, typeof(CellValidationAttribute));
        }
    }
}
