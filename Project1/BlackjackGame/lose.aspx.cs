using System;
using System.Web.UI;

namespace BlackjackGame
{
    public partial class lose : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Function determines whether or not user has placed a Bet on Bet.aspx. If yes, it displays bet
            // and shows Value after the current game state (Win / Lose / Draw)
            if (Session["Bet"] != null)
            {
                // Calculate final Balance (Win: 2x, Loss: $0, Draw: No change)
                int bet = Convert.ToInt32(Session["Bet"]);
                int balance = bet * 2;
                BetLabel.Text = $"You Lose! You have lost your bet of ${bet} </br> and now your balance is $0! </br> Better Luck Next Time.";
            }
            else
            {
                BetLabel.Text = "No bet was placed.";
            }
        }

        protected void PlayAgainButton_Click(object sender, EventArgs e)
        {
            // Redirect to the bet page (Bet.aspx)
            Response.Redirect("Bet.aspx");
        }
    }
}
