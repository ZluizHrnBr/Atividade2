namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome1 = "Eduardo";
            aluno.Matricula1 = "123";
            aluno.Estudar();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome1 = "Raffael";
            funcionario.Departamento1 = "Desenvolvimento";
            funcionario.Trabalhar();
            funcionario.Dormir();

           
        }
    }
}
