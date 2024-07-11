using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MemoryMatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declare and initialize variables
        //initialize 12 cards not equal to 0;
        //  When set to a number, 2 cards will equal 1, two will equal 2, etc. 
        // assigned in randomization loop below 
        //Values: 1=Kitten; 2-=uppy; 3=Monkey; 4=Polar bear; 5=wile e coyote; 6=road runner
        private int card1 = 0, card2 = 0, card3 = 0, card4 = 0, card5 = 0, card6 = 0, card7 = 0, card8 = 0, card9 = 0, card10 = 0, card11 = 0, card12 = 0;
        private int randomNum = 0; //used to randomly assign cards to images
        private int numMatches = 0; //countrs tyhe number of matches when rendomizing
        private int counter = 0; //used inside the randomization as a counter

        private int mistakes = 0; //counts wrong attempts, displayed in upper left
        private int numSelectedCards = 0; //will either be 0,1,2
        private int totalNumMatchesRemoved = 0; //will be 0,1,2,3,4,5,6
        private int firstSelectedCard = 0; //set it equal to the match number 1-6

        //below, store the first selected Image control and Border control
        //so they can be compared against the second selection
        private System.Windows.Controls.Image firstSelectedImage = new Image();
        private System.Windows.Controls.Border firstSelectedBorder = new Border();




        public MainWindow()
        {
            InitializeComponent();
            //set our image location
            var uriSource = new Uri(@"CardPair_sm.png", UriKind.Relative);
            pbMatch1.Source = new BitmapImage(uriSource);
            pbMatch2.Source = new BitmapImage(uriSource);
            pbMatch3.Source = new BitmapImage(uriSource);
            pbMatch4.Source = new BitmapImage(uriSource);
            pbMatch5.Source = new BitmapImage(uriSource);
            pbMatch6.Source = new BitmapImage(uriSource);


            //hide those 6 matches in the upper right
            pbMatch1.Visibility = Visibility.Hidden;
            pbMatch2.Visibility = Visibility.Hidden;
            pbMatch3.Visibility = Visibility.Hidden;
            pbMatch4.Visibility = Visibility.Hidden;
            pbMatch5.Visibility = Visibility.Hidden;
            pbMatch6.Visibility = Visibility.Hidden;

            //hide congrats and play again
            lblCongrats.Visibility = Visibility.Hidden;
            btnPlayAgain.Visibility = Visibility.Hidden;

            //set label mistakes to nothing
            lblMistakes.Content = "";

            playGame();

        } //end Mainwindow
        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            //call playGame to set up a new game
            playGame();
        }

        private void playGame()
        {
            //re-initialize variables:
            card1 = 0;
            card2 = 0;
            card3 = 0;
            card4 = 0;
            card5 = 0;
            card6 = 0;
            card7 = 0;
            card8 = 0;
            card9 = 0;
            card10 = 0;
            card11 = 0;
            card12 = 0;
            randomNum = 0;
            numMatches = 0;
            counter = 0;
            mistakes = 0;
            numSelectedCards = 0;
            totalNumMatchesRemoved = 0;
            firstSelectedCard = 0;
            firstSelectedBorder = new Border();
            firstSelectedImage = new Image();


            //hide congrats and play again
            lblCongrats.Visibility = Visibility.Hidden;
            btnPlayAgain.Visibility = Visibility.Hidden;

            //show all 12 cards
            pbBorder1.Visibility = Visibility.Visible;
            pbBorder2.Visibility = Visibility.Visible;
            pbBorder3.Visibility = Visibility.Visible;
            pbBorder4.Visibility = Visibility.Visible;
            pbBorder5.Visibility = Visibility.Visible;
            pbBorder6.Visibility = Visibility.Visible;
            pbBorder7.Visibility = Visibility.Visible;
            pbBorder8.Visibility = Visibility.Visible;
            pbBorder9.Visibility = Visibility.Visible;
            pbBorder10.Visibility = Visibility.Visible;
            pbBorder11.Visibility = Visibility.Visible;
            pbBorder12.Visibility = Visibility.Visible;

            //hide the 6 matches in the upper right
            pbMatch1.Visibility = Visibility.Hidden;
            pbMatch2.Visibility = Visibility.Hidden;
            pbMatch3.Visibility = Visibility.Hidden;
            pbMatch4.Visibility = Visibility.Hidden;
            pbMatch5.Visibility = Visibility.Hidden;
            pbMatch6.Visibility = Visibility.Hidden;

            //set our image location
            var uriSource = new Uri(@"cardBack.jpg", UriKind.Relative);

            pictureBox1.Source = new BitmapImage(uriSource);
            pictureBox2.Source = new BitmapImage(uriSource);
            pictureBox3.Source = new BitmapImage(uriSource);
            pictureBox4.Source = new BitmapImage(uriSource);
            pictureBox5.Source = new BitmapImage(uriSource);
            pictureBox6.Source = new BitmapImage(uriSource);
            pictureBox7.Source = new BitmapImage(uriSource);
            pictureBox8.Source = new BitmapImage(uriSource);
            pictureBox9.Source = new BitmapImage(uriSource);
            pictureBox10.Source = new BitmapImage(uriSource);
            pictureBox11.Source = new BitmapImage(uriSource);
            pictureBox12.Source = new BitmapImage(uriSource);

            //clear the mistakes label
            lblMistakes.Content = "";


            //we have 12 cards so we need 6 matches. loop until we have 6 matches.
            Random r = new Random();

            while (numMatches < 6)
            {
                //generatea random number between 1 and 12
                randomNum = r.Next(1, 13);

                switch (randomNum)
                {
                    case 1:
                        if (card1 == 0)
                        {
                            card1 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 2:
                        if (card2 == 0)
                        {
                            card2 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 3:
                        if (card3 == 0)
                        {
                            card3 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 4:
                        if (card4 == 0)
                        {
                            card4 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 5:
                        if (card5 == 0)
                        {
                            card5 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 6:
                        if (card6 == 0)
                        {
                            card6 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 7:
                        if (card7 == 0)
                        {
                            card7 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 8:
                        if (card8 == 0)
                        {
                            card8 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 9:
                        if (card9 == 0)
                        {
                            card9 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 10:
                        if (card10 == 0)
                        {
                            card10 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 11:
                        if (card11 == 0)
                        {
                            card11 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 12:
                        if (card12 == 0)
                        {
                            card12 = numMatches + 1;
                            counter++;
                        }
                        break;

                } // end switch

                if (counter == 2)
                {
                    numMatches++;
                    counter = 0;
                }


            }//end while loop



        }//end playGame
        private void displayMatches()
        {
            for (int x = 1; x <= totalNumMatchesRemoved; x++)
            {
                switch (x)
                {
                    case 1:
                        pbMatch1.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        pbMatch2.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        pbMatch3.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        pbMatch4.Visibility = Visibility.Visible;
                        break;
                    case 5:
                        pbMatch5.Visibility = Visibility.Visible;
                        break;
                    case 6:
                        pbMatch6.Visibility = Visibility.Visible;
                        break;
                }
            }//end for loop

        }//end displayMatches

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // create a new image control and its surrounding border
            System.Windows.Controls.Image currentImage = new Image();
            System.Windows.Controls.Border currentBorder = new Border();

            //cast the sender into an Image control
            currentImage = (System.Windows.Controls.Image)sender;

            //increment the numSelectedCards - will be either 0, 1, 2
            numSelectedCards++;

            //initialize uriSOurce to Anything, it doesn't matter what
            //set our image location
            var uriSource = new Uri(@"cardBack.jpg", UriKind.Relative);

            //create a varible to store the current card
            int currentCard = 0;

            //determine which card needs to be used based on which image was clicked
            if (currentImage.Name == "pictureBox1")
            {
                currentCard = card1;
                currentBorder = pbBorder1;
            }
            else if (currentImage.Name == "pictureBox2")
            {
                currentCard = card2;
                currentBorder = pbBorder2;
            }
            else if (currentImage.Name == "pictureBox2")
            {
                currentCard = card2;
                currentBorder = pbBorder2;
            }
            else if (currentImage.Name == "pictureBox3")
            {
                currentCard = card3;
                currentBorder = pbBorder3;
            }
            else if (currentImage.Name == "pictureBox4")
            {
                currentCard = card4;
                currentBorder = pbBorder4;
            }
            else if (currentImage.Name == "pictureBox5")
            {
                currentCard = card5;
                currentBorder = pbBorder5;
            }
            else if (currentImage.Name == "pictureBox6")
            {
                currentCard = card6;
                currentBorder = pbBorder6;
            }
            else if (currentImage.Name == "pictureBox7")
            {
                currentCard = card7;
                currentBorder = pbBorder7;
            }
            else if (currentImage.Name == "pictureBox8")
            {
                currentCard = card8;
                currentBorder = pbBorder8;
            }
            else if (currentImage.Name == "pictureBox9")
            {
                currentCard = card9;
                currentBorder = pbBorder9;
            }
            else if (currentImage.Name == "pictureBox10")
            {
                currentCard = card10;
                currentBorder = pbBorder10;
            }
            else if (currentImage.Name == "pictureBox11")
            {
                currentCard = card11;
                currentBorder = pbBorder11;
            }
            else if (currentImage.Name == "pictureBox12")
            {
                currentCard = card12;
                currentBorder = pbBorder12;
            }

            //check to see which picture to display
            if (currentCard == 1)
                uriSource = new Uri(@"kitten.jpg", UriKind.Relative);
            else if (currentCard == 2)
                uriSource = new Uri(@"puppy.jpg", UriKind.Relative);
            else if (currentCard == 3)
                uriSource = new Uri(@"funnyMonkey.jpg", UriKind.Relative);
            else if (currentCard == 4)
                uriSource = new Uri(@"polarBears.jpg", UriKind.Relative);
            else if (currentCard == 5)
                uriSource = new Uri(@"WileECoyote.jpg", UriKind.Relative);
            else if (currentCard == 6)
                uriSource = new Uri(@"roadrunner.gif", UriKind.Relative);

            //put ht emew image source into currentImage that was clicked
            currentImage.Source = new BitmapImage(uriSource);

            //check to see if 2 cards have been selected 
            if (numSelectedCards == 2)
            {
                //pause the application
                System.Threading.Thread.Sleep(100);
                WpfApplication.DoEvents();
                System.Threading.Thread.Sleep(100);
                WpfApplication.DoEvents();
                System.Threading.Thread.Sleep(1200);
                WpfApplication.DoEvents();

                if (firstSelectedCard == currentCard)
                {
                    //correct choice, first and second choices match, remove them from the screen
                    currentBorder.Visibility = Visibility.Hidden;
                    firstSelectedBorder.Visibility = Visibility.Hidden;

                    totalNumMatchesRemoved++;
                    displayMatches();

                    if (totalNumMatchesRemoved == 6)
                    {
                        //show congrats
                        lblCongrats.Visibility = Visibility.Visible;
                        btnPlayAgain.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    mistakes++;
                    lblMistakes.Content = mistakes.ToString();

                    uriSource = new Uri(@"cardBack.jpg", UriKind.Relative);

                    pictureBox1.Source = new BitmapImage(uriSource);
                    pictureBox2.Source = new BitmapImage(uriSource);
                    pictureBox3.Source = new BitmapImage(uriSource);
                    pictureBox4.Source = new BitmapImage(uriSource);
                    pictureBox5.Source = new BitmapImage(uriSource);
                    pictureBox6.Source = new BitmapImage(uriSource);
                    pictureBox7.Source = new BitmapImage(uriSource);
                    pictureBox8.Source = new BitmapImage(uriSource);
                    pictureBox9.Source = new BitmapImage(uriSource);
                    pictureBox10.Source = new BitmapImage(uriSource);
                    pictureBox11.Source = new BitmapImage(uriSource);
                    pictureBox12.Source = new BitmapImage(uriSource);
                } //end firstSelectedCard if

                //reset the number of selected cards to 0 because
                //we either just turend them all over or removed them

                numSelectedCards = 0;
                firstSelectedCard = 0;
                firstSelectedBorder = new Border();
                firstSelectedImage = new Image();

            }//end if statement
            else if (firstSelectedCard == 0)
            {
                firstSelectedCard = currentCard;
                firstSelectedImage = currentImage;
                firstSelectedBorder = currentBorder;
            }



        }

    }

}
