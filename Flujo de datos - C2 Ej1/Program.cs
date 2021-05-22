using System;

namespace Flujo_de_datos___C2_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = A + B + C;
            Console.WriteLine("La variable D es {0}+{1}+{2} = {3}",A,B,C,D);
        }
    }
}
