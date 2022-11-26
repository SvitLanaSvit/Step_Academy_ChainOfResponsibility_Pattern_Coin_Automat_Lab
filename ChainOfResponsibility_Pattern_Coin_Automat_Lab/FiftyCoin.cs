using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public class FiftyCoin : CoinHandler
    {
        public override void Handle(Coin coin, ref double sum)
        {
            if ((coin.Width > 22.7 && coin.Width < 23.3) && (coin.Weight > 4.00 && coin.Weight < 4.4))
            {
                sum += 0.5;
                coin.ValueOfCoin = 0.5;
            }             
            else if (Successor != null)
                Successor.Handle(coin, ref sum);
            else
                MessageBox.Show("Unknown coin!!!");
        }
    }
}
