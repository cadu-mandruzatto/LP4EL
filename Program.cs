using System;

namespace Exercises
{
    class Program
    {
        enum Sinal
        {
            Soma,
            Subtracao
        }
        public static void Main(string[] args)
        {
            const double valor = 4;
            var pi = valor;
            var operacao = Sinal.Subtracao;

            for (var i = 3; i <= 10000; i+= 2)
            {
                if(operacao == Sinal.Subtracao)
                {
                    pi -= valor/i;
                    operacao = Sinal.Soma;
                }
                else
                {
                    pi+= valor/i;
                    operacao = Sinal.Subtracao;
                }
            }

            Console.Write($"O valor de Pi = {pi}");
        }
    }
}