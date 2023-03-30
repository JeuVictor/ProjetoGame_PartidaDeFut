using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALPHA1
{
    internal class Player
    {
        private bool Computer;
        public bool PC_Player { get { return Computer; } set { Computer = value; } }
        private bool RodadaDaVez;
        public bool JogadorDaVez { get { return RodadaDaVez; } set { RodadaDaVez= value; } }
        private int Validar_PC;
        public int validarPC 
        { get
            { return Validar_PC; } 
        set
            {
                Validar_PC = value;
            } }
        private string Jogador;
        public string jogador {
            get { return Jogador; }
            set { Jogador = value.ToUpper(); }
        }
       
     
        private int Score;
        public int score { get { return Score; } set { Score = value; } }

        private int Energe =10;
        public int energe { get { return Energe; } set { Energe = value; } }


        private int Gols;
        public int gols { get { return Gols;} set { Gols = value; } }
       
        public int teste;
       /* public void TestGol()
        {
            while (teste != 2 ) 
            {
                Console.WriteLine("Digite o botão 1 para marcar o gol e 2 para sair do If");
                this.teste = int.Parse(Console.ReadLine());
                if (this.teste == 1) { Gol_Marcado(); }
                else { Console.WriteLine("Encerrando"); }
            }
        } */
       public void Apresentacao() 
        {
            Console.Clear();
            Console.WriteLine("Rodada da vez : Jogador " + jogador);
            Console.WriteLine("Pontuação atual: "+score);
            Console.WriteLine("Gols marcado: "+gols);
            Console.WriteLine("Energia restante: "+energe);
            Console.WriteLine("_______________________________________");
            Console.WriteLine("");
        }
        public void Player_X()
        {
            Console.WriteLine("Digite o nome do jogador: ");
            this.jogador = Console.ReadLine();
        }
        public void Gol_Marcado()
        {
            Console.WriteLine("GOOOOOOOOOOOLLLL!!!! Do " + this.Jogador);
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            this.gols = this.gols + 1;
            Console.WriteLine("Total de gols é de " + this.gols);
            Console.WriteLine("");
            Console.ReadKey();
        }
        public void VsPlayer()
        {
            Console.WriteLine("Escolha a opção para iniciar o jogo: ");
            Console.WriteLine("[1 - Player 1 vs Player 2 ||  2 - Player 1 vs Computador]");
            validarPC = int.Parse(Console.ReadLine());
            if (validarPC == 2) { PC_Player = true; }
            else { PC_Player = false; }
        }
        public void Ganhador()
        {
            Console.Clear();
            Console.WriteLine("Parabens o jogador "+jogador+" é o ganhador!");
            Console.WriteLine(Score+" pts;");
            Console.WriteLine(gols+" Gols;");
        }
        public void Perdedor() 
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("Infelizmente o jogador " + jogador + " não ganhou dessa vez!");
            Console.WriteLine(Score + " pts;");
            Console.WriteLine(gols + " Gols;");
         }
        public void Empate()
        {
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("Apesar do empate, parabens o jogador " + jogador );
            Console.WriteLine(Score + " pts;");
            Console.WriteLine(gols + " Gols;");
            Console.WriteLine("_________________________________________________________");
        }

    }
    
}
