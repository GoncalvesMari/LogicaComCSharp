using System;


namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine());
            comprimento = double.Parse(Console.ReadLine());
            precoMetroQuadrado = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Preco = " + preco);

            Console.ReadLine();

        }

    }
}
