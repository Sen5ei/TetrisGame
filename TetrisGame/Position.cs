namespace TetrisGame
{
    /// <summary>
    /// A class that represents a position or a cell in a grid.
    /// It stores a row and a column.
    /// </summary>
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
