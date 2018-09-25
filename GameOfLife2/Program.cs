using GameOfLife2.GameItems;
using GameOfLife2.TextManipulation;
using GameOfLife2.UserInterface;

namespace GameOfLife2
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(new Menu(new TextIO()));
            game.StartGame();
        }
    }
}
