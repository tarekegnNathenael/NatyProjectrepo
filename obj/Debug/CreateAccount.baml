   M S B A M L   `   `   `  ����B  >newLife, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:newLifenewLife  5   	       newLife.CreateAccount   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:newLife     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.0.815, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  CreateAccount��5	   	   $��544.06��6   $	��503��6/   .��5
      � $��0,4,0,5q�6   $
��Left=�6   $	��483��67   .+�5   
   � $��
10,20,10,0q�6   $	��Top=�6$   $	��116��6<    � RowDefinitions 5      �� 5      $	��49* �6    �� 5      $	��67* �6    .+�5      �� $
��90,0q�6   $��26.667(�6&   $
��Bold"�68   $��Italic$�6J   
����  �$��	Underline{�6t   $��46��6�   $	��Top=�6�   CREATE ACCOUNT5      '  !MaterialDesignThemes.Wpf.PackIcon  5      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.815, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�6&   $��Center=�66   $��0��6R   $��84��6_   $��
144,32,0,0q�6k   $	��130��6   
�������
���2͚�$��2��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   5      � 5   
   $��10,181,10,99q�6   $��Center=�6&   $	��224��6A    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $��* �6#   �� 5      $
��auto �6#    5      �� 5      $��* �6    �� 5      $��* �6    �� 5       $��* �6    �� 5!      $��* �6    �� 5"      $��* �6    �� 5#      $��* �6    �� 5%      $��* �6    �� 5&      $��* �6    �� 5'      $��* �6    �� 5(      $��* �6    �� 5)      $��* �6    �� 5*      $
��auto �6    .+�5,        $ 
AccountBox=�6&   ���#0288D1$��0��6P   $��0��6`   $��0,8,0,0q�6m   $��2��6~   �� 5-      $��0��6   $��1��6%   $��2��65   ���#0288D1$��10,5,377,13q�5.      $��2��6-   First Name:6K   �� 5/      -   5        $��	Firstname��50      $��2��5/      $��0��6&   $��124,-4,0,12q�63   $��Center=�6H   ���#0288D1$��28��50   =   $��2��6I   .��6Z   51        53      $ 
AccountBox=�6&   $��0��69   $��2��6I   $��0,10,0,0q�6V   ���#0288D1$��2��6   �� 54      $��2��6   $��1��6%   $��2��65   ���#0288D1$��
0,13,357,3q�55      $��Right=�6,   $��80��6H   $��2��6S   Second Name:6r   �� 56      -   5        $��
secondname��57   G   $��2��56      $��1��6&   ���#0288D1$��124,16,0,10q�57      $��Center=�6+   $��28��6Y   $��3��6e   .��6v   58        59      $ CellphoneAndroid=�6&   $��0��6?   $��4��6O   ���#0288D1$ 
0.732,1.74&�5:   &   $��16��6I   $	��Top=�5;   &   $
��Left=�6>   $��16��6Y   $��0,16,0,0q�6d   $��2��6v   �� 5<      $��4��6   $��1��6%   $��2��65   $��
0,16,362,0q�6I   $��Right=�6]   $��80��5=      $��2��6#   ���#0288D1	Phone No:6U   �� 5>      -   5        $��pphone��5>   a   $��2��6   $��4��6&   $��	124,4,0,4q�63   $��Center=�6F   $��28��6o   $��2��6{   .��6�   5?        5@      $
 Lock=�6&   $��0��63   $��6��6C   ���#0288D1$ 
0.732,1.74&�5A   &   $��16��6I   $	��Top=�5B   &   $
��Left=�6>   $��16��6Y   $��0,10,0,0q�6d   $��2��6v   �� 5C      $��6��6   $��1��6%   $��2��65   $��
0,10,357,6q�6I   $��Right=�6]   $��80��5D      $��2��6#   ���#0288D1	Password:6T   G� 5E      -   5        $��	ppassword��5E   f   $��2��6   $��6��6*   $��
124,3,0,10q�67   $��Center=�6K   $��28��6w   $��2��6�   5F        5G      $
 Lock=�6&   $��0��63   $��8��6C   ���#0288D1$ 
0.732,1.74&�5H   &   $��16��6I   $	��Top=�5I   &   $
��Left=�6>   $��16��6Y   $��0,8,0,0q�6d   $��2��6u   �� 5J      $��8��6   $��1��6%   $��2��65   $��	0,8,341,8q�6I   $��Right=�6\   $��96��5K      $��2��6#   ���#0288D1$��ExtraCondensed&�6I   confirm password:6y   G� 5L      -   5        $��Re_password��5L   f   $��2��6   $��8��6*   $��
124,0,0,13q�67   $��Center=�6K   $��28��6y   $��2��6�   5M      5R      �� 5T   
   -   5         ��Name$ CAccount��5T      $��CreateAccount ��6$   ���#80CBC4$	��1.3q�6S   $
��Left=�5U      $��143,405,0,0q�61   $	��Top=�6F   $	��129��6^   ���#0277BD$��37��5V   -   69   �� 5X   
   -   5         ��Name$ errorMessage��5X      $
��Left=�6*   ���#D32F2F$��
63,152,0,0q�6Z   $
��Wrap=�5Y      $	��Top=�6(   $��24��6@   $	��374��6L   �� 5Z   
   -   5        $
 exit��5Z      $��Cancel ��6    ���#80CBC4$	��1.3q�6H   $
��Left=�5[   
   $��277,405,0,0q�6%   $	��Top=�6:   $��89��6R   ���#D50000$��37��5\   !   6-   5b      5d      