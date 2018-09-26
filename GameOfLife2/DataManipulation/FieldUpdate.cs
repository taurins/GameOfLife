
using GameOfLife2.DataMAnipilation;
using GameOfLife2.Models;

namespace GameOfLife2.DataManipulation
{
    public class FieldUpdate
    {
        public Field Field;
        private Neighbors Neighbors;

        public FieldUpdate(Field field)
        {
            Field = field;
            Field.Iteration = 0;
            Neighbors = new Neighbors(Field.Cells);
        }

        //need to fux bug
        public void UpdateField()
        {
            Field.Iteration += 1;
            Field TempField = new Field(new TwoIntegerVariable { X = Field.Cells.GetLength(0), Y = Field.Cells.GetLength(1) });
            //CellPopulator Populator = new CellPopulator(TempField);
            //Populator.RandomPopulation();
            for (int x = 0; x < Field.Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Field.Cells.GetLength(1); y++)
                {
                    Cell c = new Cell();
                    TempField.Cells[x, y] = new Cell();
                    CellUpdate Update = new CellUpdate(c);

                    Update.ChangeStatus(c.IsAlive);
                    int count = Neighbors.GetNeighborCount(x, y);
                    Update.ChangeStatus(count);

                    TempField.Cells[x, y] = c;

                    //CellUpdate Update2 = new CellUpdate(TempField.Cells[x, y]);
                    //Update2.ChangeStatus(c.IsAlive);

                    //TempField.Cells[x, y] = new Cell();

                    //CellUpdate Update = new CellUpdate(TempField.Cells[x, y]);

                    //Update.ChangeStatus(Field.Cells[x, y].IsAlive);
                    //int count = Neighbors.GetNeighborCount(x, y);
                    //Update.ChangeStatus(count);

                    //Update = new CellUpdate(TempField.Cells[x, y]);
                    //TempField.Cells[x, y].IsAlive = c.IsAlive;
                    // Update.ChangeStatus(c.IsAlive);
                    //Update = new CellUpdate(TempField.Cells[x, y]);

                    //Update.ChangeStatus(Neighbors.GetNeighborCount(x, y));
                    //TempField.Cells[x, y] = c;
                }
            }
            int AliveCells = new AliveCells(Field.Cells).GetAliveCellsCount();
            //Field.Cells = new Cell[Field.Cells.GetLength(0), Field.Cells.GetLength(1)];
            Field.Cells = TempField.Cells;
        }
    }
}
