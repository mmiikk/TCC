   M S B A M L   `   `   `  ����>  :TCC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TCC.ViewTCC.View  5      'clr-namespace:TCC.Helper
TCC.Helper  5          TCC.View.ElementValues   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:TCC.View     5      )convclr-namespace:TCC.Helper     5      U QMaterialDesignThemes.Wpf, Version=1.5.0.523, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � DataContext  5	      �� *ElementValues+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source   booleanToVisibilityConverter  TCC.Helper.isNotConverter  isNotConverter�� 5   
    5      �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ComboBox.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Slider.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %:   &	       &	      �� 5      6+     5      6"   5      .��5      � .+�5    
   #  MaterialDesignThemes.Wpf.Card  $��0 4 0 0q�6   .��5!      � $��8q�6    � ColumnDefinitions 5"      �� 5#      $	��15* �6'   65   �� 5$      $	��15* �6'   65   �� 5%      $	��15* �6'   65   �� 5&      $	��15* �6'   65   �� 5'      $	��15* �6'   65   �� 5(      $	��25* �6'   65    � RowDefinitions 5+      �� 5,      $
��auto �6$   64   �� 5-      $
��auto �6$   64   �� 5.      $
��auto �6$   64   .+�51      �� -   5        $��Value_IDBtn��51      $��0��6,   $��0��6<   ��6I   �� *SetActiveValueCommand+��6s   �� *	ValueID+��52      �� 53       �� 
TargetType" ��6     $  MaterialDesignRaisedAccentButton �� BasedOn# [ 64   	 �� Triggers	 55      �� 56   "   
 �� Binding
 6.   ��  �� Path$ ValueID.Selected� �� Value	 False6Y   .a�57   &   ��  �� Property � �� �� Value
 �����6C   �� 58   &    � ��
 �����6D   59   #   5;      .��5<   $   
Value_ID5>      �� 5@      -   5        $��FontColorBtn��5@      $��1��6-   $��0��6=   $��8 0 0 0q�6J   ��6\   �� *SetActiveValueCommand+��6�   �� *	FontColor+��5A      �� 5B      " ��6    # [ 64   	 5D      �� 5E   "   
 6.   �� $ FontColor.Selected�	 False6[   .a�5F   &   ��  � ��
 �����6C   �� 5G   &    � ��
 �����6D   5H   #   5J      .��5K   $   
Font Color5M      �� 5O      -   5        $��BackColorBtn��5O      $��2��6-   $��0��6=   $��8 0 0 0q�6J   ��6\   �� *SetActiveValueCommand+��6�   �� *	BackColor+��5P      �� 5Q      " ��6    # [ 64   	 5S      �� 5T   "   
 6.   �� $ BackColor.Selected�	 False6[   .a�5U   &   ��  � ��
 �����6C   �� 5V   &    � ��
 �����6D   5W   #   5Y      .��5Z   $   
Back Color5\      �� 5^      -   5        $��	ActionBtn��5^      $��3��6*   $��0��6:   $��8 0 0 0q�6G   ��6X   �� *SetActiveValueCommand+��6�   �� *Action+��5_      �� 5`      " ��6    # [ 64   	 5b      �� 5c   "   
 6.   �� $ Action.Selected�	 False6X   .a�5d   &   ��  � ��
 �����6C   �� 5e   &    � ��
 �����6D   5f   #   5h      .��5i   $   Action5k      �� 5m      -   5        $��
VisibleBtn��5m      $��4��6+   $��0��6;   $��8 0 0 0q�6H   ��6Y   �� *SetActiveValueCommand+��6�   �� *
Visibility+��5n      �� 5o      " ��6    # [ 64   	 5q      �� 5r   "   
 6.   �� $ Visibility.Selected�	 False6\   .a�5s   &   ��  � ��
 �����6C   �� 5t   &    � ��
 �����6D   5u   #   5w      .��5x   $   	Visible5z      � 5|      $��0��6   $��1��6'   $��6��64   $��0 8 0 0q�6H    5}      �� 5~      $	��15* �6+   69   �� 5      $	��15* �6+   69   �� 5�      $	��15* �6+   69   �� 5�      $	��15* �6+   69   �� 5�      $	��15* �6+   69   �� 5�      $	��25* �6+   69    5�      �� 5�      $
��auto �6(   68   �� 5�      $
��auto �6(   68   .+�5�      �� -   5        $��MaskBtn��5�      $��1��6,   $��0��6<   $��8 0 0 0q�6I   $
��Mask��6�   y�6Z   �� *MaskVisibility+ �� 	Converter# [ ��6�   �� *SetActiveValueButtonCommand+��5�      �� 5�      " ��6$   # [ 68   	 5�   "   �� 5�   &   
 62   �� $ CurrentValue�# [  �� ConverterParameter$
 Mask��	 False6�   .a�5�   *   ��  � ��
 �����6G   �� 5�   *    � ��
 �����6H   5�   '   5�      .��5�   (   Mask5�      �� 5�      -   5        $��	StaticBtn��5�      $��2��6.   $��0��6>   $��8 0 0 0q�6K   $��Static��6�   y�6]   �� *StaticVisibility+# [ ��6�   �� *SetActiveValueButtonCommand+��5�      �� 5�      " ��6$   # [ 68   	 5�   "   �� 5�   &   
 62   �� $ CurrentValue�# [ $ Static��	 False6�   .a�5�   *   ��  � ��
 �����6G   �� 5�   *    � ��
 �����6H   5�   '   5�      .��5�   (   Static5�      �� 5�      -   5        $��	DirectBtn��5�      $��3��6.   $��0��6>   $��8 0 0 0q�6K   $��Direct��6�   y�6\   �� *DirectVisibility+# [ ��6�   �� *SetActiveValueButtonCommand+��5�      �� 5�      " ��6$   # [ 68   	 5�   "   �� 5�   &   
 62   �� $ CurrentValue�# [ $ Direct��	 False6�   .a�5�   *   ��  � ��
 �����6G   �� 5�   *    � ��
 �����6H   5�   '   5�      .��5�   (   Direct5�         TCC.View.StaticValueText  5�      $��0��6,   $��5��6<   $��1��6P      TCC.View.DirectFields  5�      $��0��6)   $��6��69   $��1��6M   5�      5�      5�      5�      5�      