using GameOfLife2.Models;


namespace GameOfLife2.DataMAnipilation
{
    public class CellUpdate
    {
        private Cell Cell;
        private readonly char Alive = '*';
        private readonly char Dead = '-';

        public CellUpdate(Cell cell)
        {
            Cell = cell;
        }

        public void ChangeStatus(int count)
        {
            if (Cell.IsAlive)
            {
                if (count < 2 || count > 3) Cell.IsAlive = false;
                if (count == 2 || count == 3) Cell.IsAlive = true;
            }
            else
                if (count == 3) Cell.IsAlive = true;
            ChangeSymbol();
        }

        private void ChangeSymbol()
        {
            if (Cell.IsAlive)
                Cell.Symbol = Alive;
            else
                Cell.Symbol = Dead;
        }

        public void ChangeStatus(bool isAlive)
        {
            Cell.IsAlive = isAlive;
            ChangeSymbol();
        }
    }
}
