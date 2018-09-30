
using GameOfLife2.Models;

namespace GameOfLife2.DataManipulation
{
    public class Neighbors
    {
        public Cell[,] Cells;

        public Neighbors(Cell[,] cells)
        {
            Cells = cells;
        }

        public bool CheckOutOfBounds(int X, int Y)
        {
            int x = X, y = Y;

            if (X == -1)
                x = Cells.GetLength(0) - 1;
            else
                if (X == Cells.GetLength(0))
                x = 0;

            if (Y == -1)
                y = Cells.GetLength(1) - 1;
            else
                if (Y == Cells.GetLength(1))
                y = 0;

            return Cells[x, y].IsAlive;
        }

        public int GetNeighborCount( int x, int y)
        {
            int count = 0;

            if (CheckOutOfBounds(x - 1, y))
            {
                count += 1;
            }
            if (CheckOutOfBounds(x - 1, y - 1))
            {
                count += 1;
            }
            if (CheckOutOfBounds(x, y - 1))
            {
                count += 1;
            }
            if (CheckOutOfBounds(x + 1, y - 1))
            {
                count += 1;
            }
            if (CheckOutOfBounds(x + 1, y))
            {
                count += 1;
            }
            if (CheckOutOfBounds(x + 1, y + 1))
            {
                count += 1;
            }
            if (CheckOutOfBounds(x, y + 1))
            {
                count += 1;
            }
            if (CheckOutOfBounds(x - 1, y + 1))
            {
                count += 1;
            }

            return count;
        }
    }
}
