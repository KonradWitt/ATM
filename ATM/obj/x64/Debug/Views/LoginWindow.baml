   M S B A M L   `   `   `  ����>  :ATM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ATMATM  5   	       ATM.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:ATM     5   	   -   5        $��18(�5        � Title$  Your ATM��5   	   $	��450��6   $	��400��6'   $��	Helvetica)�5	   	    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   ��  �� CornerRadius$ 20��6   $��3��6#   ��5      �� 5      .��5      �  � Color$ AntiqueWhite��6#   5      5      �� 5   
   $��0��6   .+�5      �� $��/Images/ATM_icon.png��6   $	��120��62   $��0,30,0,0q�6>   5       �� 5"   
   $��1��6    �� Orientation$ Vertical=�6"   .+�5#      �� -   5         ��Name$ TextBox��5#      $��Light"�5$      $��Account number��5%      $��20(�5&      $��Center=�5'      
���   �
������ $��0q�5*      $	��235��5+      $��25��5,      $��Center=�5-      	 � ToolTip$z	 tExample login credintials:
Account number: 123, Pin: 123
Account number: 456, Pin: 456
Account number: 789, Pin: 789��51      �� 52      $	��250��6   $��2��53      
���   �
 J� Opacity$	
 0.5Q�55      G� 56      -   5         G�Name$ PasswordBox��56      $��Light"�57       G� Password$
 1234��58      $��20(�59      $��Center=�5:      
���   �
������ $��0q�5=      $	��235��5>      $��25��5?      $��Center=�5@      $��0,20,0,0q�5B      $z	 tExample login credintials:
Account number: 123, Pin: 123
Account number: 456, Pin: 456
Account number: 789, Pin: 789��5E      �� 5F      $	��250��6   $��2��5G      
���   �$	
 0.5Q�5I      $��0,0,0,20q�5J      �� 5L      -   5         ��Name$ ButtonLogin��5L      $	��100��5M      $��50��5N      $��LOGIN��5O      {�.  5Q      �� 5S      -   5         ��Name$ TextBlockInvalidLogin��5S      $��Invalid Login Message��5T      $��17(�5U      
���  ��$��0,10,0,0q�5W       �� TextAlignment$ Center=�5X      $y�Hidden=�5Y      5[      �� 5]   
   $��2��6   $��Right=�6"   $��Center=�6>   $��0,0,10,0q�6Y   .+�5^      �� -   5        $��70��5^      $��40��6    $��About��6,   $��16(�6<   6J   5_      5b      5c      