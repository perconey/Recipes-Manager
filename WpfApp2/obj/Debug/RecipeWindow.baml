   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.RecipeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Przepis��5   	   $	��400��6   $��573.931��6&   $	��400��66   $	��396��6E    � 
ResizeMode$ NoResize=�6U   .��5	      � .+�5
   
   �� -   5         ��Name$ recipeNameTextBlock��5
       �� Padding$ 5q�61   $
��Left=�6=   $��41��6X   $��	10,10,0,0q�6d   $
��Wrap=�6w   $	��Top=�6�   $	��374��6�   $��20(�6�    �� TextAlignment$ Center=�6�   ���	#FFECE7E7��6�   Z� 6�   �� 5   
   -   5        $  recipeDescriptionTextBlock��5      $
��Left=�68   $	��275��6S   $��	10,56,0,0q�6`   $
��Wrap=�6s   $	��Top=�6�   $	��374��6�   ���	#FFF0ECEC6�   �� 5   
   -   5        $ recipeDateTextBlock��5      $
��Left=�61   $��16��6L   $��
11,339,0,0q�6X   $
��Wrap=�6l   $	��Top=�6�   $	��373��6�   ���	#FFD4D2D26�   �� 5   
   -   5        $��ingredientsListView��5      $y�Visible=�6.   $��397,10,10,0q�6l   $	��345��6�   $	��Top=�6�   ��6C   �� *SourceCollection+ �� View 5      �� 5      .P�5      ��  �� Width$ 80��6%   $��Nazwa��60    �� DisplayMemberBinding 6?   ��  �� Path$ Iname��� 5      $ 34��6%   $��Ilosc��60    6?   �� $ Iamount��� 5      $ 35��6%   $
��Jedn��60    6>   �� $ Iunit�5      5       5&      5'      