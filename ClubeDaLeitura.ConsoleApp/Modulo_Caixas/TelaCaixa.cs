using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Caixas
{
    class TelaCaixa
    {
        public  RepositorioCaixa RepositorioCaixa;

        public TelaCaixa(RepositorioCaixa repositorioCaixa)
        {
            RepositorioCaixa = repositorioCaixa;
        }

        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerenciador de Caixas");
            Console.WriteLine();
            Console.WriteLine("----------------------------");

        }

        public char ApresentarMenu()
        {
            ExibirCabecalho();

            Console.WriteLine("1 - Inserir Caixa");
            Console.WriteLine("2 - Editar Caixa");
            Console.WriteLine("3 - Excluir Caixa");
            Console.WriteLine("4 - Visualizar Caixas");
            

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;
        }
    }
}
