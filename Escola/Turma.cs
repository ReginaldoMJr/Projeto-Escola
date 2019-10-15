using System;
using System.Collections.Generic;

namespace Projeto
{
    class Turma
    {
        public List<Turma> turmas = new List<Turma>();
        public int NumTurma { get; set; }
        public List<Professor> professores = new List<Professor>();
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
        public void ExibirTurmas()
        {
            foreach (Turma t in turmas)
                Console.WriteLine($"Numero da turma: {t.NumTurma}");
        }
        public void ExibirProfessores()
        {
            foreach (Professor p in professores)
                Console.WriteLine($"Registro: {p.Registro} -- Nome: {p.Nome} -- Idade: {p.Idade} -- Sexo: {p.Sexo}");
        }
        public void AdicionarProfessor()
        {

        }
    }
}
