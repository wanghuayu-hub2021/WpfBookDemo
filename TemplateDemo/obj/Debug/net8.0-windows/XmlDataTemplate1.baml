   M S B A M L   `   `   `  ����G  CTemplateDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TemplateDemoTemplateDemo  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   #    TemplateDemo.XmlDataTemplate1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TemplateDemo     5   	   @c2clr-namespace:System.Collections;assembly=mscorlib     5   	     � Title$  XmlDataTemplate1��5	   	   $	��450��6"   $	��800��6/    � 	Resources 5
       �� DataType �� Orientation �� XPath   ds � XPath � IsAsynchronous,  &System.Windows.Data.DataSourceProvider   IsInitialLoadEnabled��%|  (��       5      *Unit+)&	      �� 6
   $
 Unit��6   .R�5      � .+�5      �� $ 
Horizontal=�6   .+�5      � .+�5      �� 
��� �����6$   �� $ @Price��6D   �� 5      ��6$   �� $ @Year��5      �� 5      ��6    �� $ @Price��6@   5      5      5      � 5   
   $ 
Units/Unit��6%   $ False��68   $
 True��6O   .��5      ��<Units xmlns="">
                    <Unit Price="80" Year="1998"></Unit>
                    <Unit Price="90" Year="1999"></Unit>
                    <Unit Price="100" Year="2000"></Unit>
                </Units>        5      5      .��5       �� .+�5!   
   �� ��6   ��  �� Source# [  6G   �� 5"   
   ��6   �� # [  6H   5#      5$      