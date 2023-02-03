using Estudos.Entidades;

namespace curso
{
    class ChapterFour         //COLETAR NOME E IDADE E MOSTRAR QUAL É MAIS VELHA
    {
        public static void Main(string[] args) {


            DadosPessoa Nome1, Nome2;

            Nome1 = new DadosPessoa();
            Nome2 = new DadosPessoa();

            Console.Write("Digite o primeiro nome:");
            Nome1.Nome = (Console.ReadLine());
            Console.Write("Digite a idade:");
            Nome1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo nome:");
            Nome2.Nome = (Console.ReadLine());
            Console.Write("Digite a idade:");
            Nome2.Idade = int.Parse(Console.ReadLine());

            if (Nome1.Idade > Nome2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é :" + Nome1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é:" + Nome2.Nome);
            }
         
        }
      } }





