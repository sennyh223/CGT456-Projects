   M S B A M L   `   `   `  ����  Project2Game    SlidingPuzzle.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��475��6   $	��450��6)   .��5      � -   5         �Name$ MainGrid��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   �� -   5         ��Name$ TitleTextBox��5      $��Sliding Puzzle��6(   $��Center=�6>   $��24(�6[   $��38��6�   $��Center=�6�   $��Arial Black)�6�   ��6i   Z� 6�   �� 5   
   -   5         ��Name$ 
PuzzleGrid��5      $	��300��6+   $��1��68   $��
66,29,66,0q�6E   $	��Top=�6Y   ��5      �� 5      .R�5      A�  A� Rows$ 3��6"    A� Columns$ 3��6+   5      5      �� 5   
   $��	Actions: ��6   $
��Left=�6$   $��Center=�6?   $��24,0,0,0q�6Z   $��Italic$�6l   �� 5   
   -   5         ��Name$ ActionCountLabel��5      $��0��6*   $
��Left=�66   $��Center=�6Q   $��79,0,0,0q�6l   $��Italic$�6~    J� RenderTransformOrigin$ 2.489,0.617&�6�   �� 5   
   -   5        	 ��Name$	 ReshuffleButton��5      $��	Reshuffle��6*   $
��Left=�6\   $��	355,0,0,0q�6w   $��20��6�   $��Center=�6�   $��74��6�   �� 5   
   -   5        $	 btnPlayAgain��5      $��14��6'   $��155,352,155,25q�65   $��
Play Again��5      $��16(�6!   $��Arial)�6/   $��1��6]   ��5   
   �� 5      
 �� ImageSource$
 background.jpg��6   5!      5&      