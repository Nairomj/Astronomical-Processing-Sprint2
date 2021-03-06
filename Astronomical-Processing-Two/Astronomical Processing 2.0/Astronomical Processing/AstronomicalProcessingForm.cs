using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// J Moriancumer Esguerra, Zachary Purkiss,  Sprint Two
// 11/10/2021
// Version: 2.2
// Astronomical Processing
// Program uses an array of 24 integers to sort, search, add, delete, edit and auto fill list

namespace Astronomical_Processing
{
    public partial class AstronomicalProcessing : Form
    {
        public AstronomicalProcessing()
        {
            InitializeComponent();
            toolTip.SetToolTip(ButtonSort, "Sorts data set in ascending order");
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(ButtonEditItem, "Modify the selected data item");
            toolTip.SetToolTip(ButtonAddItem, "Add a new data into the data set");
            toolTip.SetToolTip(ButtonDeleteItem, "Removes an existing data item from the data set");
            toolTip.SetToolTip(ButtonSearch, "Search a data item using binary search algorithm");
            toolTip.SetToolTip(ButtonSeqSearch, " Search a data item using sequential search algorithm");
            toolTip.SetToolTip(ButtonFillData, "Generates 24 random integers into the data set");
            toolTip.SetToolTip(ButtonMidExtreme, "Calculates the mid-extreme of the data set");
            toolTip.SetToolTip(ButtonMode, "Calculates the mode of the data set and it's frequency");
            toolTip.SetToolTip(ButtonAverage, "Calculates the mean average of the data set");
            toolTip.SetToolTip(ButtonRange, "Calucaltes the range of the data set");
            toolTip.SetToolTip(ClearDataButton, "Clears all data item from the data set");
            toolTip.SetToolTip(TextBoxItem, "Enter an integer");
            toolTip.SetToolTip(ListBoxItems, "Displays existing data set");
            toolTip.SetToolTip(MidExtremeTextBox, "Displays the mid-extreme of the data set");
            toolTip.SetToolTip(ModeTextBox, "Displays the mode of the data set");
            toolTip.SetToolTip(AverageTextBox, "Displays the mean average of the data set");
            toolTip.SetToolTip(RangeTextBox, "Displays the range of the data set");
        }
        static int max = 24; // • The array has 24 elements to reflect the number of hours per day.
        int nextEmptyTask = 0;
        int[] listData = new int[max]; // •	All data is stored as integers in an array.

        #region SprintOne

        //Displays listData in list box
        private void DisplayList()
        {
            ListBoxItems.Items.Clear();
            for (int x = 0; x < nextEmptyTask; x++)
            {
                ListBoxItems.Items.Add(listData[x]);
            }
        }

        // • There are buttons that can sort and search the data.
        // • The sort method must be coded using the Bubble Sort algorithm.
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            BubbleSort();
            DisplayList();
       
        }

        private void BubbleSort()
        {
            for (int i = 0; i < nextEmptyTask; i++)
            {
                for (int j = i + 1; j < nextEmptyTask; j++)
                {
                    if (listData[i] > listData[j])
                    {
                        int temp = listData[i];
                        listData[i] = listData[j];
                        listData[j] = temp;
                    }
                }
            }
        }

