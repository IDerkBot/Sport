   M S B A M L   `   `   `  ����	  Sport     Sport.UserPages.OrdersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  
OrdersPage��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��320* �6   �� 5      $��35 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGOrders��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Товар��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Equipment.Name+  5      $ Кол-во��6%   $ 50 65    6@   �� *Count+  5      $ 
Сумма��6%   $ 50 64    6?   �� *Sum+5      �� 5   
   -   5        $��Вернуться��5      $��1��68   �� 5   
   -   5        	 ��Name$	 Alert��5      $
��Left=�6#   $��1��6>   $��Center=�6K   5      5      