   M S B A M L   `   `   `  ����A  =AMONIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AMONICAMONIC  5   	       AMONIC.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AMONIC     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Login��5	   	   $	��450��6   $	��800��6$   .��5
      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� -   5        $
��logo��5      $	��200��6    $	��500��6-   5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��UserName��6   $��30��6(   $��50 20 20 20q�64   �� 5      -   5         ��Name$ txtUsername��5      $��30��6+   $	��600��67   $��15q�6C   6Q   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   .+�5      �� $��PassWord��6   $��30��6(   $��50 20 20 20q�64   �� 5      -   5        $ txtPassword��5      $��30��6+   $	��600��67   $��15q�6C   6Q   5      �� 5   
   $��3��6   $ 
Horizontal=�6"   .+�5      �� -   5        $��Login��5      $��25��6:   $	��250��6F   $��170 10 10 10q�6R   �� 5      -   5         ��Name$
 exit��5      $
��Exit��6#   $��25��62   $	��250��6>   $��10q�6J   6V   5      5"      5#      