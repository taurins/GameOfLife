
namespace GameOfLife2.Models
{
    public class Field
    {
        public Cell[,] Cells;
        public int Iteration { get; set; }
        private TwoIntegerVariable Size;

        public Field(TwoIntegerVariable size)
        {
            Size = size;
            Cells = new Cell[Size.X, Size.Y];
        }        

        //public void UpdateCells()
        //{
        //    Iterations += 1;
        //    Field TempField = new Field(Cells.GetLength(0), Cells.GetLength(1));
        //    for (int x = 0; x < Cells.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < Cells.GetLength(1); y++)
        //        {
        //            Cell c = new Cell();
        //            CellUpdate = new CellUpdate(c);
        //            CellUpdate.ChangeStatus(Cells[x, y].IsAlive);
        //            CellUpdate.ChangeStatus(new Neighbors().GetNeighborCount(Cells,x,y));
        //            CellUpdate = new CellUpdate(TempField.Cells[x, y]);
        //            CellUpdate.ChangeStatus(c.IsAlive);
        //           // TempField.Cells[x, y].ChangeStatus(c.GetStatus());
        //        }
        //    }
        //    int AliveCells = new AliveCells().GetAliveCellsCount(Cells);
        //    Cells = TempField.Cells;
        //}       

        //public int GetIterations()
        //{
        //    return Iterations;
        //}        
    }
}
