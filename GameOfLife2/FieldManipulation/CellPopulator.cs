using System;

namespace GameOfLife2.FieldManipulation
{
    public class CellPopulator
    {
        public void RandomPopulation(Cell[,] cells)
        {
            Random r = new Random();
            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < cells.GetLength(1); y++)
                {
                    cells[x, y] = new Cell();
                    if (r.Next(2) == 1)
                        cells[x, y].ChangeStatus(true);
                    else cells[x, y].ChangeStatus(false);
                }
            }
        }

        //public void GosperGliderGunPopulation(Cell[,] cells)
        //{
        //    Random r = new Random();
        //    for (int x = 0; x < cells.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < cells.GetLength(1); y++)
        //        {
        //            cells[x, y] = new Cell();
        //            if (r.Next(2) == 1)
        //                cells[x, y].ChangeStatus(true);
        //            else cells[x, y].ChangeStatus(false);
        //        }
        //    }
        //}
    }
}
