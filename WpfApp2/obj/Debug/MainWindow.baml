   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Przepisy v1.0 - Stable��5   	   $	��655��6(   $	��802��65    � 
ResizeMode$ NoResize=�6A   
�������.��5	      � 
�������$	��800��6   $	��600��6-   $��0,-166,1,-140q�6=   $	��800��6T   $	��600��6c   $��Center=�6s   $��Center=�6�   $	��932��6�   $	��795��6�   .+�5   
   �� -   5        $��LoadRecipes��5      $��Załaduj przepisy��6$   $
��Left=�6?   $��56��6Z   $��	49,32,0,0q�6f   $	��Top=�6y   $	��191��6�   6�   �� 5   
   -   5        $��listView��5      $y�Visible=�6#   $��49,103,49,0q�6a   $	��481��6�   $	��Top=�6�   ��68   �� *SourceCollection+ �� View 5      �� 5      .P�5      �� $��Nazwa��6%    �� Width$	 100��6b    �� DisplayMemberBinding 64   ��  �� Path$ Nazwa�6b   �� 5      $��Przepis��6%   $	 250��6f    66   �� $ Przepis�6f   �� 5      $
��Data��6%   $	 100��6`    63   �� $
 Data�6`   5      5      �� 5   
   -   5        $��	AddRecipe��5      $��Dodaj Przepis��6"   $
��Left=�6:   $��56��6U   $��
560,32,0,0q�6a   $	��Top=�6u   $	��191��6�   6�   5      5      