   M S B A M L   `   `   `  ����G  CTemplateDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TemplateDemoTemplateDemo  5   	   #    TemplateDemo.DataTemplateView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TemplateDemo     5   	     � Title$  DataTemplateView��5   	   $	��450��6"   $	��800��6/    � 	Resources 5	      /   )TemplateDemo.AutoMaker2PhotoPathConverter   a2p*   $TemplateDemo.Name2PhotoPathConverter  n2p  detailTemplate �� CornerRadius ��Name �� 	Converter �� Orientation ��Name  carListItem��%  &	        &	      &	 &     7  &	 �    7    5
   
   6;     5   
   66   �� 5   
   .R�5      �� 
���   �$��1q�6*   $ 6��6>   ._�5      �� $��5q�6   .+�5      �� $
 img1��6   $	��250��6*   $	��400��67   ��6C   �� *Name+8   6|   �� 5      $ 
Horizontal=�6!   .+�5      �� $��Name:��6$   $��25(�61   $
��Bold"�6?   6S   �� 5      $ tblName��6$   $��25(�65   $
��Bold"�6C   ��6U   �� *Name+6m   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��
AutoMaker:��6$   $��5q�66   6C   �� 5      $ tblAutoMaker��6$   $��5q�6:   ��6E   �� *	AutoMaker+6b   �� 5      $��Year:��6$   $��5q�61   6>   �� 5      $ tblYear��6$   $��5q�65   ��6@   �� *Year+6X   �� 5      $��
TopSpeed::��6$   $��5q�66   6C   �� 5      $ tblTopSpeed��6$   $��5q�69   ��6D   �� *
TopSpeed+6`   5      5      5      5      �� 5   
   .R�5       �� 
���   �$ 6��6)   $��1q�6:   ._�5!      �� $��5q�6   $ 
Horizontal=�6(   .+�5"      �� $��64��6S   $��64��6^   ��6   �� *Name+8   6l   �� 5#      .+�5$      �� ��6$   �� *Name+6<   �� 5%      ��6$   �� *Year+6<   5&      5'      5(      5)      5*      .��5+      �  � ColumnDefinitions 5,   
   �� 5-      $
��200* �6   6.   �� 5.      $
��100* �6   6.   .+�50   
   >� -   5         >�Name$ ucCarDetail��50      $��0��6+   #��[ 6;   ��6n   �� 	 �� ElementName$	 
listBoxCar��
 �� Path$
 SelectedItem�51      �� 52   
   -   5         ��Name$ 
listBoxCar��52      $��1��6&   #��[ 66   6d   53      54      