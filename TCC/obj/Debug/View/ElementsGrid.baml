   M S B A M L   `   `   `  ����>  :TCC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TCC.ViewTCC.View  5          TCC.View.ElementsGrid   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=1.5.0.523, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      "localclr-namespace:TCC.View  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      f bGalaSoft.MvvmLight.Platform, Version=5.3.0.19032, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5
        � DataContext  5      �� *ElementsGrid+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source&   System.Windows.Controls.DataGrid �� 
TargetType  MaterialDesignDataGrid �� BasedOn �� Property �� Value�� 5   
    5      �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ComboBox.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.CheckBox.xaml?�6%   �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Slider.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.TextBox.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.DataGrid.xaml?�6%   %]   '        7  �� 5      "  6   8   .�5      ��  � ��
 ���� 6E   5      5      .��5         -   5        	  Name$	 	dataGrid1��5    �   ��. 
   
IsReadOnly
 . $
��1000��6M   "   VerticalScrollBarVisibility$
 Auto=�6      SelectionMode$ Extended=�6�   $��Stretch=�6�   $��Stretch=�6�      AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q�6%     ColumnHeaderPadding$ 8q�6Z  ��6^   �� *
Elements+   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6K     5$      $
 Name��6%    63   �� *Name+6N     5%      $ 
Position X��6%    69   �� *
Position_X+6Z     5&      $ 
Position Y��6%    69   �� *
Position_Y+6Z     5'      $ Width��6%    64   �� *Width+6P     5(      $ Height��6%    65   �� *Height+6R   4  .System.Windows.Controls.DataGridCheckBoxColumn  5*      $ Show Border��6&    - )MaterialDesignDataGridCheckBoxColumnStyle   ElementStyle# [ 6Z    6;   �� *
ShowBorder+6�     5+      $ On Top��6%      
IsReadOnly . # [ 6b    65   �� *OnTop+6�   .  (System.Windows.Interactivity.Interaction   Triggers 5-   
   /  )System.Windows.Interactivity.EventTrigger  5.         	EventName$ SelectionChanged��6   .	  (System.Windows.Interactivity.TriggerBase 	  Actions. 5/      /
  )GalaSoft.MvvmLight.Command.EventToCommand
   
  Command 6&   �� *SendSelectedElementsCommand+ 
  CommandParameter 6V   ��  �� ElementName$ 	dataGrid1�� �� Path$ SelectedItems�6�   50      52      54      