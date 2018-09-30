
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
            Neighbors = new Neighbors(Field.Cells);
        }

        public void UpdateField()
        {
            Field.Iteration += 1;
            Field TempField = new Field(new TwoIntegerVariable { X = Field.Cells.GetLength(0), Y = Field.Cells.GetLength(1) });
            for (int x = 0; x < Field.Cells.GetLength(0); x++)
            {
                for (int y = 0; y < Field.Cells.GetLength(1); y++)
                {
                    Cell c = new Cell();
                    TempField.Cells[x, y] = new Cell();
                    CellUpdate Update = new CellUpdate(c);
                    Update.ChangeStatus(Field.Cells[x, y].IsAlive);

                    Update.ChangeStatus(new Neighbors(Field.Cells).GetNeighborCount(x, y));
                    //Update.ChangeStatus(Neighbors().GetNeighborCount(x, y)); bug is here
                    Update = new CellUpdate(TempField.Cells[x, y]);
                    Update.ChangeStatus(c.IsAlive);
                }
            }
            int AliveCells = new AliveCells(Field.Cells).GetAliveCellsCount();
            Field.Cells = TempField.Cells;
        }
    }
}
