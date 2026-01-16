using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Mapa_com_movimento_do_caracter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerX = 5;
            int playerY = 5;
            char[,] mapa = new char[10, 10];

            while (true) 
            { 

                    Console.Clear();

                    for (int linha = 0; linha < 10; linha++)
                    {
                        for (int coluna = 0; coluna < 10; coluna++)
                        {
                            if (playerX == coluna && playerY == linha)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("C");
                                Console.ResetColor();
                            }
                             else // O ELSE PRECISA ESTAR AQUI!
                           {
                            Console.Write(".");
                           }
                    }
                        Console.WriteLine();

                    }
                var tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        
                        if (playerX > 0)playerX--;
                        break;
                    case ConsoleKey.D:
                        if (playerX < 9) playerX++;
                        break;
                    case ConsoleKey.W:
                        if (playerY > 0) playerY--;
                        break;
                    case ConsoleKey.S:
                        if (playerY < 9) playerY++;
                        break;
                }
            }
        }
    }
}
