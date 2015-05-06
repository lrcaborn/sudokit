namespace Lrc.Sudokit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Lrc.Sudokit.Validations;
    
    public class Cell
    {
        public const int MinValue = 1;
        public const int MaxValue = 9;

        private List<int> values;

        public Cell()
        {
            this.values = new List<int>();
        }

        [Range(Cell.MinValue, Cell.MaxValue, ErrorMessage = "Cell value must be between 1 and 9.")]
        [CellValidation]
        public List<int> Values
        {
            get { return this.values; }
            set { }
        }
    }
}
