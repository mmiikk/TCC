   M S B A M L   `   `   `  ����>  :TCC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TCC.ViewTCC.View  5      'clr-namespace:TCC.Helper
TCC.Helper  5
          TCC.View.StaticValueText   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:TCC.View     5      U QMaterialDesignThemes.Wpf, Version=1.5.0.523, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      f bGalaSoft.MvvmLight.Platform, Version=5.3.0.19032, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5	      #convclr-namespace:TCC.Helper  5
        � DataContext  5      �� *StaticValuesText+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source*  $TCC.Helper.VisibilityStaticConverter  VisibilityStaticConverter �� 
TargetType  MaterialDesignTextBox �� BasedOn �� Property �� Value�� 5   
    5      �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   %�   &	       '��      7    5      6Q   �� 5      " ��6   8   .�5      ��  � ��$ 8 0 8 0q�6+   �� 5       �@��TextAlignment$ Center=�62   6C   5      5      .��5      � 	 � ColumnDefinitions	 5      �� 5      $
��100* �6#   
 � RowDefinitions
 5       �� 5!      $
��Auto �6    .+�5$   
   �� $��0��6.   $��0��6>   
���   ���6   �� *
StaticText+y�6^   ��  �� Path$	 Val� �� 	Converter# [ .��6�   5&      5'      5(      