using System;
using System.Text.RegularExpressions;

namespace Projeto
{
    class Menu
    {
        public void menu()
        {
            Escola escola = new Escola();
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
                    Console.WriteLine("4 - Cadastrar coordenador");
                    Console.WriteLine("5 - Listar alunos");
                    Console.WriteLine("6 - Listar professores");
                    Console.WriteLine("7 - Listar coordenadores");
                    Console.WriteLine("8 - Listar turmas");
                    Console.WriteLine("9 - Atribuir aluno a turma");
                    Console.WriteLine("10 - Atribuir professor a turma");
                    Console.WriteLine("11 - Remover aluno da lista de espera");
                    Console.WriteLine("12 - Remover aluno de uma turma");
                    Console.WriteLine("13 - Remover professor da lista de espera");
                    Console.WriteLine("14 - Remover professor de uma turma");
                    Console.WriteLine("0 - Sair do programa");
                    num = Console.ReadLine();
                }
                while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 14);

                if (num == "0")
                    break;
                if (num == "1")
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Quantos alunos deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++)
                    {
                        Aluno aluno = new Aluno();
                        aluno.CadastrarAluno();
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
                    while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++)
                    {
                        Professor professor = new Professor();
                        professor.CadastrarProfessor(escola);
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
                    while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++)
                    {
                        Turma turma1 = new Turma();
                        turma1.CadastrarTurma(escola);
                        escola.turmas.Add(turma1);
                    }
                }
                else if (num == "4")
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Quantos coordenadores deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++)
                    {
                        Coordenador coordenador = new Coordenador();
                        coordenador.CadastrarCoordenador();
                        escola.coordenadores.Add(coordenador);
                    }
                }
                else if (num == "5")
                {
                    Console.Clear();
                    escola.ExibirAlunos();
                }
                else if (num == "6")
                {
                    Console.Clear();
                    escola.ExibirProfessores();
                }
                else if (num == "7")
                {
                    Console.Clear();
                    escola.ExibirCoordenadores();
                }
                else if (num == "8")
                {
                    Console.Clear();
                    if (escola.turmas.Count > 0)
                        escola.TurmasAtualizado();
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ainda não existem turmas");
                        Console.ResetColor();
                    }
                }
                else if (num == "9")
                {
                    Console.Clear();
                    if (escola.alunos.Count < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Não existem alunos cadastrados\n\nDeseja cadastrar alunos?\n\nEnter para cadastrar alunos\n\nEsc para sair");
                        Console.ResetColor();
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            num = "s";
                        }
                        else
                        {
                            do
                            {
                                Console.Write("Quantos alunos deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++)
                            {
                                Aluno aluno = new Aluno();
                                aluno.CadastrarAluno();
                                escola.alunos.Add(aluno);
                            }
                        }
                    }
                    if (escola.turmas.Count > 0 && escola.alunos.Count > 0)
                        escola.AtribuirAluno();
                    else
                    {
                        Console.WriteLine("Ainda não existem turmas\nDeseja cadastrar turma?\n\nEnter para cadastrar turma\n\nEsc para sair");
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            num = "s";
                        }
                        else
                        {
                            do
                            {
                                Console.Write("Quantas turmas deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++)
                            {
                                Turma turma1 = new Turma();
                                turma1.CadastrarTurma(escola);
                                escola.turmas.Add(turma1);
                            }
                            escola.AtribuirAluno();
                        }
                    }
                }
                else if (num == "10")
                {
                    Console.Clear();
                    if (escola.professores.Count < 1)
                    {
                        Console.WriteLine("Não existem professores cadastrados\nDeseja cadastrar um professor?\n\nEnter para cadastrar professores\n\nEsc para sair");
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            num = "s";
                        }
                        else
                        {
                            do
                            {
                                Console.Write("Quantos professores deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++)
                            {
                                Professor professor = new Professor();
                                professor.CadastrarProfessor(escola);
                                escola.professores.Add(professor);
                            }
                        }
                    }
                    if (escola.turmas.Count > 0 && escola.professores.Count > 0)
                        escola.AtribuirProfessor();
                    else
                    {
                        Console.WriteLine("Ainda não existem turmas\nDeseja cadastrar turma?\n\nEnter para cadastrar turma\n\nEsc para sair");
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            num = "s";
                        }
                        else
                        {
                            do
                            {
                                Console.Write("Quantas turmas deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, "^[0-9]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++)
                            {
                                Turma turma1 = new Turma();
                                turma1.CadastrarTurma(escola);
                                escola.turmas.Add(turma1);
                            }
                            escola.AtribuirProfessor();
                        }
                    }
                }
                else if(num == "11")
                {
                    escola.RemoverAlunos();
                }
                else if (num == "12")
                {
                    escola.RemoverAlunosTurma();
                }
                else if(num == "13")
                {
                    escola.RemoverProfessores();
                }
                else if(num == "14")
                {
                    escola.RemoverProfessorTurma();
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

