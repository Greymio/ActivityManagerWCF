   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    WPFActivityManager#   WPFActivityManager.Views.Home   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$
  Home��5   	   $��417.328��6   $��617.612��6'    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   >    � DataContext 6	   ��    Hvm �� Source# [   � 	Resources 5        LargeTileStyle �� 
TargetType!   MahApps.Metro.Controls.Tile �� Property �� Value  SmallTileStyle��%T  &	       &	 �     �� 5	   
   "  6'   .�5
      ��  � ��$	 300��6&   �� 5       � ��$	 125��6'   �� 5       �@ TitleFontSize$ 10Q�6.   5      �� 5   
   "  6'   .�5      ��  � ��$	 147��6&   �� 5       � ��$	 125��6'   �� 5       �@ TitleFontSize$ 10Q�6.   5      5      (   "MahApps.Metro.Controls.MetroWindow	   IconTemplate	 5      �� 5   
   .R�5      � #��z��6   #��z��5      $��4q�5      
������ 
 �� EdgeMode$
 Aliased=�5       �� BitmapScalingMode$ HighQuality=�5      .+�5      �� ��5      !� 5        appbar_github !� Visual# [ 6&   5!      5"      5#      .��5)      � $	��637��6   $	��382��6   $
��Left=�6*   $	��Top=�6E   $��0,0,-25,-28q�6]   .+�5*   
        Title$ 
Activities��6   #��[ 6+   $��3q�6T    � Cursor$
 Hand��6_   ��6m   �� *ActivityCmd+��5+      �� 5,       �� ImageSource$1 +/WPFActivityManager;component/images/bg.png��6   5.        5/   
   $ Search��6   #��[ 6'   $��3q�6P   $
 Hand��6[   ��6j   �� *	SearchCmd+��50      �� 51      $5 //WPFActivityManager;component/images/search.png��6   53        54   
   $ People��6   #��[ 6'   ���#D2691E$
 Hand��6e   ��6s   �� *	PeopleCmd+.��56      �� $5��//WPFActivityManager;component/images/people.ico��6   58        59   
   $ Sheduler��6   #��[ 6)   ���#1E90FF$
 Hand��6g   .��5:      �� $8��2/WPFActivityManager;component/images/scheduler.png��6   5<        5=   
   $ Register��6   #��[ 6)   
��� � �$
 Hand��6e   .��5>      �� $7��1/WPFActivityManager;component/images/register.png��6   5?      5@      5B      