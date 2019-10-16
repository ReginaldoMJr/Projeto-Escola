using System;
using System.Text.RegularExpressions;

namespace Projeto
{
    class Aluno : Pessoa
    {
        public string Bolsista { get; private set; }
        public int Matricula { get; private set; }

        //Metodo para cadastrar os alunos
        public Aluno CadastrarAluno()
        {
            //Cria um aluno com numero de matricula aleatorio
            Console.WriteLine("================= Cadastro Aluno ===================\n");
            Aluno aluno = new Aluno();
            Random aleatorio = new Random();
            aluno.Matricula = aleatorio.Next(1000, 9999);
            Console.WriteLine($"Numero da matricula: {aluno.Matricula}");
            //Pede o nome do aluno, fazendo a validação dentro da classe pessoa
            do
            {
                Console.Write("Qual o nome do aluno? ");
                aluno.Nome = Console.ReadLine();
            }
            while (aluno.Nome == null);
            //Pede a idade do aluno, fazendo a validação dentro da classe pessoa
            do
            {
                Console.Write($"Qual a idade do(a) {aluno.Nome}? ");
                aluno.Idade = (Console.ReadLine());
            }
            while (aluno.Idade == "");
            //Pede o sexo do aluno, fazendo a validação dentro da classe pessoa
            do
            {
                Console.Write($"Qual o sexo do(a) {aluno.Nome} (M / F)? ");
                aluno.Sexo = (Console.ReadLine());
            }
            while (aluno.Sexo == "");
            //Pergunta se o aluno é bolsista ou não, e faz a validação dentro da propria classe
            char bolsa;
            do
            {
                Console.Write($"O(a) {aluno.Nome} é bolsista (S / N)? ");
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
                aluno.Bolsista = "Sim";
            else
                aluno.Bolsista = "Nao";

            return aluno;
        }
    }
}

