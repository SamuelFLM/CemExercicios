using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Exercicios41_50
{
    public class Listas41_50
    {
        public void Exercicio41()
        {
            var dataInicio = new int[4];
            var dataFim = new int[4];

            for (var i = 0; i < dataInicio.Length; i++)
                dataInicio[i] = int.Parse(Console.ReadLine());
            for (var i = 0; i < dataFim.Length; i++)
                dataFim[i] = int.Parse(Console.ReadLine());

            var dayHoursEventsStart = new TimeSpan(dataInicio[0], dataInicio[1], dataInicio[2], dataInicio[3]);
            var dayHoursEventsEnd = new TimeSpan(dataFim[0], dataFim[1], dataFim[2], dataFim[3]);
            var calcEvents = dayHoursEventsStart - dayHoursEventsEnd;

            Console.WriteLine($"{Math.Abs(calcEvents.Days)} dia(s)");
            Console.WriteLine($"{Math.Abs(calcEvents.Hours)} hora(s)");
            Console.WriteLine($"{Math.Abs(calcEvents.Minutes)} minuto(s)");
            Console.WriteLine($"{Math.Abs(calcEvents.Seconds)} segundos(s)");
        }

        public void Exercicio42()
        {
            Console.Clear();

            var valoresPositivos = new float[6];
            float soma = 0;
            for (var i = 0; i < valoresPositivos.Length; i++)
            {
                valoresPositivos[i] = float.Parse(Console.ReadLine());
                if (valoresPositivos[i] > 0)
                    soma += valoresPositivos[i];
            }
            valoresPositivos = valoresPositivos.Where(number => number > 0).ToArray();

            Console.WriteLine($"{valoresPositivos.Length} valores positivos");
            Console.WriteLine("{0:f1}", (soma / (double)valoresPositivos.Length));
        }

        public void Exercicio43()
        {
            var pares = new int[5];
            for (var i = 0; i < pares.Length; i++)
                pares[i] = int.Parse(Console.ReadLine());
            pares = pares.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine($"{pares.Length} valores pares");
        }

        public void Exercicio44()
        {
            // N
            var numeros = new int[5];
            int contador = 0;
            for (var i = 0; i < numeros.Length; i++)
                numeros[i] = int.Parse(Console.ReadLine());

            var numerosPar = numeros = numeros.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine($"{numerosPar.Length} valor(es) par(es)");

            var numerosImpar = numeros = numeros.Where(x => x % 2 == 1).ToArray();
            Console.WriteLine($"{numerosImpar.Length} valor(es) impar(es)");

            var numerosPositivo = numeros = numeros.Where(x => x > 0).ToArray();
            Console.WriteLine($"{numerosPositivo.Length} valor(es) positivo(s)");

            var numerosNegativo = numeros = numeros.Where(x => x < 0).ToArray();
            Console.WriteLine($"{numerosNegativo.Length} valor(es) negativo(es)");
        }


        public void Exercicio45()
        {
            var impar = int.Parse(Console.ReadLine());
            for (var i = 0; i <= impar; i++)
                if (i % 2 == 1)
                    Console.WriteLine(i);
        }

        public void Exercicio46()
        {
            var listas = new List<int>();
            var impar = 8;
            if (impar % 2 == 0)
                impar += 1;
            listas.Add(impar);

            for (var i = 1; i < 6; i++)
                listas.Add(impar += 2);

            listas = listas.Where(x => x % 2 == 1).ToList();
            foreach (int i in listas)
                Console.WriteLine(i);
        }


        public void Exercicio47()
        {
            // N
            var valores = new int[2];
            for (var i = 0; i < valores.Length; i++)
                valores[i] = int.Parse(Console.ReadLine());
        }

        public void Exercicio48()
        {
            int entrada = 4;
            var armazenaDados = new int[entrada];
            int dentro = 0, fora = 0;
            for (var i = 0; i < armazenaDados.Length; i++)
            {
                armazenaDados[i] = int.Parse(Console.ReadLine());
                if (armazenaDados[i] >= 10 && armazenaDados[i] <= 20)
                    dentro++;
                else
                    fora++;
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
        public void Exercicio49()
        {
            int numeroLimite = int.Parse(Console.ReadLine());
            if (numeroLimite > 5)
                for (var i = 1; i <= numeroLimite; i++)
                    if (i % 2 == 0)
                        Console.WriteLine($"{i}^{2} = {Math.Pow(i, 2)}");
        }
        public void Exercicio50()
        {
            var entradaValor = 4;
            var num = new int[entradaValor];
            for (var i = 0; i < num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());

            foreach (int i in num)
            {
                if (i % 2 == 0 && i > 0)
                    Console.WriteLine("EVEN POSITIVO");
                if (i % 2 == 0 && i < 0)
                    Console.WriteLine("EVEN NEGATIVE");

                if (i % 2 == 1 && -i < 0)
                    Console.WriteLine("ODD NEGATIVE");
                if (i % 2 == 1 && i > 0)
                    Console.WriteLine("ODD POSITIVO");
                if (i == 0)
                    Console.WriteLine("NULL");
            }
        }
    }
}