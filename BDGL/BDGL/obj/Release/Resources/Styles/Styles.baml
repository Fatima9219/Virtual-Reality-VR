   M S B A M L   `   `   `  ���� R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   EnabledBrush  �� 
StartPoint �� EndPoint � Offset � Color �� A �� R �� G �� B  DisabledBrush  MouseOverBrush  MouseDownBrush  ButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value  ControlButtonStyle ��Name J� SnapsToDevicePixels ��Name �� Triggers �� 
TargetName  TitleBarButtonStyle'   !System.Windows.Shell.WindowChrome  WindowMainPanelStyle  WindowBorderBrush �� Binding �� RelativeSource �� AncestorType �� Path �� Value �� 
Background �� Bullet �� CornerRadius F�Name �� Color'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup    States   System.Windows.VisualState!   
Storyboard" �� 
TargetName# �� TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame$ �� KeyTime% �� Value& R� KeyTime  System.Windows.Visibility'   Visible( R� Value�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %b  &	        &	 �     &	 ,    &	 �    &	 X    7  7   7  7  &	 �    '�� c    &	 �    &	     '�� �    �� $  0.5,0&�$ 0.5,1&�.��� $ 0Q� �� $	 255��$ 67��$ 73��$ 83��� $ 1Q� �� $	 255��$ 51��$ 56��$ 63���� $  0.5,0&�$ 0.5,1&�.��� $ 0Q� �� $	 255��$ 45��$ 49��$ 54��� $ 1Q� �� $	 255��$ 45��$ 49��$ 54���� $  0.5,0&�$ 0.5,1&�.��� $ 0Q� �� $	 255��$ 30��$ 73��$ 83��� $ 1Q� �� $	 255��$ 40��$ 70��$ 70���� $  0.5,0&�$ 0.5,1&�.��� $ 0Q� �� $	 255��$ 43��$ 47��$ 52��� $ 1Q� �� $	 255��$ 49��$ 54��$ 60���� " ��.��� 	 �@�OverridesDefaultStyle
 . �� 	 � ��

 ������� 	 � ��
 �� " ��.R�� #��z��.+��� $ MyContentPresenter��#��z��$��Center=�$��Center=� P�  � {� .  . ��� 	 � ��8
   �� 	 � ��

 �����P�  � {� . . ��� 	 � ��8
  P�  �@J�IsMouseOver . . ��� 	 � ��8
  P�  � �� . . ��� 	 � ��8
  �� " �� P�  �@J�IsMouseOver . . ��� 	 � ��

 �����P�  �@J�IsMouseOver .  . ��� 	 � ��

 ������� " ��.��� 	 � ��
 �� " ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=� P�  � {� .  . ��� $ border��	 �@J�Opacity$

 0.56Q�P�  �@J�	IsFocused . . ��� $ border��	 � ��

 ������� " ��.��� 	 � ��#
 � ���� 	 � ��$
 0q���  	 �@  IsHitTestVisibleInChrome
 . �� 	 � ��
 .  �� 	 � ��
 �� " ��.R��� $ border��
������ $��0q� . ._��� $ contentPresenter��$��0q�$��Center=�$��Center=�|�.  ��.  P�  �@J�IsMouseOver . . ��� 	 � ��

 �����P�  � �� . . ��� 	 � ��

 ������� " ��.��� 	 � ��#
 �  �� 	 � ��$
 1q� ��  ��  �� *FindAncestor+" �$ WindowState� 	Maximized.a��� 	 � ��$
 6q��� " ��.��� 	 �@J�SnapsToDevicePixels
 . �� 	 �@�OverridesDefaultStyle
 . �� 	 � ��
 �� " ��.R��� 
 ����  �� $ Border��$��13��$��13��$ 0��$��1q����� $	  0,0&�$	 0,1&���� � $ 	Gainsboro��$	 0.0Q�� $ 	Gainsboro��$	 1.0Q����� $	  0,0&�$	 0,1&���� � $ Transparent��� $ Transparent��$	 1.0Q�._�� .+�F� $ 	CheckMark��$y�	Collapsed=�$��7��$��7�� .  $��2��+����        ���j ��j �    ��j ���j     	���� $ White��F� $ InderminateMark��$y�	Collapsed=�$��7��$��7�� .  $��2������    ��j ���j     	���� $
 Gray��   CommonStates��.    
Normal��  	MouseOver��.! �� .���� $" Border��$N# H(Panel.Background).(GradientBrush.GradientStops)[1].(GradientStop.Color)�.g�  $$ 0��$% Transparent��  Pressed��.! �� .���� $" Border��$N# H(Panel.Background).(GradientBrush.GradientStops)[1].(GradientStop.Color)�.g�  $$ 0��$% Transparent���� $" Border��$P# J(Border.BorderBrush).(GradientBrush.GradientStops)[0].(GradientStop.Color)�.g�  $$ 0��$
% Gray���� $" Border��$P# J(Border.BorderBrush).(GradientBrush.GradientStops)[1].(GradientStop.Color)�.g�  $$ 0��$% Transparent��  Disabled��  CheckStates��.    Checked��.! �� .��T� $# (UIElement.Visibility)�$" 	CheckMark��..�i� $& 0��#( Z'   	Unchecked��  Indeterminate��.! �� .��T� $# (UIElement.Visibility)�$" InderminateMark��..�i� $& 0��#( Z' ._��� $��4,0,0,0q�$��Center=�$
��Left=���. 