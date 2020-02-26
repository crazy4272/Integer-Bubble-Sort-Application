using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_Bubble_Sort_Application
{
    public partial class Form1 : Form
    {
        int textBoxSizeEdges;
        int arrayLength, arrayMinValue, arrayMaxValue;

        public Form1()
        {
            InitializeComponent();
            textBoxSizeEdges = (UnsortedArrayTextBox.Height - UnsortedArrayTextBox.Font.Height);
            this.AscendingOrderRadioButton.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateArrayButton_Click(object sender, EventArgs e)
        {

            //Gather input from user checking that it is formatted correctly
            if (int.TryParse(LengthInputTextBox.Text, out arrayLength) && int.TryParse(MinValueTextBox.Text, out arrayMinValue) && int.TryParse(MaxValueTextBox.Text, out arrayMaxValue))
            {
                //Print out so we know what input it thinks is coming through
                //this.UnsortedArrayTextBox.Text = arrayLength.ToString() + " " + arrayMinValue.ToString() + " " + arrayMaxValue.ToString() + "\r\n";

                //We now know they are integers and parsed correctly we do more specific checks on the input
                Boolean lengthCheck = arrayLength > 1;
                Boolean minMaxCheck = arrayMinValue < arrayMaxValue;

                if (lengthCheck && minMaxCheck)
                {
                    //In case this isn't the first time we've done this clear the textbox
                    this.UnsortedArrayTextBox.ResetText();
                    //Everything checks out so we need to build our array
                    int[] unsortedArray = new int[arrayLength];
                    //Now lets populate it with random integer values
                    Random numberGenerator = new Random();
                    for(int i = 0; i < arrayLength; i++)
                    {
                        //Use rand to generate values within the acceptable range set by min and max value 
                        unsortedArray[i] = numberGenerator.Next(arrayMinValue, arrayMaxValue + 1);

                        //Code to try and check if random is inclusive of the numbers you add or not
                        //if(unsortedArray[i] == arrayMinValue)
                        //{
                        //    this.SortedArrayTextBox.Text += "minValue did occur \r\n";
                        //}
                        //else if(unsortedArray[i] == arrayMaxValue)
                        //{
                        //    this.SortedArrayTextBox.Text += "maxValue did occur \r\n";
                        //}
                    }
                    //Simple print out to unsorted array textbox
                    for (int i = 0; i < arrayLength; i++)
                    {
                        this.UnsortedArrayTextBox.Text += unsortedArray[i];
                        if(i + 1 != arrayLength)
                        {
                            this.UnsortedArrayTextBox.Text += " ";
                        }
                    }
                    
                }
                else
                {
                    //We need to know which check failed to inform the user better
                    if (lengthCheck) 
                    {
                        //Length Check is fine so the error must have been the minMax Check
                        String errorMessage = "MinValue must be below MaxValue to be processable";
                        String errorTitle = "Minimum-Maximum Condition";
                        MessageBox.Show(errorMessage, errorTitle);
                    }
                    else if(minMaxCheck)
                    {
                        //Only length check failed then, the array length needs to be at least 2 long or there's nothing to compare and sort
                        String errorMessage = "Length must be at least 2 or no comparisons can be made";
                        String errorTitle = "Length Condition";
                        MessageBox.Show(errorMessage, errorTitle);
                    }
                    else
                    {
                        //Both Checks Failed
                        String errorMessage = "Length must be at least 2 or no comparisons can be made\nMinimum must be below Maximum to be processable";
                        String errorTitle = "Length & Minimum-Maximum Condition";
                        MessageBox.Show(errorMessage, errorTitle);
                    }
                }
            }
            else 
            {
                //This means at least one of our parse attempts failed so alert the user to correctly format the data better
                String errorMessage = "Please ensure your Length, MinValue and MaxValue inputs are formatted correctly";
                String errorTitle = "Input Format";
                MessageBox.Show(errorMessage, errorTitle);
                //** Make this more informative try be user friendly you muppet **
            }

            

            //Old code to attempt to manually change the text box size to fit the input

            //this.UnsortedArrayTextBox.Text += "17A 17B";
            //Size size = TextRenderer.MeasureText(UnsortedArrayTextBox.Text, UnsortedArrayTextBox.Font);
            //this.LengthInputTextBox.Text = UnsortedArrayTextBox.Width.ToString();
            //this.MinValueTextBox.Text = size.Width.ToString();
            //this.MaxValueTextBox.Text = size.Height.ToString();
            //UnsortedArrayTextBox.Height = (size.Height) * (size.Width / UnsortedArrayTextBox.Width) + textBoxSizeEdges;
            //UnsortedArrayTextBox.Width = size.Width;

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void SORTButton_Click(object sender, EventArgs e)
        {
            //Gather the array from the previous textbox (bit inefficient but bit stuck on how to pass the array to this click event
            String unsortedSequence = UnsortedArrayTextBox.Text;

            //We need to use a more flexible collection method incase the sequence has been edited by manual input
            String[] integers = unsortedSequence.Split(' ');
            int length = integers.Length;

            //Check that is picking up the correct length
            this.LengthInputTextBox.Text = length.ToString();

            //Loop through attempting to parse as much as possible but keep track of any failures that occur in that
            int[] numberSequence = new int[length];
            String[] parseErrors = new string[length];
            int errorCount = 0;

            for (int i = 0; i < length; i++)
            {
                //Attempt to parse but if it fails account for the error and move on
                if(!(int.TryParse(integers[i], out numberSequence[i - errorCount])))
                {
                    //If we're here then the parse attempt failed
                    parseErrors[errorCount] = integers[i];
                    errorCount++;
                }
            }

            //If any errors did occur best to give the user an informed mesage about it
            if(errorCount > 0)
            {
                //Want to let the user know which strings failed so hopefully they can see why they failed
                String errorMessage = errorCount.ToString() + " value(s) could not be converted to integers:\r\n";
                for (int i = 0; i < errorCount; i++) 
                {
                    errorMessage += " - " + parseErrors[i] + "\r\n";
                }
                String errorTitle = "Parsing Error";
                MessageBox.Show(errorMessage, errorTitle);
            }

            ////Split the text by the spaces between them
            //String[] numbers = new string[arrayLength];
            //numbers = unsortedSequence.Split(' ');

            ////Loop through and convert them back into ints so we can perform operations
            ////int[] numberSequence = new int[arrayLength];
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    //Since we have created the numbers ourselves a TryParse should be unnecessary ** CHANGE IF YOU LATER ALLOW MANUAL INPUT **
            //    numberSequence[i] = int.Parse(numbers[i]);
            //}
            
            //Check if we are looking for ascending or descending order
            Boolean ascendingOrder = AscendingOrderRadioButton.Checked;

            if(ascendingOrder)
            {
                this.SortedArrayTextBox.Text = "--In Ascending Order-- \r\n";
            }
            else
            {
                this.SortedArrayTextBox.Text = "--In Descending Order-- \r\n";
            }

            //Bubble Sorting - double loop and swap values around
            int holderValue;
            int comparisons = 0;
            int swaps = 0;
            //Early Exit Idea if an entire 'j' loop occurs without a swap that means you're finished and could be before yu would normally finish
            Boolean swapMade;
            //Single if statement 
            if (ascendingOrder)
            {
                for (int i = 0; i < length - errorCount; i++)
                {
                    swapMade = false;
                    for (int j = 0; j < length - (errorCount + 1 + i); j++)
                    {
                        comparisons++;
                        if (numberSequence[j] > numberSequence[j + 1])
                        {
                            //We need to switch things around
                            holderValue = numberSequence[j];
                            numberSequence[j] = numberSequence[j + 1];
                            numberSequence[j + 1] = holderValue;
                            swaps++;
                            //Stop the possibility of finishing early as we may not be finished
                            swapMade = true;
                        }
                    }

                    if (!swapMade)
                    {
                        //We're done then exit the loop and go home
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < length - errorCount; i++)
                {
                    for (int j = 0; j < length - (errorCount + 1 + i); j++)
                    {
                        comparisons++;
                        if (numberSequence[j] < numberSequence[j + 1])
                        {
                            //We need to switch things around
                            holderValue = numberSequence[j];
                            numberSequence[j] = numberSequence[j + 1];
                            numberSequence[j + 1] = holderValue;
                            swaps++;
                        }
                    }
                }
            }

            //Simple print out to unsorted array textbox
            for (int i = 0; i < length - errorCount; i++)
            {
                this.SortedArrayTextBox.Text += numberSequence[i] + " ";
            }

            //Report how many integer comparisons and swaps it had to make to sort the array
            this.BS_ComparisonsTextBox.Text = comparisons.ToString();
            this.BS_SwapsTextBox.Text = swaps.ToString();
        }

        private void manualInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Check whether we are now checked or not and enable or disable parts of the form as necessary
            this.CreateArrayButton.Enabled = !(this.manualInputCheckBox.Checked);
            this.LengthInputTextBox.Enabled = !(this.manualInputCheckBox.Checked);
            this.MinValueTextBox.Enabled = !(this.manualInputCheckBox.Checked);
            this.MaxValueTextBox.Enabled = !(this.manualInputCheckBox.Checked);
            this.UnsortedArrayTextBox.ReadOnly = !(this.manualInputCheckBox.Checked);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AscendingOrderRadioButton_Click(object sender, EventArgs e)
        {

        }
    }
}
