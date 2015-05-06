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

        [TestMethod]
        [Owner("LRC")]
        public void CellValidationAttributePassesAllowedValue()
        {
            var cellValidationAttribute = new CellValidationAttribute();
            Assert.IsTrue(cellValidationAttribute.IsValid(5));
        }

        [TestMethod]
        [Owner("LRC")]
        public void CellValidationAttributeFailsValueBelowMinimum()
        {
            var cellValidationAttribute = new CellValidationAttribute();
            Assert.IsFalse(cellValidationAttribute.IsValid(-1));
        }

        [TestMethod]
        [Owner("LRC")]
        public void CellValidationAttributeFailsValueAboveMaximum()
        {
            var cellValidationAttribute = new CellValidationAttribute();
            Assert.IsFalse(cellValidationAttribute.IsValid(16));
        }
    }
}
