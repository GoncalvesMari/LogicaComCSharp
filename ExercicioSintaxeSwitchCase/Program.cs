using System;

namespace ExercicioSintaxeSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch(x)
            {
                case 1;
                dia = "domingo";
                    break;
                case 2;
                    dia = "terça";
                    break;
                case 3;
                    dia = "quarta";
                    break;
                case 4;
                    dia = "quinta";
                    break;
                default:
                    dia = "valor invalido ";
                    break;

            }
            

            Console.WriteLine("Dia da Semana: " + dia);

            Console.ReadLine();
        }
    }
}
