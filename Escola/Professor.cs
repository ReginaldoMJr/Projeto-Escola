using System;

namespace Projeto
{
    class Professor : Pessoa
    {
        public int Registro { get; private set; }
        public Coordenador Contratante { get; private set; }
        //Metodo para criar um professor
        public void CadastrarProfessor(Escola escola)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=================== Cadastro Professor ==================\n");
            Console.ResetColor();
            //Cria um professor com numero de registro aleatorio
            Random aleatorio = new Random();
            Registro = aleatorio.Next(1000, 9999);
            Console.WriteLine($"Numero de registro: {Registro}");
            //Pergunta o nome do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write("Digite o nome do professor: ");
                Nome = Console.ReadLine();
            }
            while (Nome == null);
            //Pergunta a idade do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Digite a idade do(a) {Nome} : ");
                Idade = (Console.ReadLine());
            }
            while (Idade == "");
            //Pergunta o sexo do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Qual o sexo do(a) {Nome} (M / F): ");
                Sexo = (Console.ReadLine());
            }
            while (Sexo == "");
            do
            {
                escola.ExibirCoordenadores();
                Console.Write($"Qual o registro do contratante do(a) {Nome}? ");
                int.TryParse(Console.ReadLine(), out int result);
                Contratante = escola.coordenadores.Find(x => x.Registro == result);
                if (Contratante == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Registro de coordenador invalido");
                    Console.ResetColor();
                }
            }
            while (Contratante == null);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nProfessor cadastrado com sucesso");
            Console.ResetColor();
        }
    }
}

