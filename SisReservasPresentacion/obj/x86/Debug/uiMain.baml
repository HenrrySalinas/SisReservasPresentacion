   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       SisReservasPresentacion$   SisReservasPresentacion.uiMain   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$  	Principal��5      $��1228.504��5      $��810.5��60    � 
ResizeMode$ NoResize=�6?    � WindowStartupLocation$ CenterScreen=�6U    � WindowState$ 	Maximized=�6z    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $G Apack://application:,,,/MahApps.Metro;component/Styles/Colors.xaml?�6%   �� 5      $M Gpack://application:,,,/MahApps.Metro;component/Styles/Accents/Blue.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Accents/BaseLight.xaml?�6%   �� 5      $\ Vpack://application:,,,/MahApps.Metro;component/Styles/Controls.AnimatedTabControl.xaml?�6%   %    5      .��5      � .+�5   
   � .+�5      �� $
��Left=�6   $	��375��64   $��	10,10,0,0q�6A   $	��Top=�6T   $	��933��6l    J� RenderTransformOrigin$ 
0.505,0.47&�6x   .@�5      �� $��TabItem��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ 	rtglRutas��5   $   ���#009f00$
��Left=�6F   $��93��6a   $��	34,53,0,0q�6m   $	��Top=�6�   $	��239��6�   6�   �� 5      $
��Left=�6$   $��
116,85,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g   
�������$��20(�6�   $	��100��6�   �� 6�   	 � Language$	 es-bo�6�   $�RUTAS ��6�   6�   �� 5      ���#81287f$
��Left=�63   $��91��6N   $��
302,53,0,0q�6Z   $	��Top=�6n   $	��280��6�   �� 5       ���	#FFF99F1D$
��Left=�65   $��95��6P   $��302,168,0,0q�6\   $	��Top=�6q   $	��280��6�   �� 5!      ���#2878ec$
��Left=�63   $	��210��6N   $��
614,53,0,0q�6[   $	��Top=�6o   $	��228��6�   �� 5"      ���	#FF35C4DA$
��Left=�65   $��96��6P   $��
39,168,0,0q�6\   $	��Top=�6p   $	��235��6�   5%      5&      �� 5'      $��TabItem��6   .��5(      � ���	#FFE5E5E5.+�5)      �� $
��Left=�6%   $��93��6@   $��	34,53,0,0q�6L   $	��Top=�6_   $	��239��6w   ��5*      �� 5+   "   
 �� ImageSource$
 C:\time.gif��6-   5-      �� 5.      $
��Left=�6$   $��
116,85,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g   
�������$��20(�6�   $	��100��6�   �� 6�   $	 es-bo�6�   $�RUTAS ��6�   6�   �� 5/      ���#81287f$
��Left=�63   $��91��6N   $��
302,53,0,0q�6Z   $	��Top=�6n   $	��280��6�   �� 50      ���	#FFF99F1D$
��Left=�65   $��95��6P   $��302,168,0,0q�6\   $	��Top=�6q   $	��280��6�   �� 51      ���#2878ec$
��Left=�63   $	��210��6N   $��
614,53,0,0q�6[   $	��Top=�6o   $	��228��6�   �� 52      ���	#FF35C4DA$
��Left=�65   $��96��6P   $��
39,168,0,0q�6\   $	��Top=�6p   $	��235��6�   �� 53      $��Button��6!   $
��Left=�62   $��	36,18,0,0q�6M   $	��Top=�6`   $��75��6x   54      55      56      59      &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ 
dgvHorario��5:      $
��Left=�6'   $��
29,400,0,0q�6B   $	��Top=�6V      AutoGenerateColumns .     Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$	 N°��6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$	 nro�   ClipboardContentBinding 6B   Z� 6e     5=      $ Horario��6i    6%   �� $ horario� 6F   Z� 6i     5>      $ idRuta��6h    6%   �� $ idRuta� 6E   Z� 6h   5@        5A   
   -   5        $ 	dgvCiudad��5A      $
��Left=�5B   #   $��
955,57,0,0q�5C   #   $	��Top=�5D   #    .  $	��228��5F   #   $
��auto��6/   ���#ccc$��1q�5G   6    5H        5I   "   $	 Nro��6z    65   �� $ idCiudad� 6W   Z� 6z     5J   "   $ Ciudad��6x    65   �� $ ciudad� 6U   Z� 6x   5L      5N      5P      