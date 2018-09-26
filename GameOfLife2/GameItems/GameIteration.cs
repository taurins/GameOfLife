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
       // private static List<Field> Fields;
        private static FieldPrinter Text;
        private static List<FieldUpdate> Updates;

        public GameIteration(List<FieldUpdate> updates, FieldPrinter text)
        {
            Text = text;
            //Fields = field;
            Updates = updates;

            Iteration.AutoReset = false;
            Iteration.Elapsed += DoStep;            
            Iteration.Start();
        }

        private static void DoStep(Object source, ElapsedEventArgs e)
        {
            foreach (var update in Updates)
            {                
                if (new AliveCells(update.Field.Cells).GetAliveCellsCount() > 0)
                {

                    //Update.Field = field;
                    update.UpdateField();
                    Text.PrintField(0, 0, update.Field);
                    
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
