   M S B A M L   `   `   `  ����A  =AMONIC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AMONICAMONIC  5   	       AMONIC.AutomationSystem   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AMONIC     5   	     � Title$&   AMONIC Airline Automation System��5      $	��450��64   $	��800��6A   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $	��10* �6   �� 5      $
��1.5* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      m� -   5        $��Add User��5      6)   m� 5      -   5        $
��Exit��5      6%   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5      �� $��Office��6   $
��15 5q�6%   $��10q�63   �� 5      -   5         ��Name$ cbOffice��5      $	��200��6)   $
��15 5q�65   6C   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgGrid��5      $��2��6   $��10q�6+      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 67   ��5      �� *DataGridItem+5   |   �� 5   
   $��3��6   $ 
Horizontal=�6"   .+�5      �� -   5         ��Name$ 
changeRoll��5   +   $��Change Roll��6   $	��200��6X   $��25��6d   $��20 10q�6p   �� 5      $��Enable/Disable Login��6   $��25��65   $
��0 10q�6A   $	��200��6O   �� 5      -   5        $ manageFlightSchedules��5   5   $��ManageFlightSchedules��6   $��25��6T   $��20 10q�6`   $	��200��6o   6{   5      5       5!      