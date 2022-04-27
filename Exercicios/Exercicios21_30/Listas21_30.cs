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
            var valores = new double[3];

            for (var i = 0; i < valores.Length; i++)
                valores[i] = double.Parse(Console.ReadLine());
                
            var delta = Math.Pow(valores[1], 2) - (4 * valores[0] * valores[2]);

            if (delta > 0)
            {
                var result = (valores[1] - Math.Sqrt(delta)) / (2 * valores[0]);
                Console.WriteLine("R1 = {0:f5}", result);
                var result2 = (valores[1] + Math.Sqrt(delta)) / (2 * valores[0]);
                Console.WriteLine("R2 = {0:f5}", result2);
            }
        }

        public void Exercicio24()
        {
            Console.Clear();

            var intervalos = new double[] { 0.25, 25.50, 50.75, 75.100 };

            double recebeValor = double.Parse(Console.ReadLine());

            if (recebeValor >= intervalos[0] && recebeValor < intervalos[1])
                Console.WriteLine($"Intervalo ({intervalos[0]}]");

            else if (recebeValor >= intervalos[1] && recebeValor < intervalos[2])
                Console.WriteLine($"Intervalo ({intervalos[1]}]");

            else if (recebeValor >= intervalos[2] && recebeValor < intervalos[3])
                Console.WriteLine($"Intervalo ({intervalos[2]}]");

            else if (recebeValor >= intervalos[3] && recebeValor <= 100)
                Console.WriteLine($"Intervalo ({intervalos[3]}]");
            else
                Console.WriteLine("Fora de intervalo");
        }

        public void Exercicio25()
        {
            Console.Clear();

            Console.Write("Codigo: ");
            short option = short.Parse(Console.ReadLine());

            Console.Write("\nQtd Vezes: ");
            short qtdVezes = short.Parse(Console.ReadLine());

            CodigoEVezes(option, qtdVezes);

            void CodigoEVezes(short option, short qtdVezes)
            {
                var valores = new double[] { 4.00, 4.50, 5.00, 2.00, 1.50 };
                switch (option)
                {
                    case 1: var retorno = valores[0] * qtdVezes; Console.WriteLine("Total: R$ {0:f2}", retorno); break;
                    case 2: var retorno2 = valores[1] * qtdVezes; Console.WriteLine("Total: R$ {0:f2}", retorno2); break;
                    case 3: var retorno3 = valores[2] * qtdVezes; Console.WriteLine("Total: R$ {0:f2}", retorno3); break;
                    case 4: var retorno4 = valores[3] * qtdVezes; Console.WriteLine("Total: R$ {0:f2}", retorno4); break;
                    case 5: var retorno5 = valores[4] * qtdVezes; Console.WriteLine("Total: R$ {0:f2}", retorno5); break;
                }
            }
        }

        public void Exercicio26()
        {
            var notas = new float[4];
            Console.Clear();

            var n = 1;
            for (var i = 0; i < notas.Length; i++)
            {
                Console.Write($"Notas {n++} : ");
                notas[i] = float.Parse(Console.ReadLine());
            }
            var media = ((notas[0] * 2) + (notas[1] * 3) + (notas[2] * 4) + (notas[3] * 1)) / 10;

            if (media >= 5.0 && media <= 6.9)
            {
                AlunoExame();
            }
            else if (media >= 7.0)
            {
                Console.WriteLine($"MEDIA : {media}");
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine($"MEDIA : {media}");
                Console.WriteLine("Aluno reprovado");
            }


            void AlunoExame()
            {
                Console.Clear();

                var notaExame = 6.4f;
                Console.WriteLine($"MEDIA : {media}");
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine($"Nota do exame: {notaExame}");
                if ((notaExame + media) / 2 >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {(notaExame + media) / 2}");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {(notaExame + media) / 2}");
                }
            }
        }

        public void Exercicio27()
        {
            Console.Clear();
            var eixos = new float[2];
            var quadrantes = new string[] { "Q1", "Q2", "Q3", "Q4" };

            for (var i = 0; i < eixos.Length; i++)
            {
                eixos[i] = float.Parse(Console.ReadLine());
            }

            ReturnQuadrante(eixos[0], eixos[1]);

            void ReturnQuadrante(float eixoX, float eixoY)
            {
                if (eixoX > 0.0 && eixoY < 0.0)
                    Console.WriteLine(quadrantes[3]);
                if (eixoX > 0.0 && eixoY > 0.0)
                    Console.WriteLine(quadrantes[0]);
                if (eixoX < 0.0 && eixoY > 0.0)
                    Console.WriteLine(quadrantes[1]);
                if (eixoX < 0.0 && eixoY < 0.0)
                    Console.WriteLine(quadrantes[2]);
                if (eixoX == 0.0 && eixoY == 0.0)
                    Console.WriteLine("Origem");
            }
        }

        public void Exercicio28()
        {
            Console.Clear();

            var vr = new int[3];
            var vp = new int[3];

            for (var i = 0; i < vr.Length; i++)
            {
                vr[i] = int.Parse(Console.ReadLine());
                vp[i] = vr[i];
            }

            Array.Sort(vr);
            Console.Clear();

            foreach (int vrr in vr)
            {
                Console.WriteLine(vrr);
            }
            Console.WriteLine("");
            foreach (int vpp in vp)
            {
                Console.WriteLine(vpp);
            }
        }

        public void Exercicio29()
        {
            Console.Clear();
            var valores = new float[3];

            for (var i = 0; i < valores.Length; i++)
            {
                Console.Write($"Valor {i + 1} : ");
                valores[i] = float.Parse(Console.ReadLine());
            }

            if (valores[0] < valores[1] + valores[2])
                Console.WriteLine($"Perimetro = {(float)valores[0] + valores[1] + valores[2]}");
            else
                Console.WriteLine($"Area = {(((float)valores[0] + valores[1]) * valores[2]) / 2}");
        }

        public void Exercicio30()
        {
            Console.Clear();
            var multiplos = new int[2];
            for (var i = 0; i < multiplos.Length; i++)
            {
                multiplos[i] = int.Parse(Console.ReadLine());
            }

            var result = multiplos[1] / multiplos[0];

            if (result * multiplos[0] == multiplos[1])
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}