using System;

namespace Aula007
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.WriteLine($"Digite o valor da posição [{linha},{coluna}]:");
                    matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine();
                }
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
