   M S B A M L   `   `   `  ����F  BMemoryMatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MemoryMatchMemoryMatch  5   	       MemoryMatch.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MemoryMatch     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��900��6)   .��5	      � .+�5   
   �� $��Center=�6   $��Center=�6-   $	��900��6H   $	��650��6T   $
��Fill=�6a   $��background.jpg��5      �� 5   
   -   5         ��Name$ lblTitle��5      $��80��6"   $	��505��6.   $��60(�6:   $��MV Boli)�6H   $��0��6]   
���""��
������ $��	196,9,0,0q�5   $   $
��Left=�67   $	��Top=�6R   $��Memory Match��6j   �� 5   
   -   5        $ lblCongrats��5      $��63��6%   $	��306��61   $��40(�6=   $��Microsoft Sans Serif)�6K   $��13��6m   
���""��
������ $��293,212,0,0q�5   $   $
��Left=�69   $	��Top=�6T   $��Congratulations��6l   �� 5   
   -   5         ��Name$ btnPlayAgain��5      $��40��6'   $	��140��63   $��14��6?   $��374,0,0,248q�6M   $
��Left=�6b   $��Bottom=�6}   $��
Play Again��5      $��16(�6!   $��	Helvetica)�6/   6F   �� 5   
   -   5         ��Name$ 	pbBorder1��5      
���   �$
��Left=�68   $	��Top=�6S   $��127,108,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�5      
������ ._�5      �� -   5         ��Name$ pictureBox1��5      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�5      $��cardback.jpg��6   64   5      �� 5   
   -   5        $ 	pbBorder2��5      
���   �$
��Left=�68   $	��Top=�6S   $��304,108,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�5      
������ ._�5      �� -   5        $ pictureBox2��5      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�5      $��cardback.jpg��6   64   5       �� 5!   
   -   5        $ 	pbBorder3��5!      
���   �$
��Left=�68   $	��Top=�6S   $��487,108,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�5"      
������ ._�5#      �� -	   5        $ pictureBox3��5#      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�5$      $��cardback.jpg��6   64   5%      �� 5&   
   -
   5        $ 	pbBorder4��5&      
���   �$
��Left=�68   $	��Top=�6S   $��674,108,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�5'      
������ ._�5(      �� -   5        $ pictureBox4��5(      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�5)      $��cardback.jpg��6   64   5*      �� 5,   
   -   5        $ 	pbBorder5��5,      
���   �$
��Left=�68   $	��Top=�6S   $��127,268,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�5-      
������ ._�5.      �� -   5        $ pictureBox5��5.      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�5/      $��cardback.jpg��6   64   50      �� 51   
   -   5        $ 	pbBorder6��51      
���   �$
��Left=�68   $	��Top=�6S   $��304,268,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�52      
������ ._�53      �� -   5        $ pictureBox6��53      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�54      $��cardback.jpg��6   64   55      �� 56   
   -   5        $ 	pbBorder7��56      
���   �$
��Left=�68   $	��Top=�6S   $��487,268,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�57      
������ ._�58      �� -   5        $ pictureBox7��58      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�59      $��cardback.jpg��6   64   5:      �� 5;   
   -   5        $ 	pbBorder8��5;      
���   �$
��Left=�68   $	��Top=�6S   $��674,268,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�5<      
������ ._�5=      �� -   5        $ pictureBox8��5=      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�5>      $��cardback.jpg��6   64   5?      �� 5A   
   -   5        $ 	pbBorder9��5A      
���   �$
��Left=�68   $	��Top=�6S   $��127,439,0,0q�6k   $	��100��6�   $	��100��6�   $��1q�5B      
������ ._�5C      �� -   5        $ pictureBox9��5C      $	��100��6)   $	��100��66   $
��Left=�6B   $	��Top=�6]   $
��Fill=�5D      $��cardback.jpg��6   64   5E      �� 5F   
   -   5        $ 
pbBorder10��5F      
���   �$
��Left=�69   $	��Top=�6T   $��304,439,0,0q�6l   $	��100��6�   $	��100��6�   $��1q�5G      
������ ._�5H      �� -   5        $ pictureBox10��5H      $	��100��6*   $	��100��67   $
��Left=�6C   $	��Top=�6^   $
��Fill=�5I      $��cardback.jpg��6   64   5J      �� 5K   
   -   5        $ 
pbBorder11��5K      
���   �$
��Left=�69   $	��Top=�6T   $��487,439,0,0q�6l   $	��100��6�   $	��100��6�   $��1q�5L      
������ ._�5M      �� -   5        $ pictureBox11��5M      $	��100��6*   $	��100��67   $
��Left=�6C   $	��Top=�6^   $
��Fill=�5N      $��cardback.jpg��6   64   5O      �� 5P   
   -   5        $ 
pbBorder12��5P      
���   �$
��Left=�69   $	��Top=�6T   $��674,439,0,0q�6l   $	��100��6�   $	��100��6�   $��1q�5Q      
������ ._�5R      �� -   5        $ pictureBox12��5R      $	��100��6*   $	��100��67   $
��Left=�6C   $	��Top=�6^   $
��Fill=�5S      $��cardback.jpg��6   64   5T      �� 5Z   
   $��Right=�6   $��Bottom=�6,   $��0,0,5,42q�6G   $��Italic$�6Y   $��Created by:��6l   �� 5[   
   $��Right=�6   $��Bottom=�6,   $��0,0,4,31q�6G   $��Italic$�6Y   $��Senny Huang��6l   �� 5\   
   $��Right=�6   $��Bottom=�6,   $��0,0,5,15q�6G   $��Italic$�6Y   $ ��Web Dev and Design Student��6l   �� 5]   
   $��Right=�6   $��Bottom=�6,   $��0,0,4,1q�6G   $��Italic$�6X   $��Purdue 2024��6k   �� 5b   
   -   5        $ pbMatch1��5b      $��30��6"   $��25��6.   $
��left=�69   $	��top=�6T   $��
700,30,0,0q�6l   $��CardPair_sm.png��5c      �� 5d   
   -   5        $ pbMatch2��5d      $��30��6"   $��25��6.   $
��left=�69   $	��top=�6T   $��
730,30,0,0q�6l   $��CardPair_sm.png��5e      �� 5f   
   -   5        $ pbMatch3��5f      $��30��6"   $��25��6.   $
��left=�69   $	��top=�6T   $��
760,30,0,0q�6l   $��CardPair_sm.png��5g      �� 5h   
   -   5        $ pbMatch4��5h      $��30��6"   $��25��6.   $
��left=�69   $	��top=�6T   $��
790,30,0,0q�6l   $��CardPair_sm.png��5i      �� 5j   
   -    5        $ pbMatch5��5j      $��30��6"   $��25��6.   $
��left=�69   $	��top=�6T   $��
820,30,0,0q�6l   $��CardPair_sm.png��5k      �� 5l   
   -!   5        $ pbMatch6��5l      $��30��6"   $��25��6.   $
��left=�69   $	��top=�6T   $��
850,30,0,0q�6l   $��CardPair_sm.png��5m      �� 5p   
   $
��Left=�6   $	��Top=�6+   $��	50,30,0,0q�6C   $��Italic$�6V   $��Wrong Attempts: ��6i   �� 5q   
   -"   5        $ lblMistakes��5q      $
��Left=�6%   $	��Top=�6@   $��
145,30,0,0q�6X   $��x��6l   $��Italic$�6x   5r      5s      