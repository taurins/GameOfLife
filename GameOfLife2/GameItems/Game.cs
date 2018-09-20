using System.Collections.Generic;
using GameOfLife2.FieldManipulation;
using GameOfLife2.TextManipulation;
using GameOfLife2.UserInterface;
using GameOfLife2.Utilities;

namespace GameOfLife2.GameItems
{
    public class Game
    {
        public void StartGame()
        {
            var MenuItem = new Menu().GetMenuItem();

            if(MenuItem == 1)
            {
                StartGameIteration();
            }            
        }

        public void StartGameIteration()
        {

            var Inputs = GetInputs();
            if (Inputs.GetHeight() < 0 || Inputs.GetWidth() < 0 || Inputs.GetHeight() == 0 || Inputs.GetWidth() == 0)
                new Printer().PrintLine("Incorrect values");
            else
            {
                new Printer().ClearConsole();

                var Fields = new List<Field>();
                Fields.Add(new Field(Inputs.GetWidth(), Inputs.GetHeight()));

                var Iteration = new GameIteration(Fields);

                new TextReader().ReadLine();
                Iteration.Stop();
            }            
        }

        public FieldSize GetInputs()
        {
            var Printer = new Printer();
            TextReader Reader = new TextReader();
            var FieldSize = new FieldSize();

            Printer.Print("Input field width: ");            

            int.TryParse(Reader.ReadLine(), out int x);

            Printer.Print("Input field height: ");            
            int.TryParse(Reader.ReadLine(), out int y);
            
            FieldSize.SetSize(x,y);
            return FieldSize;
        }
    }
}
