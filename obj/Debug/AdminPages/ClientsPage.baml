   M S B A M L   `   `   `  ����	  Sport"    Sport.AdminPages.ClientsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  ClientsPage��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��320* �6   �� 5      $��35 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGClients��5         AutoGenerateColumns .     
IsReadOnly . $��0��6T      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+6K     5      $ 
Адрес��6%   $	 200 6P    64   �� *	Address+6P     5      $ Телефон��6%   $ 80 6P    66   �� *Phone+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� -   5        $ ��Редактировать��5   %   6=   5      5      5      �� 5   
   $��1��6   $��Right=�6"   
 �� Orientation$
 
Horizontal=�6>   .+�5      �� -   5         ��Name$ 	AddClient��5   (   $��Добавить��6   $��80��6S   $��5q�6^   �� 5      -   5        $ DeleteClient��5   '   $��Удалить��6   $��80��6X   5       �� 5!   
   -   5        $��Вернуться��5!      $��1��6%   62   5"      5#      