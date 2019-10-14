using System;
using System.Collections.Generic;

namespace Projeto
{
    class Turma
    {
        public int NumTurma { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> alunos = new List<Aluno>();
        //Cadastrar a turma, com numero de turma aleatório 
        public void CadastrarTurma()
        {
            Turma turma = new Turma();
            Random numTurma = new Random();
            NumTurma = numTurma.Next(10, 99);
            Console.Write($"Numero da turma: {NumTurma}\n");
            //Fazer o cadastro de um professor
            Console.Write("\n====== Cadastrar Professor ======\n");
            Professor professor = new Professor();
            Professor = professor.CadastrarProfessor();
            //Fazer o cadastro de varios alunos
            Console.WriteLine("\n====== Cadastro Aluno ======\n");
            int num;
            do
            {
                Console.Write("Quantos alunos pretende cadastrar? ");
                string testeNum = Console.ReadLine();
                if (byte.TryParse(testeNum, out byte result) == false || result > 100)
                {
                    Console.WriteLine("\nNumero invalido, Digite novamente\n");
                    num = 0;
                }
                else
                    num = result;
            }
            while (num == 0);
            //Com o numero digitado pelo usuario faz o cadastro dos alunos usando a quantidade solicitada
            for (int i = 0; i < num; i++)
            {
                Aluno aluno = new Aluno();
                aluno = aluno.CadastrarAluno();
                alunos.Add(aluno);
            }
        }
        //Metodo para mostrar todos os dados do programa
        public void Exibir()
        {
            Console.WriteLine($"\nTurma: {NumTurma}      Professor: {Professor.Nome} -- Idade: {Professor.Idade} -- Sexo: {Professor.Sexo} -- Registro: {Professor.Registro}\n\nAlunos: \n");
            foreach (Aluno s in alunos)
                Console.WriteLine($"Matricula: {s.Matricula} -- Nome: {s.Nome} -- Idade: {s.Idade} -- Sexo: {s.Sexo} -- Bolsista: {s.Bolsista}\n");
        }
    }
}
