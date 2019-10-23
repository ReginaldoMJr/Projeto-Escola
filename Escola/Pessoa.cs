
using System;
using System.Text.RegularExpressions;

namespace Projeto {
    public abstract class Pessoa {
        private string _nome { get; set; }
        private byte? _idade { get; set; }
        private char? _sexo { get; set; }

        //Usando o proprio set para fazer a validação do nome da pessoa
        public string Nome {
            get { return _nome; }
            set {
                if (Regex.IsMatch(value, "^[a-z A-Z]{1,30}$") && !value.Contains("  ") && !string.IsNullOrWhiteSpace(value))
                    _nome = value.Trim();
                else {
                    Console.WriteLine("\nNome invalido\nDigite os dados novamente\n");
                    _nome = null;
                }
            }
        }
        //Usando o proprio set para fazer a validação do sexo da pessoa
        public string Sexo {
            get { return _sexo.ToString(); }
            set {
                if (Regex.IsMatch(value, "^[mfMF]{1}$"))
                    _sexo = char.Parse(value);
                else {
                    Console.WriteLine("\nSexo invalido\nDigite os dados novamente\n");
                    _sexo = null;
                }
            }
        }
        //Usando o proprio set para fazer a validação da idade da pessoa
        public string Idade {
            get { return _idade.ToString(); }
            set {
                if (Regex.IsMatch(value, @"^[\d]{1,3}$") && int.Parse(value) < 150 && int.Parse(value) > 5)
                    _idade = byte.Parse(value);
                else {
                    Console.WriteLine("\nIdade invalida\nDigite os dados novamente\n");
                    _idade = null;
                }
            }
        }

    }
}
