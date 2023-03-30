using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALPHA1
{
    internal class Player
    {
        private string Jogador;
        public string jogador {
            get { return Jogador; }
            set { Jogador = value.ToUpper(); }
        }
        public void Player_X() 
        {
            Console.WriteLine("Digite o nome do jogador: ");
            this.jogador = Console.ReadLine();
        }
        private int Score;
        public int score { get { return Score; } set { Score = value; } }

        private int Energe =10;
        public int energe { get { return Energe; } set { Energe = value; } }
        public void EnergiaInicial()
        {
            this.energe= 10;
        }

        private int Gols;
        public int gols { get { return Gols;} set { Gols = value; } }
        public void Gol_Marcado()
        {
            Console.WriteLine("GOOOOOOOOOOOLLLL!!!! Do " + this.Jogador);
            this.gols = this.gols+1;
            Console.WriteLine("Total de gols é de "+ this.gols);
        }
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

    }
    
}
