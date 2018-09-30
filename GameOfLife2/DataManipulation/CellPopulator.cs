
using GameOfLife2.DataMAnipilation;
using GameOfLife2.Models;
using System;

namespace GameOfLife2.DataManipulation
{
    public class CellPopulator
    {
        private CellUpdate CellUpdate;
        private Field Field;

        public CellPopulator(Field field)
        {
            Field = field;
        }

        public void RandomPopulation()
        {
            Random r = new Random();
            for (int x = 0; x < Field.Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Field.Cells.GetLength(1); y++)
                {
                    Field.Cells[x, y] = new Cell();
                    CellUpdate = new CellUpdate(Field.Cells[x, y]);
                    if (r.Next(2) == 1)
                    {                        
                       CellUpdate.ChangeStatus(true);
                    }
                    else
                    {
                        CellUpdate.ChangeStatus(false);
                    }
                    
                }
            }
        }

        public void CreateBlinker()
        {
            for (int x = 0; x < Field.Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Field.Cells.GetLength(1); y++)
                {
                    Field.Cells[x, y] = new Cell();
                    CellUpdate = new CellUpdate(Field.Cells[x, y]);
                    if (x == 2 && ((y == 1) || (y == 2) || (y == 3)))
                    {
                        CellUpdate.ChangeStatus(true);
                    }
                    else
                    {
                        CellUpdate.ChangeStatus(false);
                    }
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
