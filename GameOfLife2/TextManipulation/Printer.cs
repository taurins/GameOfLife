using GameOfLife2.FieldManipulation;
using System;

namespace GameOfLife2.TextManipulation
{
    public class Printer
    {
        public void PrintField(int CursorPositionX, int CursorPositionY, Field field)
        {
            Console.SetCursorPosition(CursorPositionX, CursorPositionY);

            Console.Write(new string(' ',Console.WindowWidth));

            Console.SetCursorPosition(CursorPositionX, CursorPositionY);

            Console.Write($"Alive: {new AliveCells().GetAliveCellsCount(field.Cells)} | Iter: {field.GetIterations()}");
            Console.WriteLine();
            for (int x = 0; x < field.Cells.GetLength(1); x++)
            {
                for (int y = 0; y < field.Cells.GetLength(0); y++)
                {
                    Console.Write(field.Cells[y,x].GetSymbol());
                }
                Console.WriteLine();
            }
        }

        public void Print(string text)
        {
            Console.Write(text);
        }

        public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        public void ClearConsole()
        {
            Console.Clear();
        }
    }
}
