   M S B A M L   `   `   `  ����G  CTemplateDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TemplateDemoTemplateDemo  5   	   +    %TemplateDemo.HierarchicalTemplateDemo   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TemplateDemo     5   	     � Title$  HierarchicalTemplateDemo��5   	   $	��450��6*   $	��800��67    � 	Resources 5	         ds � Source � XPath �� DataType �� ItemsSource �� XPath 	� 	GroupName  ds2 �� Orientation��%b  &	        (�� 8     5   #   *Grade+)(�� �     5   #   *Class+)(�� *    5   #   *Group+)&	 �    (�� �    5   #   *	Operation+)� 5
   
   $ Data.xml?�6%   $ 
Data/Grade��67   �� 5   
   $ Grade��6#    64   �� $ Class��.R�5      �� ��6   �� $ @Name��67   5      �� 5   
   $ Class��6#    64   �� $ Group��.R�5      	� $ gn��6:   ��6   �� $ @Name��6K   5      �� 5   
   $ Group��6#    64   �� $ Student��.R�5      �� ��6   �� $ @Name��69   5      � 5   
   $ Data.xml?�6&   $ Data/Operation��68   �� 5   
   $ 	Operation��6#    68   �� $ 	Operation��.R�5      �� $ 
Horizontal=�6   .+�5      �� $	��0,5q�69   ��6   �� $ @Name��6H   �� 5      $	��0,5q�6<   ��6   �� $ @Gesture��6K   5      5      5      .��5      � .+�5   
   R� -   5        	 R�Name$	 tv��5      $��5q�6   ��6*   �� 
 �� Source#
 [ 6`   5      5      