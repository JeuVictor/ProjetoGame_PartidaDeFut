using ALPHA1;

namespace ProjetoAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sair = 0;
            
                Console.WriteLine("Bem-vindo ao jogo de futebol da xPlayB2!");
                Player Jogador1 = new Player();
                Player Jogador2 = new Player();
            
                Console.WriteLine("-------------- Jogador 1 -----------");
                Jogador1.Player_X();
                Console.Clear();
                Console.WriteLine("-------------- Jogador 2 -----------");
                Jogador2.Player_X();
            while (Sair != 1)
            {
                Console.WriteLine(Jogador1.jogador + " vs " + Jogador2.jogador);
                /* Jogador1.TestGol();
                 Jogador2.TestGol(); */
                CardGame JogoCartas = new CardGame();
                JogoCartas.Sorteio();
                JogoCartas.TrêsX();
                if (JogoCartas.Golls == true) { 
                    Jogador1.Gol_Marcado(); }
                if (JogoCartas.Energia== true) { Jogador1.energe++; }
                if (JogoCartas.Repetiu3== false) { Jogador1.score = Jogador1.score+JogoCartas.score; }
                Console.WriteLine("Pontuação "+Jogador1.score);
                Console.WriteLine("Gols: "+Jogador1.gols);
                Console.WriteLine("Deseja sair? [1 - Sim | 2 - Não] ");
                Jogador1.energe = Jogador1.energe - 1;
                Sair = int.Parse(Console.ReadLine());
                if (Jogador1.energe == 0) { Sair =1; }
            }
            
        }
    }
}