using System;
using System.Collections.Generic;
using System.Timers;
using GameOfLife2.FieldManipulation;
using GameOfLife2.TextManipulation;

namespace GameOfLife2.GameItems
{
    public class GameIteration
    {
        private Timer Iteration = new Timer(500);
        private static List<Field> Fields;

        public GameIteration(List<Field> field)
        {
            Fields = field;
            Iteration.AutoReset = false;
            Iteration.Elapsed += DoStep;

            Iteration.Start();
        }

        private static void DoStep(Object source, ElapsedEventArgs e)
        {
            var Printer = new Printer();
            foreach (var field in Fields)
            {
                if (new AliveCells().GetAliveCellsCount(field.Cells) > 0)
                {
                    field.UpdateCells();
                    Printer.PrintField(0, 0, field);
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
