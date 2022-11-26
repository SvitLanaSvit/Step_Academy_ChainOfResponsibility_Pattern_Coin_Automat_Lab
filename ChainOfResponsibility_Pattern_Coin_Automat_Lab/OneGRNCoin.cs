using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public class OneGRNCoin : CoinHandler
    {
        public override void Handle(Coin coin, ref double sum)
        {
            if ((coin.Width > 18.7 && coin.Width < 19.1) && (coin.Weight > 3.1 && coin.Weight < 3.5))
            {
                sum += 1.0;
                coin.ValueOfCoin = 1.0;
            }
            else if (Successor != null)
                Successor.Handle(coin, ref sum);
            else
                MessageBox.Show("Unknown coin!!!");
        }
    }
}
