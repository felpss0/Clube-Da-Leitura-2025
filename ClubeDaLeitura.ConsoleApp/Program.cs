using ClubeDaLeitura.ConsoleApp.Amigos;
using ClubeDaLeitura.ConsoleApp.Caixas;
using ClubeDaLeitura.ConsoleApp.Compartilhado;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();


            TelaAmigo telaAmigo = new TelaAmigo(repositorioAmigo);
            TelaCaixa telaCaixa = new TelaCaixa(repositorioCaixa);


            MenuPrincipal telaPrincipal = new MenuPrincipal();

            while (true) 
            {
                Console.Clear();

                char opcaoPrincipal = telaPrincipal.ApresentarMenu();

                if (opcaoPrincipal == '1') 
                {
                    char opcaoEscolhida = telaAmigo.ApresentarMenu();

                    switch (opcaoEscolhida) 
                    {
                        case '1': telaAmigo.CadastrarAmigo(); break;
                        
                        case '2': telaAmigo.EditarAmigo(); break;

                        case '3': telaAmigo.ExcluirAmigo();break;

                        case '4': telaAmigo.VisualizarAmigo(true); break;

                    }
                }

                if (opcaoPrincipal == '2')
                {
                    char opcaoEscolhida = telaCaixa.ApresentarMenu();

                    switch (opcaoEscolhida)
                    {
                        case '1': ; break;

                        case '2': ; break;

                        case '3': ; break;

                        case '4': ; break;

                    }
                }
            }
        }
    }
}
