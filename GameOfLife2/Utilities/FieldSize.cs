
namespace GameOfLife2.Utilities
{
    public class FieldSize
    {
        private int X;
        private int Y;

        public void SetSize(int width, int height)
        {
            X = width;
            Y = height;
        }

        public int GetWidth()
        {
            return X;
        }

        public int GetHeight()
        {
            return Y;
        }
    }
}
