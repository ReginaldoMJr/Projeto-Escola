using System;
using System.Text.RegularExpressions;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    Aluno aluno = new Aluno();
                    aluno = aluno.CadastrarAluno();
                    turma.alunos.Add(aluno);
                }
                else if (num == "2")
                {
                    Professor professor = new Professor();
                    professor = professor.CadastrarProfessor();
                    turma.professores.Add(professor);
                }
                else if (num == "3")
                {
                    Turma turma1 = new Turma();
                    turma1.CadastrarTurma();
                    turma.turmas.Add(turma1);
                }
                else if (num == "4")
                {
                    turma.ExibirAlunos();
                }
                else if (num == "5")
                {
                    turma.ExibirProfessores();
                }
                else if (num == "6")
                {
                    turma.ExibirTurmas();
                }
                else if (num == "7")
                {

                    );
                }
                else if (num == "8")
                {
                    foreach (Professor p in turma.professores)
                    {
                        ;
                    }
                }
                Console.WriteLine("Deseja voltar ao menu? ");
                num = Console.ReadLine();
            }
            while (num == "9");
        }
    }
}
