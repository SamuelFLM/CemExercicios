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

        public void Exercicio14()
        {
            Console.Clear();
            var valores = new float[2];

            for (var i = 0; i < valores.Length; i++)
                valores[i] = float.Parse(Console.ReadLine());

            Console.WriteLine("{0:f3} km/l", valores[0] / valores[1]);
        }

        public void Exercicio15()
        {
            Console.Clear();
            var valores = new float[4];
            for (var i = 0; i < valores.Length; i++)
                valores[i] = float.Parse(Console.ReadLine());
            var calc = Math.Pow(valores[2] - valores[0], 2) + Math.Pow(valores[3] - valores[1], 2);
            Console.WriteLine("{0:f4}", Math.Sqrt(calc));
        }

        public void Exercicio16()
        {
            var valorKM = int.Parse(Console.ReadLine());
            Console.WriteLine($"{valorKM * 2} minutos");
        }

        public void Exercicio17()
        {
            Console.Clear();
            var recebeValores = new float[2];
            for (var i = 0; i < recebeValores.Length; i++)
            {
                recebeValores[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0:f3}", (recebeValores[0] * recebeValores[1]) / 12);
        }

        public void Exercicio18()
        {
            Console.Clear();

            var notas = new int[] { 100, 50, 20, 10, 5, 2, 1 };
            var valorNotas = int.Parse(Console.ReadLine());

            for (var i = 0; i < notas.Length; i++)
            {
                var quociente = valorNotas / notas[i];
                Console.WriteLine($"{quociente} nota(s) de R$ {notas[i]},00");
                valorNotas %= notas[i];
            }
        }

        public void Exercicio19()
        {
            Console.Clear();
            var tempo = new int[] { 3600, 60 };
            var segundos = int.Parse(Console.ReadLine());
            Console.WriteLine($"{segundos / tempo[0]}:{segundos / tempo[1]}:{segundos % tempo[1]}");
        }

        public void Exercicio20()
        {
            Console.Clear();
            int data = int.Parse(Console.ReadLine());

            var ano = data / 365;
            var mes = (data % 365) / 30;
            var dia = (data % 365) % 30;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}