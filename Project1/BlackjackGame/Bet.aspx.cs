using System;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlackjackGame
{
    public partial class Bet : Page
    {
        private int bet = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Bet"] = 0;
            }
        }

        protected void StartButton_Click(object sender, EventArgs e)
        {
            // Redirect to the game page (Game.aspx)
            Response.Redirect("Game.aspx");
        }

        protected void Btn20_Click(object sender, EventArgs e)
        {
            // Adds $20 to the Bet value

            bet = Convert.ToInt32(Session["Bet"]);
            bet += 20;
            Session["Bet"] = bet;
            BetDisplay.Text = bet.ToString();
        }

        protected void Btn50_Click(object sender, EventArgs e)
        {
            // Adds $50 to the Bet value

            bet = Convert.ToInt32(Session["Bet"]);
            bet += 50;
            Session["Bet"] = bet;
            BetDisplay.Text = bet.ToString();
        }

        protected void Btn100_Click(object sender, EventArgs e)
        {
            // Adds $50 to the Bet value

            bet = Convert.ToInt32(Session["Bet"]);
            bet += 100;
            Session["Bet"] = bet;
            BetDisplay.Text = bet.ToString();
        }

        protected void NumberButton_Click(object sender, EventArgs e)
        {
            // Adds number to the display, based on respective number clicked

            Button button = (Button)sender;
            int number = Convert.ToInt32(button.Text);
            bet = Convert.ToInt32(Session["Bet"]);
            bet = bet * 10 + number;
            Session["Bet"] = bet;
            BetDisplay.Text = bet.ToString();
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            // Clears all numbers in Text Box field

            Session["Bet"] = 0;
            BetDisplay.Text = "0";
        }
    }
}

