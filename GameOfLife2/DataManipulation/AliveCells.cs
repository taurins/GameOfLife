
using GameOfLife2.Models;

namespace GameOfLife2.DataManipulation
{
    public class AliveCells
    {
        private Cell[,] Cells;

        public AliveCells(Cell[,] cells)
        {
            Cells = cells;
        }

        public int GetAliveCellsCount()
        {
            int AliveCells = 0;
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    if (Cells[x, y].IsAlive)
                    {
                        AliveCells += 1;
                    }
                }
            }

            return AliveCells;
        }
    }
}
