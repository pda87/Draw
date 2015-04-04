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
            Console.Title = "Draw";
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
            Console.SetCursorPosition(85, 10);
            Console.WriteLine("DDDDD   RRRRRR    AAA   WW      WW ");
            Console.SetCursorPosition(85, 11);
            Console.WriteLine("DD  DD  RR   RR  AAAAA  WW      WW ");
            Console.SetCursorPosition(85, 12);
            Console.WriteLine("DD   DD RRRRRR  AA   AA WW   W  WW ");
            Console.SetCursorPosition(85, 13);
            Console.WriteLine("DD   DD RR  RR  AAAAAAA  WW WWW WW ");
            Console.SetCursorPosition(85, 14);
            Console.WriteLine("DDDDDD  RR   RR AA   AA   WW   WW  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************************************************************************************WRITTEN BY PETER ARDEN" +
                                                    "******************************************************************************************");

            helpMessage();

            //Thread.Sleep(2000);
            //Thread.Sleep(2000);
            //Thread.Sleep(2000);

            Console.Clear();

            #region initialanimation

            while (true)
            {
                Thread.Sleep(40);
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
            int stringLength = 5;

            #region mainLoop

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
                    mainString = mainString.PadRight(stringLength, '*');
                    Console.CursorVisible = false;
                }

                if (checkKey == true)
                {
                    Console.ForegroundColor = Console.BackgroundColor;
                    ConsoleKeyInfo input = Console.ReadKey();

                    if (input.Key == ConsoleKey.X)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 0);
                        Console.Write("Enter horizontal position: ");
                        string value = Console.ReadLine();
                        Console.ForegroundColor = Console.BackgroundColor;
                        Console.Write("                                              ");

                        if (int.TryParse(value, out xConsolePosition))
                        {
                            xConsolePosition = Convert.ToInt32(value);
                            if (xConsolePosition <= 0)
                            {
                                xConsolePosition = 0;
                            }

                            if (xConsolePosition >= 193 - mainString.Length)
                            {
                                xConsolePosition = 193 - stringLength;
                            }
                        }
                    }

                    if (input.Key == ConsoleKey.Y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 0);
                        Console.Write("Enter vertical position: ");
                        string value = Console.ReadLine();
                        Console.ForegroundColor = Console.BackgroundColor;
                        Console.Write("                                              ");

                        if (int.TryParse(value, out yConsolePosition))
                        {
                            yConsolePosition = Convert.ToInt32(value);
                            if (yConsolePosition <= 0)
                            {
                                yConsolePosition = 0;
                            }

                            if (yConsolePosition >= 59)
                            {
                                yConsolePosition = 59;
                            }
                        }
                    }
                    
                    if (input.Key == ConsoleKey.Q)
                    {
                        break;
                    }

                    if (input.Key == ConsoleKey.H)
                    {
                        helpMessage();
                        Console.SetCursorPosition(xConsolePosition, yConsolePosition);
                    }

                    if (input.Key == ConsoleKey.A)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    if (input.Key == ConsoleKey.S)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    
                    if (input.Key == ConsoleKey.Add)
                    {
                        if (stringLength < 31)
                        {
                            stringLength += 1;
                        }
                    }

                    if (input.Key == ConsoleKey.Subtract)
                    {
                        if (stringLength > 1)
                        {
                            stringLength = stringLength - 1;
                            
                        }
                    }

                    if (input.Key == ConsoleKey.NumPad8 && input.Key == ConsoleKey.NumPad6)
                    {
                        xConsolePosition++;
                        yConsolePosition++;
                    }

                    if (input.Key == ConsoleKey.NumPad8 && input.Key == ConsoleKey.NumPad4)
                    {
                        xConsolePosition--;
                        yConsolePosition++;
                    }

                    if (input.Key == ConsoleKey.NumPad6 && input.Key == ConsoleKey.NumPad2)
                    {
                        xConsolePosition++;
                        yConsolePosition--;
                    }

                    if (input.Key == ConsoleKey.NumPad4 && input.Key == ConsoleKey.NumPad2)
                    {
                        xConsolePosition--;
                        yConsolePosition--;
                    }


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

                if (xConsolePosition >= 193 - mainString.Length)
                {
                    xConsolePosition = 193 - stringLength;
                }

                if (yConsolePosition <= 0)
                {
                    yConsolePosition = 0;
                }

                if (yConsolePosition >= 59)
                {
                    yConsolePosition = 59;
                }
            }

            #endregion

            quitMessage();
        }

        private static void quitMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 200; i++)
            {
                for (int j = 60; j > 0; j--)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write("*");

                }


            }
        }

        private static void helpMessage()
        {
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
            Console.WriteLine("*****                 Press 0 to toggle line trails on or off           *****");
            Console.SetCursorPosition(60, 38);
            Console.WriteLine("*****                   Press H to display this help message            *****");
            Console.SetCursorPosition(60, 39);
            Console.WriteLine("*****                      Press + to increase the pen size             *****");
            Console.SetCursorPosition(60, 40);
            Console.WriteLine("*****                Press - and 0 twice to decrease the pen size       *****");
            Console.SetCursorPosition(60, 41);
            Console.WriteLine("*****                      Press A for a black background               *****");
            Console.SetCursorPosition(60, 42);
            Console.WriteLine("*****                      Press S for a white background               *****");
            Console.SetCursorPosition(60, 43);
            Console.WriteLine("*****               Press X to set the horizonal cursor position        *****");
            Console.SetCursorPosition(60, 44);
            Console.WriteLine("*****               Press Y to set the vertical  cursor position        *****");
            Console.SetCursorPosition(60, 47);
            Console.WriteLine("*****                              Press Q to quit                      *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(90, 46);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.SetCursorPosition(60, 30);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 31);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 32);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 33);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 34);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 35);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 36);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 37);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 38);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 39);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 40);
            Console.WriteLine("                                                                             ");
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(90, 40);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 41);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 42);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 43);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 44);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 46);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(60, 47);
            Console.WriteLine("                                                                             ");
        }
    }
}
