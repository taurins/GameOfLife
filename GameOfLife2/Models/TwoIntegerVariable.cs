
using GameOfLife2.UserInterface;

namespace GameOfLife2.Models
{
    public class TwoIntegerVariable
    {
        public int X;
        public int Y;

        public void GetInputs()
        {
            Menu Menu = new Menu(new TextManipulation.TextIO());

            Menu.Text.Print("Input field width: ");

            int.TryParse(Menu.Text.ReadLine(), out X);

            Menu.Text.Print("Input field height: ");
            int.TryParse(Menu.Text.ReadLine(), out Y);
        }
    }
}
