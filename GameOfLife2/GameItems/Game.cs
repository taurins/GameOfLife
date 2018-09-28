using System.Collections.Generic;
using GameOfLife2.DataManipulation;
using GameOfLife2.FileManipulation;
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

            switch (MenuItem)
            {
                case MenuItem.Newgame:
                    NewGame();
                    break;
                case MenuItem.Continue:
                    ContinueGame();
                    break;
            }            

        }

        public void NewGame()
        {
            TwoIntegerVariable Inputs = new TwoIntegerVariable();
            Inputs.GetInputs();

            if (Inputs.X < 0 || Inputs.Y < 0 || Inputs.X == 0 || Inputs.Y == 0)
                Menu.Text.PrintLine("Incorrect values");
            else
            {
                Field Field = new Field(Inputs);
                CellPopulator Populator = new CellPopulator(Field);
                Populator.RandomPopulation();
                //If field size is atleast 5x5
                //Populator.CreateBlinker();
                var FieldUpdates = new List<FieldUpdate>();

                FieldUpdates.Add(new FieldUpdate(Field));
                StartGameIteration(FieldUpdates);
            }
        }

        public void ContinueGame()
        {
            JsonManipulator json = new JsonManipulator();
            List<FieldUpdate> ReadUpdates = new List<FieldUpdate>();
            foreach (var item in json.ReadFromFile())
            {
                ReadUpdates.Add(new FieldUpdate(item));
            }
            StartGameIteration(ReadUpdates);

        }

        public void StartGameIteration(List<FieldUpdate> updates)
        {           
                Menu.Text.ClearConsole();               

                var Iteration = new GameIteration(updates, new FieldPrinter(Menu.Text));

                Menu.Text.PrintLine("Pause - p");
                Menu.Text.PrintLine("Cont - c");

                while (true)
                {                 
                    if (Menu.Text.ReadLine() == "p")
                    {
                        Iteration.Pause();
                    }

                    if (Menu.Text.ReadLine() == "c")
                    {
                        Menu.Text.ClearConsole();
                        Iteration.Continue();
                    }
                    else
                    {
                        break;
                    }                   
                }
                Menu.Text.ReadLine();
                Iteration.Stop();
                       
        }
    }
}
