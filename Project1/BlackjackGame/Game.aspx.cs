using System;
using System.Web.UI;

namespace BlackjackGame
{
    public partial class Game : System.Web.UI.Page
    {
        private Random random = new Random();
        private int userHandValue = 0;
        private int dealerHandValue = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize game
            // Draws 3 Random Numbers (2 for user, 1 for dealer) from 1-11, to simulate a simple game of Blackjack.
            int num1 = random.Next(1, 12);
            int num2 = random.Next(1, 12);
            int num3 = random.Next(1, 12);
            userHandValue = num1 + num2;
            dealerHandValue = num3;
            UserHandLabel.Text = $"{num1} + {num2}";
            DealerHandLabel.Text = num3.ToString();
        }

        protected void HitButton_Click(object sender, EventArgs e)
        {
            // Add random number to user hand
            int num = random.Next(1, 12);
            userHandValue += num;
            UserHandLabel.Text += $" + {num}";

            // Add random number to dealer hand
            dealerHandValue += num;
            DealerHandLabel.Text += $" + {num}";
            CheckGameEnd();
        }

        protected void StandButton_Click(object sender, EventArgs e)
        {
            // Add random number to dealer hand
            int num = random.Next(1, 12);
            dealerHandValue += num;
            DealerHandLabel.Text += $" + {num}";
            CheckGameEnd();
        }

        // Function checks game state and figures out whether User Wins/Loses.
        // If either the Dealer or Uuser busts (going over 21), the game automatically results in a loss for the respective party.
        // If no one busts, whoever is closest to 21 wins. 
        // If both hands are tied, result in a draw.
        private void CheckGameEnd()
        {
            if (userHandValue >= 22)
            {
                // User loses
                EndGame("Bust, you have lost");
            }
            else if (dealerHandValue >= 22)
            {
                // User wins
                EndGame("Dealer bust, you have won");
            }
            else if (dealerHandValue == 21)
            {
                // User loses
                EndGame("Dealer has 21, you have lost");
            }
            else if (userHandValue == 21)
            {
                // User wins
                EndGame("You have 21, you have won");
            }
            else if (userHandValue > dealerHandValue)
            {
                // User wins
                EndGame("You have won");
            }
            else if (userHandValue < dealerHandValue)
            {
                // User loses
                EndGame("You have lost");
            }
            else
            {
                // Draw
                EndGame("It's a draw");
            }
        }

        private void EndGame(string message)
        {
            string redirectPage;

            // Determine redirect page based on the message
            switch (message)
            {
                case "Bust, you have lost":
                case "Dealer has 21, you have lost":
                case "You have lost":
                    redirectPage = "lose.aspx";
                    break;
                case "Dealer bust, you have won":
                case "You have 21, you have won":
                case "You have won":
                    redirectPage = "win.aspx";
                    break;
                default:
                    redirectPage = "draw.aspx";
                    break;
            }

            // Redirect to appropriate page
            Response.Redirect(redirectPage);
        }
    }
}
