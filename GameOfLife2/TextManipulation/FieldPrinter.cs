using GameOfLife2.DataManipulation;
using GameOfLife2.Models;
using System;

namespace GameOfLife2.TextManipulation
{
    public class FieldPrinter
    {
        private TextIO Text;

        public FieldPrinter(TextIO textIO)
        {
            Text = textIO;
        }

        public void PrintField(int CursorPositionX, int CursorPositionY, Field field)
        {
            int Top = Text.SaveCurrentConsolePosition();

            Text.SetCursorPosition(CursorPositionX, CursorPositionY);
            Text.Print();
            Text.SetCursorPosition(CursorPositionX, CursorPositionY);

            Text.Print($"Alive: {new AliveCells(field.Cells).GetAliveCellsCount()} | Iter: {field.Iteration}");
            Text.PrintLine();
            for (int x = 0; x < field.Cells.GetLength(1); x++)
            {
                for (int y = 0; y < field.Cells.GetLength(0); y++)
                {
                    Text.Print(field.Cells[y, x].Symbol.ToString());
                }
                Text.PrintLine();
            }

            Text.SetCurrentConsolePostition(Top);
        }

       
    }
}
