using ALPHA1;

namespace ProjetoAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sair = 2;

            Console.WriteLine("Bem-vindo ao jogo de futebol da xPlayB2!");
            Player Jogador1 = new Player();
            Player Jogador2 = new Player();
            CardGame JogoCartas = new CardGame();
            Jogador1.VsPlayer();
            Console.WriteLine("-------------- Jogador 1 -----------");
            Jogador1.Player_X();
            Console.Clear();
            if (Jogador1.PC_Player == false)
            {
                Console.WriteLine("-------------- Jogador 2 -----------");
                Jogador2.Player_X();
            }
            else { Jogador2.jogador = "Computador"; }

            while (Jogador1.energe > -1 || Jogador2.energe > -1)
            {
                Console.WriteLine("________________________________________________________");
                Console.WriteLine(Jogador1.jogador + " vs " + Jogador2.jogador);
                Console.WriteLine("________________________________________________________");
                switch (Jogador1.JogadorDaVez)
                {
                    case true:
                        /* Jogador1.TestGol();
                         Jogador2.TestGol(); */
                        Jogador1.Apresentacao();
                        JogoCartas.Sorteio();
                        JogoCartas.TrêsX();
                        if (JogoCartas.Golls == true)
                        {
                            Jogador1.Gol_Marcado();
                            JogoCartas.Golls = false;
                        }
                        if (JogoCartas.Energia == true) { Jogador1.energe++; }
                        else { Jogador1.score = Jogador1.score + JogoCartas.score; }
                        Jogador1.energe = Jogador1.energe - 1;
                        Jogador1.JogadorDaVez = false;
                       
                        break;
                    case false:
                        Jogador2.Apresentacao();
                        JogoCartas.Sorteio();
                        JogoCartas.TrêsX();
                        if (JogoCartas.Golls == true)
                        {
                            Jogador2.Gol_Marcado();
                            JogoCartas.Golls=false;
                        }
                        if (JogoCartas.Energia == true) { Jogador2.energe++; }
                        else { Jogador2.score = Jogador2.score + JogoCartas.score; }
                        Jogador2.energe = Jogador1.energe - 1;
                        Jogador1.JogadorDaVez = true;
                        
                        break;


                }
                if (Jogador1.energe == 0 && Jogador1.energe == Jogador2.energe)
                {
                    if (Jogador1.gols > Jogador2.gols || Jogador1.gols == Jogador2.gols && Jogador1.score > Jogador2.score) { Jogador1.Ganhador(); Jogador2.Perdedor(); }

                    else if (Jogador2.gols > Jogador1.gols || Jogador1.gols == Jogador2.gols && Jogador2.score > Jogador1.score) { Jogador2.Ganhador(); Jogador1.Perdedor(); }
                    else
                    {
                        Console.WriteLine("Incrivel! Um Empate!");
                        Jogador1.Empate();
                    }
                    Console.WriteLine("Deseja sair? [1 - Sim | 2 - Não] ");
                    Sair = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}