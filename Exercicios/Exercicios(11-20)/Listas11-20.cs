using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosOnzeAVinte
{
    public class ListasOnzeAVinte
    {
        public void Exercicio11()
        {
            Console.Clear();
            var valores = new double[] { 3, 15, 1523 };
            for (var i = 0; i < valores.Length; i++)
            {
                double calcVolume = (4 / 3.0) * (3.14159 * Math.Pow(valores[i], 3));
                Console.WriteLine("VOLUME = {0:f3}", calcVolume);
            }
        }

        public void Exercicio12()
        {
            Console.Clear();
            var valores = new List<double>();
            var valoresEntrada = new float[3];
            var nomes = new string[] { "TRIANGULO", "CIRCULO", "TRAPEZIO", "QUADRADO", "RETANGULO" };
            for (var i = 0; i < 3; i++)
            {
                valores.Add(double.Parse(Console.ReadLine()));
            }
            //Começa no 3
            valores.Add((valores[0] * valores[2]) / 2);
            valores.Add(Math.Pow(valores[2], 2) * 3.14159);
            valores.Add(((valores[0] + valores[1]) * valores[2]) / 2);
            valores.Add(Math.Pow(valores[1], 2));
            valores.Add(valores[0] * valores[1]);

            Console.WriteLine($"{nomes[0]}: {valores[3]:f3}");
            Console.WriteLine($"{nomes[1]}: {valores[4]:f3}");
            Console.WriteLine($"{nomes[2]}: {valores[5]:f3}");
            Console.WriteLine($"{nomes[3]}: {valores[6]:f3}");
            Console.WriteLine($"{nomes[4]}: {valores[7]:f3}");
        }

        public void Exercicio13()
        {
            Console.Clear();
            var lista = new List<int>();
            for (var i = 0; i < 3; i++)
            {
                lista.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"{lista.Max()} eh o maior");
        }

    }
}