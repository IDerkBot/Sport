   M S B A M L   `   `   `  ����	  Sport%    Sport.AdminPages.EquipmentsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  EquipmentsPage��5      .��5	      �  � RowDefinitions 5
   
   �� 5      $
��320* �6   �� 5      $��35 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGEquipments��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     5      $ Стоимость��6%   $ 70 6R    68   �� *Price+6R     5      $ На складе��6%   $ 70 6T    68   �� *	Storage+6T   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 200 6)   	   CellTemplate	 5      �� 5      .R�5      �� -   5        $ ��Редактировать��5   %   6=   5      5      5      �� 5   
   $��1��6   
 �� Orientation$
 
Horizontal=�6"   $��Right=�6;   .+�5      �� -   5        $��Добавить��5      $	��100��6(   $��5q�64   6?   �� 5      -   5        $��Удалить��5      $	��100��6'   63   5       �� 5!   
   -   5        $��Вернуться��5!      $��1��6%   62   5"      5#      