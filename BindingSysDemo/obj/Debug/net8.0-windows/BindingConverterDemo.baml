   M S B A M L   `   `   `  ����I  EBindingSysDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BindingSysDemoBindingSysDemo  5   	   )    #BindingSysDemo.BindingConverterDemo   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BindingSysDemo     5   	     � Title$  BindingConverterDemo��5   	   $	��500��6&   $	��600��63    � 	Resources 5	      -   'BindingSysDemo.Category2SourceConverter   c2s0   *BindingSysDemo.State2NullableBoolConverter  s2b��%:   &	        &	        5
   
   67     5   
   6:   5      .��5      �� 
�������.+�5   
   �� -   5         ��Name$ listBoxPlane��5      $	��300��6(   $��5q�65   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��40��6    $��20��6+   ��67   ��  �� Path$ Category� �� 	Converter# [  6z   �� 5      $��60��6?   $
��80,0q�6J   ��6$   �� $
 Name�6Z   �� 5       d� IsThreeState$
 True��6#    d� 	IsChecked 67   �� $ State�# [ 6z   5      5      5      �� 5   
   -   5         ��Name$ btnLoad��5      $
��Load��6"   $��25��61   $��5q�6=   6`   �� 5   
   -   5        $ btnSave��5      $
��Save��6"   $��25��61   $��5q�6=   6`   5      5      