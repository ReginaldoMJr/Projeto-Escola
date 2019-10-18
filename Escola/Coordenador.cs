using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto
{
    class Coordenador : Pessoa
    {
        public int Registro;

        public Coordenador CadastrarCoordenador()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================== Cadastro Coordenador ==================\n");
            Console.ResetColor();
            //Cria um coordenador com numero de registro aleatorio
            Coordenador coordenador = new Coordenador();
            Random aleatorio = new Random();
            coordenador.Registro = aleatorio.Next(1000, 9999);
            Console.WriteLine($"Numero de registro: {coordenador.Registro}");
            //Pergunta o nome do coordenador, e faz a validação na classe pessoa
            do
            {
                Console.Write("Digite o nome do coordenador: ");
                coordenador.Nome = Console.ReadLine();
            }
            while (coordenador.Nome == null);
            //Pergunta a idade do coordenador, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Digite a idade do(a) {coordenador.Nome} : ");
                coordenador.Idade = (Console.ReadLine());
            }
            while (coordenador.Idade == "");
            //Pergunta o sexo do coordenador, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Qual o sexo do(a) {coordenador.Nome} (M / F): ");
                coordenador.Sexo = (Console.ReadLine());
            }
            while (coordenador.Sexo == "");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCoordenador cadastrado com sucesso");
            Console.ResetColor();
            return coordenador;
        }

    }
}
