   M S B A M L   `   `   `  ����[  WУра новый вариант, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Ура_новый_вариант Ура_новый_вариант  5   	   1    +Ура_новый_вариант.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Ура_новый_вариант     5   	     � Title$  
MainWindow��5   	   $	��560��6   $	��525��6)    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Resources.xaml?�6%   6?   %    5       � DataContext 5      ;   5Ура_новый_вариант.MainWindowsViewModel  5   
   6'   .��5      �� 
������.+�5   
   ��  
  Header#��[  6   Регистрация6A   � 5   
   $��20q�6   
������� � ColumnDefinitions 5      �� 5      $��2* �6#   60   �� 5      $��7* �6#   60    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"   .+�5      �� $��0��6;   $��0��6H     
LabelStyle#��[ 6X    �� Target 6   ��  �� ElementName$ Surname��.��6|   Фамилия6�   �� 5       -   5        $��Surname��5       $��0��6%   $��1��62     TopTextBoxStyle#��[ 6B   .��6k   .��5!      �� 	 �� Path$	 Surname�6   
 �� Mode$
 TwoWay=�6)    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6T    �� NotifyOnValidationError .  �� ValidationRules 5"      =   7Ура_новый_вариант.NotEmptyValidationRule  5#      69   5%      5&      �� 5'      $��1��68   $��0��6E   #��[ 6U    6   �� $
 Name��.��6y   Имя6~   �� 5(      -   5        $
��Name��5(      $��1��6"   $��1��6/   #��[ 6?   .��6h   .��5)      �� $
	 Name�6   $
 TwoWay=�6&    . $ PropertyChanged=�6Q    .  5*        5+      69   5-      5.      �� 5/      $��2��6>   $��0��6K   #��[ 6[    6   �� $ 
Patronymic��.��6   Отчество6�   �� 50      -   5        $��
Patronymic��50      $��2��6(   $��1��65   #��[ 6E   .��6n   .��51      �� $	 
Patronymic�6   $
 TwoWay=�6,    . $ PropertyChanged=�6W    .  52        53      69   55      56      57      � 58   
   $��	20,0,20,0q�6   
������� 59      �� 5:      $��3* �6#   60   �� 5;      $��2* �6#   60   �� 5<      $��5* �6#   60    5>      �� 5?      6"   .+�5A      ��   Address#��[ 6   $��0��69   $��0��6F   
Адрес6]   �� 5B      $��0��68   $��1��6E     	CityStyle#��[ 6U    6   �� $
 City��.��6x   
Город6   �� 5C      -   5        $
��City��5C   4   $��0��6   $��2��6$     CityList#��[ 6@    �� DisplayMemberPath$
 Name��5D   [   ��6   �� *Cities+$ PropertyChanged=� �� SelectedItem 5E      �� *SelectedCity+5F      5G      � 5H   
   $��20q�6   
������� 5I      �� 5J      $��3* �6#   60   �� 5K      $��7* �6#   60    5M      �� 5N      6"   .+�5P      �� $��0��6:   $��0��6G     StreetStyle#��[ 6W    6   �� $ Street��.��6|   
Улица6�   �� 5Q      -   5        $��Street��5Q   4   $��0��6   $��1��6$   #��[ 6B   $
 Name��5R   \   ��6   �� *	Streets+$ PropertyChanged=� 5S      �� *SelectedStreet+5T      5U      � 5V   
   $��	20,0,20,0q�6   
������� 5W      �� 5X      $
��0.8* �6#   62   �� 5Y      $��1* �6#   60   �� 5Z      $��1* �6#   60   �� 5[      $��1* �6#   60   �� 5\      $
��0.8* �6#   62   �� 5]      $��1* �6#   60    5_      �� 5`      6"   .+�5b      �� $��0��68   $��0��6E     	HomeLabel#��[ 6U    6   �� $
 Home��.��6x   дом6}   �� 5c      -   5        $
��Home��5c   3   $��0��6   $��1��6#     BottomTextBox#��[ 6?   .��6f   .��5d      �� $
	 Home�6   $
 TwoWay=�6&    . $ PropertyChanged=�6Q    .  5e      @   :Ура_новый_вариант.LessThanMaxValidationRule  5f      6<   5h      5i      �� 5j      $��0��68   $��2��6E    	 HomeCenterLabel#��[	 6U    6   �� $
 StrK��.��6~   корп./стр.6�   �� 5k      -   5        $
��StrK��5k      $��0��6"   $��3��6/   #��[ 6?   .��6f   .��5l      �� $
	 StrK�6   $
 TwoWay=�6&    . $ PropertyChanged=�6Q    .  5m        5n      6<   5p      5q      �� 5r      $��0��6>   $��4��6K   #��[	 6[    6   �� $ 
Apartament��.��6�   кв6�   �� 5s      -   5        $��
Apartament��5s   3   $��0��6   $��5��6#    
 BottomRightTextBox#��[
 6E   .��6q   .��5t      �� $	 
Apartament�6   $
 TwoWay=�6,    . $ PropertyChanged=�6W    .  5u        5v      6<   5x      5y      5z      � 5{   
   $��10,30,10,30q�6    5|      �� 5}      $��3* �6#   60   �� 5~      $��5* �6#   60   �� 5      $��2* �6#   60   �� 5�      $��5* �6#   60   �� 5�      $��3* �6#   60    5�      �� 5�      6"   .+�5�      �� $��1��6   $��0��6%     
SaveButton#��[ 62   ��6V   �� *Save+$
 TwoWay=���6|   �� .��6�   Сохранить6�   �� 5�      $��3��6   $��0��6%     CancelButton#��[ 62   $��18(�6X   $��5q�6f   ��6r   �� *Cancel+$
 TwoWay=���6�   �� .��6�   Отмена6�   5�      5�      5�      