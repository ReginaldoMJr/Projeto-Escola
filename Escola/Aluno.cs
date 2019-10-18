using System;
using System.Text.RegularExpressions;

namespace Projeto
{
    class Aluno : Pessoa
    {
        public string Bolsista { get; private set; }
        public int Matricula { get; private set; }

        //Metodo para cadastrar os alunos
        public void CadastrarAluno()
        {
            //Cria um aluno com numero de matricula aleatorio
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n================= Cadastro Aluno ===================\n");
            Console.ResetColor();
            Random aleatorio = new Random();
            Matricula = aleatorio.Next(10000, 99999);
            Console.WriteLine($"Numero da matricula: {Matricula}");
            //Pede o nome do aluno, fazendo a validação dentro da classe pessoa
            do
            {
                Console.Write("Qual o nome do aluno? ");
                Nome = Console.ReadLine();
            }
            while (Nome == null);
            //Pede a idade do aluno, fazendo a validação dentro da classe pessoa
            do
            {
                Console.Write($"Qual a idade do(a) {Nome}? ");
                Idade = (Console.ReadLine());
            }
            while (Idade == "");
            //Pede o sexo do aluno, fazendo a validação dentro da classe pessoa
            do
            {
                Console.Write($"Qual o sexo do(a) {Nome} (M / F)? ");
                Sexo = (Console.ReadLine());
            }
            while (Sexo == "");
            //Pergunta se o aluno é bolsista ou não, e faz a validação dentro da propria classe
            char bolsa;
            do
            {
                Console.Write($"O(a) {Nome} é bolsista (S / N)? ");
                string testeBolsa = Console.ReadLine();
                if (Regex.IsMatch(testeBolsa, "^[sSnN]{1}$"))
                    bolsa = char.Parse(testeBolsa);
                else
                {
                    Console.WriteLine("\nValor invalido\nDigite novamente\n");
                    bolsa = ' ';
                }
            }
            while (bolsa == ' ');
            //Se o aluno for bolsista, atribuir a string "Sim", senão atribuir "Nao"
            if (bolsa == 's')
                Bolsista = "Sim";
            else
                Bolsista = "Nao";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAluno cadastrado com sucesso");
            Console.ResetColor();
        }
    }
}

