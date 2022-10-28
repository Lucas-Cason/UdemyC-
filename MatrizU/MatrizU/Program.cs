using System;
using System.Globalization;
using System.Collections.Generic;

namespace MatrizU
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3]; // tipo[,] <nome da matriz> = new tipo[qtd linhas, qutd colunas];

            Console.WriteLine(mat.Length); // exibe quantos elementos a matriz tem total
            Console.WriteLine(mat.Rank); // quantas linhas tem
            Console.WriteLine(mat.GetLength(0)); // linhas
            Console.WriteLine(mat.GetLength(1)); // colunas
        }
    }
}