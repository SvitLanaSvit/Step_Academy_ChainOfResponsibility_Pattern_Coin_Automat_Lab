using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public class TenCoin : CoinHandler
    {
        public override void Handle(Coin coin, ref double sum)
        {
            if ((coin.Width > 16.1 && coin.Width < 16.4) && (coin.Weight > 1.5 && coin.Weight < 1.9))
            {
                sum += 0.1;
                coin.ValueOfCoin = 0.1;
            }
            else if(Successor != null) 
                Successor.Handle(coin, ref sum);
            else
                MessageBox.Show("Unknown coin!!!");
        }
    }
}
