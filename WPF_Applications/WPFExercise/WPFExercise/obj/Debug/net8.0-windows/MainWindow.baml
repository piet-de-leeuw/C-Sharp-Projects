   M S B A M L   `   `   `  ����F  BWPFExercise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFExerciseWPFExercise  5   	       WPFExercise.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFExercise     5   	     � Title$  	Todo List��5   	   $	��450��6   $	��400��6(    � 
ResizeMode$ NoResize=�64   .��5	      � ���	#FF4E7743 � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��10 �6   �� 5      $	��100 �6   �� 5      $��50 �6   �� 5      $��10 �6   .+�5   
   �� $��1��6   $��1��6'   ���	#FFF8F9AB.��5      �� -   5         ��Name$ 	TodoStack��5   {   $
��Auto=�6   $
��Auto=�6K   .+�5      �� -   5         ��Name$ DisplayText��5   H   $��1��6   $��1��6,   $�� TODOS:��69   $
��Bold"�6]   5      5      �� 5   
   -   5         ��Name$ TextToWrite��5   b   $��1��6   $��3��6"    �� TextWrapping$
 Wrap=�6/   $��Write Your todo here...��6C   ���	#FFFFFED86w   �� 5!   
   -   5        $��1��5!      $��4��6!   $��Create Todo��6.   
���   �
�������$	��190��6�   $
��Left=�6�   �� 5"   
   -   5        $��1��5"      $��4��6!   $��remove Todo Nr:��6.   ���	#FF676666
�������$	��190��6�   $��Right=�6�   �� 5#   
   -   5        $ 
NrToRemove��5#   8   $��1��6   $��4��6"   $��1��6/   $��30��6L   $��25��6W   $��Right=�6c   $��0,0,15,0q�6    �� TextAlignment$ Center=�6�   $��15(�6�   ���	#FF9C9797
�������
�������6�   5(      5)      