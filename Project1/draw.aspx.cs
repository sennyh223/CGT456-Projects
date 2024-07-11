using System;
using System.Web.UI;

namespace BlackjackGame
{
    public partial class draw : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Function determines whether or not user has placed a Bet on Bet.aspx. If yes, it displays bet
            // and shows Value after the current game state (Win / Lose / Draw)
            if (Session["Bet"] != null)
            {
                // Calculate final Balance (Win: 2x, Loss: $0, Draw: No change)
                int bet = Convert.ToInt32(Session["Bet"]);
                BetLabel.Text = $"It's a Draw! Your ${bet} is retained and nothing is lost. </br> Nice try.";
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
