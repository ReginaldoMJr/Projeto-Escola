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
        public List<Coordenador> coordenadores = new List<Coordenador>();

        public void AtribuirAluno()
        {
            Aluno aluno = null;
            while (aluno == null)
            {
                ExibirAlunos();
                Console.Write("Digite o numero da matricula: ");
                if (int.TryParse(Console.ReadLine(), out int numMatricula))
                {
                    aluno = alunos.Where(x => x.Matricula == numMatricula).FirstOrDefault();
                    if (aluno == null)
                        Console.WriteLine("\nAluno não encontrado, digite novamente\n");
                }
            }
            Turma turma = null;
            int numTurma = 0;
            while (turma == null)
            {
                ExibirTurmas();
                Console.Write("Digite o numero da turma: ");
                int.TryParse(Console.ReadLine(), out numTurma);
                turma = turmas.Find(x => x.NumTurma == numTurma);
                if (turma == null)
                    Console.WriteLine("\nTurma não encontrada, digite novamente\n");
            }
            
            turmas.Where(x => x.NumTurma == numTurma).FirstOrDefault().alunos.Add(aluno);
            alunos.Remove(aluno);
        }
        public void AtribuirProfessor()
        {
            Professor professor = null;
            while (professor == null)
            {
                ExibirProfessores();
                Console.Write("Digite o numero de registro: ");
                if (int.TryParse(Console.ReadLine(), out int numRegistro))
                {
                    professor = professores.Where(x => x.Registro == numRegistro).FirstOrDefault();
                    if (professor == null)
                        Console.WriteLine("\nProfessor não encontrado, digite novamente\n");
                }
            }
            Turma turma = null;
            int numTurma = 0;
            while (turma == null)
            {
                ExibirTurmas();
                Console.Write("Digite o numero da turma: ");
                int.TryParse(Console.ReadLine(), out numTurma);
                turma = turmas.Find(x => x.NumTurma == numTurma);
                if (turma == null)
                    Console.WriteLine("\nTurma não encontrada, digite novamente\n");
            }
            turmas.Where(x => x.NumTurma == numTurma).FirstOrDefault().professor = professor;
            professores.Remove(professor);
        }
        public void ExibirCoordenadores()
        {
            foreach (Coordenador c in coordenadores)
            {
                Console.WriteLine($"Registro: {c.Registro} -- Nome: {c.Nome} -- Idade: {c.Idade} -- Sexo: {c.Sexo}");
            }
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
            foreach (Turma t1 in turmas)
            {
                if (t1.professor != null)
                    Console.WriteLine($"Turma: {t1.NumTurma} Registro: {t1.professor.Registro} -- Nome: {t1.professor.Nome} -- Idade: {t1.professor.Idade} -- Sexo: {t1.professor.Sexo}");
            }
            foreach (Professor p in professores)
                Console.WriteLine($"Registro: {p.Registro} -- Nome: {p.Nome} -- Idade: {p.Idade} -- Sexo: {p.Sexo}");
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
            foreach (Turma t in turmas)
            {
                t.MostrarTurma();
            }
        }
    }
}
