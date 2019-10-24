using System;
using System.Collections.Generic;

namespace Projeto {
    class Turma {
        public int NumTurma { get; set; }
        public Professor professor;
        public List<Aluno> alunos = new List<Aluno>();
        public Coordenador Responsavel;
        public uint tamanho;
        //Cadastrar a turma, com numero de turma aleatório 
        public void CadastrarTurma(Escola escola) {
            do NumTurma = new Random().Next(1000, 9999);
            while (escola.turmas.Exists(x => x.NumTurma == NumTurma));
            Console.Write($"Numero da turma: {NumTurma}\n");
            do {
                escola.ExibirCoordenadores();
                Console.Write("Qual o registro de coordenador desse turma? ");
                int.TryParse(Console.ReadLine(), out int result);
                Coordenador coordenador = escola.coordenadores.Find(x => x.Registro == result);
                Responsavel = coordenador;
                if(Responsavel == null) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Coordenador não encontrado");
                    Console.ResetColor();
                }
            }
            while (Responsavel == null);
            Console.Write("Qual o valor maximo de alunos dentro da turma? ");
            do {
                if (uint.TryParse(Console.ReadLine(), out uint valido))
                    tamanho = valido;
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor invalido");
                    Console.ResetColor();
                }
            }
            while (tamanho < 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTurma cadastrada com sucesso");
            Console.ResetColor();
            
        }
        //Metodo para mostrar todos os dados do programa
        public void MostrarTurma() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"==================  Turma {NumTurma}  ====================\n");
            if (Responsavel == null) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Coordenador não atribuido\n");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Coordenador: {Responsavel.Nome} -- Idade: {Responsavel.Idade} -- Sexo: {Responsavel.Sexo} -- Registro: {Responsavel.Registro}\n");
            }
            if (professor == null) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Professor Não atribuido");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Professor: {professor.Nome} -- Idade: {professor.Idade} -- Sexo: {professor.Sexo} -- Registro: {professor.Registro}\n");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n==================== Alunos ========================\n");
            if (alunos.Count < 1) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem alunos atribuidos");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (Aluno a in alunos)
                    Console.WriteLine($"Matricula: {a.Matricula} -- Nome: {a.Nome} -- Idade: {a.Idade} -- Sexo: {a.Sexo} -- Bolsista: {a.Bolsista}\n");
                Console.ResetColor();
            }
        }
    }
}
