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
            Console.WriteLine("=================== Cadastro Professor ==================\n");
            //Cria um professor com numero de registro aleatorio
            Coordenador coordenador = new Coordenador();
            Random aleatorio = new Random();
            coordenador.Registro = aleatorio.Next(1000, 9999);
            Console.WriteLine($"Numero de registro: {coordenador.Registro}");
            //Pergunta o nome do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write("Digite o nome do professor: ");
                coordenador.Nome = Console.ReadLine();
            }
            while (coordenador.Nome == null);
            //Pergunta a idade do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Digite a idade do(a) {coordenador.Nome} : ");
                coordenador.Idade = (Console.ReadLine());
            }
            while (coordenador.Idade == "");
            //Pergunta o sexo do professor, e faz a validação na classe pessoa
            do
            {
                Console.Write($"Qual o sexo do(a) {coordenador.Nome} (M / F): ");
                coordenador.Sexo = (Console.ReadLine());
            }
            while (coordenador.Sexo == "");
            return coordenador;
        }

    }
}
