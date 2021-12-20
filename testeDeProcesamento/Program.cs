using System;

namespace testeDeProcesamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y;

            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);

            int a, c;
            double resultado;

            a = 5;
            c = 2;

            resultado = (double) a / c;
            Console.WriteLine(resultado);

        }
    }
}
