   M S B A M L   `   `   `  ����G  CRegistration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RegistrationRegistration  5   	       Registration.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Registration     5   	   -   5          � Title$  Database��5   	   $	��400��6   $	��600��6'   .��5
      �  � RowDefinitions 5   
   �� 5      6   �� 5      $
��0.1* �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��0��6%      EnableRowVirtualization$
 True��62   �� 5   
   -   5        $	��Add��5   -   $��Right=�6;   $��	10,5,10,5q�6W   $��1��6j   $��Center=�6w    � Cursor$
 Hand��6�   $��	10,1,10,1q�6�   $
��True��6�   $��85��6�    � UseLayoutRounding$ False��6�   $��20��6  $��0,0,0,0q�6  �� 5   
   -   5        $��Refresh��5   (   $
��Left=�6:   $��	10,5,10,5q�6U   $��1��6h   $��Center=�6u   $
 Hand��6�   $��	10,1,10,1q�6�   $
��True��6�   $��85��6�   $ False��6�   $��20��6�   $��0,0,0,0q�6  �� 5   
   -   5        $��Delete��5   '   $��Center=�68   $��	10,5,10,5q�6U   $��1��6h   $��Center=�6u   $
 Hand��6�   $��	10,1,10,1q�6�   $
��True��6�   $��85��6�   $ False��6�   $��20��6�   $��0,0,0,0q�6  5      5      