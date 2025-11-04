using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        static void Main(string[] args)
        {



            DisplayMap();



        }
        static void DisplayMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {

                for (int j = 0; j < map.GetLength(1); j++)
                {

                    Console.Write(map[i, j]);


                }

                Console.WriteLine();
            }
            Console.Write("\n");
        }

        static void DisplayMap(int scale)
        {

            if (scale == 1)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {

                    for (int j = 0; j < map.GetLength(1); j++)
                    {

                        Console.Write(map[i, j]);


                    }

                    Console.WriteLine();
                }
                Console.Write("\n");
            }
            if(scale == 2)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {

                    for (int j = 0; j < map.GetLength(1); j++)
                    {

                        Console.Write(map[i, j]);

                        Console.Write(map[i, j]);


                    }

                    Console.WriteLine();
                    for (int j = 0; j < map.GetLength(1); j++)
                    {

                        Console.Write(map[i, j]);

                        Console.Write(map[i, j]);


                    }
                    Console.Write("\n");
                }
            }

            if(scale == 3)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {

                    for (int j = 0; j < map.GetLength(1); j++)
                    {

                        Console.Write(map[i, j]);

                        Console.Write(map[i, j]);

                        Console.Write(map[i, j]);


                    }

                    Console.WriteLine();
                    for (int j = 0; j < map.GetLength(1); j++)
                    {

                        Console.Write(map[i, j]);

                        Console.Write(map[i, j]);

                        Console.Write(map[i, j]);


                    }
                    Console.Write("\n");
                }
            }


        }
    }
}
