using System.Collections.Generic;

namespace Exercicios91_101
{
    public class ListaLetsCode
    {
        public void Exercicios91()
        {
            short num = short.Parse(Console.ReadLine());
            if (num % 5 == 0)
                Console.WriteLine("Número Divisivel por 5");
            else
                Console.WriteLine("Número Não Divisivel por 5");
        }
        public void Exercicios92()
        {
            //recebe listas.
            short tamanho = short.Parse(Console.ReadLine());
            var lista = new short[tamanho];
            Console.WriteLine($"Tamanho da lista é {lista.Length}");
        }
        public void Exercicios93()
        {
            var alunos = new string[] { "Samuel", "Carlos", "Naruto" };
            var alunosPresentes = new string[alunos.Length];

            for (var i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Aluno {alunos[i]}");
                Console.WriteLine($"Está Presente: [S] || [N]");
                var op = Console.ReadLine().ToLower();

                if (op == "s")
                    alunosPresentes[i] = alunos[i];
            }

            Console.WriteLine("Alunos Presentes: ");
            foreach (var alunoss in alunosPresentes)
                Console.WriteLine(alunoss);
        }

        public void Exercicios94()
        {
            var idade = DateTime.Parse(Console.ReadLine());
            var temp = DateTime.Now;
            Console.WriteLine($"Sua idade é : {Math.Sqrt(idade.Year - temp.Year)}");
        }
        public void Exercicios95()
        {
            var numerosAleatorio = new short[10];
            for (var i = 0; i < numerosAleatorio.Length; i++)
                numerosAleatorio[i] = short.Parse(Console.ReadLine());
            Console.WriteLine($"{numerosAleatorio.ToArray().Max()}");
        }
        public void Exercicios96()
        {

        }

        public void Exercicios97()
        {
            var numerosAleatorio = new short[10];
            for (var i = 0; i < numerosAleatorio.Length; i++)
                numerosAleatorio[i] = short.Parse(Console.ReadLine());
            Console.WriteLine($"Maior número: {numerosAleatorio.ToArray().Max()}");
            Console.WriteLine($"Menor número: {numerosAleatorio.ToArray().Min()}");
        }

        public void Exercicios98()
        {
            var palavras = new string[10];
            for(var i =0; i < palavras.Length; i++)
                palavras[i] = Console.ReadLine();

            foreach(var i in palavras)
                Console.WriteLine(i);
        }

        public void Exercicios99()
        {
            var i = 20;


            i++;
            Console.WriteLine(i);
        }
        public void Exercicios100()
        {
            var listas = new int[10];
            for(var i = 0; i < listas.Length; i++)
                listas[i] = int.Parse(Console.ReadLine());
            
            listas = listas.OrderBy(x => x ).ToArray();
            Console.WriteLine(listas);
        }
    }
}