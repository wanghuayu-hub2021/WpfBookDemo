   M S B A M L   `   `   `  ����G  CTemplateDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TemplateDemoTemplateDemo  5   	   "    TemplateDemo.ControlTemplate   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TemplateDemo     5   	     � Title$  ControlTemplate��5   	   $	��300��6!   $	��400��6.    � 	Resources 5	         RoundCornerTextBox �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType ��Name �� CornerRadius	 J� SnapsToDevicePixels
 ��Name��%<  &	        �� 5
   
   " ��6>    6+   Z� .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ bd��62   $ 5��6!   $
	 True��6>   #��z��5   !   #��z��5   !   #��z��5   !   ._�5      �� $
 PART_ContentHost��6+   #	 z	 6E   6�   5      5      5      5      5      ��5      �� 5   
    �� 
StartPoint$ 0.5,0&�6    �� EndPoint$ 0.5,1&�61   .��5      �  � Color$ Orange��6    � Offset$ 0Q�6*   67   � 5      $ White��6   $ 1Q�6)   66   5      .��5      �� .+�5    
   �� $	��120��6   $��40��6   #��[  6*   
���   �$��5q�6j   6w   �� 5!   
   $	��120��6   $��40��6   #��[  6*   
���   �$��5q�6j   6w   �� 5"   
   $	��120��6   $��40��6   $��点击一下��6*   $��5q�69   6F   5#      5$      