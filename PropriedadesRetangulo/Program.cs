using System;

namespace PropriedadesRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Propriedades de um retângulo");
            Console.Write("Digite a largura: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double area = altura * largura;
            double perimetro = 2 * altura + 2 * largura;
            double diagonal = Math.Sqrt(altura * altura + largura * largura);

            Console.WriteLine("\nEsse retângulo tem" +
                "\nArea: " + area +
                "\nPerimetro: " + perimetro +
                "\nDiagonal: " + diagonal);
        }
    }
}
