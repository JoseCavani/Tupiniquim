using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiniquim
{
    public class Robo
    {
        private int x;
        private int y;
        private char orientacao;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public char Orientacao { get => orientacao; set => orientacao = value; }
        public Robo(int x, int y, char orientacao)
        {
            this.x = x;
            this.y = y; 
            this.orientacao = orientacao;  
        }
    }
   
}
