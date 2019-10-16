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
            NumTurma = numTurma.Next(10, 99);
            Console.Write($"Numero da turma: {NumTurma}\n");
        }
        //Metodo para mostrar todos os dados do programa
        public void ExibirAlunos()
        {
            //Console.WriteLine($"\nTurma: {NumTurma}      Professor: {Professor.Nome} -- Idade: {Professor.Idade} -- Sexo: {Professor.Sexo} -- Registro: {Professor.Registro}\n\nAlunos: \n");
            foreach (Aluno s in alunos)
                Console.WriteLine($"Matricula: {s.Matricula} -- Nome: {s.Nome} -- Idade: {s.Idade} -- Sexo: {s.Sexo} -- Bolsista: {s.Bolsista}\n");
        }
    }
}
