   M S B A M L   `   `   `  ����  AlcoolTestWpf2024)    #AlcoolTestWpf2024.UserProfileWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Profil utilisateur��5   	   $	��250��6$   $	��400��61    � WindowStartupLocation$ CenterScreen=�6=   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��50 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6    $��Profil utilisateur��64   $��Center=�5      $��16(�6-   $
��Bold"�6;   $��0,0,0,20q�6M   �� 5   
   $��1��6   $��Poids (en kg):��6   $��Center=�66   �� 5   
   -   5         ��Name$ PoidsTextBox��5      $	��150��6(   $��2��64   $��114,51,96,0q�6H   $��2��6]   �� 5   
   $��2��6   $��Sexe:��6   $��Center=�6-   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��2��6;   $��120,25,30,-25q�6O   .+�5      	� -   5         	�Name$ HommeRadioButton��5      $��Homme��64    	� 	GroupName$
 Sexe��6D    d� 	IsChecked$
 TrueY�6U   $��0,0,20,0q�6f   	� 5      -   5        $ FemmeRadioButton��5      $��Femme��64   $
 Sexe��6D   5      �� 5    
   -   5        $��Enregistrer��5       $��2��6'   $��0��64   $��2��6D   $
��Left=�5!      $	��150��6,   $��114,57,0,-57q�6R   5"      5#      