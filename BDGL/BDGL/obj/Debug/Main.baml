   M S B A M L   `   `   `  ����?  ;BDGL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BDGLBDGL  5   	       	BDGL.Main   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:BDGL     5   	      BDGL.CWindow    KeyDown$  Window_KeyDown��5   �    � Title$" BIBA - DigiLab Game Launcher��6	   $	��480��6.   $	��320��6:    � WindowStartupLocation$ CenterScreen=�6G    � 
ResizeMode$ NoResize=�6l   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      CaptionHeight$ 32Q�6   %  System.Windows.SystemParameters"   WindowResizeBorderThickness   ResizeBorderThickness# Z 6*    � 	Resources 5         UnlockAnimation	 �� 
TargetName
 �� TargetProperty	 W� By g� Duration W� From	 W� To  LockAnimation  FadeOutAnimation��%�  &	        &	 �    &	 �    �� 5   
   .��5      W� $	 MovingPImage��6   $3
 -(Path.RenderTransform).(TranslateTransform.X)�6C   $
 -268X�6�   $ 0:0:0.2D�6�   6�   W� 5      $	 MovingPImage��6   $
 Opacity�6C   $ 1X�6g   $ 0X�6p   $ 0:0:0.6D�6w   W� 5      $	 MovingPImage��6   $
 Width�6C   $	 128X�6e   $ 64X�6p   $ 0:0:0.4D�6x   W� 5      $	 MovingPImage��6   $
 Height�6C   $	 128X�6f   $ 64X�6q   $ 0:0:0.4D�6y   5      �� 5   
   .��5      W� $	 MovingPImage��6   $3
 -(Path.RenderTransform).(TranslateTransform.X)�6C   $
  268X�6�   $ 0:0:0.2D�6�   6�   W� 5      $	 MovingPImage��6   $
 Opacity�6C   $ 0X�6g   $ 1X�6p   $ 0:0:0.6D�6w   W� 5      $	 MovingPImage��6   $
 Width�6C   $ 64X�6e   $	 128X�6o   $ 0:0:0.4D�6x   W� 5      $	 MovingPImage��6   $
 Height�6C   $ 64X�6f   $	 128X�6p   $ 0:0:0.4D�6y   5      �� 5   
   .��5      W� $	 AvatarImage��6   $
 Width�6B   $ 64X�6d   $	 128X�6n   $ 0:0:0.4D�6w   W� 5      $	 AvatarImage��6   $
 Height�6B   $ 64X�6e   $	 128X�6o   $ 0:0:0.4D�6x   5      5      .��5      � -   5         �Name$ GridMain��5      $��0��6   $	��480��6*   $	��320��66   ���#2a2e33 � RowDefinitions 5   
   �� 5       $
��320* �6   �� 5!      $��0* �6   �� 5"      $��0* �6   �� 5#      .+�5%   
   �� ���#2a2e33
�������$��1,1,1,1q�6>   $��4��6X   6k   �� 5&   
   -   5         ��Name$ TitelBar��5&      $"��BIBA - DigiLab Game Launcher��6"   $	��Top=�6I   $"��./Resources/Fonts/#Agency FB)�6a   $��14(�6�   
�������$��28��6�   �� 5'   
   -   5         �� EdgeMode$ Aliased=�5'   /     TitleBarButtonStyle#��[ 6P   $��434,4,26,295q�6}   .��5(      F� $��12��6   $��12��6     minimize_vct#��[ 6*    �� Stretch$
 Fill=�6�   ��6P   ��  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ��6�   5)      �� 5*   
   -   5         ��Name$ CloseBtn��5*      #��[ 6>   $��456,4,4,295q�6k   .��5+      F� $��12��6   $��12��6     	close_vct#��[ 6*   $
 Fill=�6�   ��6M   �� $ 
Foreground� �� " ��6�   5,      �� 5-   
   -   5         ��Name$ AvatarImage��5-      $	��128��6%   $	��128��61   $
��Fill=�6>   $��60,42,292,149q�6M   6g   F� 5.   
   -   5         F�Name$ MovingPImage��5.        profile_vct#��[ 6%   
�������$	��128��6W   $	��128��6c   $
 Fill=�6p   $��328,42,24,149q�6   z�5/      T� 50      52      � 53   
   -   5        $ 	loginGrid��53      $��4��6"   $y�Visible=�63   .+�54      �� -   5         ��Name$ usernameTXTbox��54      $
��Left=�6.   $��23��6I   $��	60,72,0,0q�6U   $	��Top=�6h   $��Center=�6�   $	��200��6�   $"��./Resources/Fonts/#Agency FB)�6�    �� 	MaxLength$ 20��6�   $��14(�6�   ���#2a2e33
�������6  �� 55      -	   5        $ usernameLabel��55      $��Username��6+   $
��Left=�6>   $��
202,72,0,0q�6Y   $	��Top=�6m   $"��./Resources/Fonts/#Agency FB)�6�   $��16(�6�   
�������6�   �� 56      -
   5        $ usernameICO��56      $��20��6)   $��20��65   $��38,73.5,422,226.5q�6@   $%��./Resources/Icons/userlogin.png��6[   �� 57      -   5        $ passwordICO��57      $��20��6)   $��20��65   $��38,111,422,189q�6@   $$��./Resources/Icons/userlock.png��6Y   �� 58      -   5        $ passwordTXTbox��58      $
��Left=�6/   $��24��6J   $��
60,109,0,0q�6V   $	��Top=�6j   $��Center=�6�   $	��200��6�   $!��./Resources/Fonts/#Password)�6�   $ 20��6�   $��14(�6�   ���#2a2e33
�������6  �� 59      -   5        $ passwordLabel��59      $��Password��6+   $
��Left=�6>   $��204,110,0,0q�6Y   $	��Top=�6n   $"��./Resources/Fonts/#Agency FB)�6�   $��16(�6�   
�������$��27��6�   $��59��6�   �� 5:      -   5        $ pwEyeBtn��5:      
������ 
������ $��18��6Z   $��20��6f   $��265,112,195,188q�6q    5;        	Unpressed  Pressed��%�   &	       &	 S     �� 5<      .R�5=      �� $%��./Resources/Icons/pw_unhide.png��6    5>      �� 5?      .R�5@      �� $"��./Resources/Icons/pw_aye.png��6    5A      5B      ��5C      �� 5D       �� 
TargetType" ��6   .�5E      ��  �� Property � �� �� Value
 ���� 67   �� 5F       � �� 5G      �� 5H   "    �� 
TargetType" ��62   .R�5I   &   �� #��z��6-   ._�5J   *   �� $��Center=�6;   $��Center=�6X   5K   '   5L   #   5N      �� 5O       � ��# [ 6<     �� Triggers  5P      P� 5Q      ! P� Property! � ��" P� Value" . . �5R   "   ��  � ��# [ 6D   5S      5U      5W      �� 5X      -   5        $ 
newUserBtn��5X       	 ButtonStyle#��[	 6+   $$��CREATE YOUR DIGILAB ACCOUNT...��6P   $��278,250,12,46q�6y   $��24��6�   $"��./Resources/Fonts/#Agency FB)�6�   $��14(�6�   6�   5Y      � 5Z   
   -   5        $ confirmationGrid��5Z      $��4��6)   $y�Hidden=�6:   .+�5[      �� $��Center=�6   $��0,61,0,0q�61   $	��Top=�6C   
�������$U��OPlease confirm your account by entering the code that was sent to you by Email.��6n   $��29��6�   $	��426��6�   5\      � 5]   
   -   5        $ mainMenuGrid��5]      $��4��6%   $y�Hidden=�66   .+�5^      �� -   5        $ appsAndGamesDashboardBtn��5^      $��
Start Game��69   $��253,63,51,225q�6O   $"��./Resources/Fonts/#Agency FB)�6g   $��14(�6�   6�   5_      �� 5`   
   -   5        $ loginBtn��5`      #��[	 6#   $��LOGIN��6H   $��Center=�6X   $��60,189,292,0q�6u   $	��Top=�6�   $	��128��6�   $��24��6�   $"��./Resources/Fonts/#Agency FB)�6�   $��14(�6�   {�.  6  �� 5a   
   -   5        $ msgLabel��5a      $
��Left=�6"   $��
10,218,0,0q�6=   $	��Top=�6Q   
�������$��27��6|   $	��454��6�   �� 5b   
   # �� Orientation$# Vertical=�6   $��10,240,10,74q�6,   .+�5c      �� #��["�6   5d      � 5e   
   -   5        $ AccountRecoveryGrid��5e      $��4��6,   $y�Hidden=�6=   $��
0,28,10,10q�6Q   .+�5f      �� $
��Left=�6   $��	18,10,0,0q�6/   $	��Top=�6B   $"��./Resources/Fonts/#Agency FB)�6Z   $��16(�6�   
�������$��68��6�   $	��452��6�   .��5g      ��  Forgot your login credentials?�� 6;   .,To receive a recovery code for your account,�� 6t   64please enter the email address you used to register.6�   5h      �� 5i      -   5        $! sendRecoveryCodeEmailTXTbox��5i      $
��Left=�6<   $��24��6W   $��	24,85,0,0q�6c   $	��Top=�6v   $��Center=�6�   $	��280��6�   $"��./Resources/Fonts/#Agency FB)�6�   $ 40��6�   $��14(�6�   ���#2a2e33
�������6  �� 5j      -   5        $ passwordLabe��5j      $��email��6*   $
��Left=�6:   $��
268,83,0,0q�6U   $	��Top=�6i   $"��./Resources/Fonts/#Agency FB)�6�   $��16(�6�   
�������$��26��6�   $��37��6�   5k      5l      5m      