   M S B A M L   `   `   `  ����>  :TCC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TCC.ViewTCC.View  5      'clr-namespace:TCC.Helper
TCC.Helper  5          TCC.View.DirectFields   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:TCC.View     5      U QMaterialDesignThemes.Wpf, Version=1.5.0.523, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      #convclr-namespace:TCC.Helper  5        � DataContext  5
      �� *DirectFields+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source*  $TCC.Helper.VisibilityDirectConverter  VisibilityDirectConverter$  TCC.Helper.VisibilityValueType  VisibilityValueType!  TCC.Helper.VisibilityValues  VisibilityValues!  TCC.Helper.VisibilityLength  VisibilityLength �� 
TargetType  MaterialDesignListBox �� BasedOn �� Property �� Value  MaterialDesignTextBox�� 5   
    5      �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ListBox.xaml?�6%   �� 5      $i cpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBlock.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ComboBox.xaml?�6%   �� 5      $k epack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.RadioButton.xaml?�6%   �� 5      $l fpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ToggleButton.xaml?�6%   %�  &	       &	      &	 &     &	 9     '�� L     7  '�� �     7  '�� �       5      6Q     5      6E     5      6?     5      6?   �� 5      " ��6   8   .�5      ��  � ��$ 8 0 8 0q�6+   5!      �� 5"      " ��6   8   5#      �� 5%      " ��6   .�5&      ��  � ��$ 11(�6-   6:   �� 5'       � ��$ Center=�66   6G   �� 5(       � ��$ 8 0 8 0q�6+   6>   �� 5)       �@��TextAlignment$ Center=�62   6C   5*      5.      .��50      � $��0 8 0 0q�6b   y�6   �� 	 �� Path$		 Val�
 �� 	Converter#
 [  � RowDefinitions 51   
   �� 52      $	��10* �6   6+   �� 53      $	��45* �6   6+   �� 54      $	��45* �6   6+    � ColumnDefinitions 56   
   �� 57      $	��15* �6   6-   �� 58      $	��15* �6   6-   �� 59      $	��15* �6   6-   �� 5:      $	��15* �6   6-   �� 5;      $	��15* �6   6-   �� 5<      $	��25* �6   6-   .+�5?   
   �� $��0��6   $��0��6!   $	��Bit��6W   ��6.   �� *SetActiveTypeCommand+.��6n   Bit��5@      �� 5A      " ��6    $  MaterialDesignRaisedAccentButton# [ 6,    �� Triggers 5B      �� 5C       �� Binding 6&   �� $		 Val�#
 [  �� ConverterParameter$	 Bit�� �� Value	 False6�   .a�5D      ��  � ��
 �����6;   �� 5E       � ��
 �����6<   5F      5H      5J      �� 5K   
   $��1��6   $��0��6!   $��8 0 0 0q�6.   $	��Int��6h   ��6?   �� *SetActiveTypeCommand+.��6   Int��5L      �� 5M      " ��6   # [ 6,    5N      �� 5O       6&   �� $		 Val�#
 [ $	 Int��	 False6�   .a�5P      ��  � ��
 �����6;   �� 5Q       � ��
 �����6<   5R      5T      5V      �� 5W   
   $��2��6   $��0��6!   $��8 0 0 0q�6.   $
��Real��6h   ��6?   �� *SetActiveTypeCommand+.��6�   Real��5X      �� 5Y      " ��6   # [ 6,    5Z      �� 5[       6&   �� $		 Val�#
 [ $
 Real��	 False6�   .a�5\      ��  � ��
 �����6;   �� 5]       � ��
 �����6<   5^      5`      5b      �� 5c   
   $��3��6   $��0��6!   $��8 0 0 0q�6.   $��String��6h   ��6?   �� *SetActiveTypeCommand+.��6�   String��5d      �� 5e      " ��6   # [ 6,    5f      �� 5g       6&   �� $		 Val�#
 [ $ String��	 False6�   .a�5h      ��  � ��
 �����6;   �� 5i       � ��
 �����6<   5j      5l      5n      �� 5o   
   $��4��6   $��0��6!   $��8 0 0 0q�6/   $
��Byte��6i   ��6@   �� *SetActiveTypeCommand+.��6�   Byte��5p      �� 5q      " ��6   # [ 6,    5r      �� 5s       6&   �� $		 Val�#
 [ $
 Byte��	 False6�   .a�5t      ��  � ��
 �����6;   �� 5u       � ��
 �����6<   5v      5x      5z      #  MaterialDesignThemes.Wpf.Card  5|   
   $��0 8 0 8q�6      UniformCornerRadius$ 6Q�61   $��1��6I   $��0��6V   $��0 4 0 0q�6f   $��6��6w     PrimaryHueLightBrush#���  5}        "	 PrimaryHueLightForegroundBrush#��� 	 5~      .��5      � y�6   �� $		 Val�#
 [  5�      �� 5�      $	��33* �6$   63   �� 5�      $	��33* �6$   63    5�      �� 5�      $	��15* �6'   65   �� 5�      $	��15* �6'   65   �� 5�      $	��30* �6'   65   �� 5�      $	��10* �6'   65   �� 5�      $	��10* �6'   65   �� 5�      $	��10* �6'   65   �� 5�      $	��10* �6'   65   �� 5�      $	��10* �6'   65   �� 5�      $	��10* �6'   65   .+�5�      �� $��
Start Byte��6   $��0��6.   $��0��6>   $��8 0 8 0q�6K   6^   �� 5�      $��Length��6   $��1��6*   $��0��6:   $��8 0 8 0q�6G   y�6Y   �� $		 Val�#
 [ $ String���� 5�      $	��Bit��6   $��1��6'   $��0��67   $��8 0 8 0q�6D   y�6V   �� $		 Val�#
 [ $	 Bit���� 5�      $��
DB Station��6   $��3��6.   $��0��6>   $��2��6K   $��8 0 8 0q�6_   6r   �� 5�      $��DB Panel��6   $��5��6,   $��0��6<   $��2��6J   $��8 0 8 0q�6^   6q   �� 5�      $��	DB Manual��6   $��7��6-   $��0��6=   $��2��6K   $��8 0 8 0q�6_   6r   �� 5�      $��0��6   $��1��6*    �� TextAlignment$ Center=�6V   $��8 0 8 0q�6m   ��67   �� *Val.StartByte+6�   �� 5�      $��1��6   $��1��6*   $ Center=�6�   $��8 0 8 0q�6�   ��67   �� *
Val.Length+y�6S   �� $		 Val�#
 [ 6�   d� 5�       $
  MaterialDesignSwitchToggleButton#��[
 6   $��Center=�6Y   $��8 0 0 0q�6t   $��3��6�   $��1��6�   $��Center=�6�   $��Station��5�   g    d� 	IsChecked 6   �� *Val.DBStation+��6<   �� *SetActiveDBTypeCommand+6g   �� 5�      $��4��6   $��1��6*   $ Center=�6R   $��8 0 8 0q�6i   ��67   �� *	DBStation+6|   d� 5�      #��[
 6   $��Center=�6Y   $��8 0 0 0q�6t   $��5��6�   $��1��6�   $��Center=�6�   $��Panel��5�   c    6   �� *Val.DBPanel+��68   �� *SetActiveDBTypeCommand+6c   �� 5�      $��6��6   $��1��6*   $ Center=�6P   $��8 0 8 0q�6g   ��67   �� *	DBPanel+6z   d� 5�      #��[
 6   $��Center=�6Y   $��8 0 0 0q�6t   $��7��6�   $��1��6�   $��Center=�6�   $��Manual��5�   e    6   �� *Val.DBManual+��6:   �� *SetActiveDBTypeCommand+6e   �� 5�      $��8��6   $��1��6*   $ Center=�6Q   $��8 0 8 0q�6h   ��67   �� *
DBManual+6{   �� 5�      $��0��6   $��2��6(   $��8 0 8 0q�69   $��2��6J   .  (MaterialDesignThemes.Wpf.TextFieldAssist   Hint$	 PLC��6[    & "MaterialDesignFloatingHintComboBox#��[ 6�    �� DisplayMemberPath$
 Name��6�    �� SelectedIndex$ 0��6�    �� 
IsEditable .     HintOpacity$	 .26Q�5�   &   ��5�   �   �� *PLCs+ �� SelectedItem 6  �� *SelectedPLC+5�   Y   5�      5�         TCC.View.Mask  5�   
   $��2��6   $��6��6"   5�      5�      