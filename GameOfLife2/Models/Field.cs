
namespace GameOfLife2.Models
{
    public class Field
    {
        public Cell[,] Cells;
        public int Iteration { get; set; }
        public TwoIntegerVariable Size;

        public Field(TwoIntegerVariable size)
        {
            Size = size;
            Cells = new Cell[Size.X, Size.Y];

        }               
    }
}
