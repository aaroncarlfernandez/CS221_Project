   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      e aSystem.Activities.Presentation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35wTclr-namespace:System.Activities.Presentation;assembly=System.Activities.PresentationSystem.Activities.Presentation 5      �Yclr-namespace:System.Activities.Presentation.View;assembly=System.Activities.Presentation#System.Activities.Presentation.View 5	      �_clr-namespace:System.Activities.Presentation.Converters;assembly=System.Activities.Presentation)System.Activities.Presentation.Converters 5
       CS221_Events9   3CS221_Events.ActivityDesigners.RandomNumberDesigner   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      4s&clr-namespace:System;assembly=mscorlib     5      dsadTclr-namespace:System.Activities.Presentation;assembly=System.Activities.Presentation     5      jsadvYclr-namespace:System.Activities.Presentation.View;assembly=System.Activities.Presentation     5	      psadc_clr-namespace:System.Activities.Presentation.Converters;assembly=System.Activities.Presentation     5
      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      8  2System.Activities.Presentation.WorkflowViewElement    Collapsible  .  J� 	AllowDrop .    ExpandState .   � 	Resources 5      M  GSystem.Activities.Presentation.Converters.ArgumentToExpressionConverter !  argumentToExpressionConverter�� 5      ResourceDictionary_1��%F   &	          5      ($sadv:ArgumentToExpressionConverter_2��6X   5      .��5      � -   5        $��grid1��5      $��81��6	    � RowDefinitions 5      �� 5      $	��23* �6   �� 5      $	��23* �6   �� 5      $	��23* �6    � ColumnDefinitions 5      �� 5      $	��95* �6   �� 5      $
��138* �6   .+�5   
   �� -   5        $��labelNum��5   H   $��Number��6   $��23��6!   $
��Left=�6-   $	��Top=�6X   �� 5    
   -   5        $��	labelFrom��5    c   $
��From��6   $��23��6   $��0��6+   $��1��6;   $
��Left=�6H   $	��Top=�6t   �� 5!   
   -   5        $��labelTo��5!   a   $��To��6   $��23��6   $��0��6)   $��2��69   $
��Left=�6F   $	��Top=�6p   ;  5System.Activities.Presentation.View.ExpressionTextBox  5#   
   -   5        $��
ctrlNumber��5#   e   $��1��6!   $��0��61   $��23��6>   $
��Left=�6J   $	��Top=�6w   $	��139��6�   4  .System.Windows.Automation.AutomationProperties   AutomationId$ Number��5$   !      ExpressionType" ��5&   !      UseLocationExpression . 	   
Expression	 5%   !   �� 
 �� Path$
 ModelItem.Number� �� Mode$ TwoWay=� �� 	Converter# [   �� ConverterParameter$	 Out��   OwnerActivity 5'   !   �� $
 	ModelItem�$ OneWay=�5(   !     5+   
   -   5        $��ctrlFrom��5+   e   $��1��6!   $��1��61   $��23��6>   $
��Left=�6J   $	��Top=�6u   $	��139��6�   $
 From��5,   !   " ��5.   !   	 5-   !   �� $
 ModelItem.From�$ TwoWay=�# [  $ In�� 5/   !   �� $
 	ModelItem�$ OneWay=�  52   
   -   5        $��ctrlTo��52   e   $��1��6!   $��2��61   $��23��6>   $
��Left=�6J   $	��Top=�6s   $	��139��6�   $ To��53   !   " ��55   !   	 54   !   �� $
 ModelItem.To�$ TwoWay=�# [  $ In�� 56   !   �� $
 	ModelItem�$ OneWay=�59      5:      