using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife2.TextManipulation
{
    public class TextIO
    {
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

        public string ReadLine()
        {
            string Text = Console.ReadLine();
            return Text;
        }

        public void SetCursorPosition(int cursorPositionX, int cursorPositionY)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
        }

        public void PrintLine()
        {
            Console.WriteLine();
        }

        public void Print()
        {
            Console.Write(new string(' ', Console.WindowWidth));
        }
    }
}
