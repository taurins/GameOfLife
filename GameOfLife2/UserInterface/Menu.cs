using GameOfLife2.Models;
using GameOfLife2.TextManipulation;
using System;

namespace GameOfLife2.UserInterface
{
    public class Menu
    {
        public TextIO Text;

        public Menu(TextIO text)
        {
            Text = text;
        }

        public MenuItem GetMenuItem()
        {
            Text.PrintLine("Start a new game - 1");
            Text.PrintLine("Load a saved game - 2");
            //Text.PrintLine("Stop application - 3");
            Text.Print("Your choice: ");
            MenuItem item = (MenuItem)Enum.Parse(typeof(MenuItem) ,Text.ReadLine());
            return item;
        }
    }
}
