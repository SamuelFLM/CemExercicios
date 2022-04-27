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
    }
}