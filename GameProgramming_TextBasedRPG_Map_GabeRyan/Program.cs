using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameProgramming_TextBasedRPG_Map_GabeRyan
{
    internal class Program
    {
        static Random random = new Random();
        
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','O','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','O','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','O','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','O','`','`','`','`','`'},
            {'`','`','`','O','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','O','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','O','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','O','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','O','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','O','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','O','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','O','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static string[] boarder = { "═", "║" };


        static void Main(string[] args)
        {

            Console.ReadKey();
            DisplayMap();

          

        }
        static void DisplayMap()
        {



            for (int i = 0; i < map.GetLength(0); i++)
            {


                for (int j = 0; j < map.GetLength(1); j++)
                {

                    for (int z = 0; z < 1; z++)
                    {
                        if (map[i, j] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else if (map[i, j] == '`')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (map[i, j] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (map[i, j] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (map[i, j] == 'O')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.SetCursorPosition(1 + j, 1 + i);
                        Console.Write(map[i, j]);
                        Console.ResetColor();
                    }

                   


                }

                Console.WriteLine();
            }

            Console.Write("\n");

            for (int k = 0; k < map.GetLength(1); k++)
            {
                Console.SetCursorPosition(k + 1, 0);
                Console.Write(boarder[0]);
                Console.SetCursorPosition(k + 1, map.GetLength(0) + 1);
                Console.Write(boarder[0]);

            }
            for (int n = 0; n < map.GetLength(0); n++)
            {
                Console.SetCursorPosition(0, n + 1);
                Console.Write(boarder[1]);
                Console.SetCursorPosition(map.GetLength(1) + 1, n + 1);
                Console.Write(boarder[1]);
            }
            

            Console.SetCursorPosition(map.GetLength(1) + 5, 0);
            Console.Write("' = Ground");
            Console.SetCursorPosition(map.GetLength(1) + 5, 1);
            Console.Write("^ = Tree");
            Console.SetCursorPosition(map.GetLength(1) + 5, 2);
            Console.Write("~ = Water");
            Console.SetCursorPosition(map.GetLength(1) + 5, 3);
            Console.Write("* = Snow");
            Console.SetCursorPosition(map.GetLength(1) + 5, 4);
            Console.Write("O = Berry Bushes");
            Console.ReadKey();
        }

        static void DisplayMap(int scale)
        {
            

            for (int BoardTop = 0; BoardTop < (map.GetLength(1)) * scale; BoardTop++)
            {
                Console.SetCursorPosition(BoardTop + 1, 0);
                Console.Write(boarder[0]);

            }
           

            

            Console.SetCursorPosition(0, 1);


            for (int i = 0; i < map.GetLength(0); i++)
            {


                for (int x = 0; x < scale; x++)
                {
                    Console.CursorLeft = 1;

                    for (int j = 0; j < map.GetLength(1); j++)
                    {




                        for (int z = 0; z < scale; z++)
                        {
                            if (map[i,j] == '^')
                            {
                               Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else if (map[i,j] == '`')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (map[i,j] == '~')
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (map[i,j] == '*')
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (map[i,j] == 'O')
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                                Console.Write(map[i, j]);
                            Console.ResetColor();
                        }

                    }
                    if (x < scale)
                    {

                        Console.WriteLine();
                    }
                }

            }


            Console.Write("\n");



            for (int BoardTop = 0; BoardTop < (map.GetLength(1)) * scale; BoardTop++)
            {

                int randomLength = random.Next(0, map.GetLength(0));

                Console.SetCursorPosition(BoardTop + 1, map.GetLength(0) * scale);
                Console.Write(boarder[0]);

                
            }

            for (int BoardSide = 0; BoardSide < map.GetLength(0) * scale; BoardSide++)
            {
                Console.SetCursorPosition(0, BoardSide + 1);
                Console.Write(boarder[1]);
                Console.SetCursorPosition(map.GetLength(1) * scale + 1, BoardSide + 1);
                Console.Write(boarder[1]);



            }

            Console.SetCursorPosition(map.GetLength(1) * scale + 5, 0);
            Console.Write("' = Ground");
            Console.SetCursorPosition(map.GetLength(1) * scale + 5, 1);
            Console.Write("^ = Tree");
            Console.SetCursorPosition(map.GetLength(1) * scale + 5, 2);
            Console.Write("~ = Water");
            Console.SetCursorPosition(map.GetLength(1) * scale + 5, 3);
            Console.Write("* = Snow");
            Console.SetCursorPosition(map.GetLength(1) * scale + 5, 3);
            Console.Write("O = Berry Bushes");
            Console.ReadKey();


            
            

            Console.Write("\n");

            



        }




    }
}
    
  
