using System;
using System.Collections.Generic;
using System.Timers;
using GameOfLife2.DataManipulation;
using GameOfLife2.Models;
using GameOfLife2.TextManipulation;

namespace GameOfLife2.GameItems
{
    public class GameIteration
    {
        private Timer Iteration = new Timer(500);
        private static List<Field> Fields;
        private static FieldPrinter Text;
        private static FieldUpdate Update;

        public GameIteration(List<Field> field, FieldPrinter text, FieldUpdate update)
        {
            Text = text;
            Fields = field;
            Update = update;

            Iteration.AutoReset = false;
            Iteration.Elapsed += DoStep;            
            Iteration.Start();
        }

        private static void DoStep(Object source, ElapsedEventArgs e)
        {
            foreach (var field in Fields)
            {
                if (new AliveCells().GetAliveCellsCount(field.Cells) > 0)
                {
                    Update.Field = field;
                    Update.UpdateField();
                    //field.UpdateCells();
                    Text.PrintField(0, 0, field);
                }
            }
            Timer RestartTimer = (Timer)source;
            RestartTimer.Start();
        }

        public void Stop()
        {
            Iteration.Stop();
            Iteration.Dispose();
        }
    }
}
