using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ALPHA1
{
    internal class CardGame
    {
        List <string> cards = new List <string> { "Gol", "Pênalti", "Energia", "Falta", "Cartão Amarelo", "Cartão Vermelho"};
        List<int> PontCards = new List<int> {3, 2, 2, 1, 1, 0};
        Random sorteio = new Random();
        private int Score;
        public int score { get { return Score; } set { Score = value; } }    
        private bool Golls2 = false ;
        public bool Golls { get { return Golls2; } set { Golls2 = value; } }
        private bool Energia1 = false;
        public bool Energia { get { return Energia1; } set { Energia1 = value; } }
        private int Penalidade;
        public int PenalidadeEnergia { get { return Penalidade; } set { Penalidade = value; } }
        int Chute = 0;
        int Defesa = 0;
        private int cartao1;
        private int cartao2;
        private int cartao3;
        public int Cartao1 { get { return cartao1; } set { cartao1 = value; } }
        public int Cartao2 { get { return cartao2; } set { cartao2 = value; } }
        public int Cartao3 { get { return cartao3; } set { cartao3 = value; } }
        private int CartaoAmarelo;
        public int CartAmarelo { get { return CartaoAmarelo; } set { CartaoAmarelo = value; } }
  

        public void Sorteio()
        {
            score = 0;
             Cartao1 = sorteio.Next(6);
             Cartao2 = sorteio.Next(6);
             Cartao3 = sorteio. Next(6);
            Console.WriteLine("Carta: "+this.cards[Cartao1]);
            Console.WriteLine("Carta: " + this.cards[Cartao2]);
            Console.WriteLine("Carta: " + this.cards[Cartao3]);
            if (Cartao1 != Cartao2 && Cartao2 != Cartao3)
            {
                score = PontCards[Cartao1] + PontCards[Cartao2] + PontCards[Cartao3];
            }
            Console.ReadKey();

        }
        public void TrêsX()
        {
            if (Cartao1 == Cartao2 && Cartao2 == Cartao3)
            {
                switch (cartao3) 
            {
                
                case 0:
                    Golls = true;
                break;
                case 1:
                    Console.WriteLine("PENALIDADE MÁXIMA! AGORA É UMA ÓTIMA CHANCE PARA MARCAR!");
                Console.WriteLine("[1 - Chute na Esquerda | 2 - Chute no Centro | 3 - Chute na Direita] ");
                this.Chute = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("AGORA A VEZ DO GOLEIRO!");
                Console.WriteLine("[1 - Defende na Esquerda | 2 - Defende no Centro | 3 - Defende na Direita]");
                this.Defesa = int.Parse(Console.ReadLine());
                if (Defesa == Chute) { Console.WriteLine("QUE DEFESA INCRIVEL DO GOLEIRO! E O PLACAR CONTINUA O MESMO!"); }
                else { Console.WriteLine("EXTRAORDINARIO CHUTE DESSE JOGADOR! NÃO TINHA COMO DEFENDER!"); Golls = true; }
                    break;
                case 2:
                    Energia = true;
                    break;
                 case 3:
                        Console.WriteLine("Falta! Vantagem adversaria.");
                    break; 
                 case 4:
                        PenalidadeEnergia = 0;
                        Console.WriteLine("Cartão Amarelo!");
                        this.CartAmarelo++;
                        if (CartAmarelo== 1)
                        { Console.WriteLine("O jogador perdeu uma jogada, na próxima ele perde 2 energias! ");
                            PenalidadeEnergia = -1;
                        }
                        else
                        {
                            Console.WriteLine("É {0}° Cartão amarelo, ele irá ser penalisado com -2 energias.",CartAmarelo);
                            PenalidadeEnergia = -2;
                        }


                    break; 
                 case 5:
                        Console.WriteLine("Cartão vermelho! O Jogador perde 2 energias!");
                        PenalidadeEnergia = -2;
                    break;
            }

            }
        }
    }
}
