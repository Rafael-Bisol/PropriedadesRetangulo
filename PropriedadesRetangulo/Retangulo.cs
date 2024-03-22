using System;

namespace PropriedadesRetangulo
{
    class Retangulo
    {
        public double largura, altura;

        public double Area
        {
            get
            {
                return largura * altura;
            }
        }

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

        public Retangulo(){
            largura = 1;
            altura = 1;
        }
        public Retangulo(double largura, double altura){
            this.largura = largura;
            this.altura = altura;
        }
    }
}
