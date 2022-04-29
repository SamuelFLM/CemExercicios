namespace Exercicios.Exercicios81_90
{
    public class Listas81_90
    {
        public void Exercicios81()
        {
            var notaAluno = new float[2];
            for (var i = 0; i < notaAluno.Length; i++)
                notaAluno[i] = float.Parse(Console.ReadLine());
            var calcNotaAluno = (notaAluno[0] + notaAluno[1]) / 2;
            if (calcNotaAluno < 5.0)
                Console.WriteLine($"Nota {calcNotaAluno} : REPROVADO");
            else if (calcNotaAluno >= 5.0 && calcNotaAluno <= 6.9)
                Console.WriteLine($"Nota {calcNotaAluno} : RECUPERAÇÃO");
            else
                Console.WriteLine($"Nota {calcNotaAluno} : APROVADO");
        }
        public void Exercicios82()
        {
            var terreno = new float[2];
            for (var i = 0; i < terreno.Length; i++)
                terreno[i] = float.Parse(Console.ReadLine());
            var calcTerreno = terreno[0] * terreno[1];
            if (calcTerreno < 100)
                Console.WriteLine("TERRENO POPULAR");
            else if (calcTerreno > 100 && calcTerreno < 500)
                Console.WriteLine("TERRENO MASTER");
            else
                Console.WriteLine("TERRENO VIP");
        }
        public void Exercicios83()
        {
            Console.Write("Infome seu nome: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Infome seu Salario: ");
            double salarioFuncionario = double.Parse(Console.ReadLine());
            short anosEmpresa = short.Parse(Console.ReadLine());

            if (anosEmpresa <= 3)
                Console.Write($"Reajuste Salario: {(salarioFuncionario * 0.03) + salarioFuncionario}");
            else if (anosEmpresa > 3 && anosEmpresa < 10)
                Console.Write($"Reajuste Salario: {(salarioFuncionario * 0.125) + salarioFuncionario}");
            else
                Console.Write($"Reajuste Salario: {(salarioFuncionario * 0.20) + salarioFuncionario}");
        }
        public void Exercicios84()
        {
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

        public void Exercicios85()
        {
            var opcao = new string[] { "Pedra", "Papel", "Tesoura" };
            Random random = new Random();
            int tamanhoSorteio = random.Next(opcao.Length);
            var sorteia = ((string)opcao[tamanhoSorteio]);

            Console.Write("Informe uma opção: ");
            Console.WriteLine("\n[1] - Tesoura ");
            Console.WriteLine("[2] - Pedra ");
            Console.WriteLine("[3] - Papel ");
            Console.Write("\nDigite:  ");
            short opUser = short.Parse(Console.ReadLine());

            string selecionado;
            switch (opUser)
            {
                case 1:
                    if (sorteia == "Pedra")
                        Console.WriteLine($"Robo jogou {sorteia} - Voce Perdeu");
                    else
                        Console.WriteLine($"Robo jogou {sorteia} - Voce Ganhou");
                    break;
                case 2:
                    if (sorteia == "Papel")
                        Console.WriteLine($"Robo jogou {sorteia} - Voce Perdeu");
                    else
                        Console.WriteLine($"Robo jogou {sorteia} - Voce Ganhou");
                    break;
                case 3:
                    if (sorteia == "Tesoura")
                        Console.WriteLine($"Robo jogou {sorteia} - Voce Perdeu");
                    else
                        Console.WriteLine($"Robo jogou {sorteia} - Voce Ganhou");
                    break;
            }

        }
        public void Exercicios86()
        {
            Random rm = new Random();
            int numeroAleatorio = rm.Next(1, 6);
            Console.Write("Informe um número: ");
            short numeroUser = short.Parse(Console.ReadLine());
            if (numeroUser == numeroAleatorio)
                Console.WriteLine("Parabens Acertou");
            else
                Console.WriteLine($"Errou numero era : {numeroAleatorio}");
        }
        public void Exercicios87()

        {
            var valores = new double[] { 2.0, 4.0, 7.5, 8.0 };
            var calcMedia = ((valores[0] * 2) + (valores[1] * 3) + (valores[2] * 4) + (valores[3] * 1)) / 10;

            Console.WriteLine($"Media: {calcMedia.ToString("0.0")}");
            if (calcMedia >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            if (calcMedia < 5.0)
                Console.WriteLine("Aluno reprovado.");
            if (calcMedia >= 5.0 && calcMedia <= 6.9)
            {
                double e = 2.2;
                Console.WriteLine("Aluno em exame.");
                Console.Write($"Nota do exame: {e}");


                var calc = (calcMedia + e) / 2;
                if (calc >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Aluno reprovado.");

                }
                Console.WriteLine($"Media final: {calc.ToString("0.0")}");
            }
        }
        public void Exercicios88()
        {
            double valorCasa = double.Parse(Console.ReadLine());
            double salarioIndv = double.Parse(Console.ReadLine());
            short qtdAnos = short.Parse(Console.ReadLine());

            var calcMeses = qtdAnos * 12;
            var valorMensal = valorCasa / calcMeses;
            if (valorMensal < salarioIndv * 0.30)
                Console.WriteLine("Empréstimo aceito");
            else
                Console.WriteLine("Empréstimo negado");
        }
        public void Exercicios89()
        {
            double peso = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            var calcImc = peso / Math.Pow(altura, 2);

            if (calcImc < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (calcImc > 18.5 && calcImc <= 25)
                Console.WriteLine("Peso Ideal");
            else if (calcImc > 18.5 && calcImc <= 25)
                Console.WriteLine("Peso Ideal");
            else if (calcImc > 25 && calcImc <= 30)
                Console.WriteLine("Sobrepeso");
            else if (calcImc > 30 && calcImc <= 40)
                Console.WriteLine("Obesidade");
            else
                Console.WriteLine("Obesidade mórbida");
        }
        public void Exercicios90()
        {
            short carro = 0;
            double km = 0.0;
            short op = short.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        short qtdDias = short.Parse(Console.ReadLine());
                        double kmPecorrido = double.Parse(Console.ReadLine());
                        calcCarroDiasKm(1,qtdDias,kmPecorrido);
                    }
                    break;
                case2:
                    {
                        short qtdDias = short.Parse(Console.ReadLine());
                        double kmPecorrido = double.Parse(Console.ReadLine());
                        calcCarroDiasKm(2,qtdDias,kmPecorrido);
                    }
                    break;
            }

            void calcCarroDiasKm(short numero, short dias, double km)
            {
                if (numero == 1)
                {
                    if (km <= 100)
                    {
                        var calcValorDia = 90 * dias;
                        var calcKm = km * 0.20;
                        Console.WriteLine($"Total a pagar {calcValorDia * calcKm}");
                    }
                    else
                    {
                        var calcValorDia = 90 * dias;
                        var calcKm = km * 0.10;
                        Console.WriteLine($"Total a pagar {calcValorDia * calcKm}");
                    }
                }
                else if (numero == 2)
                {
                    if (km <= 200)
                    {
                        var calcValorDia = 150 * dias;
                        var calcKm = km * 0.30;
                        Console.WriteLine($"Total a pagar {calcValorDia * calcKm}");
                    }
                    else
                    {
                        var calcValorDia = 150 * dias;
                        var calcKm = km * 0.25;
                        Console.WriteLine($"Total a pagar {calcValorDia * calcKm}");
                    }
                }
            }
        }
    }
}