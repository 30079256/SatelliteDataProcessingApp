   M S B A M L   `   `   `  ���� U  QSatelliteDataProcessingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SatelliteDataProcessingAppSatelliteDataProcessingApp  +    %SatelliteDataProcessingApp.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :local(clr-namespace:SatelliteDataProcessingApp     ] YXceed.Wpf.Toolkit.NET5, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$  Satellite Data Processing��$	��450��$	��800��.��� .+�%  Xceed.Wpf.Toolkit.IntegerUpDown  -     Name$ IntegerUpDownSigma���  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   FormatString$ N0��$��20,20,700,370q��  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Value 10   Minimum 10   Maximum 20  -   $ IntegerUpDownMu��$ N0��$��100,20,620,370q� 50 35 75�� -    ��Name$ ListviewSensor��$��10,70,608,35q� �� View �� .P��� -   GridViewColumnSensorA��$��Sensor A�� �� DisplayMemberBinding �� *	SensorA+�� -   GridViewColumnSensorB��$��Sensor B�� �� *	SensorB+�� $��Sigma��$
��Left=�$��19,0,0,0q�$	��Top=�$��26���� $��Mu��$
��Left=�$��	102,0,0,0q�$	��Top=��� -   	 ��Name$	 ButtonLoadSensorData��$��Load Sensor Data��$
��Left=�$��	20,45,0,0q�$	��Top=�$	��146���� $��Sensor A��$
��Left=�$��	244,0,0,0q�$	��Top=��� -   $	 ButtonIterativeSearchA��$��Search��$
��Left=�$��
244,40,0,0q�$	��Top=�$��57���� $��Binary Search Iterative��$
��Left=�$��
239,16,0,0q�$	��Top=��� -   
 ��Name$
 TextBoxIterativeSearchA��$
��Left=�$��
244,70,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��110�� �� 
IsReadOnly$
 True���� -	   $	 ButtonRecursiveSearchA��$��Search��$
��Left=�$��248,127,0,0q�$	��Top=�$��57���� $��Binary Search Recursive��$
��Left=�$��243,105,0,0q�$	��Top=��� -
   $
 TextBoxRecursiveSearchA��$
��Left=�$��248,157,0,0q�$
 Wrap=�$	��Top=�$	��110��$
 True���� -   $
 TextBoxSearchTargetA��$
��Left=�$��305,187,0,0q�$
 Wrap=�$	��Top=�$��53���� $��Search Target��$
��Left=�$��224,183,0,0q�$	��Top=��� -   $
 TextBoxSelectionSortA��$
��Left=�$��250,276,0,0q�$
 Wrap=�$	��Top=�$	��120��$
 True���� $��Selection Sort��$
��Left=�$��248,223,0,0q�$	��Top=��� -   $	 ButtonSelectionSortA��$
��Sort��$
��Left=�$��253,247,0,0q�$	��Top=�$��52���� -   $
 TextBoxInsertionSortA��$
��Left=�$��250,367,0,0q�$
 Wrap=�$	��Top=�$	��120��$
 True���� $��Insertion Sort��$
��Left=�$��248,314,0,0q�$	��Top=��� -   $	 ButtonInsertionSortA��$
��Sort��$
��Left=�$��253,338,0,0q�$	��Top=�$��52���� -    ��Name$ ListBoxSensorA��$��382,22,304,35q� �� SelectionMode$ Multiple=��� $��Sensor B��$
��Left=�$��	520,0,0,0q�$	��Top=��� $��Binary Search Iterative��$
��Left=�$��
508,16,0,0q�$	��Top=��� -   $	 ButtonIterativeSearchB��$��Search��$
��Left=�$��
515,40,0,0q�$	��Top=�$��57���� -   $
 TextBoxIterativeSearchB��$
��Left=�$��
517,70,0,0q�$
 Wrap=�$	��Top=�$	��110��$
 True���� $��Binary Search Recursive��$
��Left=�$��508,105,0,0q�$	��Top=��� -   $	 ButtonRecursiveSearchB��$��Search��$
��Left=�$��515,127,0,0q�$	��Top=�$��57���� -   $
 TextBoxRecursiveSearchB��$
��Left=�$��517,157,0,0q�$
 Wrap=�$	��Top=�$	��110��$
 True���� $��Search Target��$
��Left=�$��501,183,0,0q�$	��Top=� J� RenderTransformOrigin$ -0.008,0.656&��� -   $
 TextBoxSearchTargetB��$
��Left=�$��582,187,0,0q�$
 Wrap=�$	��Top=�$��53���� $��Selection Sort��$
��Left=�$��508,223,0,0q�$	��Top=��� -   $	 ButtonSelectionSortB��$
��Sort��$
��Left=�$��515,247,0,0q�$	��Top=�$��52���� -   $
 TextBoxSelectionSortB��$
��Left=�$��512,276,0,0q�$
 Wrap=�$	��Top=�$	��120��$
 True���� $��Insertion Sort��$
��Left=�$��509,314,0,0q�$	��Top=��� -   $	 ButtonInsertionSortB��$
��Sort��$
��Left=�$��515,338,0,0q�$	��Top=�$��52��$ 5.195,0.641&��� -   $
 TextBoxInsertionSortB��$
��Left=�$��512,367,0,0q�$
 Wrap=�$	��Top=�$	��120��$
 True���� -   $ ListBoxSensorB��$��661,22,25,35q�$ Multiple=��� $��Bottom=�.@��� .���� -    ��Name$ StatusLabelFeedback��$�� ��