   M S B A M L   `   `   `  ����	  Sport!    Sport.AdminPages.OrdersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  
OrdersPage��5      .��5	      �  � RowDefinitions 5
   
   �� 5      $
��320* �6   �� 5      $��35 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGOrders��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Клиент��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Client.Name+6U     5      $ 
Товар��6%   $
 200* 6W    64   �� *Equipment.Name+6W     5      $ Кол-во��6%   $ 50 6O    65   �� *Count+6O     5      $ 
Сумма��6%   $	 100 6L    64   �� *Sum+6L   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 200 6)   	   CellTemplate	 5      �� 5      .R�5      �� -   5        $ ��Редактировать��5   %   6=   5      5      5      �� 5   
   $��1��6   $��Right=�6"   
 �� Orientation$
 
Horizontal=�6>   .+�5      �� -   5         ��Name$ 	AddClient��5   (   $��Добавить��6   $��5q�6S   $��80��6^   �� 5      -   5        $ RemoveClient��5   '   $��Удалить��6   $��80��6X   5       �� 5!   
   -   5        $��Вернуться��5!      $��1��6%   62   5"      5#      