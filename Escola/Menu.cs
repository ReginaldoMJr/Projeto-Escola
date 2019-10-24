using System;
using System.Text.RegularExpressions;

namespace Projeto {
    class Menu {
        
        public void menu(Escola escola) {
            string num;
            do {
                do {
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
                    Console.WriteLine("15 - Remover coordenador");
                    Console.WriteLine("16 - Remover coordenador da turma");
                    Console.WriteLine("0 - Sair do programa");
                    num = Console.ReadLine();
                }
                while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 16);

                if (num == "0")
                    Environment.Exit(0);
                if (num == "1") {
                    Console.Clear();
                    Console.WriteLine("Cadastro aluno selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    do {
                        Console.Clear();
                        Console.Write("Quantos alunos deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++) {
                        Aluno aluno = new Aluno();
                        aluno.CadastrarAluno(escola);
                        escola.alunos.Add(aluno);
                    }
                }
                else if (num == "2") {
                    Console.Clear();
                    if (escola.coordenadores.Count < 1) {
                        Console.WriteLine("Ainda não existem coordenadores\n\nDeseja cadastrar?\n\nSe sim aperte enter, senão aperte esc para voltar ao menu");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) {
                            menu(escola);
                        }
                        do {
                            Console.Clear();
                            Console.Write("Quantos coordenadores deseja cadastrar? ");
                            num = Console.ReadLine();
                        }
                        while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                        for (int i = 0; i < int.Parse(num); i++) {
                            Coordenador coordenador = new Coordenador();
                            coordenador.CadastrarCoordenador(escola);
                            escola.coordenadores.Add(coordenador);
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Cadastro de professores");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    do {
                        Console.Clear();
                        Console.Write("Quantos professores deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++) {
                        Professor professor = new Professor();
                        professor.CadastrarProfessor(escola);
                        escola.professores.Add(professor);
                    }
                }
                else if (num == "3") {
                    Console.Clear();
                    if (escola.coordenadores.Count < 1) {
                        Console.WriteLine("Ainda não existem coordenadores\n\nDeseja cadastrar?\n\nSe sim aperte enter, senão aperte esc para voltar ao menu");
                        Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) {
                            menu(escola);
                        }
                        do {
                            Console.Clear();
                            Console.Write("Quantos coordenadores deseja cadastrar? ");
                            num = Console.ReadLine();
                        }
                        while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                        for (int i = 0; i < int.Parse(num); i++) {
                            Coordenador coordenador = new Coordenador();
                            coordenador.CadastrarCoordenador(escola);
                            escola.coordenadores.Add(coordenador);
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Cadastro de turma selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    do {
                        Console.Clear();
                        Console.Write("Quantas turmas deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++) {
                        Turma turma1 = new Turma();
                        turma1.CadastrarTurma(escola);
                        escola.turmas.Add(turma1);
                    }
                }
                else if (num == "4") {
                    Console.Clear();
                    Console.WriteLine("Cadastro coordenadores selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    do {
                        Console.Clear();
                        Console.Write("Quantos coordenadores deseja cadastrar? ");
                        num = Console.ReadLine();
                    }
                    while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                    for (int i = 0; i < int.Parse(num); i++) {
                        Coordenador coordenador = new Coordenador();
                        coordenador.CadastrarCoordenador(escola);
                        escola.coordenadores.Add(coordenador);
                    }
                }
                else if (num == "5") {
                    Console.Clear();
                    Console.WriteLine("Exibir alunos selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    Console.Clear();
                    if (escola.alunos.Count > 0)
                        escola.ExibirAlunos();
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ainda não existem alunos");
                        Console.ResetColor();
                    }

                }
                else if (num == "6") {
                    Console.Clear();
                    Console.WriteLine("Exibir professores selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    Console.Clear();
                    if (escola.professores.Count > 0)
                        escola.ExibirProfessores();
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ainda não existem professores");
                        Console.ResetColor();
                    }
                }
                else if (num == "7") {
                    Console.Clear();
                    Console.WriteLine("Exibir coordenadores selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    Console.Clear();
                    if (escola.coordenadores.Count > 0)
                        escola.ExibirCoordenadores();
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ainda não existem coordenadores");
                        Console.ResetColor();
                    }
                }
                else if (num == "8") {
                    Console.Clear();
                    Console.WriteLine("Exibir turmas selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    Console.Clear();
                    if (escola.turmas.Count > 0)
                        escola.TurmasAtualizado();
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ainda não existem turmas");
                        Console.ResetColor();
                    }
                }
                else if (num == "9") {
                    Console.Clear();
                    Console.WriteLine("Atribuir aluno selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    if (escola.alunos.Count < 1) {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Não existem alunos cadastrados\n\nDeseja cadastrar alunos?\n\nEnter para cadastrar alunos\n\nEsc para sair");
                        Console.ResetColor();
                        if (Console.ReadKey().Key == ConsoleKey.Escape) {
                            menu(escola);
                        }
                        else {
                            do {
                                Console.Write("Quantos alunos deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++) {
                                Aluno aluno = new Aluno();
                                aluno.CadastrarAluno(escola);
                                escola.alunos.Add(aluno);
                            }
                        }
                    }
                    if (escola.turmas.Count > 0 && escola.alunos.Count > 0)
                        escola.AtribuirAluno();
                    else {
                        Console.Clear();
                        Console.WriteLine("Ainda não existem turmas\nDeseja cadastrar turma?\n\nEnter para cadastrar turma\n\nEsc para sair");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) {
                            menu(escola);
                        }
                        else {
                            do {
                                Console.Write("Quantas turmas deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++) {
                                Turma turma1 = new Turma();
                                turma1.CadastrarTurma(escola);
                                escola.turmas.Add(turma1);
                            }
                            Console.Clear();
                            escola.AtribuirAluno();
                        }
                    }
                }
                else if (num == "10") {
                    Console.Clear();
                    if (escola.professores.Count < 1) {
                        Console.WriteLine("Não existem professores cadastrados\nDeseja cadastrar um professor?\n\nEnter para cadastrar professores\n\nEsc para sair");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) {
                            menu(escola);
                        }
                        else {
                            do {
                                Console.Write("Quantos professores deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++) {
                                Professor professor = new Professor();
                                professor.CadastrarProfessor(escola);
                                escola.professores.Add(professor);
                            }
                        }
                    }
                    if (escola.turmas.Count > 0 && escola.professores.Count > 0)
                        escola.AtribuirProfessor();
                    else {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ainda não existem turmas\nDeseja cadastrar turma?\n\nEnter para cadastrar turma\n\nEsc para sair");
                        Console.ResetColor();
                        Console.WriteLine("Cadastro aluno selecionado");
                        Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) {
                            menu(escola);
                        }
                        else {
                            do {
                                Console.Write("Quantas turmas deseja cadastrar? ");
                                num = Console.ReadLine();
                            }
                            while (Regex.IsMatch(num, @"^[\d]{1,2}$") == false || int.TryParse(num, out int result) == false || result > 15);
                            for (int i = 0; i < int.Parse(num); i++) {
                                Turma turma1 = new Turma();
                                turma1.CadastrarTurma(escola);
                                escola.turmas.Add(turma1);
                            }
                            escola.AtribuirProfessor();
                        }
                    }
                }
                else if (num == "11") {
                    Console.Clear();
                    Console.WriteLine("Remover aluno selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    if (escola.alunos.Count < 1) {
                        Console.WriteLine("Sem alunos cadastrados");
                        break;
                    }
                    else
                        escola.RemoverAlunos();
                }
                else if (num == "12") {
                    Console.Clear();
                    Console.WriteLine("Remover aluno da turma selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    if (escola.turmas.Exists(x => x.alunos.Count < 1)) {
                        Console.WriteLine("Sem alunos atribuidos");
                        break;
                    }
                    else
                        escola.RemoverAlunosTurma();
                }
                else if (num == "13") {
                    Console.Clear();
                    Console.WriteLine("Remover professor selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    if (escola.professores.Count < 1) {
                        Console.WriteLine("Sem professores");
                        break;
                    }
                    else
                        escola.RemoverProfessores();
                }
                else if (num == "14") {
                    Console.Clear();
                    Console.WriteLine("Remover professor da turma selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    if (escola.turmas.Exists(x => x.professor == null))
                        Console.WriteLine("Sem professores atribuidos");
                    else
                        escola.RemoverProfessorTurma();
                }
                else if (num == "15") {
                    Console.Clear();
                    Console.WriteLine("Remover coordenador selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    if (escola.coordenadores.Count < 1)
                        Console.WriteLine("Sem coordenadores");
                    else
                        escola.RemoverCoordenadores();
                }
                else if (num == "16") {
                    Console.Clear();
                    Console.WriteLine("Remover coordenador da turma selecionado");
                    Console.WriteLine("Aperte Esc para sair ou Enter para continuar");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) {
                        menu(escola);
                    }
                    escola.RemoverCoordenadorTurma();
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

