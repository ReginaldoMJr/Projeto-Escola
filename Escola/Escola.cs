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
                if (turma.alunos.Count() >= turma.tamanho)
                    turma = null;
                if (turma == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTurma não encontrada ou lotada, digite novamente\n");
                    Console.ResetColor();
                }
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
            if (turma.professor != null)
            {
                if (professores.Exists(x => x.Registro == turma.professor.Registro) == false)
                    professores.Add(turma.professor);
            }
            turmas.Where(x => x.NumTurma == numTurma).FirstOrDefault().professor = professor;
            if (turmas.GroupBy(a => a.professor).Any(a => a.Count() == 2))
            {
                professores.Remove(professor);
            }
        }
        public void ExibirCoordenadores()
        {
            Console.WriteLine("============== Coordenadores ==================");
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
            Console.WriteLine("=============== Professores atribuidos ==================\n");
            foreach (Turma t1 in turmas)
            {
                if (t1.professor != null)
                    Console.WriteLine($"Turma: {t1.NumTurma} Registro: {t1.professor.Registro} -- Nome: {t1.professor.Nome} -- Idade: {t1.professor.Idade} -- Sexo: {t1.professor.Sexo} -- Contratante: {t1.professor.Contratante.Nome}");
            }
            Console.WriteLine("\n=============== Professores disponiveis ==================\n");
            foreach (Professor p in professores)
                Console.WriteLine($"Registro: {p.Registro} -- Nome: {p.Nome} -- Idade: {p.Idade} -- Sexo: {p.Sexo} -- Contratante {p.Contratante.Nome}");
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
        public void RemoverAlunos()
        {
            Aluno aluno;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    aluno = alunos.Where(x => x.Matricula == result).FirstOrDefault();
                    alunos.Remove(aluno);
                }
                else
                {
                    Console.WriteLine("Numero de matricula não encontrado ou invalido");
                    aluno = null;
                }
            }
            while (aluno == null);
        }
        public void RemoverAlunosTurma()
        {
            TurmasAtualizado();
            Console.WriteLine("Digite o numero da turma do aluno");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da matricula do aluno");
            int num2 = int.Parse(Console.ReadLine());
            Turma turma = turmas.Where(x => x.NumTurma == num).FirstOrDefault();
            Aluno aluno = turma.alunos.Where(x => x.Matricula == num2).FirstOrDefault();
            turma.alunos.Remove(aluno);
            alunos.Add(aluno);
        }
        public void RemoverProfessores()
        {
            int num = int.Parse(Console.ReadLine());
            Professor professor = professores.Where(x => x.Registro == num).FirstOrDefault();
            professores.Remove(professor);
        }
        public void RemoverProfessorTurma()
        {
            TurmasAtualizado();
            Console.WriteLine("Digite o numero da turma do professor");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero do registro do professor");
            int num2 = int.Parse(Console.ReadLine());
            Turma turma = turmas.Where(x => x.NumTurma == num).FirstOrDefault();
            professores.Add(turma.professor);
            turma.professor = null;
        }
        public void RemoverCoordenadores()
        {
            int num = int.Parse(Console.ReadLine());
            Coordenador coordenador = coordenadores.Where(x => x.Registro == num).FirstOrDefault();
            coordenadores.Remove(coordenador);
        }
        public void RemoverTurmas()
        {
            int num = int.Parse(Console.ReadLine());
            Turma turma = turmas.Where(x => x.NumTurma == num).FirstOrDefault();
            turmas.Remove(turma);
        }
    }
}
