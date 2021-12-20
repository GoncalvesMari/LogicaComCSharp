using System;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Entre com o seu nome ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto custa esse produto?");
            double produto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o seu nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(Console.ReadLine());


            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(produto);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);








        }
    }
}
