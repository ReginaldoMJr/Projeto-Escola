using System;

namespace Projeto
{
    class Aluno : Pessoa
    {
        public string Bolsista { get; private set; }
        public int Matricula { get; private set; }


        public Aluno CadastrarAluno()
        {
            Aluno aluno = new Aluno();
            Random aleatorio = new Random();
            aluno.Matricula = aleatorio.Next(1000, 9999);
            Console.WriteLine($"\nNumero da matricula: {aluno.Matricula}");
            do
            {
                Console.Write("Qual o nome do aluno? ");
                aluno.Nome = Console.ReadLine();
            }
            while (aluno.Nome == null);
            do
            {
                Console.Write($"Qual a idade do {aluno.Nome}? ");
                aluno.Idade = (Console.ReadLine());
            }
            while (aluno.Idade == "");
            do
            {
                Console.Write("Qual o sexo do aluno (M / F)? ");
                aluno.Sexo = (Console.ReadLine());
            }
            while (aluno.Sexo == "");
            char bolsa = ' ';
            do
            {
                Console.Write("O aluno é bolsista (S / N)? ");
                string testeBolsa = Console.ReadLine();
                if (char.TryParse(testeBolsa, out char result) && result == 's' || result == 'S' || result == 'n' || result == 'N')
                    bolsa = result;
                else
                {
                    Console.WriteLine("Valor invalido, Digite novamente");
                    bolsa = ' ';
                }
            }
            while (bolsa == ' ');
            if (bolsa == 's')
                aluno.Bolsista = "Sim";
            else
                aluno.Bolsista = "Nao";

            return aluno;
        }
    }
}

