   M S B A M L   `   `   `  ����A  =AMONIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AMONICAMONIC  5   	       AMONIC.EditRole   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AMONIC     5   	     � Title$  EditRole��5   	   $	��450��6   $	��800��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   .+�5      �� $��Email Address��6   $��Right=�6,   $��10 50 10 10q�6H   $	��100��6]   �� 5      $��
First Name��6   $��Right=�6)   $��10q�6E   $	��100��6Q   �� 5      $��	Last Name��6   $��Right=�6(   $��10q�6D   $	��100��6P   �� 5      $��Office��6   $��Right=�6%   $��10q�6A   $	��100��6M   �� 5      $
��Role��6   $��Right=�6#   $��10q�6?   $	��100��6K   5      �� 5   
   $��1��6   .+�5      �� -   5         ��Name$ txtEmail��5   R   $	��300��6   $��10 55 10 10q�6"   $
��Left=�67   6R   �� 5      -   5        $ txtfName��5   R   $	��300��6   $��10 15 10 10q�6"   $
��Left=�67   6R   �� 5      -   5        $ txtlName��5   R   $	��300��6   $��10 15 10 10q�6"   $
��Left=�67   6R   �� 5      -   5         ��Name$ cbOffice��5   S   $	��300��6   $��10 15 10 10q�6#   $
��Left=�68   6S   	� 5      -   5         	�Name$ rbUser��5   K   $��10 15 10 10q�6   $
��Left=�60   .��6[   User6a   	� 5      -   5        $ rbAdmin��5   J   $��
10 5 10 10q�6   $
��Left=�6/   .��6[   Admin6b   5      �� 5   
   $��2��6   $��0��6)   $��10 300 10 10q�69    �� Orientation$ 
Horizontal=�6O   .+�5       �� -   5         ��Name$ Apply��5    %   $��Apply��6   $	��150��64   $��30��6@   $��200 10 10 40q�6L   6b   �� 5!      $��Cancel��6   $	��150��6&   $��30��62   $��20 10 10 40q�6>   5"      5$      5%      