using ALPHA1;

namespace ProjetoAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo de futebol da xPlayB2!");
            Player Jogador1= new Player();
            Player Jogador2= new Player();
            Console.WriteLine("-------------- Jogador 1 -----------");
            Jogador1.Player_X();
            Console.Clear();
            Console.WriteLine("-------------- Jogador 2 -----------");
            Jogador2.Player_X();
            Console.WriteLine(Jogador1.jogador + " vs " + Jogador2.jogador);
           /* Jogador1.TestGol();
            Jogador2.TestGol(); */
            
        }
    }
}