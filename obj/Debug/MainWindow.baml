   M S B A M L   `   `   `  ����?  ;crud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:crudcrud  5   	       crud.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:crud     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��	0,0,0,-16q�6   .+�5
   
   �� $��C# CRUD WPF OPERATIONS��6   $
��Left=�61   $��
140,55,0,0q�6L   $	��Top=�6`   �� 5   
   $
��Name��6   $
��Left=�6   $��
24,142,0,0q�6:   $	��Top=�6N   �� 5   
   $	��Age��6   $
��Left=�6   $��
27,173,0,0q�69   $	��Top=�6M   �� 5   
   $��Gender��6   $
��Left=�6!   $��18,0,0,0q�6<   $��Center=�6N   �� 5   
   $
��City��6   $
��Left=�6   $��
27,106,0,0q�6:   $	��Top=�6N   �� 5   
   -   5         ��Name$ city_txt��5      $
��Left=�6$   $��
66,110,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6h   $	��120��6�   �� 5   
   -   5        $ name_txt��5      $
��Left=�6$   $��
66,146,0,0q�6?   $
 Wrap=�6S   $	��Top=�6h   $	��120��6�   �� 5   
   -   5        $ age_txt��5      $
��Left=�6#   $��
66,176,0,0q�6>   $
 Wrap=�6R   $	��Top=�6g   $	��120��6   �� 5   
   -   5        $ 
gender_txt��5      $
��Left=�6&   $��68,0,0,0q�6A   $
 Wrap=�6S   $��Center=�6h   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $��
351,0,0,26q�6P   �� 5   
   -   5         ��Name$ insert��5      $��Insert��6!   $
��Left=�62   $��
10,366,0,0q�6M   $	��Top=�6a   $��58��6y   $��64��6�   �� 5   
   -   5        $ update��5      $��Update��6!   $
��Left=�62   $��
94,366,0,0q�6M   $	��Top=�6a   $��58��6y   $��64��6�   6�   �� 5   
   -   5        $ delete��5      $��Delete��6!   $
��Left=�62   $��174,366,0,0q�6M   $	��Top=�6b   $��58��6z   $��64��6�   6�   �� 5   
   -	   5        $ clear��5      $��
Clear Data��6    $
��Left=�65   $��256,366,0,0q�6P   $	��Top=�6e   $��58��6}   $��64��6�   �� 5   
   -
   5        $ searchId��5      $
��Left=�6$   $��
94,343,0,0q�6?   $
 Wrap=�6S   $	��Top=�6h   $	��144��6�   �� 5   
   $��ID��6   $
��Left=�6   $��
94,312,0,0q�68   $	��Top=�6L   5      5      