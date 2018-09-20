
namespace GameOfLife2.FieldManipulation
{
    public class Neighbors
    {
        private Cell[,] Cells;

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

            return Cells[x, y].GetStatus();
        }

        public int GetNeighborCount(Cell[,] cells , int x, int y)
        {
            Cells = cells;
            int count = 0;

            if (CheckOutOfBounds(x - 1, y)) count += 1;
            if (CheckOutOfBounds(x - 1, y - 1)) count += 1;
            if (CheckOutOfBounds(x, y - 1)) count += 1;
            if (CheckOutOfBounds(x + 1, y - 1)) count += 1;
            if (CheckOutOfBounds(x + 1, y)) count += 1;
            if (CheckOutOfBounds(x + 1, y + 1)) count += 1;
            if (CheckOutOfBounds(x, y + 1)) count += 1;
            if (CheckOutOfBounds(x - 1, y + 1)) count += 1;

            return count;
        }
    }
}
