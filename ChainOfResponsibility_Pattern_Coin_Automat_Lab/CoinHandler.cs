using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public abstract class CoinHandler
    {
        public CoinHandler Successor { get; set; } = null!;
        public abstract void Handle(Coin coin, ref double sum);
    }
}
