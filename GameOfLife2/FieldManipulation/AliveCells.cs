
namespace GameOfLife2.FieldManipulation
{
    class AliveCells
    {
        public int GetAliveCellsCount(Cell[,] cells)
        {
            int AliveCells = 0;
            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < cells.GetLength(1); y++)
                {
                    if (cells[x, y].GetStatus()) AliveCells += 1;
                }
            }

            return AliveCells;
        }
    }
}
