using System;

namespace ProdutoEscalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Desafio();
        }

        public static void Desafio()
        {
            Console.Clear();

            Console.Write("Escreva o primeiro vetor: ");
            string strVetor1 = Console.ReadLine();

            Console.Write("Escreva o segundo vetor: ");
            string strVetor2 = Console.ReadLine();

            var sptVetor1 = strVetor1.Split(",");
            var sptVetor2 = strVetor2.Split(",");


            int resultado = 0;
            if (sptVetor1.Length == sptVetor2.Length)
            {
                var arrVetor1 = new int[sptVetor1.Length];
                var arrVetor2 = new int[sptVetor1.Length];
                int calculo = 0;
                for (int i = 0; i < sptVetor1.Length; i++)
                {
                    try
                    {
                        arrVetor1[i] = Convert.ToInt32(sptVetor1[i]);
                        arrVetor2[i] = Convert.ToInt32(sptVetor2[i]);
                    }
                    catch
                    {
                        Console.WriteLine("Valor diferente de um número encontrado.");
                        VoltarDesafio();
                    }

                    calculo = arrVetor1[i] * arrVetor2[i];
                    resultado += calculo;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Os vetores precisam ter o mesmo número de elementos.");
                VoltarDesafio();
            }

            Console.Clear();
            Console.Write("O produto escalar entre esses vetores é: ");
            Console.WriteLine(resultado);
            VoltarDesafio();
        }

        public static void VoltarDesafio()
        {
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Desafio();
        }
    }
}
