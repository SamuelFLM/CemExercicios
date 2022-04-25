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
            var entrada = 10;
            var armazena = new string[entrada];
            var animais = new char[] { 'C', 'R', 'S' };
            for (var i = 0; i < armazena.Length; i++)



        }

        public void Exercicio56()
        {
            int a = 0, b = 0;
            for (var i = 1; i <= 10; i++)
            {
                i += 3;
                a = i;
                for (var j = 60; j <= 50; i--)
                {
                    j -= 5;
                    b = j;
                }
                Console.WriteLine($"I={a} J={b}");
            }
        }
    }
}