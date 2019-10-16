using System;
using System.Collections.Generic;

namespace Projeto
{
    class Escola : Turma
    {
        public List<Turma> turmas = new List<Turma>();
        public List<Professor> professores = new List<Professor>();

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

    }
}
