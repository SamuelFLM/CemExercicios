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

        }

        public void Exercicio32()
        {

        }

        public void Exercicio33()
        {

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