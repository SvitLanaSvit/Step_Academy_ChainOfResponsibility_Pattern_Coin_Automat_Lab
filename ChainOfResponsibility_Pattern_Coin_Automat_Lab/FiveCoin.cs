using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public class FiveCoin : CoinHandler
    {
        public override void Handle(Coin coin, ref double sum)
        {
            if ((coin.Width > 23.8 && coin.Width < 24.2) && (coin.Weight > 4.2 && coin.Weight < 4.6))
            {
                sum += 0.05;
                coin.ValueOfCoin = 0.05;
            }
            else if (Successor != null)
                Successor.Handle(coin, ref sum);
            else
                MessageBox.Show("Unknown coin!!!");
        }
    }
}
