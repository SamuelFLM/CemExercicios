namespace Exercicios.Exercicios61_70
{
    public class Listas61_70
    {
        public void Exercicios61()
        {
            Console.Write("Digite um número: ");
            float numeroReal = float.Parse(Console.ReadLine());
            Console.WriteLine($"O dobro de {numeroReal} é {numeroReal * 2}");
            Console.WriteLine($"A terça parte de {numeroReal} é {numeroReal / 3}");
        }
        public void Exercicios62()
        {
            Console.Write("Digite uma distância em metros: ");
            float distancia = float.Parse(Console.ReadLine());
            Console.WriteLine($"A distância de {distancia}m corresponde a: ");

            Console.WriteLine($"{distancia / 1000}Km");
            Console.WriteLine($"{distancia / 100}Hm");
            Console.WriteLine($"{distancia / 10}Dam");

            Console.WriteLine($"{distancia * 10}dm");
            Console.WriteLine($"{distancia * 100}cm");
            Console.WriteLine($"{distancia * 1000}mm");
        }
        public void Exercicios63()
        {
            float carteira = float.Parse(Console.ReadLine());
            Console.WriteLine($"Voce pode comprar US${0:f2}", carteira / 3.45);
        }
        public void Exercicios64()
        {
            var parede = new float[2];
            for (var i = 0; i < parede.Length; i++)
                parede[i] = float.Parse(Console.ReadLine());
            var calcArea = parede[0] * parede[1];
            Console.WriteLine($"Área parede {calcArea}");
            Console.WriteLine($"Quantidade de tinta para pintar parede {calcArea / 2}");
        }
        public void Exercicios65()
        {
            var delta = new float[3];
            for (var i = 0; i < delta.Length; i++)
                delta[i] = float.Parse(Console.ReadLine());

            var calcDelta = Math.Pow(delta[1], 2) - (4 * delta[0] * delta[2]);

            var result = (delta[1] - Math.Sqrt(calcDelta)) / (2 * delta[0]);
            Console.WriteLine("R1 = {0:f5}", result);
            var result2 = (delta[1] + Math.Sqrt(calcDelta)) / (2 * delta[0]);
            Console.WriteLine("R2 = {0:f5}", result2);
        }

        public void Exercicios66()
        {
            var valorProduto = float.Parse(Console.ReadLine());
            Console.WriteLine($"PREÇO PROMOCIONAL 5% de desconto. Valor liquido: {valorProduto * 0.05}");
        }
        public void Exercicios67()
        {
            var salarioFuncionario = float.Parse(Console.ReadLine());
            Console.WriteLine($"Aumento Salário 15%: {0:f2}", (salarioFuncionario * 0.15) + salarioFuncionario);
        }
        public void Exercicios68()
        {
            int dia = 90;
            float km = 0.20f;
            Console.Write("Quantos dias alugado: ");
            int aluguelDias = int.Parse(Console.ReadLine());
            Console.Write("Quantos km percorrido: ");
            float kmPercorrido = float.Parse(Console.ReadLine());
            Console.WriteLine($"Total a pagar: {(aluguelDias * dia) + (kmPercorrido * km):F2}");
        }
        public void Exercicios69()
        {
            const int salario = 8 * 25;
            Console.Write($"Quantos Dias Trabalhados: ");
            int diasTrabalhado = int.Parse(Console.ReadLine());
            Console.WriteLine($"Salário a receber: {diasTrabalhado * salario}");
        }
        public void Exercicios70()
        {
            //n
            Console.Write("Quantidade de cigarros fumados por dia: ");
            int qtdCigarrosDias = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de anos fumados: ");
            int qtdAnosFumados = int.Parse(Console.ReadLine());
            
            // 10m * 6 = resultado minutos. -> transforma em horas  -> (qtdAnos * 365 = total dias)
            var calcCigarrosHora = (qtdCigarrosDias * 10) / 60;
            var calcDiasFumados = qtdAnosFumados * 365;
        }
    }
}