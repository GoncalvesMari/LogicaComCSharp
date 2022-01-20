﻿using System;
using System.Globalization;

namespace OutroExercicioComVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i=0; i<N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            for(int i=0; i<N; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for(int i=0; i<N; i++)
            {
                soma = soma + vet[i];
            }
            double media = soma / N;

            Console.ReadLine();
        }
    }
}
