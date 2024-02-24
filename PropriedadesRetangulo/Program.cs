using System;

namespace PropriedadesRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();
            
            Console.WriteLine("Propriedades de um retângulo");
            Console.Write("Digite a largura: ");
            retangulo1.largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            retangulo1.altura = double.Parse(Console.ReadLine());


            Console.WriteLine("\nEsse retângulo tem" +
                "\nArea: " + retangulo1.CalcularArea() +
                "\nPerimetro: " + retangulo1.CalcularPerimetro() +
                "\nDiagonal: " + retangulo1.CalcularDiagonal());
        }
    }
}
