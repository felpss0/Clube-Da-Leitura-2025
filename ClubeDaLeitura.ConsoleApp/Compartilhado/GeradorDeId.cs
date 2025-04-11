

namespace ClubeDaLeitura.ConsoleApp.Compartilhado
{
    class GeradorDeId
    {
        public static int IdAmigo = 0;


        public static int GerarIdAmigo() 
        {
            IdAmigo ++;

            return IdAmigo;
        }
    }
}
