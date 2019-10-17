using System;
using System.Collections.Generic;

namespace Projeto
{
    class Turma
    {
        public int NumTurma { get; set; }
        public Professor professor;
        public List<Aluno> alunos = new List<Aluno>();
        //Cadastrar a turma, com numero de turma aleatório 
        public void CadastrarTurma()
        {
            Random numTurma = new Random();
            NumTurma = numTurma.Next(100, 999);
            Console.Write($"Numero da turma: {NumTurma}\n");
        }
        //Metodo para mostrar todos os dados do programa
        public void MostrarTurma()
        {
            Console.WriteLine($"==================  Turma {NumTurma}  ====================\n");
            if (professor == null)
            {
                Console.WriteLine(" Professor Não atribuido");
            }
            else
                Console.Write($"Professor: {professor.Nome} -- Idade: {professor.Idade} -- Sexo: {professor.Sexo} -- Registro: {professor.Registro}\n");
            Console.WriteLine("\n==================== Alunos ========================\n");
            if (alunos.Count < 1)
                Console.WriteLine("Sem alunos atribuidos");
            else
            {
                foreach (Aluno a in alunos)
                Console.WriteLine($"Matricula: {a.Matricula} -- Nome: {a.Nome} -- Idade: {a.Idade} -- Sexo: {a.Sexo} -- Bolsista: {a.Bolsista}\n");
            }
        }
    }
}
