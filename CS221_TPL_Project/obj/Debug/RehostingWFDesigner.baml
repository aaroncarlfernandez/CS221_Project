   M S B A M L   `   `   `  ����e  aSystem.Activities.Presentation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�\clr-namespace:System.Activities.Presentation.Toolbox;assembly=System.Activities.Presentation&System.Activities.Presentation.Toolbox  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   S OCS221_TPL_Project, Version=1.0.6830.30671, Culture=neutral, PublicKeyToken=null5clr-namespace:CS221_TPL_ProjectCS221_TPL_Project 5   	   +   %CS221_TPL_Project.RehostingWfDesigner   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   msapt\clr-namespace:System.Activities.Presentation.Toolbox;assembly=System.Activities.Presentation     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   1localclr-namespace:CS221_TPL_Project     5   	   -   5          � Title$-  'Theory of Programming Languages Project��5   	   $��534.328��69   $��880.597��6J    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowState$ 	Maximized=�5
   	   $��11(�6Q    � 	Resources 5         AssemblyName��%v   &	        ��5      XTSystem.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35��6|   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5      -   5           Command$ ApplicationCommands.New��5      6Z     5      -   5        $ ApplicationCommands.Open��5      68     5      -   5        $ ApplicationCommands.Save��5      68     5      -   5        $  ApplicationCommands.SaveAs��5      6:     5      -   5        $# local:DataCommands.CommandRun��5      6`   .��5      �  � RowDefinitions 5      �� 5      $��30 �6   �� 5      $��* �6   .+�5      ]� $��0��6   .+�5      c� .@�5   
   �� -   5        $��	ButtonNew��5      $��ApplicationCommands.New��6"   .��6D   New6I   �� 5   
   -   5        $��
ButtonOpen��5      $��ApplicationCommands.Open��6#   .��6F   Open6L   �� 5   
   -	   5        $��
ButtonSave��5      $��ApplicationCommands.Save��6#   .��6F   Save6L   �� 5   
   -
   5        $��ButtonSaveAs��5      $ ��ApplicationCommands.SaveAs��6%   .��6J   	Save as6S   �� 5    
   $��10��6   �� 5!   
   -   5        $��	ButtonRun��5!      $#��local:DataCommands.CommandRun��6"   .��6J   	Execute6S   5"   	   5#      � 5$      $��1��6    � ColumnDefinitions 5%      �� 5&   
   $
��169* �6   $��50��6(   �� 5'   
   $��5 �6   �� 5(   
   $
��520* �6   $��50��6(   �� 5)   
   $��5 �6   �� 5*   
   $
��203* �6   $��50��6(   .+�5,      �� �� 5-      $��0��6   ._�5.   
   ;   5System.Activities.Presentation.Toolbox.ToolboxControl     
Categories. 5/      <   6System.Activities.Presentation.Toolbox.ToolboxCategory  	   CategoryName$	 Simple Actions��6!   ?   9System.Activities.Presentation.Toolbox.ToolboxItemWrapper  50      
   DisplayName$
 Print Message��6&      AssemblyName$ CS221_Events��6C      ToolName$  CS221_Events.SimpleMessage��53   2   54        55      $
 	Get Input��6&   $ CS221_Events��6?   $ CS221_Events.InputNumber��58   2   59        5:      $
 Random Number��6&   $ CS221_Events��6B   $ CS221_Events.RandomNumber��5=   2   5>        5?      $
 Condition Statement��6&   # [  6H   $/ )System.Activities.Statements.FlowDecision��5B   2   5C      5D        5E      $	 Events��6!     5F      $
 Assign��6&   # [  6;   $) #System.Activities.Statements.Assign��5I   2   5J        5K      $
 Message - expression��6&   $ CS221_Events��6J   $$ CS221_Events.ExpressionMessage��5N   2   5O        5P      $
 Enter a variable��6&   $ CS221_Events��6F   $( "CS221_Events.InputExpressionNumber��5S   2   5T      5U      5V      5W   	   �� 5X      $��1��6    �� ResizeDirection$ Columns=�5Y      $��Center=�5Z      $��Stretch=�5[      $��5��5\      �� 5^      -   5        $��DesignerBorder��5^      $��2��6   6   �� 5_      $��3��6   $ Columns=�5`      $��Center=�5a      $��Stretch=�5b      $��5��5c      �� 5e   
   $��4��6    �� TabStripPlacement$ Right=�6%   $��Center=�6?   $��LeftToRight=�6a    5f       �� 
TargetType �� Property �� Value � LayoutTransform �� Angle��%�   '��       �� 5g      " ��6   .�5h      ��  � ��$ 4q�6*   �� 5i       � �� 5j      �� 5k      .R�5l      �� #��z��6'    5m      �� 5n      $	 270Q�6*   5p      5q      5s      5t      5u      .@�5v      �� $��Input/Output��6   .��5w      �� -   5        $��InOutTextBlock��5w      
������� �� AcceptsReturn .  �� 
IsReadOnly .  �� IsUndoEnabled .   �� TextWrapping$
 Wrap=�6|   5x      �� 5y      $��These actions��6   .��5z      �� -   5        $��PropertyBorder��5z      5{      �� 5|      $��Settings��6   .��5}      ]� $��0��6   $	��Top=�6%   $��5,2,5,2q�6=   .+�5~      �� $
��Left=�6   .��61   Size:68   �� 5       � Minimum$ 10Q�6    � Maximum$ 17Q�6$    �� Interval$ 1��61    � Value 5�      �� 5�       �� Path$ FontSize�6    �� Mode$ TwoWay=�6,    �� RelativeSource 5�      �� 5�       �� Mode$ FindAncestor=�6'     �� AncestorType"  �6;   6\   5�      5�      5�      5�      5�      5�      5�      5�      