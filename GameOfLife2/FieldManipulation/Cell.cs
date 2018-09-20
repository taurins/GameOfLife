
namespace GameOfLife2.FieldManipulation
{
    public class Cell
    {
        private bool IsAlive;
        private char Symbol;

        private readonly char Alive = '*';
        private readonly char Dead = '-';

        public void ChangeStatus(int count)
        {
            if(IsAlive)
            {
                if (count < 2 || count > 3) IsAlive = false;
                if (count == 2 || count == 3) IsAlive = true;
            }
            else
                if (count == 3) IsAlive = true;
            ChangeSymbol();
        }

        private void ChangeSymbol()
        {
            if (IsAlive)
                Symbol = Alive;
            else
                Symbol = Dead;
        }

        public void ChangeStatus(bool isAlive)
        {
            IsAlive = isAlive;
            ChangeSymbol();
        }

        public bool GetStatus()
        {
            return IsAlive;
        }

        public char GetSymbol()
        {
            return Symbol;
        }
    }
}
