using Galileo6;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Media.Animation;
using System.Collections.ObjectModel;

namespace SatelliteDataProcessingApp
{
    // Student Name: Olga Selezneva
    // Student ID: 30079256
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }
        #region Global Methods
        //4.1 Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic namespace.
        //The data must be of type “double”; you are not permitted to use any additional classes, nodes, pointers or data structures (array, list, etc)
        //in the implementation of this application. The two LinkedLists of type double are to be declared as global within the “public partial class”.
        LinkedList<double> sensorAList = new LinkedList<double>();
        LinkedList<double> sensorBList = new LinkedList<double>();

        //4.2 Copy the Galileo.DLL file into the root directory of your solution folder and add the appropriate reference in the solution explorer.
        //Create a method called “LoadData” which will populate both LinkedLists.
        //Declare an instance of the Galileo library in the method and create the appropriate loop construct to populate the two LinkedList;
        //the data from Sensor A will populate the first LinkedList, while the data from Sensor B will populate the second LinkedList.
        //The LinkedList size will be hardcoded inside the method and must be equal to 400. The input parameters are empty, and the return type is void.
        private void LoadData()
        {            
            try
            {
                ReadData sensorValues = new ReadData();
                int size = 400;

                for (int i = 0; i < size; i++)
                {
                    sensorAList.AddLast(sensorValues.SensorA((double)IntegerUpDownMu.Value, (double)IntegerUpDownSigma.Value));
                }

                for (int i = 0; i < size; i++)
                {
                    sensorBList.AddLast(sensorValues.SensorB((double)IntegerUpDownMu.Value, (double)IntegerUpDownSigma.Value));
                }
            }
            catch (Exception e)
            {
                StatusLabelFeedback.Text = "Load data error: " + e.Message;
            }            
        }

        // 4.3 Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a ListView.
        // Add column titles “Sensor A” and “Sensor B” to the ListView.
        // The input parameters are empty, and the return type is void.
        private void ShowAllSensorData()
        {
            try
            {
                ListviewSensor.Items.Clear();
                for (int i = 0; i < NumberOfNodes(sensorAList); i++)
                {
                    var item = new
                    {
                        SensorA = sensorAList.ElementAt(i),
                        SensorB = sensorBList.ElementAt(i)
                    };

                    ListviewSensor.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                StatusLabelFeedback.Text = "Show all sensor data error: " + e.Message;
            }
        }

        //4.4 Create a button and associated click method that will call the LoadData and ShowAllSensorData methods.
        //The input parameters are empty, and the return type is void.
        private void ButtonLoadSensorData_Click(object sender, RoutedEventArgs e)
        {
            ClearAllViews();            
            LoadData();
            ShowAllSensorData();
        }

        private void ClearAllViews()
        {
            ListviewSensor.Items.Clear();
            sensorAList.Clear();
            sensorBList.Clear();
            TextBoxIterativeSearchA.Text = "";
            TextBoxRecursiveSearchA.Text = "";
            TextBoxSearchTargetA.Text = "";
            TextBoxSelectionSortA.Text = "";
            TextBoxInsertionSortA.Text = "";
            ListBoxSensorA.Items.Clear();
            TextBoxIterativeSearchB.Text = "";
            TextBoxRecursiveSearchB.Text = "";
            TextBoxSearchTargetB.Text = "";
            TextBoxSelectionSortB.Text = "";
            TextBoxInsertionSortB.Text = "";
            ListBoxSensorB.Items.Clear();
            StatusLabelFeedback.Text = "";
        }
        #endregion

        #region Utility Methods
        // 4.5 Create a method called “NumberOfNodes” that will return an integer which is the number of nodes(elements) in a LinkedList.
        // The method signature will have an input parameter of type LinkedList, and the calling code argument is the linkedlist name.
        private static int NumberOfNodes(LinkedList<double> list) => list.Count();

        // 4.6 Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the appropriate ListBox.
        // The method signature will have two input parameters; a LinkedList, and the ListBox name.
        // The calling code argument is the linkedlist name and the listbox name.
        private void DisplayListboxData(LinkedList<double> list, ListBox listbox)
        {
            try
            {
                listbox.Items.Clear();
                foreach (double data in list)
                {
                    listbox.Items.Add(data);
                }
                listbox.UpdateLayout();
            }
            catch (Exception e)
            {
                StatusLabelFeedback.Text = "Display listbox data error: " + e.Message;
            }
        }
        #endregion

        #region Sort and Search Methods
        // 4.7 Create a method called “SelectionSort” which has a single input parameter of type LinkedList,
        // while the calling code argument is the linkedlist name. The method code must follow the pseudo code supplied below in the Appendix.
        // The return type is Boolean.
        private bool SelectionSort(LinkedList<double> list)
        {           
            try
            {
                int min = 0;
                int max = NumberOfNodes(list);
                for (int i = 0; i < max - 1; i++)
                {
                    min = i;

                    for (int j = i + 1; j < max; j++)
                    {
                        if (list.ElementAt(j) < list.ElementAt(min))
                        {
                            min = j;
                        }
                    }

                    LinkedListNode<double> currentMin = list.Find(list.ElementAt(min));
                    LinkedListNode<double> currentI = list.Find(list.ElementAt(i));
                    var temp = currentMin.Value;
                    currentMin.Value = currentI.Value;
                    currentI.Value = temp;
                }
                return true;
            }
            catch (Exception e)
            {
                StatusLabelFeedback.Text = "Selection sort error: " + e.Message;
            }
            return false;
        }
        
        // 4.8 Create a method called “InsertionSort” which has a single parameter of type LinkedList,
        // while the calling code argument is the linkedlist name. The method code must follow the pseudo code supplied below in the Appendix.
        // The return type is Boolean.
        private bool InsertionSort(LinkedList<double> list)
        {
            try
            {
                int max = NumberOfNodes(list);
                for (int i = 0; i < max - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (list.ElementAt(j - 1) > list.ElementAt(j))
                        {
                            LinkedListNode<double> current = list.Find(list.ElementAt(j));
                            var temp = current.Value;
                            current.Value = current.Previous.Value;
                            current.Previous.Value = temp;
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                StatusLabelFeedback.Text = "Insertion sort error: " + e.Message;
            }
            return false;
        }

        // 4.9 Create a method called “BinarySearchIterative” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum.
        // This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value.
        // The calling code argument is the linkedlist name, search value, minimum list size and the number of nodes in the list.
        // The method code must follow the pseudo code supplied below in the Appendix.
        private int BinarySearchIterative(LinkedList<double> list, int searchValue, int minimum, int maximum)
        {
            try
            {
                while (minimum <= maximum - 1)
                {
                    int middle = (minimum + maximum) / 2;
                    if (searchValue == (int)list.ElementAt(middle))
                    {
                        return ++middle;
                    }
                    else if (searchValue < (int)list.ElementAt(middle))
                    {
                        maximum = middle - 1;
                    }
                    else minimum = middle + 1;
                }
                return minimum;
            }
            catch (Exception e)
            {
                StatusLabelFeedback.Text = "Iterative search error: " + e.Message;
            }
            return -1;
        }

        // 4.10 Create a method called “BinarySearchRecursive” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum.
        // This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value.
        // The calling code argument is the linkedlist name, search value, minimum list size and the number of nodes in the list.
        // The method code must follow the pseudo code supplied below in the Appendix.
        private int BinarySearchRecursive(LinkedList<double> list, int searchValue, int minimum, int maximum)
        {
            try
            {
                if (minimum <= maximum - 1)
                {
                    int middle = (minimum + maximum) / 2;
                    if (searchValue == (int)list.ElementAt(middle))
                    {
                        return middle;
                    }
                    else if (searchValue < (int)list.ElementAt(middle))
                    {
                        return BinarySearchRecursive(list, searchValue, minimum, middle - 1);
                    }
                    else
                    {
                        return BinarySearchRecursive(list, searchValue, middle + 1, maximum);
                    }
                }
                return minimum;
            }
            catch (Exception e)
            {
                StatusLabelFeedback.Text = "Recursive search error: " + e.Message;
            }
            return -1;
        }
        #endregion

        #region UI Button Methods
        // 4.11 Create button click methods that will search the LinkedList for an integer value entered into a textbox on the form. The four methods are:
        // 1.Method for Sensor A and Binary Search Iterative
        // 2.Method for Sensor A and Binary Search Recursive
        // 3.Method for Sensor B and Binary Search Iterative
        // 4.Method for Sensor B and Binary Search Recursive
        // The search code must check to ensure the data is sorted, then start a stopwatch before calling the search method.
        // Once the search is complete the stopwatch will stop, and the number of ticks will be displayed in a read only textbox.
        // Finally, the code/method will call the “DisplayListboxData” method and highlight the search target number and two values on each side.
        private void ButtonIterativeSearchA_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (string.IsNullOrWhiteSpace(TextBoxSearchTargetA.Text))
            {
                StatusLabelFeedback.Text = "Empty search target";
                return;
            }

            if (SelectionSort(sensorAList))
            {
                stopwatch.Start();
                int result = BinarySearchIterative(sensorAList, int.Parse(TextBoxSearchTargetA.Text), 0, NumberOfNodes(sensorAList));
                stopwatch.Stop();
                TextBoxIterativeSearchA.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorAList, ListBoxSensorA);

                for (int i = Math.Max(0, result - 2); i <= Math.Min(NumberOfNodes(sensorAList) - 1, result + 2); i++)
                {
                    ListBoxSensorA.SelectedItems.Add(sensorAList.ElementAt(i));
                }

                ListBoxSensorA.ScrollIntoView(ListBoxSensorA.SelectedItems[ListBoxSensorA.SelectedItems.Count - 1]);
                ListBoxSensorA.Focus();
            }
        }

        private void ButtonRecursiveSearchA_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (string.IsNullOrWhiteSpace(TextBoxSearchTargetA.Text))
            {
                StatusLabelFeedback.Text = "Empty search target";
                return;
            }

            if (SelectionSort(sensorAList))
            {
                stopwatch.Start();
                int result = BinarySearchRecursive(sensorAList, int.Parse(TextBoxSearchTargetA.Text), 0, NumberOfNodes(sensorAList));
                stopwatch.Stop();
                TextBoxRecursiveSearchA.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorAList, ListBoxSensorA);

                for (int i = Math.Max(0, result - 2); i <= Math.Min(NumberOfNodes(sensorAList) - 1, result + 2); i++)
                {
                    ListBoxSensorA.SelectedItems.Add(sensorAList.ElementAt(i));
                }

                ListBoxSensorA.ScrollIntoView(ListBoxSensorA.SelectedItems[ListBoxSensorA.SelectedItems.Count - 1]);
                ListBoxSensorA.Focus();
            }
        }

        private void ButtonIterativeSearchB_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (string.IsNullOrWhiteSpace(TextBoxSearchTargetB.Text))
            {
                StatusLabelFeedback.Text = "Empty search target";
                return;
            }

            if (SelectionSort(sensorBList))
            {
                stopwatch.Start();
                int result = BinarySearchIterative(sensorBList, int.Parse(TextBoxSearchTargetB.Text), 0, NumberOfNodes(sensorBList));
                stopwatch.Stop();
                TextBoxIterativeSearchB.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorBList, ListBoxSensorB);

                for (int i = Math.Max(0, result - 2); i <= Math.Min(NumberOfNodes(sensorBList) - 1, result + 2); i++)
                {
                    ListBoxSensorB.SelectedItems.Add(sensorBList.ElementAt(i));
                }

                ListBoxSensorB.ScrollIntoView(ListBoxSensorB.SelectedItems[ListBoxSensorB.SelectedItems.Count - 1]);
                ListBoxSensorB.Focus();
            }
        }

        private void ButtonRecursiveSearchB_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (string.IsNullOrWhiteSpace(TextBoxSearchTargetB.Text))
            {
                StatusLabelFeedback.Text = "Empty search target";
                return;
            }

            if (SelectionSort(sensorBList))
            {
                stopwatch.Start();
                int result = BinarySearchRecursive(sensorBList, int.Parse(TextBoxSearchTargetB.Text), 0, NumberOfNodes(sensorBList));
                stopwatch.Stop();
                TextBoxRecursiveSearchB.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorBList, ListBoxSensorB);

                for (int i = Math.Max(0, result - 2); i <= Math.Min(NumberOfNodes(sensorBList) - 1, result + 2); i++)
                {
                    ListBoxSensorB.SelectedItems.Add(sensorBList.ElementAt(i));
                }

                ListBoxSensorB.ScrollIntoView(ListBoxSensorB.SelectedItems[ListBoxSensorB.SelectedItems.Count - 1]);
                ListBoxSensorB.Focus();
            }
        }

        // 4.12 Create button click methods that will sort the LinkedList using the Selection and Insertion methods. The four methods are:
        // 1.Method for Sensor A and Selection Sort
        // 2.Method for Sensor A and Insertion Sort
        // 3.Method for Sensor B and Selection Sort
        // 4.Method for Sensor B and Insertion Sort
        // The button method must start a stopwatch before calling the sort method.
        // Once the sort is complete the stopwatch will stop, and the number of milliseconds will be displayed in a read only textbox.
        // Finally, the code/method will call the “ShowAllSensorData” method and “DisplayListboxData” for the appropriate sensor.
        private void ButtonSelectionSortA_Click(object sender, RoutedEventArgs e)
        {
            StatusLabelFeedback.Text = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SelectionSort(sensorAList);
            stopwatch.Stop();
            TextBoxSelectionSortA.Text = stopwatch.ElapsedMilliseconds.ToString() + " milliseconds";
            ShowAllSensorData();
            DisplayListboxData(sensorAList, ListBoxSensorA);
        }

        private void ButtonInsertionSortA_Click(object sender, RoutedEventArgs e)
        {
            StatusLabelFeedback.Text = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort(sensorAList);
            stopwatch.Stop();
            TextBoxInsertionSortA.Text = stopwatch.ElapsedMilliseconds.ToString() + " milliseconds";
            ShowAllSensorData();
            DisplayListboxData(sensorAList, ListBoxSensorA);
        }        

        private void ButtonSelectionSortB_Click(object sender, RoutedEventArgs e)
        {
            StatusLabelFeedback.Text = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SelectionSort(sensorBList);
            stopwatch.Stop();
            TextBoxSelectionSortB.Text = stopwatch.ElapsedMilliseconds.ToString() + " milliseconds";
            ShowAllSensorData();
            DisplayListboxData(sensorBList, ListBoxSensorB);
        }

        private void ButtonInsertionSortB_Click(object sender, RoutedEventArgs e)
        {
            StatusLabelFeedback.Text = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort(sensorBList);
            stopwatch.Stop();
            TextBoxInsertionSortB.Text = stopwatch.ElapsedMilliseconds.ToString() + " milliseconds";
            ShowAllSensorData();
            DisplayListboxData(sensorBList, ListBoxSensorB);
        }

        // 4.14 Add textboxes for the search value; one for each sensor, ensure only numeric integer values can be entered.
        private void TextBoxSearchTargetA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
                StatusLabelFeedback.Text = "Only numeric integer values allowed";
            }
            else StatusLabelFeedback.Text = "";
        }

        private void TextBoxSearchTargetB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
                StatusLabelFeedback.Text = "Only numeric integer values allowed";
            }
            else StatusLabelFeedback.Text = "";
        }
        #endregion        
    }
}