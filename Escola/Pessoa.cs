using System;

namespace Projeto
{
    public abstract class Pessoa
    {
        private string _nome { get; set; }
        private byte? _idade { get; set; }
        private char? _sexo { get; set; }

        //Metodo para validar se existe numero na string
        private bool Letras(string verify)
        {
            if (verify.Contains("1") || verify.Contains("2") || verify.Contains("3") || verify.Contains("4") || verify.Contains("5") || verify.Contains("6") || verify.Contains("7") || verify.Contains("8") || verify.Contains("9") || verify.Contains("0") ||
                verify.Contains("!") || verify.Contains("@") || verify.Contains("#") || verify.Contains("$") || verify.Contains("%") || verify.Contains("¨") || verify.Contains("&") || verify.Contains("*") || verify.Contains("(") || verify.Contains(")") ||
                verify.Contains("-") || verify.Contains("_") || verify.Contains("+") || verify.Contains("=") || verify.Contains("§") || verify.Contains("/") || verify.Contains("?") || verify.Contains("°") || verify.Contains(";") || verify.Contains(":") ||
                verify.Contains(".") || verify.Contains(",") || verify.Contains(">") || verify.Contains("<") || verify.Contains("|") || verify.Contains("*") || verify.Contains("'"))
                return false;
            else
                return true;
        }
        //Usando o proprio set para fazer a validação do nome da pessoa
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (char.TryParse(value, out char name2) || string.IsNullOrWhiteSpace(value) ||
                    string.IsNullOrEmpty(value) || value.Contains("  ") || value.Length > 25 || Letras(value) == false)
                {
                    Console.WriteLine("\nNome invalido\nDigite os dados novamente\n");
                    _nome = null;
                }
                else
                    _nome = value.Trim();
            }
        }
        //Usando o proprio set para fazer a validação do sexo da pessoa
        public string Sexo
        {
            get { return _sexo.ToString(); }
            set
            {
                if (char.TryParse(value, out char valido) == false || valido != 'm' && valido != 'f' && valido != 'M' && valido != 'F')
                {
                    Console.WriteLine("\nSexo invalido\nDigite os dados novamente\n");
                    _sexo = null;
                }
                else
                    _sexo = valido;
            }
        }
        //Usando o proprio set para fazer a validação da idade da pessoa
        public string Idade
        {
            get { return _idade.ToString(); }
            set
            {
                if (byte.TryParse(value, out byte result) == false || Letras(value) || result > 150)
                {
                    Console.WriteLine("\nIdade invalida\nDigite os dados novamente\n");
                    _idade = null;
                }
                else
                    _idade = result;
            }
        }

    }
}
