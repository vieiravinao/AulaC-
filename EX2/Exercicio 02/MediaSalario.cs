
using Exercicio_02.Entidades;

class MediaSalario {
        static void Main(string[] args) {


        DadosPessoa Funcionario1 = new DadosPessoa();
        DadosPessoa Funcionario2 = new DadosPessoa();

        Console.Write("Digite o nome do primeiro funcionado:");
        Funcionario1.Nome = Console.ReadLine();
        Console.Write("Digite o salário do oreia seca:");
        Funcionario1.Salário = double.Parse(Console.ReadLine());

        Console.Write("Digite o nome do segundo cabrunco:");
        Funcionario2.Nome = Console.ReadLine();
        Console.Write("DIgite o salario do péba:");
        Funcionario2.Salário= double.Parse(Console.ReadLine());


        Console.WriteLine((Funcionario2.Salário + Funcionario1.Salário) / 2);
} }
