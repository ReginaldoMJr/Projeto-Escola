namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria uma nova turma para chamar os metodos abaixo
            Turma turma = new Turma();

            turma.CadastrarTurma();
            turma.Exibir();
        }
    }
}
