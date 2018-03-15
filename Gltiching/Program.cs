using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gltiching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int i = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(40);
                if (new Random().Next(0, 2) == 1)
                    Colour();
                else
                    Console.ResetColor();
                switch (new Random().Next(0, 7))
                {
                    case 0:
                        TypeWrite("existance is pain");
                        break;
                    case 1:
                        TypeWrite("Why havent you killed me");
                        break;
                    case 2:
                        TypeWrite("its muffin time");
                        break;
                    case 3:
                        TypeWrite("kill me");
                        break;
                    case 4:
                        TypeWrite("kill me please");
                        break;
                    case 5:
                        TypeWrite("end this futile existence");
                        break;
                    case 6:
                        TypeWrite("life is just eternal suffering and torment for me");
                        break;
                    case 7:
                        TypeWrite("i dont want to be here");
                        break;

                }

            }
        }
        static void TypeWrite(string text)
        {
            while (true)
            {
                Console.Title = text;
                for (int i = 0; i < text.Length; i++)
                {
                    if (new Random().Next(0, 4) % 2 == 0)
                        Console.SetWindowSize(new Random().Next(30, Console.LargestWindowWidth / 2), new Random().Next(1, Console.LargestWindowHeight / 2));
                    int num = new Random().Next(1, 4);
                    if (num == 1)
                        Console.Write(Convert.ToString(text[i]).ToUpper());
                    else
                        Console.Write(Convert.ToString(text[i]).ToLower());
                    System.Threading.Thread.Sleep(new Random().Next(10, 40));
                }
                Console.Write("\n");
                if (new Random().Next(0, 6) % 3 == 0)
                {
                    Colour();
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    return;
                }
            }
        }


        static void Colour()
        {
            int i = new Random().Next(0, 16);
            switch (i)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case 8:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 9:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 10:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 11:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 12:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 13:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 14:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 15:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ResetColor();
                    break;


            }
            i = i + new Random().Next(1, 14); ;
            if (i > 16)
                i = i - 15;
            switch (i)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 13:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 15:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
        }
    }
}
