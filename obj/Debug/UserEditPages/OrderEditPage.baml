   M S B A M L   `   `   `  ����@  <Sport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Sport.UserEditPagesSport.UserEditPages  5      '    !Sport.UserEditPages.OrderEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Sport.UserEditPages     5        N� Title$  OrderEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��210 �6    � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   .+�5   
   �� $��0��6   $��0��6!   $��Center=�61   $��Right=�6L   $��Клиент��6h   �� 5   
   $��1��6   $��0��6!   $��Center=�61   $��Right=�6L   $��
Товар��6h   �� 5   
   $��2��6   $��0��6!   $��Center=�61   $��Right=�6L   $��Кол-во��6h   �� 5   
   $��3��6   $��0��6!   $��Center=�61   $��Right=�6L   $��
Сумма��6h   �� 5   
   -   5         ��Name$ ClientTB��5   1   $��0��6   $��1��6!   $��Center=�6`   $��Center=�6{   $	��200��6�   ��6C   �� *Client.Name+6�   �� 5   
   -   5         ��Name$ 	ProductCB��5   0   $��1��6   $��1��6    6D   �� 5   
   -   5         ��Name$ Count��5   /   $��2��6   $��1��6   ��6>   �� *Count+6U   �� 5   
   -   5        $	 Sum��5   1   $��3��6   $��1��6!   $��Center=�6S   $��Center=�6n   ��6>   �� *Sum+6n   �� 5!   
   $��4��6   $��2��6"   $��Center=�66    �� Orientation$ 
Horizontal=�6S   .+�5"      �� -   5        $��4��5"      $��2��6"   $��Вернуться��6I   $	��100��6]   $��5q�6i   �� 5#      -   5        $��4��5#      $��2��6"   $��Сохранить��6I   $	��100��6]   5$      5%      5&      