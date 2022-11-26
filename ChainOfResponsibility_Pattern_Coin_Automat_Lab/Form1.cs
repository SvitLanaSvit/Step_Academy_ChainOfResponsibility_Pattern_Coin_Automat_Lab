namespace ChainOfResponsibility_Pattern_Coin_Automat_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CoinHandler automat = null!;
        double totalSum = 0;

        private void btnPutCoin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWidth.Text, out double width) && double.TryParse(txtWeight.Text, out double weight))
            {
                Coin coin = new Coin(width, weight);
                automat.Handle(coin, ref totalSum);
                lblCoin.Text = String.Format("{0:0.00}", coin.ValueOfCoin);
                lblSum.Text = String.Format("{0:0.00}", totalSum);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CoinHandler five = new FiveCoin();
            CoinHandler ten = new TenCoin();
            CoinHandler twentyFive = new TwentyFiveCoin();
            CoinHandler fifty = new FiftyCoin();
            CoinHandler oneGrn = new OneGRNCoin();
            five.Successor = ten;
            ten.Successor = twentyFive;
            twentyFive.Successor = fifty;
            fifty.Successor = oneGrn;
            automat = five;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}