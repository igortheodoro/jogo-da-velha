using System;

namespace ConsoleApp1
{
    class Program
    {
        static int[] getCoord(char[,] tabuleiro)
        {
            int[] coord = new int[2];
            Random rnd = new Random();

            coord[0] = rnd.Next(0, 3);
            coord[1] = rnd.Next(0, 3);

            while (tabuleiro[coord[0], coord[1]] != '-')
            {
                coord[0] = rnd.Next(0, 3);
                coord[1] = rnd.Next(0, 3);
            }

            return coord;
        }

        static bool verificar(char[,] tabuleiro)
        {
            bool controlador = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        if (tabuleiro[i, j] == 'X' && tabuleiro[i, j + 1] == 'X' && tabuleiro[i, j + 2] == 'X'
                            || tabuleiro[i, j] == 'O' && tabuleiro[i, j + 1] == 'O' && tabuleiro[i, j + 2] == 'O')
                        {
                            controlador = true;
                        }
                    }

                    if (tabuleiro[0, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 2] == 'X'
                             || tabuleiro[0, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 2] == 'O')
                    {
                        controlador = true;
                    }

                    if (i == 0)
                    {
                        if (tabuleiro[i, j] == 'X' && tabuleiro[i + 1, j] == 'X' && tabuleiro[i + 2, j] == 'X'
                            || tabuleiro[i, j] == 'O' && tabuleiro[i + 1, j] == 'O' && tabuleiro[i + 2, j] == 'O')
                        {
                            controlador = true;
                        }
                    }
                }
            }

            return controlador;
        }
        static void Main(string[] args)
        {
            bool jogador1 = false;
            char[,] tabuleiro = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = '-';
                    Console.Write(tabuleiro[i, j]);
                }
                Console.WriteLine();
            }

            //A função verificar retorna se há um vencedor
            while (verificar(tabuleiro) == false)
            {
                int[] coord = new int[2];
                coord = getCoord(tabuleiro);

                if (jogador1)
                {
                    tabuleiro[coord[0], coord[1]] = 'X';
                    jogador1 = !jogador1;
                }
                else
                {
                    tabuleiro[coord[0], coord[1]] = 'O';
                    jogador1 = !jogador1;
                }

                Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(tabuleiro[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            if (jogador1)
            {
                Console.WriteLine("Jogador 1 (O) ganhou");
            }
            else
            {
                Console.WriteLine("Jogador 2 (X) ganhou");
            }

        }
    }
}
