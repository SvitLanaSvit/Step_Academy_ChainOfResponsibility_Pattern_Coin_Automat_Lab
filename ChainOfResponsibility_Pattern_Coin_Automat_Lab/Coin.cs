using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public class Coin
    {
        public double Width { get; set; }
        public double Weight { get; set; }
        public double ValueOfCoin { get; set; }

        public Coin(double width, double weight) 
        { 
            this.Width = width;
            this.Weight = weight;
        }
    }
}
