namespace Lrc.Sudokit
{
    using System;

    public class Board
    {
        public Board()
        {
            this.Cells = new Cell[this.MaxCellCount];

            for (int i = 0; i < this.Cells.Length; i++)
            {
                this.Cells[i] = new Cell();
            }
        }
        
        public Cell[] Cells
        {
            get;
            set;
        }

        public int MaxCellCount
        {
            get
            {
                return Cell.MaxValue * Cell.MaxValue;
            }
        }

        public bool PopulateByPosition(int value, int position)
        {
            bool success = false;
            this.Cells[position].Values.Add(value);
            return success;
        }
    }
}