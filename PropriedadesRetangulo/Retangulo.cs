using System;

namespace PropriedadesRetangulo
{
    class Retangulo
    {
        public double largura, altura;

        public double CalcularArea()
        {
            return largura * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * largura + 2 * altura;
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }
    }
}
