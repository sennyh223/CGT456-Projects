using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace SlidingPuzzle
{
    public partial class MainWindow : Window
    {
        private List<Image> _images = new List<Image>();
        private int _actionCount = 0; // Counts number of actions user takes when playing game.

        public MainWindow()
        {
            InitializeComponent();
            LoadImages();
            ShuffleImages();
            btnPlayAgain.Visibility = Visibility.Hidden;
        }
        private void LoadImages()
        {
            // Clear the image list to prevent duplicate images when game resets.
            _images.Clear();
            for (int i = 0; i < 9; i++)
            {
                var image = new Image
                {
                    Tag = i
                };
                if (i < 8) // Load images for the first 8 tiles so that there is an empty tile for gameplay.
                {
                    image.Source = new BitmapImage(new Uri($"image_part_{i}.jpg", UriKind.Relative));
                }
                image.MouseLeftButtonUp += Image_Click;
                _images.Add(image);
            }
        }

        private void Image_Click(object sender, MouseButtonEventArgs e)
        {
            var clickedImage = (Image)sender;
            if ((int)clickedImage.Tag == 8) // If empty tile is double clicked do nothing.
            {
                return;
            }

            var emptyImage = _images.First(img => (int)img.Tag == 8); // Find the empty tile

            
            // Check if the clicked image is adjacent to the empty tile
            int clickedIndex = _images.IndexOf(clickedImage);
            int emptyIndex = _images.IndexOf(emptyImage);
            int rowDiff = Math.Abs(clickedIndex / 3 - emptyIndex / 3);
            int colDiff = Math.Abs(clickedIndex % 3 - emptyIndex % 3);

            if ((rowDiff == 1 && colDiff == 0) || (rowDiff == 0 && colDiff == 1))
            {
                // Swap the clicked image and the empty tile
                _images[clickedIndex] = emptyImage;
                _images[emptyIndex] = clickedImage;

                // Update the Grid
                PuzzleGrid.Items.Clear();
                foreach (var image in _images)
                {
                    PuzzleGrid.Items.Add(image);
                }

                // Increase action count
                _actionCount++;
                ActionCountLabel.Content = _actionCount.ToString();

                // Check if the puzzle is solved
                if (IsPuzzleSolved())
                {
                    // If the puzzle is solved, show the complete image and a play again button
                    ShowCompleteImage();
                    ShowPlayAgainButton();
                }
            }
        }

        private void ShuffleImages()
        {
            var random = new Random();
            for (int i = 0; i < _images.Count; i++)
            {
                int j = random.Next(i, _images.Count);
                var temp = _images[i];
                _images[i] = _images[j];
                _images[j] = temp;
            }

            // Check the number of inversions
            int inversions = 0;
            for (int i = 0; i < _images.Count; i++)
            {
                for (int j = i + 1; j < _images.Count; j++)
                {
                    int tagI = (int)_images[i].Tag;
                    int tagJ = (int)_images[j].Tag;
                    if (tagI != 8 && tagJ != 8 && tagI > tagJ)
                    {
                        inversions++;
                    }
                }
            }

            // If the number of inversions is odd, swap two tiles to make it even (prevents impossible games)
            if (inversions % 2 != 0)
            {
                var temp = _images[0];
                _images[0] = _images[1];
                _images[1] = temp;
            }

            foreach (var image in _images)
            {
                PuzzleGrid.Items.Add(image);
            }
        }

        // Checks to see if all images are in correct order (puzzle is finished)
        private bool IsPuzzleSolved() 
        {
            for (int i = 0; i < _images.Count; i++)
            {
                if ((int)_images[i].Tag != i)
                {
                    return false;
                }
            }
            return true;
        }
       
        private void ShowCompleteImage()
        {
            var emptyImage = _images.First(img => (int)img.Tag == 8); // Find the empty tile
            emptyImage.Source = new BitmapImage(new Uri("image_part_8.jpg", UriKind.Relative)); // Change the source to 9th image piece to show full image
        }

        private void ShowPlayAgainButton()
        {
            // Display winning message
            MessageBox.Show($"You Win! Total Actions: {_actionCount}", "Congratulations!", MessageBoxButton.OK);
            btnPlayAgain.Visibility = Visibility.Visible;
        }

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            // Resets the game
            PlayAgain();
        }

        private void PlayAgain()
        {
            // Reset the action count
            _actionCount = 0;
            ActionCountLabel.Content = _actionCount.ToString();

            // Clear the puzzle grid
            PuzzleGrid.Items.Clear();

            // Reload and shuffle the images
            LoadImages();
            ShuffleImages();
            btnPlayAgain.Visibility = Visibility.Hidden;
        }

        private void ReshuffleButton_Click(object sender, RoutedEventArgs e)
        {
            // Resets the game without winning
            // Functions the same as playing again.
            PlayAgain();
            btnPlayAgain.Visibility = Visibility.Hidden;
        }


    }

}
