using GameOfLife2.TextManipulation;

namespace GameOfLife2.UserInterface
{
    class Menu
    {
        public int GetMenuItem()
        {
            var Printer = new Printer();
            Printer.PrintLine("Start a new game - 1");
            //Printer.PrintLine("Load an existing game - 2");
            //Printer.PrintLine("Stop application - 3");
            Printer.Print("Your choice: ");
            int.TryParse(new TextReader().ReadLine(), out int MenuItem);

            return MenuItem;
        }
    }
}
