using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Projeto
{
    class Menu
    {
        public void menu()
        {
            Escola escola = new Escola();
            Turma turma = new Turma();
            Professor professor1 = new Professor();
            string num;
            do
            {
                do
                {
                    Console.WriteLine("1 - Cadastrar aluno");
                    Console.WriteLine("2 - Cadastrar professor");
                    Console.WriteLine("3 - Cadastrar turma");
                    Console.WriteLine("4 - Listar alunos");
                    Console.WriteLine("5 - Listar professores");
                    Console.WriteLine("6 - Listar turmas");
                    Console.WriteLine("7 - Atribuir aluno a turma");
                    Console.WriteLine("8 - Atribuir professor a turma");
                    num = Console.ReadLine();
                }
                while (!Regex.IsMatch(num, "^[1-9]{1}$"));

                if (num == "1")
                {
                    Console.Clear();
                    Aluno aluno = new Aluno();
                    aluno = aluno.CadastrarAluno();
                    turma.alunos.Add(aluno);
                }
                else if (num == "2")
                {
                    Console.Clear();
                    Professor professor = new Professor();
                    professor = professor.CadastrarProfessor();
                    escola.professores.Add(professor);
                }
                else if (num == "3")
                {
                    Console.Clear();
                    Turma turma1 = new Turma();
                    turma1.CadastrarTurma();
                    escola.turmas.Add(turma1);
                }
                else if (num == "4")
                {
                    Console.Clear();
                    turma.ExibirAlunos();
                }
                else if (num == "5")
                {
                    Console.Clear();
                    escola.ExibirProfessores();
                }
                else if (num == "6")
                {
                    Console.Clear();
                    escola.ExibirTurmas();
                }
                else if (num == "7")
                {
                    Console.Clear();
                    Console.Write("Digite o numero da matricula: ");
                    int numMatricula = int.Parse(Console.ReadLine());
                    Console.Write("Digite o numero da turma: ");
                    int numTurma = int.Parse(Console.ReadLine());
                    foreach (Turma t in escola.turmas)
                    {
                        int indexturma = escola.turmas.FindIndex(c => t.NumTurma == numTurma);
                        foreach (Aluno a in turma.alunos)
                        {
                            int index = turma.alunos.FindIndex(b => a.Matricula == numMatricula);
                            escola.turmas.Insert(indexturma, turma.alunos[index])
                        }
                    }
                }
                else if (num == "8")
                {
                    Console.Clear();
                    Console.Write("Digite o numero de registro: ");
                    foreach (Professor p in escola.professores)
                    {
                    }
                }
                Console.WriteLine("Deseja voltar ao menu? ");
                num = Console.ReadLine();
            }
            while (num == "9");
        }
    }
}
