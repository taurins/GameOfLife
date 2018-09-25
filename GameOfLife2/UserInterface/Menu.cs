using GameOfLife2.TextManipulation;

namespace GameOfLife2.UserInterface
{
    public class Menu
    {
        public TextIO Text;

        public Menu(TextIO text)
        {
            Text = text;
        }

        public int GetMenuItem()
        {
            Text.PrintLine("Start a new game - 1");
            //Printer.PrintLine("Load an existing game - 2");
            //Printer.PrintLine("Stop application - 3");
            Text.Print("Your choice: ");
            int.TryParse(Text.ReadLine(), out int MenuItem);

            return MenuItem;
        }
    }
}
