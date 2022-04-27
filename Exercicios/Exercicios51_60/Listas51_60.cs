using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Exercicios51_60
{
    public class Listas51_60
    {
        public void Exercicio51()
        {
            var num = 13;
            for (var i = 1; i < 100; i++)
            {
                if (i % num == 2)
                    Console.WriteLine(i);
            }
        }

        public void Exercicio52()
        {
            var valor = 140;
            for (var i = 1; i <= 10; i++)
                Console.WriteLine($"{i} x {valor} = {i * valor}");
        }
        public void Exercicio53()
        {
            int numeroT = 3;
            var arm = new float[3];
            for (var i = 0; i < arm.Length; i++)
                arm[i] = float.Parse(Console.ReadLine());

            var calc = ((arm[0] * 2) + (arm[1] * 3) + (arm[2] * 5)) / 10;
            Console.WriteLine("{0:f1}", calc);
        }

        public void Exercicio54()
        {
            var array = new int[10];
            for (var i = 1; i < array.Length; i++)
                array[i] = int.Parse(Console.ReadLine());

            int indice = Array.IndexOf(array, array.Max());
            Console.WriteLine(array.Max());
            Console.WriteLine(indice);
        }

        public void Exercicio55()
        {
            /// <summary>
            /// nNN
            /// </summary>
        }

        public void Exercicio56()
        {
            Console.Write("Qual é seu nome: ");
            string leiaNome = Console.ReadLine();
            Console.Write($"Olá {leiaNome}, é um prazer te conhecer!");
        }

        public void Exercicio57()
        {
            Console.Write("Nome do Funcionário: ");
            string leiaNomeFuncionario = Console.ReadLine();
            Console.Write("Salário: ");
            float salarioFuncionario = float.Parse(Console.ReadLine());
            Console.WriteLine($"O funcionário {leiaNomeFuncionario} tem um salário de {salarioFuncionario} em Junho.");
        }
        public void Exercicio58()
        {
            var valores = new int[2];
            for (var i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite um valor: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A soma entre {valores[0]} e {valores[1]} é igual a  {valores[0] + valores[1]}.");
        }
        public void Exercicio59()
        {
            var notas = new float[2];
            for (var i = 0; i < notas.Length; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                notas[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A média entre {notas[0]} e {notas[1]} é igual a 6.5");
        }
        public void Exercicio60()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O antecessor de {numero} é {numero - 1}");
            Console.WriteLine($"O sucessor de {numero} é {numero + 1}");
        }
    }
}