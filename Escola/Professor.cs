using System;

namespace Projeto
{
    class Professor : Pessoa
    {
        public int Registro { get; private set; }

        public Professor CadastrarProfessor()
        {
            Professor professor = new Professor();
            Random aleatorio = new Random();
            professor.Registro = aleatorio.Next(1000, 9999);
            Console.WriteLine($"Numero de registro: {professor.Registro}");
            do
            {
                Console.Write("Digite o nome do professor: ");
                professor.Nome = Console.ReadLine();
            }
            while (professor.Nome == null);
            do
            {
                Console.Write("Digite a idade do professor: ");
                professor.Idade = (Console.ReadLine());
            }
            while (professor.Idade == "");
            do
            {
                Console.Write("Qual o sexo do professor (M / F): ");
                professor.Sexo = (Console.ReadLine());
            }
            while (professor.Sexo == "");
            return professor;
        }
    }
}

