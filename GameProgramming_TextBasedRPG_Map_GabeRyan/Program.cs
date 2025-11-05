using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameProgramming_TextBasedRPG_Map_GabeRyan
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static string[] boarder = { "_", "|" };


        static void Main(string[] args)
        {


            DisplayMap(3);
            


        }
        static void DisplayMap()
        {



            for (int i = 0; i < map.GetLength(0); i++)
            {


                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.SetCursorPosition(1 + j, 1 + i);
                    Console.Write(map[i, j]);


                }

                Console.WriteLine();
            }

            Console.Write("\n");

            //for (int i = 0; i < map.GetLength(1); i++)
            //{
            //    Console.SetCursorPosition(i + 1, 0);
            //    Console.Write(boarder[0]);
            //    Console.SetCursorPosition(i + 1, map.GetLength(0) + 1);
            //    Console.Write(boarder[0]);

            //}
            //for (int j = 0; j < map.GetLength(0); j++)
            //{
            //    Console.SetCursorPosition(0, j + 1);
            //    Console.Write(boarder[1]);
            //    Console.SetCursorPosition(map.GetLength(1) + 1, j + 1);
            //    Console.Write(boarder[1]);
            //}
            //Console.SetCursorPosition(0, 20);
        }

        static void DisplayMap(int scale)
        {
            int length = map.GetLength(0) * scale;


 
            for (int i = 0; i < map.GetLength(0); i++)
            {
                
                for (int x = 0; x < scale; x++)
                {


                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.SetCursorPosition(1, 1);

                        for (int z = 0; z < scale; z++)
                        {
                            
                            Console.Write(map[i, j]);

                        }
                        

                    }
                    if (x < scale)
                    {
                        Console.WriteLine();
                    }
                }
                
            }
            Console.Write("\n");
        }
    }









//            if (scale == 1)
//            {
//                for (int i = 0; i < map.GetLength(0); i++)
//                {


//                    for (int j = 0; j < map.GetLength(1); j++)
//                    {
//                        Console.SetCursorPosition(1 + j, 1 + i);
//                        Console.Write(map[i, j]);


//                    }

//                    Console.WriteLine();
//                }

//                Console.Write("\n");

//                for (int i = 0; i < map.GetLength(1); i++)
//                {
//                    Console.SetCursorPosition(i + 1, 0);
//                    Console.Write(boarder[0]);
//                    Console.SetCursorPosition(i + 1, map.GetLength(0) + 1);
//                    Console.Write(boarder[0]);

//                }
//                for (int j = 0; j < map.GetLength(0); j++)
//                {
                    
//                    Console.Write(boarder[1]);
                    
//                    Console.Write(boarder[1]);
//                }
//                Console.SetCursorPosition(0, 20);
//            }
        
//            if(scale == 2)
//            {
//                for (int i = 0; i < map.GetLength(0); i++)
//                {

//                    for (int j = 0; j < map.GetLength(1); j++)
//                    {
                        
//                        Console.Write(map[i, j]);
                        
//                        Console.Write(map[i, j]);

                        

//                    }

//                    Console.WriteLine();
//                    for (int j = 0; j < map.GetLength(1); j++)
//                    {

//                        Console.Write(map[i, j]);

//                        Console.Write(map[i, j]);


//                    }

//                    Console.Write("\n");
//                }

//                //for (int i = 0; i < map.GetLength(1) * scale; i++)
//                //{
//                //    Console.SetCursorPosition(i + 1, 0);
//                //    Console.Write(boarder[0]);
//                //    Console.SetCursorPosition(i + 1, map.GetLength(0) * scale + 1);
//                //    Console.Write(boarder[0]);

//                //    Thread.Sleep(1000);
//                //}
//                //for (int j = 0; j < map.GetLength(0) * scale; j++)
//                //{
//                //    Console.SetCursorPosition(0, j + 1);
//                //    Console.Write(boarder[1]);
//                //    Console.SetCursorPosition(map.GetLength(1) * scale, j + 1);
//                //    Console.Write(boarder[1]);
//                //}

                
//                Console.ReadKey();
//            }

//            if(scale == 3)
//            {
//                for (int i = 0; i < map.GetLength(0); i++)
//                {

//                    for (int j = 0; j < map.GetLength(1); j++)
//                    {

//                        Console.Write(map[i, j]);

//                        Console.Write(map[i, j]);

//                        Console.Write(map[i, j]);


//                    }

//                    Console.WriteLine();
//                    for (int j = 0; j < map.GetLength(1); j++)
//                    {

//                        Console.Write(map[i, j]);

//                        Console.Write(map[i, j]);

//                        Console.Write(map[i, j]);


//                    }
//                    Console.Write("\n");
//                }
//            }


        }
    
  
