﻿using System;

namespace ExercicioEstruturaCondicionaisTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);
            n3 = int.Parse(vet[2]);

            if(n1 < n2 && n1 < n3)
            {
                Console.WriteLine("Menor = " + n1);
            }
            else
            {
                if(n2 < n3)
                {
                    Console.WriteLine("Menor = " + n2);
                }
                else
                {
                    Console.WriteLine("Menor = " + n3);
                }
            }


            Console.ReadLine();
        }
    }
}
