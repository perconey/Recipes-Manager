   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.AddRecipeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Dodaj Przepis��5   	   $	��433��6   $	��612��6,    � 
ResizeMode$ NoResize=�68   .��5	      � .+�5
   
   �� -   5         ��Name$ 
recipeName��5
      $
��Left=�6(   $��18��6C   $��	10,10,0,0q�6O   $
��Wrap=�6b   $��Nazwa przepisu:��6v   $	��Top=�6�   $��89��6�   �� 5   
   -   5         ��Name$ recipeNameTextField��5      $
��Left=�6/   $��18��6J   $��
104,10,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��480��6�   �� 5   
   -   5        $ recipeDescTextField��5      $
��Left=�6/   $	��287��6J   $��	10,58,0,0q�6W   $
 Wrap=�6j   $	��Top=�6~   $	��574��6�   �� 5   
   -   5         ��Name$ button��5      $��Dodaj��6!   $
��Left=�61   $��31��6L   $��
10,350,0,0q�6X   $	��Top=�6l   $	��574��6�   6�   �� 5   
   -   5        $ ingredientNameTextField��5      $
��Left=�63   $��20��6N   $��	60,33,0,0q�6Z   $
 Wrap=�6m   $	��Top=�6�   $	��189��6�   �� 5   
   -   5        $ ingredientAmountTextField��5      $
��Left=�65   $��20��6P   $��
308,33,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $��70��6�   �� 5   
   -   5        $ ingredientUnitTextField��5      $
��Left=�63   $��20��6N   $��
443,33,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $��29��6�   �� 5   
   -   5        $! addIngredientToRecipeButton��5      $��Dodaj składnik��66   $
��Left=�6O   $��20��6j   $��
500,33,0,0q�6v   $	��Top=�6�   $��84��6�   6�   �� 5   
   -	   5        $ 	textBlock��5      $
��Left=�6'   $��21��6B   $��	10,34,0,0q�6N   $
��Wrap=�6a   $��
Składnik:��6u   $	��Top=�6�   $��49��6�   �� 5   
   -
   5        $ 
textBlock1��5      $
��Left=�6(   $��19��6C   $��
277,34,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $��49��6�   �� 6�   $�Il��6�   �� 6�   $�ość:��6�   6�   �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��19��6C   $��
386,34,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $��60��6�   �� 6�   $�	Jednostka��6�   �� 6�   $�:��6�   6�   5      5      