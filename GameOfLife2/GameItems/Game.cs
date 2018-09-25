using System.Collections.Generic;
using GameOfLife2.DataMAnipilation;
using GameOfLife2.DataManipulation;
using GameOfLife2.Models;
using GameOfLife2.TextManipulation;
using GameOfLife2.UserInterface;

namespace GameOfLife2.GameItems
{
    public class Game
    {
        private Menu Menu;
        public Game(Menu menu)
        {
            Menu = menu;
        }
        public void StartGame()
        {
             var MenuItem = Menu.GetMenuItem();

            if(MenuItem == 1)
            {
                StartGameIteration();
            }            
        }

        public void StartGameIteration()
        {

            var Inputs = GetInputs();
            if (Inputs.X < 0 || Inputs.Y < 0 || Inputs.X == 0 || Inputs.Y == 0)
               Menu.Text.PrintLine("Incorrect values");
            else
            {
                Menu.Text.ClearConsole();

                var Fields = new List<Field>();
                //FieldUpdate Update = new FieldUpdate(new Field(Inputs));
                Field Field = new Field(Inputs);
                CellPopulator Populator = new CellPopulator(Field);
                Populator.RandomPopulation();
                
                
                Fields.Add(Field);

                var Iteration = new GameIteration(Fields, new FieldPrinter(Menu.Text), new FieldUpdate( Fields[0]));

                Menu.Text.ReadLine();
                Iteration.Stop();
            }            
        }

        public TwoIntegerVariable GetInputs()
        {
            var FieldSize = new TwoIntegerVariable();

            Menu.Text.Print("Input field width: ");            

            int.TryParse(Menu.Text.ReadLine(), out FieldSize.X);

            Menu.Text.Print("Input field height: ");            
            int.TryParse(Menu.Text.ReadLine(), out FieldSize.Y);
            
            return FieldSize;
        }
    }
}
