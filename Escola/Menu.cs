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
                    Console.Clear();
                    Console.WriteLine("============== Menu =================");
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
                while (!Regex.IsMatch(num, "^[1-8]{1}$"));

                if (num == "1")
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Quantos alunos deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, "^[1-9]{2}$") && int.Parse(num) < 15);
                    for (int i = 0; i < int.Parse(num); i++)
                    {
                        Aluno aluno = new Aluno();
                        aluno = aluno.CadastrarAluno();
                        escola.alunos.Add(aluno);
                    }
                }
                else if (num == "2")
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Quantos professores deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, "^[1-9]{2}$") && int.Parse(num) < 15);
                    for (int i = 0; i < int.Parse(num); i++)
                    {
                        Professor professor = new Professor();
                        professor = professor.CadastrarProfessor();
                        escola.professores.Add(professor);
                    }
                }
                else if (num == "3")
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Quantas turmas deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, "^[1-9]{2}$") && int.Parse(num) < 15);
                    for (int i = 0; i < int.Parse(num); i++)
                    {
                        Turma turma1 = new Turma();
                        turma1.CadastrarTurma();
                        escola.turmas.Add(turma1);
                    }
                }
                else if (num == "4")
                {
                    Console.Clear();
                    escola.ExibirAlunos();
                }
                else if (num == "5")
                {
                    Console.Clear();
                    escola.ExibirProfessores();
                }
                else if (num == "6")
                {
                    Console.Clear();
                    if (escola.turmas.Count > 0)
                        escola.TurmasAtualizado();
                    else
                        Console.WriteLine("Ainda não existem turmas");
                }
                else if (num == "7")
                {
                    Console.Clear();
                    if (escola.turmas.Count > 0 && escola.alunos.Count > 0)
                        escola.AtribuirAluno();
                    else
                        Console.WriteLine("Ainda não existem turmas");
                }
                else if (num == "8")
                {
                    Console.Clear();
                    if (escola.turmas.Count > 0 && escola.professores.Count > 0)
                        escola.AtribuirProfessor();
                    else
                        Console.WriteLine("Ainda não existem turmas");
                }
                Console.WriteLine("Deseja voltar ao menu? (S / N) ");
                string validarmenu = Console.ReadLine();
                if (Regex.IsMatch(validarmenu, "^[sS]{1}$"))
                    num = validarmenu;
            }
            while (num == "s" || num == "S");
        }

    }
}
