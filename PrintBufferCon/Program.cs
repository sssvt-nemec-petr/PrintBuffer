using System;
using System.IO;
using System.Text;

namespace PrintBufferCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestPrintBuffer();
        }
        static void TestPrintBuffer()
        {
            PrintBuffer printBuffer = new PrintBuffer();
            printBuffer.Print("Jak se máš? Mám se dobře.");
            printBuffer.ToConsole();
            printBuffer.PrinLine("Kolik? Máš s sebou něco?");
            printBuffer.ToConsole();
            Console.ReadKey(true);
        }
    }
    public class PrintBuffer
    {
        StringBuilder stringbuilder = new StringBuilder();
        public void Print(string text)
        {
            stringbuilder.Append(text);
        }
        public void PrinLine(string text)
        {
            stringbuilder.Clear();
            stringbuilder.AppendLine(text);
            char[] stringToTrim = { '.', '?' };
            for (int i = 0; i < stringbuilder.Length; i++)
            {
                if (stringbuilder[i] == stringToTrim[0] 
                    || stringbuilder[i] == stringToTrim[1])
                    stringbuilder.AppendLine(Environment.NewLine);
                else
                    stringbuilder.Append(stringbuilder[i]);
            }
            //Console.WriteLine(stringbuilder);
        }
        public void ToConsole()
        {
            Console.WriteLine(stringbuilder);
        }
    }
}
