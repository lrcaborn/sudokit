namespace Lrc.Sudokit
{
    using System;
    using System.Collections.Generic;
    
    public class Cell
    {
        public const int MinValue = 1;
        public const int MaxValue = 9;

        private List<int> values;

        public Cell()
        {
            this.values = new List<int>();
        }

        public List<int> Values
        {
            get { return this.values; }
            set { }
        }
    }
}
