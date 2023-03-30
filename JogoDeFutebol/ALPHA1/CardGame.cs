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
        List<int> PontCards = new List<int> {3, 2, 2, 1, 0};
        int indice = 0;
        Random sorteio = new Random();
        private int Score;
        int Validar = 0;
        bool Repetiu2 = false;
        private bool Repetiu = false;
        public bool Repetiu3 { get { return Repetiu; } set { Repetiu = value; } }
        
        private bool Golls2 = false ;
        public bool Golls { get { return Golls2; } set { Golls2 = value; } }
        
        private bool Energia1 = false;
        public bool Energia { get { return Energia1; } set { Energia1 = value; } }
        int Chute = 0;
        int Defesa = 0;


        public int score { get { return Score; } set { Score = value; } }

        public void Sorteio()
        {
            indice = 0;
            while (indice < 3)
            {
                int Aleatorio = sorteio.Next(6);
                Console.WriteLine("Carta: "+this.cards[Aleatorio]);
                if (Aleatorio < 5) { this.score = this.score + this.PontCards[Aleatorio]; }               
                //Console.WriteLine("Sua Pontuação é de: " + this.score);
                indice++;                
                if (indice > 0) 
                {
                    if ( Aleatorio >= 0 && Aleatorio < 3 )
                    {
                        if (Validar == Aleatorio && indice < 2) { 
                            this.Repetiu2 = true;
                            if (indice== 2 && Validar == Aleatorio) { this.Repetiu3 = true; }
                        }
                    }
                }
                Validar = Aleatorio;
                Console.ReadKey();
            }
        }
        public void TrêsX()
        {
            if (Repetiu3 == true)
            {
                switch (this.PontCards[Validar]) 
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
            }

            }
        }
    }
}
