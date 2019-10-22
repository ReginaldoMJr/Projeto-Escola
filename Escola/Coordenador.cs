using System;

namespace Projeto
{
    class Coordenador : Pessoa
    {
        public int Registro;

        public void CadastrarCoordenador(Escola escola)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================== Cadastro Coordenador ==================\n");
            Console.ResetColor();
            //Cria um coordenador com numero de registro aleatorio
            do Registro = new Random().Next(10, 99);
            while (escola.coordenadores.Exists(x => x.Registro == Registro));
            Console.WriteLine($"Numero de registro: {Registro}");
            //Pergunta o nome do coordenador, e faz a validação na classe pessoa
            do
            {
                Console.Write("Digite o nome do coordenador: ");
                Nome = Console.ReadLine();
            }
            while (Nome == null);
            //Pergunta a idade do coordenador, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Digite a idade do(a) {Nome} : ");
                Idade = (Console.ReadLine());
            }
            while (Idade == "");
            //Pergunta o sexo do coordenador, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Qual o sexo do(a) {Nome} (M / F): ");
                Sexo = (Console.ReadLine());
            }
            while (Sexo == "");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCoordenador cadastrado com sucesso");
            Console.ResetColor();
        }

    }
}
