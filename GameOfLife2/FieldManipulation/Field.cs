
namespace GameOfLife2.FieldManipulation
{
    public class Field
    {
        private int Iterations = 0; 
        public Cell[,] Cells;

        public Field(int width, int height)
        {                      
            Cells = new Cell[width, height];

            new CellPopulator().RandomPopulation(Cells);
        }        

        public void UpdateCells()
        {
            Iterations += 1;
            Field TempField = new Field(Cells.GetLength(0), Cells.GetLength(1));
            for (int x = 0; x < Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Cells.GetLength(1); y++)
                {
                    Cell c = new Cell();
                    c.ChangeStatus(Cells[x, y].GetStatus());
                    c.ChangeStatus(new Neighbors().GetNeighborCount(Cells,x,y));
                    TempField.Cells[x, y].ChangeStatus(c.GetStatus());
                }
            }
            int AliveCells = new AliveCells().GetAliveCellsCount(Cells);
            Cells = TempField.Cells;
        }       

        public int GetIterations()
        {
            return Iterations;
        }        
    }
}
