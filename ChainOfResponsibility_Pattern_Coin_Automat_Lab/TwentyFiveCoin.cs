using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public class TwentyFiveCoin : CoinHandler
    {
        public override void Handle(Coin coin, ref double sum)
        {
            if ((coin.Width > 20.6 && coin.Width < 21.0) && (coin.Weight > 2.7 && coin.Weight < 3.1))
            {
                sum += 0.25;
                coin.ValueOfCoin = 0.25;
            } 
            else if (Successor != null)
                Successor.Handle(coin, ref sum);
            else
                MessageBox.Show("Unknown coin!!!");
        }
    }
}