        // • There are buttons that can sort and search the data.
        // • The client can use a text box input to search the array.
        // • The search method must be coded using the Binary Search algorithm.
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Array.Sort(listData, 0, nextEmptyTask);
            DisplayList();
            if (!string.IsNullOrEmpty(TextBoxItem.Text))
            {
                int target = int.Parse(TextBoxItem.Text);

                if (target < 100 && target > 9)
                {

                    int min = 0, max = nextEmptyTask - 1, mid = 0;
                    bool found = false;

                    while (min <= max)
                    {
                        mid = (min + max) / 2;
                        if (target == listData[mid])
                        {
                            found = true;
                            break;
                        }
                        else if (target < listData[mid])
                            max = mid - 1;
                        else
                            min = mid + 1;
                    }
                    if (found)
                        MessageBox.Show("Found at element [" + mid + "]"); // •	The program must generate a message if the search is successful.
                    else
                        MessageBox.Show("Not Found"); // •	The program must generate an error message if the search is not successful.
                }
                else
                    MessageBox.Show("Number is outside of range!"); // • The program must generate an error message if the search is not successful.
            }
            else
                MessageBox.Show("No number entered in text box!"); // •	The program must generate an error message if the text box is empty.
        }

        //Fills listData with random integers between 10-99 inclusive
        private void ButtonFillData_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            nextEmptyTask = 24;

            for (int i = 0; i < 24; i++) 
            {
                listData[i] = rnd.Next(10, 100); // • The array is filled with random integers to simulate the data stream (numbers between 10 and 99).
            }


            DisplayList();
        }

        // Make sure only integers can be typed in the text box
        private void TextBoxItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // • There is an input field (text box) so data can be deleted.
        // • The program must be able to add, edit and delete data values.
        private void ButtonDeleteItem_Click(object sender, EventArgs e)
        {
            if (ListBoxItems.SelectedIndex != -1)
            {
                string currentItem = ListBoxItems.SelectedItem.ToString();
                int taskIndex = ListBoxItems.FindString(currentItem);
                listData[taskIndex] = listData[nextEmptyTask - 1];
                Array.Sort(listData, 0, nextEmptyTask);
                nextEmptyTask--;
                DisplayList();
            }
            else
                MessageBox.Show("No task selected"); // • The program must generate an error message if the text box is empty.
        }

        // • There is an input field (text box) so data can be added.
        // • The program must be able to add, edit and delete data values.
        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxItem.Text))
            {
                int number = int.Parse(TextBoxItem.Text);

                if (number > 9 && number < 100 && nextEmptyTask < 24)
                {
                    listData[nextEmptyTask] = int.Parse(TextBoxItem.Text);
                    nextEmptyTask++;
                    Array.Sort(listData, 0, nextEmptyTask);
                    DisplayList();
                    TextBoxItem.Clear();
                }
                else if (number < 10 || number > 99)
                    MessageBox.Show("Input number is outside 10-99 range!");
                else
                    MessageBox.Show("Array is already full!");
            }
            else
                MessageBox.Show("Textbox is empty!"); // •	The program must generate an error message if the text box is empty.
        }

        // • There is an input field (text box) so data can be edited.
        // • The program must be able to add, edit and delete data values.
        private void ButtonEditItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxItem.Text))
            {
                string currentItem = ListBoxItems.SelectedItem.ToString();
                int taskIndex = ListBoxItems.FindString(currentItem);
                listData[taskIndex] = int.Parse(TextBoxItem.Text);
                DisplayList();
            }
            else
                MessageBox.Show("No Text Selected"); // • The program must generate an error message if the text box is empty.
        }

        //Displays selected list box item in text box
        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelection = ListBoxItems.SelectedItem.ToString();

            TextBoxItem.Text = currentSelection;
        }

        #endregion

        #region Sequential Search Button
        private void ButtonSeqSearch_Click(object sender, EventArgs e) 
        {
            BubbleSort();
            DisplayList();


            bool found = false;
            bool inBound = true;
            int dataIndex = -1;
            int index = 0;

            if (!String.IsNullOrEmpty(TextBoxItem.Text))
            {
                int target = int.Parse(TextBoxItem.Text);
                if (target > 9 && target < 100)
                {
                    for (int i = 0; i < listData.Length; i++)
                    {
                        if (listData[i] == target)
                        {
                            if (index == 0)
                            {
                                MessageBox.Show("Data found at element [" + i + "]");
                                index++;
                            }
                            else
                                MessageBox.Show("Duplicate data found at element [" + i + "]");

                            found = true;
                            dataIndex = i;
                            //break;
                        }
                    }

                }
                else
                {
                    inBound = false;
                    MessageBox.Show("Search target is out of bounds");
                }
            }
            if (found == false && inBound)
                MessageBox.Show("Search target not found");
        }
        #endregion

        #region Mid Extreme Button
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            BubbleSort();

            if (nextEmptyTask >= 2)
            {
                float midExtreme = (listData[0] + listData[nextEmptyTask - 1]) / 2f;
                MidExtremeTextBox.Text = midExtreme.ToString("f");
            }
            else
                MidExtremeTextBox.Text = "No Data Set";

        }

        #endregion

        #region Mode Button
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int frequencyOne = 0;
            float modeOne = 0;

            int frequencyTwo = 0;
            float modeTwo = 0;

            int frequencyThree = 0;
            float modeThree = 0;

            for(int i = 0; i < (nextEmptyTask); i++)
            {
                counter = 0;

                for(int j = 0; j < (nextEmptyTask); j++)
                {
                    if(listData[i] == listData[j])
                    {
                        counter++;
                    }
                }

                if (counter > frequencyOne)
                {
                    frequencyOne = counter;
                    modeOne = listData[i];
                }
            }

            for (int i = 0; i < (nextEmptyTask); i++)
            {
                counter = 0;

                if (listData[i] != modeOne)
                {
                    for (int j = 0; j < (nextEmptyTask); j++)
                    {
                        if (listData[i] == listData[j])
                        {
                            counter++;
                        }
                    }

                    if (counter > frequencyTwo)
                    {
                        frequencyTwo = counter;
                        modeTwo = listData[i];
                    }
                }
            }

            for (int i = 0; i < (nextEmptyTask); i++)
            {
                counter = 0;

                if (listData[i] != modeOne && listData[i] != modeTwo)
                {
                    for (int j = 0; j < (nextEmptyTask); j++)
                    {
                        if (listData[i] == listData[j])
                        {
                            counter++;
                        }
                    }

                    if (counter > frequencyThree)
                    {
                        frequencyThree = counter;
                        modeThree = listData[i];
                    }
                }
            }


            if (frequencyOne == frequencyTwo && frequencyTwo == frequencyThree && frequencyOne > 1)
            {
                ModeTextBox.Text = modeOne.ToString() + " (" + frequencyOne + ")" + "\t" + modeTwo.ToString() + " (" + frequencyTwo + ")" + "\t" + modeThree.ToString() + " (" + frequencyThree + ")";
            }
            else if (frequencyOne == frequencyTwo && frequencyTwo > frequencyThree && frequencyOne > 1)
            {
                ModeTextBox.Text = modeOne.ToString() + " (" + frequencyOne + ")" + "\t" + modeTwo.ToString() + " (" + frequencyTwo + ")";
            }
            else if (frequencyOne > 1)
                ModeTextBox.Text = modeOne.ToString() + " (" + frequencyOne + ")";
            else
                ModeTextBox.Text = "No Mode";

        }

        #endregion

        #region Average Button
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            int total = 0;
            float meanAverage;

            for(int i = 0; i < (nextEmptyTask); i++)
            {
                total = total + listData[i];
            }

            meanAverage = (float)total/(nextEmptyTask);

            AverageTextBox.Text = meanAverage.ToString("f");
        }

        #endregion

        #region Range Button
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            if (nextEmptyTask >= 2)
            {
                BubbleSort();
                int range = listData[nextEmptyTask - 1] - listData[0];
                RangeTextBox.Text = range.ToString() + " (" + listData[0] + " to " + listData[nextEmptyTask - 1] + ")";
            }
            else
                RangeTextBox.Text = "No Data Set";

        }

        #endregion

        #region Clear Data Button
        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            for (int i  = 0; i < listData.Length; i++)
            {
                listData[i] = listData[nextEmptyTask - 1];
                nextEmptyTask--;

                if (nextEmptyTask == 0)
                    break;
            }
            ListBoxItems.Items.Clear();
            DisplayList();
        }
        #endregion
        

    }
}
