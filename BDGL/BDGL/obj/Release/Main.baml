   M S B A M L   `   `   `  ���� ?  ;BDGL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BDGLBDGL      	BDGL.Main   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:BDGL        BDGL.CWindow    KeyDown$  Window_KeyDown�� � Title$" BIBA - DigiLab Game Launcher��$	��480��$	��320�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�'  !System.Windows.Shell.WindowChrome   WindowChrome      CaptionHeight$ 32Q�%  System.Windows.SystemParameters"   WindowResizeBorderThickness   ResizeBorderThickness# Z  � 	Resources    UnlockAnimation	 �� 
TargetName
 �� TargetProperty	 W� By g� Duration W� From	 W� To  LockAnimation  FadeOutAnimation��%'  &	        &	 <    &	 x    �� .��W� $	 MovingPImage��$3
 -(Path.RenderTransform).(TranslateTransform.X)�$
 -268X�$ 0:0:0.2D�W� $	 MovingPImage��$
 Opacity�$ 1X�$ 0X�$ 0:0:0.6D�W� $	 MovingPImage��$
 Width�$	 128X�$ 64X�$ 0:0:0.4D�W� $	 MovingPImage��$
 Height�$	 128X�$ 64X�$ 0:0:0.4D��� .��W� $	 MovingPImage��$3
 -(Path.RenderTransform).(TranslateTransform.X)�$
  268X�$ 0:0:0.2D�W� $	 MovingPImage��$
 Opacity�$ 0X�$ 1X�$ 0:0:0.6D�W� $	 MovingPImage��$
 Width�$ 64X�$	 128X�$ 0:0:0.4D�W� $	 MovingPImage��$
 Height�$ 64X�$	 128X�$ 0:0:0.4D��� .��W� $	 AvatarImage��$
 Width�$ 64X�$	 128X�$ 0:0:0.4D�W� $	 AvatarImage��$
 Height�$ 64X�$	 128X�$ 0:0:0.4D�.��� -    �Name$ GridMain��$��0��$	��480��$	��320�����#2a2e33 � RowDefinitions �� $
��320* ��� $��0* ��� $��0* ��� .+��� ���#2a2e33
�������$��1,1,1,1q�$��4���� -    ��Name$ TitelBar��$"��BIBA - DigiLab Game Launcher��$	��Top=�$"��./Resources/Fonts/#Agency FB)�$��14(�
�������$��28���� -    �� EdgeMode$ Aliased=�  TitleBarButtonStyle#��[ $��434,4,26,295q�.��F� $��12��$��12��  minimize_vct#��[  �� Stretch$
 Fill=�����  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ���� -    ��Name$ CloseBtn��#��[ $��456,4,4,295q�.��F� $��12��$��12��  	close_vct#��[ $
 Fill=����� $ 
Foreground� �� " ���� -    ��Name$ AvatarImage��$	��128��$	��128��$
��Fill=�$��60,42,292,149q�F� -    F�Name$ MovingPImage��  profile_vct#��[ 
�������$	��128��$	��128��$
 Fill=�$��328,42,24,149q�z�T� � -   $ 	loginGrid��$��4��$y�Visible=�.+��� -    ��Name$ usernameTXTbox��$
��Left=�$��23��$��	60,72,0,0q�$	��Top=�$��Center=�$	��200��$"��./Resources/Fonts/#Agency FB)� �� 	MaxLength$ 20��$��14(����#2a2e33
��������� -	   $ usernameLabel��$��Username��$
��Left=�$��
202,72,0,0q�$	��Top=�$"��./Resources/Fonts/#Agency FB)�$��16(�
��������� -
   $ usernameICO��$��20��$��20��$��38,73.5,422,226.5q�$%��./Resources/Icons/userlogin.png���� -   $ passwordICO��$��20��$��20��$��38,111,422,189q�$$��./Resources/Icons/userlock.png���� -   $ passwordTXTbox��$
��Left=�$��24��$��
60,109,0,0q�$	��Top=�$��Center=�$	��200��$!��./Resources/Fonts/#Password)�$ 20��$��14(����#2a2e33
��������� -   $ passwordLabel��$��Password��$
��Left=�$��204,110,0,0q�$	��Top=�$"��./Resources/Fonts/#Agency FB)�$��16(�
�������$��27��$��59���� -   $ pwEyeBtn��
������ 
������ $��20��$��20��$��265,112,195,188q�.��F�   hide_vct#��[ 
�������$	��0.2��$��20��$��20��
������� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~���  �� Angle$	 180Q�����  �� 
TargetType" ��.���  �� Property � ��  �� Value  �� ! �� 
TargetType"! ��.R�� #��z��.+��� " ��Name$" MyContentPresenter��#��z��$��Center=�$��Center=��� -   $ 
newUserBtn��  ButtonStyle#��[ $$��CREATE YOUR DIGILAB ACCOUNT...��$��278,250,12,46q�$��24��$"��./Resources/Fonts/#Agency FB)�$��14(�� -   $ confirmationGrid��$��4��$y�Hidden=�.+��� $��Center=�$��0,61,0,0q�$	��Top=�
�������$U��OPlease confirm your account by entering the code that was sent to you by Email.��$��29��$	��426��� -   $ mainMenuGrid��$��4��$y�Hidden=�.+��� -   $ appsAndGamesDashboardBtn��$��
Start Game��$��253,63,51,225q�$"��./Resources/Fonts/#Agency FB)�$��14(��� -   $ loginBtn��#��[ $��LOGIN��$��Center=�$��60,189,292,0q�$	��Top=�$	��128��$��24��$"��./Resources/Fonts/#Agency FB)�$��14(�{�.  �� -   $ msgLabel��$
��Left=�$��
10,218,0,0q�$	��Top=�
�������$��27��$	��454���� # �� Orientation$# Vertical=�$��10,240,10,74q�.+��� #��["�� -   $ AccountRecoveryGrid��$��4��$y�Hidden=�$��
0,28,10,10q�.+��� $
��Left=�$��	18,10,0,0q�$	��Top=�$"��./Resources/Fonts/#Agency FB)�$��16(�
�������$��68��$	��452��.����  Forgot your login credentials?�� .,To receive a recovery code for your account,�� 64please enter the email address you used to register.�� -   $! sendRecoveryCodeEmailTXTbox��$
��Left=�$��24��$��	24,85,0,0q�$	��Top=�$��Center=�$	��280��$"��./Resources/Fonts/#Agency FB)�$ 40��$��14(����#2a2e33
��������� -   $ passwordLabe��$��email��$
��Left=�$��
268,83,0,0q�$	��Top=�$"��./Resources/Fonts/#Agency FB)�$��16(�
�������$��26��$��37��