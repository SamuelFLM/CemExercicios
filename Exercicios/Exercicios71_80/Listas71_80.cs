namespace Exercicios.Exercicios71_80
{
    public class Listas71_80
    {
        public void Exercicios71()
        {
            Console.Write("Qual sua velocidade em KM: ");
            int velocidade = int.Parse(Console.ReadLine());

            if (velocidade >= 80)
                Console.WriteLine($"Velocidade Ultrapassada Multa: R${(velocidade - 80) * 5:F2}");
        }

        public void Exercicios72()
        {
            Console.Write("Informe o ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            var calcIdade = 2022 - anoNascimento;
            if (calcIdade >= 18)
                Console.WriteLine($"Idade {calcIdade} - Pode Votar");
            else
                Console.WriteLine($"Idade {calcIdade} - Não Pode Votar");
        }

        public void Exercicios73()
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            var notas = new float[2];
            for (var i = 0; i < notas.Length; i++)
                notas[i] = float.Parse(Console.ReadLine());
            var media = (notas[0] + notas[1]) / 2;

            if (media >= 7.0)
                Console.WriteLine($"{nome} - Teve um bom aproveitamento Nota: {media}");
            else
                Console.WriteLine($"{nome} - Não Teve um bom aproveitamento Nota: {media}");
        }
        public void Exercicios74()
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("Número e par");
            else
                Console.WriteLine("Número e impar");
        }
        public void Exercicios75()
        {
            //n
            int ano = int.Parse(Console.ReadLine());
            var calcBissexto = ano / 4;
        }
        public void Exercicios76()
        {
            Console.Write("Informe seu ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            var calcIdade = 2022 - ano;
            if (calcIdade >= 18)
                Console.WriteLine($"Já se passaram {2022 - (ano + 18)} anos desde seu alistamento.");
            else
                Console.WriteLine($"Faltam {2022 - (ano + 18)} anos desde seu alistamento.");
        }
        public void Exercicios77()
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe seu sexo [M] or [F]: ");
            string sexo = Console.ReadLine();
            Console.Write("Valor Compras: ");
            float valorCompras = float.Parse(Console.ReadLine());

            if (sexo == "m")
                Console.WriteLine($"Desconto de 5% Valor a pagar: {valorCompras * 0.05}");
            else if (sexo == "f")
                Console.WriteLine($"Desconto de 13% Valor a pagar: {valorCompras * 0.13}");
        }

        public void Exercicios78()
        {
            Console.WriteLine("Quantos Km até seu destino: ");
            short distancia = short.Parse(Console.ReadLine());

            if (distancia <= 200)
                Console.WriteLine($"Total a percorrer {distancia} - Valor: {distancia * 0.50}");
            else
                Console.WriteLine($"Total a percorrer {distancia} - Valor: {distancia * 0.45}");
        }
        public void Exercicios79()
        {
            var ladoTriangulo = new short[3];
            for (var i = 0; i < ladoTriangulo.Length; i++)
                ladoTriangulo[i] = short.Parse(Console.ReadLine());
            if (ladoTriangulo[0] < ladoTriangulo[1] + ladoTriangulo[2])
                if (ladoTriangulo[1] < ladoTriangulo[0] + ladoTriangulo[2])
                    if (ladoTriangulo[2] < ladoTriangulo[0] + ladoTriangulo[1])
                        Console.WriteLine("Forma um triangulo");
                    else
                        Console.WriteLine("Não Forma um triangulo");
        }
        public void Exercicios80()
        {
            var comparaNum = new short[2];
            for (var i = 0; i < comparaNum.Length; i++)
                comparaNum[i] = short.Parse(Console.ReadLine());
            if( comparaNum[0] > comparaNum[1])
                Console.WriteLine("O primeiro valor é maior");
            else if( comparaNum[1] > comparaNum[0])
                Console.WriteLine("O segundo valor é maior");
            else
                Console.WriteLine("N'ao existe valor maior, os dois são iguais");
        }
    }
}