   M S B A M L   `   `   `  ����F  BEcomDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EcomDesktopEcomDesktop  5          EcomDesktop.AddProduct   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:EcomDesktop     5        N� Title$  
AddProduct��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      �� $��0��6   $��0��6!   $��Product name:��61   �� 5   
   -   5         ��Name$ productNameTextBox��5   /   $��0��6   $��1��6   6/   �� 5    
   $��1��6   $��0��6   $��Product price:��6-   �� 5!   
   -   5        $ productPriceTextBox��5!   /   $��1��6   $��1��6   6/   �� 5#   
   $��2��6   $��0��6   $��Product quantity:��6-   �� 5$   
   -   5        $ productQuantityTextBox��5$   /   $��2��6   $��1��6   6/   �� 5&   
   $��3��6   $��0��6   $��Product supplier:��6-   �� 5'   
   -   5        $ productSupplierTextBox��5'   /   $��3��6   $��1��6   6/   �� 5)   
   $��4��6   $��0��6   $��Product category:��6-   �� 5*   
   -   5        $ productCategoryTextBox��5*   /   $��4��6   $��1��6   6/   �� 5,   
   -   5         ��Name$ addProductButton��5,   D   $��5��6   $��1��6   $��Add Product��6.   6^   �� 5-   
   -   5        $ cancelButton��5-   ?   $��6��6   $��1��6   $��Cancel��6.   6U   5/      50      