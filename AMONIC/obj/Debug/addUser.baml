   M S B A M L   `   `   `  ����A  =AMONIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AMONICAMONIC  5   	       AMONIC.addUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AMONIC     5   	     � Title$  Add User��5   	   $	��450��6   $	��600��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   .+�5      �� $��Email Address��6   $��Right=�6,   $��10 50 10 10q�6H   $	��100��6]   �� 5      $��
First Name��6   $��Right=�6)   $��10q�6E   $	��100��6Q   �� 5      $��	Last Name��6   $��Right=�6(   $��10q�6D   $	��100��6P   �� 5      $��Office��6   $��Right=�6%   $��10q�6A   $	��100��6M   �� 5      $��	BirthDate��6   $��Right=�6(   $��10q�6D   $	��100��6P   �� 5      $��Password��6   $��Right=�6'   $��10q�6C   $	��100��6O   5      �� 5   
   $��1��6   .+�5      �� -   5         ��Name$ txtEmail��5      $	��300��6(   $��10 55 10 10q�64   $
��Left=�6I   �� 5      -   5        $ txtFName��5      $	��300��6(   $��10 15 10 10q�64   $
��Left=�6I   �� 5      -   5        $ txtLName��5      $	��300��6(   $��10 15 10 10q�64   $
��Left=�6I   �� 5      -   5         ��Name$ cbOffice��5      $	��300��6)   $��10 15 10 10q�65   $
��Left=�6J   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpBirth��5      $	��300��6*   $��10 15 10 10q�66   $
��Left=�6K   �� 5      -   5        $ txtPassword��5      $	��300��6+   $��10 15 10 10q�67   $
��Left=�6L   5      �� 5   
   $��2��6   $��10 350 10 10q�6)    �� Orientation$ 
Horizontal=�6?   .+�5      �� -   5         ��Name$ btnSave��5      $
��Save��6&   $	��150��65   $��30��6A   $��100 10 10 10q�6c   �� 5       $��Cancel��6   $	��150��6&   $��30��62   $��20 10q�6>   5!      5#      5$      