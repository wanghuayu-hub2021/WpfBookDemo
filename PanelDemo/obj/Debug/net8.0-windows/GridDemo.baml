   M S B A M L   `   `   `  ����D  @PanelDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PanelDemo	PanelDemo  5   	       PanelDemo.GridDemo   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PanelDemo     5   	     � Title$  	留言板��5   	   $	��250��6   $	��300��6"   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+   �� 5      $��80 �6   6,   �� 5      $��4 �6   6+   �� 5      $��80 �6   6,    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $��4 �6   6)   �� 5      $��* �6   6)   �� 5      $��4 �6   6)   �� 5      $��25 �6   6*   .+�5   
   �� $%��请选择您的部分并留言:��6   $��0��6'   $��4��64   $��Center=�6H   6e   �� 5   
   $��0��6   $��5��6    
���   �6F   �� 5   
   $��0��6   $��2��6"   $��5��6/   
���   �6Y   �� 5   
   $��2��6   $��4��6!   $��提交��6.   6=   �� 5   
   $��4��6   $��4��6!   $��清除��6.   6=   5      5      