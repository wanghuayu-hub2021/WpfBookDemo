   M S B A M L   `   `   `  ����I  EBindingSysDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BindingSysDemoBindingSysDemo  5   	   ,    &BindingSysDemo.HierarchicalDataTplDemo   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BindingSysDemo     5   	     � Title$  HierarchicalDataTplDemo��5   	   $	��400��6)   $	��400��66    � 	Resources 5	         xdp � XPath��%J  &	        � 5
   
   $ FileSystem/Forder��6&   .��5      ��<FileSystem xmlns="">
                    <Forder Name="Books">
                        <Forder Name="Programming">
                            <Forder Name="Windows">
                                <Forder Name="WPF"></Forder>
                                <Forder Name="MFC"></Forder>
                                <Forder Name="Dephi"></Forder>
                            </Forder>
                        </Forder>
                        <Forder Name="Tools">
                            <Forder Name="Developmentg"></Forder>
                            <Forder Name="Designment"></Forder>
                            <Forder Name="Players"></Forder>
                        </Forder>
                    </Forder>
                </FileSystem>        5      5      .��5      � .+�5    
   R� ��6   ��  �� Source# [  ��5!      �� 5"       �� ItemsSource 6+   ��  �� XPath$ Forder��.R�5#      �� ��6    �� $ @Name��6?   5$      5&      5'      5(      