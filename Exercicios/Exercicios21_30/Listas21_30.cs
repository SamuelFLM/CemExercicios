using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Exercicios21_30
{
    public class Listas21_30
    {
        public void Exercicio21()
        {
            Console.Clear();
            var notas = new int[] { 100, 50, 20, 10, 5, 2 };
            var moedas = new double[] { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };
            var valorEntrada = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");
            for (var i = 0; i < notas.Length; i++)
            {
                var quociente = valorEntrada / notas[i];
                valorEntrada %= notas[i];
                Console.WriteLine($"{(int)quociente} nota(s) de R$ {notas[i]}");
            }
            Console.WriteLine("\nMOEDAS: ");
            for (var i = 0; i < moedas.Length; i++)
            {
                var quocienteMoedas = valorEntrada / moedas[i];
                valorEntrada %= moedas[i];
                Console.WriteLine($"{(int)quocienteMoedas} moeda(s) de R$ {moedas[i]}");
            }
        }

        public void Exercicio22()
        {
            Console.Clear();
            var valores = new int[4];
            for (var i = 0; i < valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }

            if (valores[0] % 2 == 0)
            {
                if (valores[1] > valores[2] && valores[3] > valores[0])
                    if ((valores[2] + valores[3]) > (valores[0] + valores[1]))
                        if (valores[2] > 1 && valores[3] > 1)
                            Console.WriteLine("Valores aceitos");
            }
            else
                Console.WriteLine("Valores nao aceitos");
        }

        public void Exercicio23()
        {
            Console.Clear();



        }
    }
}