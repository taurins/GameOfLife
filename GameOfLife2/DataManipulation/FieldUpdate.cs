
using GameOfLife2.DataMAnipilation;
using GameOfLife2.Models;

namespace GameOfLife2.DataManipulation
{
    public class FieldUpdate
    {
        public Field Field;

        public FieldUpdate(Field field)
        {
            Field = field;
            Field.Iteration = 0;
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
                    CellUpdate Update = new CellUpdate(c);
                    Update.ChangeStatus(Field.Cells[x, y].IsAlive);
                    Update.ChangeStatus(new Neighbors().GetNeighborCount(Field.Cells, x, y));
                    Update = new CellUpdate(TempField.Cells[x, y]);
                    Update.ChangeStatus(c.IsAlive);
                    // TempField.Cells[x, y].ChangeStatus(c.GetStatus());
                }
            }
            int AliveCells = new AliveCells().GetAliveCellsCount(Field.Cells);
            Field.Cells = TempField.Cells;
        }
    }
}
