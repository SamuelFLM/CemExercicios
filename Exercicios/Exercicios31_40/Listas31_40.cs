using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Exercicios31_40
{
    public class Listas31_40
    {
        public void Exercicio31()
        {
            Console.Clear();
            var triangulo = new double[3];

            for (var i = 0; i < triangulo.Length; i++)
                triangulo[i] = double.Parse(Console.ReadLine());
            var trianguloOrd = triangulo.OrderByDescending(x => x).ToArray();

            if (trianguloOrd[0] > 0 && trianguloOrd[1] > 0 && trianguloOrd[2] > 0)
            {
                if (trianguloOrd[0] >= trianguloOrd[1] + trianguloOrd[2])
                    Console.WriteLine("NAO FORMA TRIANGULO");

                if (Math.Pow(trianguloOrd[0], 2) == Math.Pow(trianguloOrd[1], 2) + Math.Pow(trianguloOrd[2], 2))
                    Console.WriteLine("TRIANGULO RETANGULO");

                if (Math.Pow(trianguloOrd[0], 2) > Math.Pow(trianguloOrd[1], 2) + Math.Pow(trianguloOrd[2], 2))
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                if (Math.Pow(trianguloOrd[0], 2) < Math.Pow(trianguloOrd[1], 2) + Math.Pow(trianguloOrd[2], 2))
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                if (Math.Pow(trianguloOrd[0], 2) == Math.Pow(trianguloOrd[1], 2) && Math.Pow(trianguloOrd[1], 2) == Math.Pow(trianguloOrd[2], 2))
                    Console.WriteLine("TRIANGULO EQUILATERO");

                if (Math.Pow(trianguloOrd[0], 2) == Math.Pow(trianguloOrd[1], 2) || Math.Pow(trianguloOrd[0], 2) == Math.Pow(trianguloOrd[2], 2) || Math.Pow(trianguloOrd[1], 2) == Math.Pow(trianguloOrd[2], 2))
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }
            else
                Console.WriteLine("Programa Finalizado");
        }

        public void Exercicio32()
        {
            Console.Clear();
            var jogo = new short[2];

            for (var i = 0; i < jogo.Length; i++)
            {
                jogo[i] = short.Parse(Console.ReadLine());
            }

            if (jogo[1] >= 1 && jogo[1] <= 24 && jogo[0] >= 1)
            {
                if (jogo[0] > jogo[1])
                {
                    var calcTempo = (jogo[1] + 24) - jogo[0];
                    Console.WriteLine($"O JOGO DUROU {calcTempo} HORA(S)");
                }
                else
                {
                    var calcTempo = jogo[1] - jogo[0];
                    Console.WriteLine($"O JOGO DUROU {calcTempo} HORA(S)");
                }
            }
            else
                Console.WriteLine($"O JOGO DUROU {24} HORA(S)");



        }

        public void Exercicio33()
        {
            var tempo = new ushort[4];

            for (var i = 0; i < tempo.Length; i++)
                tempo[i] = ushort.Parse(Console.ReadLine());

            if (tempo[0] <= 24 && tempo[2] <= 24 && tempo[1] >= 1 && tempo[3] >= 1)
            {
                if (tempo[0] - tempo[2] == 1 && tempo[1] - tempo[3] == 1)
                    Console.WriteLine($"O JOGO DUROU 0 HORA(S) E {60 - 1} MINUTO(S)");
                else if (tempo[0] - tempo[2] == 0 && tempo[1] - tempo[3] == 0)
                    Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
                else
                    Console.WriteLine($"O JOGO DUROU {tempo[2] - tempo[0]}HORA(S) E {+tempo[3] - tempo[1]} MINUTO(S)");
            }

        }

        public void Exercicio34()
        {

        }

        public void Exercicio35()
        {

        }

        public void Exercicio36()
        {
            short ddd = short.Parse(Console.ReadLine());

            switch (ddd)
            {
                case 61: Console.WriteLine("Brasilia"); break;
                case 71: Console.WriteLine("Salvador"); break;
                case 11: Console.WriteLine("Sao paulo"); break;
                case 21: Console.WriteLine("Rio de janeiro"); break;
                case 32: Console.WriteLine("Juiz de fora"); break;
                case 19: Console.WriteLine("Campinas"); break;
                case 27: Console.WriteLine("Vitoria"); break;
                case 31: Console.WriteLine("Belo Horizonte"); break;
            }
        }

        public void Exercicio37()
        {



        }

        public void Exercicio38()
        {
            short month = short.Parse(Console.ReadLine());

            switch (month)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
            }
        }

        public void Exercicio39()
        {
            Console.Clear();
            for (var i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        //1060
        public void Exercicio40()
        {
            Console.Clear();
            var valores = new float[6];
            for (var i = 0; i < valores.Length; i++)
            {
                valores[i] = float.Parse(Console.ReadLine());
            }

            valores = valores.Where(x => x > 0).ToArray();

            Console.WriteLine($"{valores.Length} valores positivos");

        }
    }
}