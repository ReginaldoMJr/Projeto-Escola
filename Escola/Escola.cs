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
        }
        public void AtribuirProfessor()
        {
            ExibirProfessores();
            Console.Write("Digite o numero de registro: ");
            int numRegistro = int.Parse(Console.ReadLine());
            ExibirTurmas();
            Console.Write("Digite o numero da turma: ");
            int numTurma = int.Parse(Console.ReadLine());

            //int index = professores.FindIndex(x => x.Registro == numRegistro);
            //int indexturma = turmas.FindIndex(x => x.NumTurma == numTurma);
            //turmas.Insert(indexturma, professore[index]);
            Professor professor = professores.Where(x => x.Registro == numRegistro).FirstOrDefault();
            turmas.Where(x => x.NumTurma == numTurma).FirstOrDefault().professor = professor;
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
            foreach (Professor p in professores)
                Console.WriteLine($"Registro: {p.Registro} -- Nome: {p.Nome} -- Idade: {p.Idade} -- Sexo: {p.Sexo}");
        }
        public void ExibirAlunos()
        {
            //Console.WriteLine($"\nTurma: {NumTurma}      Professor: {Professor.Nome} -- Idade: {Professor.Idade} -- Sexo: {Professor.Sexo} -- Registro: {Professor.Registro}\n\nAlunos: \n");
            foreach (Aluno s in alunos)
                Console.WriteLine($"Matricula: {s.Matricula} -- Nome: {s.Nome} -- Idade: {s.Idade} -- Sexo: {s.Sexo} -- Bolsista: {s.Bolsista}\n");
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
