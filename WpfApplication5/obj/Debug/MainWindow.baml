   M S B A M L   `   `   `  ����M  IFluent, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546f/$clr-namespace:Fluent;assembly=FluentFluent  5   	    WpfApplication5    WpfApplication5.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7Fluent$clr-namespace:Fluent;assembly=Fluent     5   	     � Title$  
MainWindow��5   	   $��725.435��6   $��1313.925��6-   .��5      � $��0,0,184,218q�6    � ColumnDefinitions 5   
   �� 5	      $	��37* �6   �� 5
      $
��652* �6   �� 5      $
��618* �6    � RowDefinitions 5   
   �� 5      $��1277* �6   �� 5      $	��24* �6   �� 5      $
��318* �6   .+�5   
      Fluent.Ribbon  $	��141��6   $��3��6%   $��
10,10,50,0q�69      Menu 5         Fluent.Backstage  5         Content. 5          Fluent.BackstageTabControl  .@�5         Fluent.BackstageTabItem  -   5           Header$ Закрыть��5   2   6C   5      5         Tabs. 5         Fluent.RibbonTabItem     Header$# Главная вкладка��6#      Groups. 5          Fluent.RibbonGroupBox  	   Header$	 Буфер обмена��6)   $��84��6?   $	��232��6K   .@�5!         Fluent.Button  
   Header$
 Вставить��6%   $��Paste��67   $��74��6G   $��56��6S     5"      $
 Вырезать��6$   $	��Cut��66     5#      $
 Копировать��6$   $
��Copy��68   5$      5&        5'      $ Список тегов��6#   . 5(        .@�5)         Fluent.ComboBox  -   5          Name$
 Tags��5)   &    �� 
IsEditable .  $	��200��6G    �� 
IsReadOnly . 6f   5*      5+      5,      &	   System.Windows.Controls.DataGrid	  5-   
   -   5         	 Name$ Table1��5-       	  AutoGenerateColumns .  $��10,60,-183.712,-221q�6h   $��3��6�   $��3��6�    � DataContext 6?   ��  �� Source$ 	dataTable�� 	  Columns 5.      0
  *System.Windows.Controls.DataGridTextColumn
  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ ГОСТ��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ��  �� Path$ X�
  50      $ НАЗВАНИЕ��6%   $ 1* 67    6B   �� $ K�
  51      $ ГОД��6%   $ 80 62    6=   �� $ A�53      (  "System.Windows.Controls.WebBrowser  54   
   -   5          Name$	 wrt��54      $��Stretch=�6#   $��10,316,-183.712,-207q�6A   $��Stretch=�6_   $��3��6{   $��3��6�   55      56      