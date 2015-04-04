    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowWidth = 200;
            Console.WindowHeight = 60;
            int xConsolePosition = 100;
            int yConsolePosition = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************" +
                                "********************************************************************************************************");

            Console.SetCursorPosition(80, 10);
            Console.WriteLine("DDDDD   RRRRRR    AAA   WW      WW ");
            Console.SetCursorPosition(80, 11);
            Console.WriteLine("DD  DD  RR   RR  AAAAA  WW      WW ");
            Console.SetCursorPosition(80, 12);
            Console.WriteLine("DD   DD RRRRRR  AA   AA WW   W  WW ");
            Console.SetCursorPosition(80, 13);
            Console.WriteLine("DD   DD RR  RR  AAAAAAA  WW WWW WW ");
            Console.SetCursorPosition(80, 14);
            Console.WriteLine("DDDDDD  RR   RR AA   AA   WW   WW  ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************************************************************************************WRITTEN BY PETER ARDEN" +
                                                    "******************************************************************************************");

            Console.SetCursorPosition(60, 30);
            Console.WriteLine("*****          USE THE NUMLOCK KEYS (ENSURE NUMLOCK IS TURNED ON)       *****");
            Console.SetCursorPosition(60, 31);
            Console.WriteLine("***** Press 2, 4, 6, & 8 to move down, left, right and up, respectively *****");
            Console.SetCursorPosition(60, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*****               Press 1 to change the colour to yellow              *****");
            Console.SetCursorPosition(60, 33);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****                 Press 3 to change the colour to green             *****");
            Console.SetCursorPosition(60, 34);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*****                  Press 9 to change the colour to  red             *****");
            Console.SetCursorPosition(60, 35);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****                  Press 7 to change the colour to  blue            *****");
            Console.SetCursorPosition(60, 36);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****             Press 5 to toggle drawing and clear the console       *****");
            Console.SetCursorPosition(60, 37);
            Console.WriteLine("*****                 Press 0 to toggle line trails on or off            *****");

            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            Thread.Sleep(2000);

            Console.SetCursorPosition(90, 40);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            
            Console.Clear();

            #region initialanimation

            while (true)
            {
                Thread.Sleep(50);
                //bool checkKey = Console.KeyAvailable;
                Console.Clear();
                Console.SetCursorPosition(xConsolePosition, yConsolePosition);

                Console.Write("*****");

                if (yConsolePosition < 60)
                {
                    yConsolePosition++;
                }

                //if (checkKey == true)
                //{

                //    Console.ForegroundColor = ConsoleColor.Black;

                //    ConsoleKeyInfo input = Console.ReadKey();

                //    if (input.Key == ConsoleKey.NumPad6)
                //    {
                //        xConsolePosition++;
                //    }

                //    if (input.Key == ConsoleKey.NumPad4)
                //    {
                //        xConsolePosition--;
                //    }

                //    Console.ForegroundColor = ConsoleColor.Green;
                //}

                //if (xConsolePosition <= 0)
                //{
                //    xConsolePosition = 0;
                //}

                //if (xConsolePosition >= 193)
                //{
                //    xConsolePosition = 193;
                //}

                if (yConsolePosition == 60)
                {
                    break;
                }

            }

            #endregion

            //********************************************************************************************************************************************************************************
            //********************************************************************************************************************************************************************************
            //********************************************************************************************************************************************************************************
            //********************************************************************************************************************************************************************************
            //********************************************************************************************************************************************************************************
            //********************************************************************************************************************************************************************************


            bool consoleClear = true;
            bool clearTrail = false;
            bool conGreen = true;
            bool conRed = false;
            bool conBlue = false;
            bool conYellow = false;
            string mainString = "*****";

            while (true)
            {
                Thread.Sleep(10);
                bool checkKey = Console.KeyAvailable;

                if (consoleClear == true)
                {
                    Console.Clear();
                }

                Console.SetCursorPosition(xConsolePosition, yConsolePosition);

                Console.Write(mainString);


                if (clearTrail == true)
                {
                    mainString = ("");
                    Console.CursorVisible = true;
                    Console.CursorSize = 20;
                }

                if (clearTrail == false)
                {
                    mainString = ("*****");
                    Console.CursorVisible = false;
                }

                if (checkKey == true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    ConsoleKeyInfo input = Console.ReadKey();

                    if (input.Key == ConsoleKey.NumPad6)
                    {
                        xConsolePosition++;
                    }

                    if (input.Key == ConsoleKey.NumPad4)
                    {
                        xConsolePosition--;
                    }

                    if (input.Key == ConsoleKey.NumPad8)
                    {
                        yConsolePosition--;
                    }

                    if (input.Key == ConsoleKey.NumPad2)
                    {
                        yConsolePosition++;
                    }

                    if (input.Key == ConsoleKey.NumPad5)
                    {
                        if (consoleClear == true)
                        {
                            consoleClear = false;
                        }

                        else if (consoleClear == false)
                        {
                            consoleClear = true;
                        }
                    }

                    if (input.Key == ConsoleKey.NumPad0)
                    {
                        if (clearTrail == true)
                        {
                            clearTrail = false;
                        }

                        else if (clearTrail == false)
                        {
                            clearTrail = true;
                        }
                    }


                    if (input.Key == ConsoleKey.NumPad7)
                    {
                        conBlue = true;
                        conRed = false;
                        conGreen = false;
                        conYellow = false;

                    }

                    if (input.Key == ConsoleKey.NumPad9)
                    {
                        conRed = true;
                        conGreen = false;
                        conBlue = false;
                        conYellow = false;
                    }

                    if (input.Key == ConsoleKey.NumPad3)
                    {
                        conGreen = true;
                        conRed = false;
                        conBlue = false;
                        conYellow = false;
                    }

                    if (input.Key == ConsoleKey.NumPad1)
                    {
                        conYellow = true;
                        conGreen = true;
                        conRed = false;
                        conBlue = false;
                    }

                    if (conGreen == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    if (conRed == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (conBlue == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }

                    if (conYellow == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }

                if (xConsolePosition <= 0)
                {
                    xConsolePosition = 0;
                }

                if (xConsolePosition >= 193)
                {
                    xConsolePosition = 193;
                }

                if (yConsolePosition <= 0)
                {
                    yConsolePosition = 0;
                }

                if (yConsolePosition >= 60)
                {
                    yConsolePosition = 60;
                }
            }

        }
    }
}
