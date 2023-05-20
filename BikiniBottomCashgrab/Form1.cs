using System.Drawing.Printing;
using System.Threading;

namespace BikiniBottomCashgrab
{
    public partial class Form1 : Form
    {
        Player.Player player;
        Thread printer;
        public Form1()
        {
            player = new Player.Player();
            InitializeComponent();
            printer = new Thread(PrintScreen)
            { IsBackground = true };
            printer.Start();
            PrintCostData(1);
            
        }

        /// <summary>
        /// This is a background thread that will run until the program terminates - it updates important screen information
        /// </summary>
        public void PrintScreen()
        {
            //This is a background 
            while (true)
            {
                if(moneyLabel.InvokeRequired)
                {
                    moneyLabel.Invoke(new MethodInvoker(delegate { moneyLabel.Text = String.Format("Cash: {0:C}", player.playerCash); }));
                }
                if(PPOwnedLabel.InvokeRequired)
                {
                    PPOwnedLabel.Invoke(new MethodInvoker(delegate { PPOwnedLabel.Text = String.Format("Pretty Patty Stands: {0}", player.GetNumberOwned(Player.enumLocations.PrettyPatties)); }));
                }

                if (TAOwnedLabel.InvokeRequired)
                {
                    TAOwnedLabel.Invoke(new MethodInvoker(delegate { TAOwnedLabel.Text = String.Format("Tentacle Acres: {0}", player.GetNumberOwned(Player.enumLocations.TentacleAcres)); }));
                }

                Thread.Sleep(100);
            }
        }



        public void PrintCostData(int numberItems)
        {
            PPCost.Text = String.Format("Cost: {0:C}", player.GetCost(Player.enumLocations.PrettyPatties, numberItems));
            TACost.Text = String.Format("Cost: {0:C}", player.GetCost(Player.enumLocations.TentacleAcres, numberItems));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //This is TAButton but its named wrong
        private void button2_Click(object sender, EventArgs e)
        {
            int numberToBuy = int.Parse(BuyCount.Items[BuyCount.SelectedIndex].ToString() ?? "1");
            //We need to calculate the cost based on how many items the user wants to buy.
            player.BuyOption(Player.enumLocations.PrettyPatties, numberToBuy);
        }

        private void PPButton_Click(object sender, EventArgs e)
        {
            int numberToBuy = int.Parse(BuyCount.Items[BuyCount.SelectedIndex].ToString() ?? "1");
            //We need to calculate the cost based on how many items the user wants to buy.
            player.BuyOption(Player.enumLocations.PrettyPatties, numberToBuy);
        }

        private void BuyCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberToBuy = int.Parse(BuyCount.Items[BuyCount.SelectedIndex].ToString() ?? "1");
            PrintCostData(numberToBuy);
        }
    }
}