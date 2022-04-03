using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosUmADez
{
    public class Listas
    {
        public void Exercicio1()
        {
            //Entradas
            var valorEntrada = new double[] { 2.00, 100.64, 150.00 };

            for (var i = 0; i < valorEntrada.Length; i++)
            {
                double area = 3.14159 * Math.Pow(valorEntrada[i], 2);
                Console.WriteLine("A={0:f4}", area);
            }
        }

        public void Exercicio2()
        {
            short valorA = short.Parse(Console.ReadLine());
            short valorB = short.Parse(Console.ReadLine());
            Console.WriteLine($"X = {valorA + valorB}");
        }

        public void Exercicio3()
        {
            short numA = short.Parse(Console.ReadLine());
            short numB = short.Parse(Console.ReadLine());
            Console.WriteLine($"SOMA = {numA + numB}");
        }

        public void Exercicio4()
        {
            short numA = short.Parse(Console.ReadLine());
            short numB = short.Parse(Console.ReadLine());
            Console.WriteLine($"PROD = {numA * numB}");
        }

        public void Exercicio5()
        {
            Console.Clear();

            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());

            double media = ((numA * 3.5) + (numB * 7.5)) / 11;
            Console.WriteLine("MEDIA = {0:f5}", media);
        }

        public void Exercicio6()
        {
            Console.Clear();

            var notas = new double[3];

            for (var i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
            }
            double media = ((notas[0] * 2) + (notas[1] * 3) + (notas[2] * 5)) / 10;
            Console.WriteLine("MEDIA = {0:f1}", media);
        }

        public void Exercicio7()
        {
            var valores = new int[4];
            for (var i = 0; i < valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }
            int diferenca = (valores[0] * valores[1]) - (valores[2] * valores[3]);
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }

        public void Exercicio8()
        {
            Console.Clear();

            var numeroESalario = new float[3];

            for (var i = 0; i < numeroESalario.Length; i++)
            {
                numeroESalario[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"NUMBER = {numeroESalario[0]}");
            Console.WriteLine("SALARY = U$ {0:f2}", numeroESalario[1] * numeroESalario[2]);


        }

        public void Exercicio9()
        {
            Console.Clear();
            var salario = new double[2];
            string nome = Console.ReadLine();
            for (var i = 0; i < salario.Length; i++)
            {
                salario[i] = double.Parse(Console.ReadLine());
            }
            double comissao = salario[1] * 0.15;
            Console.WriteLine("TOTAL = R$ {0:f2}", salario[0] + comissao);
        }

        public void Exercicio10()
        {
            Console.Clear();
            var valorA = new float[6];
            for (var i = 0; i < valorA.Length; i++)
            {
                valorA[i] = float.Parse(Console.ReadLine());
            }
            float calc = (valorA[1] * valorA[2]) + (valorA[4] * valorA[5]);
            Console.WriteLine("VALOR A PAGAR: R$ {0:f2}", calc);
        }
    }
}




