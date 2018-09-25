
using GameOfLife2.Models;

namespace GameOfLife2.DataManipulation
{
    public class AliveCells
    {
        public int GetAliveCellsCount(Cell[,] cells)
        {
            int AliveCells = 0;
            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < cells.GetLength(1); y++)
                {
                    if (cells[x, y].IsAlive)
                    {
                        AliveCells += 1;
                    }
                }
            }

            return AliveCells;
        }
    }
}
