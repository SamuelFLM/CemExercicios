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
            var tempoInicio = new ushort[2];
            var tempoFinal = new ushort[2];

            for (var i = 0; i < tempoInicio.Length; i++)
                tempoInicio[i] = ushort.Parse(Console.ReadLine());
            for (var n = 0; n < tempoFinal.Length; n++)
                tempoFinal[n] = ushort.Parse(Console.ReadLine());

            var timeSpanHoraMinutoSegundoInicio = new TimeSpan(tempoInicio[0], tempoInicio[1], 59);
            var timeSpanHoraMinutoSegundoFinal = new TimeSpan(tempoFinal[0], tempoFinal[1], 59);

            var calcTempo = timeSpanHoraMinutoSegundoInicio - timeSpanHoraMinutoSegundoFinal;
            Console.WriteLine($"O JOGO DUROU {Math.Abs(calcTempo.Hours)} HORA(S) E {Math.Abs(calcTempo.Minutes)} MINUTO(S)");
        }

        public void Exercicio34()
        {
            var valorSalario = double.Parse(Console.ReadLine());
            regras(valorSalario);

            void regras(double valor)
            {
                var salario = new double[] { 400.00, 800.00, 1200.00, 2000.00 };
                var percetualAjuste = new double[] { 0.15, 0.12, 0.10, 0.07, 0.04 };
                if (valor <= salario[0])
                    calcValor(valor, percetualAjuste[0]);
                else if (valor > salario[0] && valor <= salario[1])
                    calcValor(valor, percetualAjuste[1]);
                else if (valor > salario[1] && valor <= salario[2])
                    calcValor(valor, percetualAjuste[2]);
                else if (valor > salario[2] && valor <= salario[3])
                    calcValor(valor, percetualAjuste[3]);
                else
                    calcValor(valor, percetualAjuste[4]);
            }

            void calcValor(double valor, double valorPercentual)
            {
                Console.WriteLine($"Novo salario: {(valor * valorPercentual) + valor} ");
                Console.WriteLine($"Reajuste ganho: {valor * valorPercentual} ");
                Console.WriteLine($"Em percentual: {(int)valorPercentual * 100} % ");
            }
        }

        public void Exercicio35()
        {
            Console.Clear();

            var entradaNomes = new string[3];
            for (var i = 0; i < entradaNomes.Length; i++)
                entradaNomes[i] = Console.ReadLine();

            if (entradaNomes[0] == "vertebrado")
                Vertebrado(entradaNomes[1], entradaNomes[2]);

            else if (entradaNomes[0] == "invertebrado")
                Invertebrado(entradaNomes[1], entradaNomes[2]);

            void Vertebrado(string tipo, string tipo2)
            {
                var tipoAlimento = new string[] { "carnivoro", "onivoro", "herbivoro" };
                var tipoAve = new string[] { "aguia", "pomba" };
                var tipoMamifero = new string[] { "homem", "vaca" };

                if (tipo == "ave")
                {
                    if (tipo2 == tipoAlimento[0])
                        Console.WriteLine(tipoAve[0]);

                    else if (tipo2 == tipoAlimento[1])
                        Console.WriteLine(tipoAve[1]);
                }

                else if (tipo == "mamifero")
                {
                    if (tipo2 == tipoAlimento[1])
                        Console.WriteLine(tipoMamifero[0]);

                    else if (tipo2 == tipoAlimento[2])
                        Console.WriteLine(tipoMamifero[1]);
                }
            }

            void Invertebrado(string tipo, string tipo2)
            {
                var tipoAlimento = new string[] { "hematofago", "onivoro", "herbivoro" };
                var tipoInseto = new string[] { "pulga", "largarta" };
                var tipoAnelideo = new string[] { "sanguessuga", "minhoca" };

                if (tipo == "inseto")
                {
                    if (tipo2 == tipoAlimento[0])
                        Console.WriteLine(tipoInseto[0]);

                    else if (tipo2 == tipoAlimento[2])
                        Console.WriteLine(tipoInseto[1]);
                }

                else if (tipo == "anelideo")
                {
                    if (tipo2 == tipoAlimento[0])
                        Console.WriteLine(tipoAnelideo[0]);

                    else if (tipo2 == tipoAlimento[1])
                        Console.WriteLine(tipoAnelideo[1]);
                }
            }
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
            var lerSalario = double.Parse(Console.ReadLine());
            Impostos(lerSalario);

            void Impostos(double salario)
            {
                if (salario <= 2000.00)
                    Console.WriteLine("Isento");
                else if (salario >= 2000.01 && salario <= 3000.00)
                    CalcImposto(salario, 1);
                else if (salario >= 3000.01 && salario <= 4500.00)
                    CalcImposto(salario, 2);
                else
                    CalcImposto(salario, 3);
            }

            void CalcImposto(double salario, int retornaImposto)
            {
                switch (retornaImposto)
                {
                    case 1: Console.WriteLine($"{((salario - 2000.00)) * 0.08}"); break;
                    case 2: Console.WriteLine($"{(80 + ((salario - 3000.00) * 0.18))}"); break;
                    case 3: Console.WriteLine($"{(350 + ((salario - 4500.00) * 0.28))}"); break;
                }

            }
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