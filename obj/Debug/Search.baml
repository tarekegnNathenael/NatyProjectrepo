   M S B A M L   `   `   `  ����B  >newLife, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:newLifenewLife  5          newLife.Search   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.0.815, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !localclr-namespace:newLife  5      -   5        
�������.��5      � ���#1277BD  � RowDefinitions  5   
   �� 5      $	��91* �6   �� 5      $
��209* �6   �� 5      $
��251* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��88��6#      Mode$ Accent=�6/   
�������   CornerRadius$ 30��6Q   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�5   #   $��0,4,0,0q�6U   $��2��5   #   .��5      � $��10q�6   
�������.+�5      �� $��	388,0,0,0q�6   $
��Left=�6-   $��30(�6H   ���#1277BD$	��465��5   /   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter your text to search��5      .��6U   5      �� 5      $��
0,10,827,0q�6   ���#1277BD �� TextAlignment$ Center=�6E   $��Center=�6\   $��30(�6w   $��Oblique$�6�   $��58��6�   $��
Search by:��6�   �� 5      -   5        $
��Auto��5      $��875,10,39,10q�6'   ���#1277BD.��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.815, Culture=neutral, PublicKeyToken=null]]   Kind$ Magnify=�6.   
�������$��44��6Q   $��41��6\    J� RenderTransformOrigin$ 0.5,0.5&�6h   z�5      V� 5      .~�5    "   �� �� 5!   "   �� 5"   "    �� Angle$ 89.442Q�62   T� 5#   "   5$      5&      5'      �� 5(      -   5        	 ��Name$	 comboBox��5(      $
��Left=�6-   $��
210,10,0,0q�6H   $	��Top=�5)      ���#1277BD$	��173��6H   $��58��6T   $ 
Select One��5*      $��19(�6G   .@�5,      �� -   5        $��item1��5,   #   $��Attendant Name��60   ���#1277BD6J   �� 5-      -   5        $��item2��5-   #   $��patient Name��60   ���#1277BD6G   �� 5.      -   5        $��item3��5.   #   $��Attendant Phone��60   ���#1277BD6J   5/      50      53      � 54   
   $��1��6   
����� �$��10q�6.   $��2��6:   .+�55      &   System.Windows.Controls.DataGrid  -   5        $��DisplayPatient��55      
   AutoGenerateColumns
 .  $
��Left=�56      $	��Top=�62   $	��377��6J   $
��1002��6W   ��. $��Visible=�58         CanUserResizeColumns .    Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Patient ID��6H   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6)   �� *
Patient_Id+6H     5;      $ 
First Name��6O    6)   �� *Patient_FirstName+6O     5<      $ Middle Name��6P    6)   �� *Patient_MiddleName+6P     5=      $ 	Last Name��6N    6)   �� *Patient_LastName+6N     5>      $ Region��6L    6)   �� *Patient_Region+6L     5?      $	 Sex��6I    6)   �� *Patient_Sex+6I     5@      $ Room Number��6J    6)   �� *Patient_Room+6J     5A      $ Patient Status��6L    6)   �� *Patient_Status+6L     5B      $ 
Bed Number��6I    6)   �� *Patient_Bed+6I     5C      $ Religion��6N    6)   �� *Patient_Religion+6N   5G      5I      5L      5M      