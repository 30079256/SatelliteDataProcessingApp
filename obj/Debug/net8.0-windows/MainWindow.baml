   M S B A M L   `   `   `  ����U  QSatelliteDataProcessingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SatelliteDataProcessingAppSatelliteDataProcessingApp  5   	   +    %SatelliteDataProcessingApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:SatelliteDataProcessingApp     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Satellite Data Processing��5	   	   $	��450��6+   $	��800��68   .��5
      � .+�5   
   %  Xceed.Wpf.Toolkit.IntegerUpDown  -   5          Name$ IntegerUpDownSigma��5      �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   FormatString$ N0��69   $��20,20,700,370q�6K   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Value 106b      Minimum 106m      Maximum 206z     5   
   -   5        $ IntegerUpDownMu��5      $ N0��66   $��100,20,620,370q�6H    506`    356k    756x   �� 5   
   -   5         ��Name$ ListviewSensor��5      $��10,70,608,35q�6+    �� View 5      �� 5      .P�5      �� -   5        GridViewColumnSensorA��$��Sensor A��5   D    �� DisplayMemberBinding 6V   �� *	SensorA+�� 5      -   5        GridViewColumnSensorB��$��Sensor B��5   D    6V   �� *	SensorB+5      5      �� 5   
   $��Sigma��6   $
��Left=�6    $��19,0,0,0q�6;   $	��Top=�6M   $��26��6e   �� 5   
   $��Mu��6   $
��Left=�6   $��	102,0,0,0q�68   $	��Top=�6K   �� 5   
   -   5        	 ��Name$	 ButtonLoadSensorData��5      $��Load Sensor Data��6/   $
��Left=�6J   $��	20,45,0,0q�6e   $	��Top=�6x   $	��146��6�   6�   �� 5   
   $��Sensor A��6   $
��Left=�6#   $��	244,0,0,0q�6>   $	��Top=�6Q   �� 5   
   -   5        $	 ButtonIterativeSearchA��5      $��Search��61   $
��Left=�6B   $��
244,40,0,0q�6]   $	��Top=�6q   $��57��6�   6�   �� 5   
   $��Binary Search Iterative��6   $
��Left=�62   $��
239,16,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        
 ��Name$
 TextBoxIterativeSearchA��5      $
��Left=�63   $��
244,70,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��110��6�    �� 
IsReadOnly$
 True��6�   �� 5   
   -	   5        $	 ButtonRecursiveSearchA��5      $��Search��61   $
��Left=�6B   $��248,127,0,0q�6]   $	��Top=�6r   $��57��6�   6�   �� 5   
   $��Binary Search Recursive��6   $
��Left=�62   $��243,105,0,0q�6M   $	��Top=�6b   �� 5   
   -
   5        $
 TextBoxRecursiveSearchA��5      $
��Left=�63   $��248,157,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��110��6�   $
 True��6�   �� 5   
   -   5        $
 TextBoxSearchTargetA��5      $
��Left=�60   $��305,187,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $��53��6�   6�   �� 5    
   $��Search Target��6   $
��Left=�6(   $��224,183,0,0q�6C   $	��Top=�6X   �� 5!   
   -   5        $
 TextBoxSelectionSortA��5!      $
��Left=�61   $��250,276,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $
 True��6�   �� 5"   
   $��Selection Sort��6   $
��Left=�6)   $��248,223,0,0q�6D   $	��Top=�6Y   �� 5#   
   -   5        $	 ButtonSelectionSortA��5#      $
��Sort��6/   $
��Left=�6>   $��253,247,0,0q�6Y   $	��Top=�6n   $��52��6�   6�   �� 5$   
   -   5        $
 TextBoxInsertionSortA��5$      $
��Left=�61   $��250,367,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $
 True��6�   �� 5%   
   $��Insertion Sort��6   $
��Left=�6)   $��248,314,0,0q�6D   $	��Top=�6Y   �� 5&   
   -   5        $	 ButtonInsertionSortA��5&      $
��Sort��6/   $
��Left=�6>   $��253,338,0,0q�6Y   $	��Top=�6n   $��52��6�   6�   �� 5'   
   -   5         ��Name$ ListBoxSensorA��5'      $��382,22,304,35q�6*    �� SelectionMode$ Multiple=�6A   �� 5(   
   $��Sensor B��6   $
��Left=�6#   $��	520,0,0,0q�6>   $	��Top=�6Q   �� 5)   
   $��Binary Search Iterative��6   $
��Left=�62   $��
508,16,0,0q�6M   $	��Top=�6a   �� 5*   
   -   5        $	 ButtonIterativeSearchB��5*      $��Search��61   $
��Left=�6B   $��
515,40,0,0q�6]   $	��Top=�6q   $��57��6�   6�   �� 5+   
   -   5        $
 TextBoxIterativeSearchB��5+      $
��Left=�63   $��
517,70,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��110��6�   $
 True��6�   �� 5,   
   $��Binary Search Recursive��6   $
��Left=�62   $��508,105,0,0q�6M   $	��Top=�6b   �� 5-   
   -   5        $	 ButtonRecursiveSearchB��5-      $��Search��61   $
��Left=�6B   $��515,127,0,0q�6]   $	��Top=�6r   $��57��6�   6�   �� 5.   
   -   5        $
 TextBoxRecursiveSearchB��5.      $
��Left=�63   $��517,157,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��110��6�   $
 True��6�   �� 5/   
   $��Search Target��6   $
��Left=�6(   $��501,183,0,0q�6C   $	��Top=�6X    J� RenderTransformOrigin$ -0.008,0.656&�6p   �� 50   
   -   5        $
 TextBoxSearchTargetB��50      $
��Left=�60   $��582,187,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $��53��6�   6�   �� 51   
   $��Selection Sort��6   $
��Left=�6)   $��508,223,0,0q�6D   $	��Top=�6Y   �� 52   
   -   5        $	 ButtonSelectionSortB��52      $
��Sort��6/   $
��Left=�6>   $��515,247,0,0q�6Y   $	��Top=�6n   $��52��6�   6�   �� 53   
   -   5        $
 TextBoxSelectionSortB��53      $
��Left=�61   $��512,276,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $
 True��6�   �� 54   
   $��Insertion Sort��6   $
��Left=�6)   $��509,314,0,0q�6D   $	��Top=�6Y   �� 55   
   -   5        $	 ButtonInsertionSortB��55      $
��Sort��6/   $
��Left=�6>   $��515,338,0,0q�6Y   $	��Top=�6n   $��52��6�   $ 5.195,0.641&�6�   6�   �� 56   
   -   5        $
 TextBoxInsertionSortB��56      $
��Left=�61   $��512,367,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $
 True��6�   �� 57   
   -   5        $ ListBoxSensorB��57      $��661,22,25,35q�6*   $ Multiple=�6@   �� 58   
   $��Bottom=�6   .@�59      �� .��5:      �� -   5         ��Name$ StatusLabelFeedback��5:      $�� ��69   5;      5<      5=      5>      