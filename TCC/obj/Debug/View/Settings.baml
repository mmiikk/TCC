   M S B A M L   `   `   `  ����>  :TCC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TCC.ViewTCC.View  5          TCC.View.Settings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=1.5.0.523, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      "localclr-namespace:TCC.View  5      f bGalaSoft.MvvmLight.Platform, Version=5.3.0.19032, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5	        � DataContext  5
      �� *
Settings+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source �� 
TargetType  MaterialDesignTextBox �� BasedOn �� Property �� Value'  !MaterialDesignThemes.Wpf.PackIcon�� 5   
    5      �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ComboBox.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Slider.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   %�   '��       7  '  R     7 �� 5      " ��6   8   .�5      ��  � ��$ 0 8 0 8q�6+   5      �� 5      "  6   8   .�5      ��  � ��$ Center=�66   �� 5       � ��$ 4 0 4 0q�6+   5      5      .��5      � $��16q�6   	 � ColumnDefinitions	 5    
   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $��* �6   
 � RowDefinitions
 5&   
   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   .+�5/   
   �� $��0��6   $��0��6!   $��2��61    # MaterialDesignHeadlineTextBlock#��[ 6E   
Settings6�     51   
   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.5.0.523, Culture=neutral, PublicKeyToken=null]]   Kind$ Server=�6"   $��0��60   $��1��6@   ��6M   ��  �� ElementName$ CommentTextBox�� �� Path$ BorderBrush�6�   �� 52   
   $��1��6   $��1��6!   $��Center=�61   $��8 0 8 0q�6L   	Server IP6h   �� 53   
   -   5         ��Name$ ServerIP��54   	   $��1��53      $��2��6   ��6/   �� $ Set.IP�54        55   
   $ Account=�6"   $��0��61   $��2��6A   ��6N   �� $ CommentTextBox��$ BorderBrush�6�   �� 56   
   $��2��6   $��1��6!   $��Center=�61   $��8 0 8 0q�6L   	DB User6f   �� 57   
   -   5        $ DBUser��58   	   $��2��57      $��2��6   ��6/   �� $ 
Set.DBUser�58        5:   
   $	 Key=�6"   $��0��6-   $��3��6=   ��6J   �� $ CommentTextBox��$ BorderBrush�6�   �� 5;   
   $��3��6   $��1��6!   $��Center=�61   $��8 0 8 0q�6L   DB Password6j   �� 5<   
   -   5        $ 
DBPassword��5=   	   $��3��5<      $��2��6   ��6/   �� $ Set.DBPassword�5=        5?   
   $ Database=�6"   $��0��62   $��4��6B   ��6O   �� $ CommentTextBox��$ BorderBrush�6�   �� 5@   
   $��4��6   $��1��6!   $��Center=�61   $��8 0 8 0q�6L   	DB Name6f   �� 5A   
   -   5        $ DBName��5B   	   $��4��5A      $��2��6   ��6/   �� $ 
Set.DBName�5B      � 5C   
   $��5��6   $��3��6   	 5D      �� 5E      $	��50* �6#   �� 5F      $	��50* �6#   
 5H      �� 5I      $
��Auto �6    .+�5K      �� -   5         ��Name$ SaveBtn��5K   2   $��0��6   $��0��6"     MaterialDesignFlatButton#��[ 6\   $��Right=�6�   ��6C   �� *Save+.��6�   Save6�   �� 5L      -   5        $ 	CancelBtn��5L   2   $��0��6   $��1��6"   #��[ 6E   $
��Left=�6w   .��6�   Cancel6�   5M      5O      5P      