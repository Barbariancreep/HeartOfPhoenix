   M S B A M L   `   `   `  ����I  EHeartOfPhoenix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HeartOfPhoenixHeartOfPhoenix  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	        HeartOfPhoenix.DivDesigner   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:HeartOfPhoenix     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � 	Resources  5         paperGradient 
� GradientOrigin 
� RadiusX 
� RadiusY � Color � Offset  StatsHeader �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value��%T  &	        &	 �     7   
� 5   
   $ 0.5, 0.5&�64   $	 0.8Q�6N   $	 0.8Q�6\   .��5      � $ #ddc998��6   $	 0.0Q�6+   � 5      $ #887751��6   $	 1.0Q�6+   5      �� 5   
   "  6$   .�5      ��  � ��8   6+   �� 5       � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   5      5      .��5      ]� .+�5   
   �� $
��Left=�6   5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 DivStatsGrid��5   *   $��Right=�6   #��[  5      
   RowBackground

 ���� ��5      �� *DivStatsRows+   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Base Stats��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69      HeaderStyle# [ 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5"   %   �� *
BaseStat+  5#      $ Combat Stats��6%   $ * 6;   # [ 6E    5$   %   �� *
CombatStat+  5%      $ Equipment Cost��6%   $ * 6=   # [ 6G    5&   %   �� *EquipmentCost+5(      5)      5*      