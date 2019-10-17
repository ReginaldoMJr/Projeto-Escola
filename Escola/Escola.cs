using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto
{
    class Escola
    {
        public List<Turma> turmas = new List<Turma>();
        public List<Professor> professores = new List<Professor>();
        public List<Aluno> alunos = new List<Aluno>();


        public void AtribuirAluno()
        {
            ExibirAlunos();
            Console.Write("Digite o numero da matricula: ");
            int numMatricula = int.Parse(Console.ReadLine());
            ExibirTurmas();
            Console.Write("Digite o numero da turma: ");
            int numTurma = int.Parse(Console.ReadLine());

            Aluno aluno = alunos.Where(x => x.Matricula == numMatricula).FirstOrDefault();
            turmas.Where(x => x.NumTurma == numTurma).FirstOrDefault().alunos.Add(aluno);
            alunos.Remove(aluno);
        }
        public void AtribuirProfessor()
        {
            ExibirProfessores();
            Console.Write("Digite o numero de registro: ");
            int numRegistro = int.Parse(Console.ReadLine());
            ExibirTurmas();
            Console.Write("Digite o numero da turma: ");
            int numTurma = int.Parse(Console.ReadLine());

            Professor professor = professores.Where(x => x.Registro == numRegistro).FirstOrDefault();
            turmas.Where(x => x.NumTurma == numTurma).FirstOrDefault().professor = professor;
            professores.Remove(professor);
        }
        public void ExibirTurmas()
        {
            foreach (Turma t in turmas)
            {
                Console.WriteLine($"Numero da turma: {t.NumTurma}");
            }
        }
        public void ExibirProfessores()
        {
            if (professores.Count < 1)
                Console.WriteLine("Sem professores cadastrados");
            else
            {
                foreach (Professor p in professores)
                    Console.WriteLine($"Registro: {p.Registro} -- Nome: {p.Nome} -- Idade: {p.Idade} -- Sexo: {p.Sexo}");
            }
        }
        public void ExibirAlunos()
        {
            if (alunos.Count < 1)
                Console.WriteLine("Sem alunos cadastrados");
            else
            {
                foreach (Aluno s in alunos)
                    Console.WriteLine($"Matricula: {s.Matricula} -- Nome: {s.Nome} -- Idade: {s.Idade} -- Sexo: {s.Sexo} -- Bolsista: {s.Bolsista}\n");
            }
        }

        public void TurmasAtualizado()
        {
            foreach(Turma t in turmas)
            {
                t.MostrarTurma();
            }
        }
    }
}
