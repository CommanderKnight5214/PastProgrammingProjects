using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNumbersFinal
{
    //James Schwantes, 3/6/2020, The purpose of this code is to add shims and save them to storage. 
    public partial class Form1 : Form
    {
        //Intial Varibles
        double RunningTotal = 0;
        double RunningTotalTemp = 0;
        String TotalConversion = "";
        double NumberOfShims = 0;
        double NumberOfShimsTemp = 0;
        double RecentInputValue = 0;
        double InputValue = 0;
        double ErrorTracker = 0;
        double ErrorMessageCounter = 0;
        double UndoCounter = 0;
        double IntializeCounter = 0;
        String InputStringValue = "";
        String ResetString = "";
        String ErrorTextOne = "Invalid Input! You must type in a number.";
        String ErrorTextTwo = "You cannot undo yet, try adding some" + "\n" + "numbers first.";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //These lines of code help keep the cursor inside the text box.
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //This button allows the user to add the input varible to the Running total and Shim Total.
        //It also resets the input box and focuses on the curser
        private void button1_Click(object sender, EventArgs e)
        {
            //This code will try to add the number, if it fails to execute, 
            //a message will pop up alerting the user that he or she has an invalid input. 
            //If the error lable has an error message in it, the program will set the error lable to an empty string.
            //There is also an error checking feature that will detect if there is a valid input in TextBox 1. 
            //If there is, the input will add to the shim counter and running total. 
            //If there is not, the code will spit out an error message telling the user that there input is an invalid input. 
            try
            {
                InputStringValue = this.textBox1.Text;
                for (int i = 0; i < InputStringValue.Length; i++)
                {
                    if (InputStringValue[0] == '-' || InputStringValue[0] == '0' && InputStringValue[1] != '.')
                    {
                        ErrorTracker++;
                    }
                    else if(InputStringValue[i] == '.')
                    {
                        ErrorTracker = 0;
                    }
                }
                if (ErrorTracker != 0)
                {
                    ErrorTracker = 0;
                    this.textBox1.Text = ResetString;
                    this.label4.Text = ErrorTextOne;
                    this.ActiveControl = textBox1;
                    textBox1.Focus();
                }
                else
                {
                    InputValue = Convert.ToDouble(InputStringValue);
                    RecentInputValue = InputValue;
                    RunningTotal = RunningTotal + InputValue;
                    NumberOfShims = NumberOfShims + 1;
                    TotalConversion = Convert.ToString(RunningTotal);
                    this.textBox2.Text = TotalConversion;
                    TotalConversion = Convert.ToString(NumberOfShims);
                    this.textBox3.Text = TotalConversion;
                    this.textBox1.Text = ResetString;
                    ErrorMessageCounter = 0;
                    IntializeCounter++;
                    if (this.label4.Text != "")
                    {
                        this.label4.Text = "";
                        ErrorMessageCounter = 0;
                    }
                }
                
            }
            catch (Exception ex)
            {
                this.label4.Text = ErrorTextOne;
                this.ActiveControl = textBox1;
                textBox1.Focus();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //This button allows the user to reset the number of shims and the Running total to an empty string.
        //If the error lable has an error message in it, the program will set the error lable to an empty string.
        //This button also resets the UndoCounter and ErrorMessageCounter. 
        private void button2_Click(object sender, EventArgs e)
        {
            RunningTotal = 0;
            NumberOfShims = 0;
            this.textBox2.Text = ResetString;
            this.textBox3.Text = ResetString;
            this.ActiveControl = textBox1;
            textBox1.Focus();
            UndoCounter = 0;
            ErrorMessageCounter = 1;
            if (this.label4.Text != "")
            {
                this.label4.Text = "";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //This button will allow the user to undo the last calculation for the total number of shims. 
        //If the error lable has an error message in it, the program will set the error lable to an empty string.
        //This button will also prevent the user from going into the negatives as well. 
        //If the UndoCounter is not equal to zero, then the label will spit out an error message.
        //If the Intialize Counter is equal to zero, then the counter will increase and an error message will spit out. 
        //If the Undo and ErrorMessage counter are equal to zero, then the undo function will undo the last number.
        //If the Running total is less then or equal to zero, an error message will spit out. 
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (UndoCounter != 0)
            {
                this.label4.Text = "Maximum number of Undo's have been" + "\n" + "reached.";
                UndoCounter = 0;
                ErrorMessageCounter = 1;
            }
            else if(IntializeCounter == 0)
            {
                IntializeCounter++;
                this.label4.Text = ErrorTextTwo;
            }
            else if (UndoCounter == 0 && ErrorMessageCounter == 0)
            {
                NumberOfShims = NumberOfShims - 1;
                RunningTotal = RunningTotal - RecentInputValue;
                TotalConversion = Convert.ToString(NumberOfShims);
                this.textBox3.Text = TotalConversion;
                TotalConversion = Convert.ToString(RunningTotal);
                this.textBox2.Text = TotalConversion;
                UndoCounter++;
            }
            else if (RunningTotal <= 0)
            {
                this.label4.Text = ErrorTextTwo;
            }
            this.ActiveControl = textBox1;
            textBox1.Focus();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        //This menu option will allow the user to see the total number of shims and the running total of all those shims. 
        private void savePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //This menu will allow the user to understand what the app is for.
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For the user to understand how the app works.", "Help Menu");
        }
        //This menu will allow the user to print out the shims in a seperate window.
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Running Total: " + RunningTotal + "\n" + "Number of Shims: " + NumberOfShims, "Shim Total Summary");
            RunningTotal = 0;
            NumberOfShims = 0;
            this.textBox3.Text = ResetString;
            this.textBox2.Text = ResetString;
            this.textBox1.Text = ResetString;
            IntializeCounter = 0;
        }
        //This menu will allow the user to save a file on his or her own computer in the documents folder. 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a string array with the lines of text
            //string[] lines = { "First line", "Second line", "Third line" };
            // Set a variable to the Documents path.
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new
            StreamWriter(Path.Combine(docPath, "Total Shim Summary.txt")))
            {
                DateTime now = DateTime.Now;
                outputFile.WriteLine(now);
                outputFile.WriteLine("Weight of Shim Bundle: " + RunningTotal);
                outputFile.WriteLine("Number of Shims: " + NumberOfShims);
                MessageBox.Show("Your file has been saved in the Documents Folder", "Saved");
            }
        }
    }
}
