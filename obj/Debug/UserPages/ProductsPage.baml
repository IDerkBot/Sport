   M S B A M L   `   `   `  ����	  Sport"    Sport.UserPages.ProductsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  ProductsPage��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��320* �6   �� 5      $��35 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGProducts��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+6P     5      $ Кол-во��6%   $ 50 6Q    65   �� *	Storage+6Q     5      $ Цена��6%   $	 100 6M    63   �� *Price+6M   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$
 AddCart��68   -   5        $��Заказать��5   %   $	��100��6_   5      5      5      �� 5   
   -   5        $��Вернуться��5      $��1��6%   62   5      5      