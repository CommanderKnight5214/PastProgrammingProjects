using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//The Main purpose of this program was to create a simple counter app to keep track of my habits and tempetations that are needed to be broken. 
//This program also has a built in reset feature as well.

namespace Cross_and_Habit_Counter
{
    public partial class CandHCounter : Form
    {
        //Counters and Indicators.
        //CC = "CrossCounter", HC = "HabitCounter", IC = "IdentifierCount", InC = "IntializeCount", ResetI = "ResetIndicator"
        int CC = 0;
        int HC = 0;
        int IC = 2;
        int InC = 0;
        int ResetI = 0;

        //Filepaths for the three external text files, that serve as a storage location for the CrossCounter "CC", HabitCounter "HC", and IdentifierCount "IC".
        String CCFilepath = @"D:\GitHub Repository\MyPastProgrammingProjects\My Personal Projects\Cross and Habit Counter\CounterStorage\CrossCounter.txt";
        String HCFilepath = @"D:\GitHub Repository\MyPastProgrammingProjects\My Personal Projects\Cross and Habit Counter\CounterStorage\HabitCounter.txt";
        String ICFilepath = @"D:\GitHub Repository\MyPastProgrammingProjects\My Personal Projects\Cross and Habit Counter\CounterStorage\IdentifierCount.txt";
        String InCFilepath = @"D:\GitHub Repository\MyPastProgrammingProjects\My Personal Projects\Cross and Habit Counter\CounterStorage\IntializeCount.txt";
        public CandHCounter(int ResetIndicator)
        {
            //Upon Intialization of this form, the counters/indicators will be loaded in, either from Memory or Storage.
            InitializeComponent();
            InC = OpenCounterFunction(InC, InCFilepath);
            IC = OpenCounterFunction(IC, ICFilepath);
            ResetI = ResetIndicator;
            CC = OpenCounterFunction(CC, CCFilepath);
            HC = OpenCounterFunction(HC, HCFilepath);
            
            //If ResetI is equal to 1, then the counters, textboxes, and buttons will be reset. 
            if (ResetI == 1)
            {
                CC = 0;
                HC = 0;
                IC = 2;
                this.CrossCounterTextBox.Text = Convert.ToString(CC);
                this.HabitCounterTextBox.Text = Convert.ToString(HC);
                
                //Counters will be set, displayed, and saved into their appropriate text files or .txt file.
                //The IC count will also be decreased because it will be used to switch modes when the AddToIndentifierButton is clicked.
                AddToFunction(IC);
                SaveCounterFunction(IC, ICFilepath);
                IC = ReturnIdentifierCountFunction(IC);
                SaveCounterFunction(CC, CCFilepath);
                SaveCounterFunction(HC, HCFilepath);

            }

            //If the program does not need to be reset, then the program will not change.
            //Counters will be displayed, information will be saved, and the IC count will be reduced.
            else
            {
                this.CrossCounterTextBox.Text = Convert.ToString(CC);
                this.HabitCounterTextBox.Text = Convert.ToString(HC);
                AddToFunction(IC);
                SaveCounterFunction(IC, ICFilepath);
                IC = ReturnIdentifierCountFunction(IC);
            }
        }

        //This menu tab will pull up the About Form.
        private void AboutMenuTab_Click(object sender, EventArgs e)
        {
            AboutForm About = new AboutForm();
            About.ShowDialog();
        }

        //This menu tab will pull up a Quick Start Guide or Help form.
        private void HelpMenuTab_Click(object sender, EventArgs e)
        {
            HelpForm Help = new HelpForm();
            Help.ShowDialog();
        }

        //The AddToIndentifierButton will display the correct mode when the button is clicked.
        //This button will also Save and decrease the IdentifierCount.
        private void AddToIndentifierButton_Click(object sender, EventArgs e)
        {
            AddToFunction(IC);
            SaveCounterFunction(IC, ICFilepath);
            IC = ReturnIdentifierCountFunction(IC);
            //If the InC or "Intialization" Count is equal to 0 and the IC or "Identifier" count is not equal to two.
            //Then the InC count will be set to 1 and saved to its text or .txt file as well.
            if (IC != 2 && InC == 0)
            {
                InC = 1;
                SaveCounterFunction(InC, InCFilepath);
            }
        }

        //The AddButton will add 1 to the selected counter, designated by the AddToIndentifierButton.
        //If the identfier button has not been clicked, the program will immediatly default to the "Cross" mode.
        //Each counter is added and saved specified by the condition.
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Condition: "Cross" mode and IC count equal to 0.
            if (IC == 2 && InC == 0)
            {
                CC++;
                this.CrossCounterTextBox.Text = Convert.ToString(CC);
                SaveCounterFunction(CC, CCFilepath);
            }

            //Condition: "Both" mode.
            else if (IC == 2)
            {
                CC++;
                HC++;
                this.CrossCounterTextBox.Text = Convert.ToString(CC);
                this.HabitCounterTextBox.Text = Convert.ToString(HC);
                SaveCounterFunction(CC, CCFilepath);
                SaveCounterFunction(HC, HCFilepath);
            }

            //Condition: "Cross" mode.
            else if (IC == 1)
            {
                CC++;
                this.CrossCounterTextBox.Text = Convert.ToString(CC);
                SaveCounterFunction(CC, CCFilepath);
            }

            //Condition: "Habit" mode.
            else if (IC == 0)
            {
                HC++;
                this.HabitCounterTextBox.Text = Convert.ToString(HC);
                SaveCounterFunction(HC, HCFilepath);
            }
        }

        //The UndoButton will subtract one from the counter, desginated by the mode under the AddToIndetifierButton.
        //If a counter were to go into the negatives, and error message will appear stating that the counter cannot be undone
        //due to the maximum number of undos reached. 
        //Each counter is subtracted and saved specified by the condition.
        private void UndoButton_Click(object sender, EventArgs e)
        {
            //Condition: "Cross" mode and IC count equal to 0.
            if (IC == 2 && InC == 0)
            {
                CC--;

                //Condition: CrossCounter is less than 0.
                if (CC < 0)
                {
                    CC++;
                    MaximumReachedMessageBox("The Cross Counter");
                    SaveCounterFunction(CC, CCFilepath);
                }
                else
                {
                    this.CrossCounterTextBox.Text = Convert.ToString(CC);
                    SaveCounterFunction(CC, CCFilepath);
                }
            }

            //Condition: "Both" mode.
            else if (IC == 2)
            {
                CC--;
                HC--;

                //Condition: CrossCounter and HabitCounter are less than 0.
                if (CC < 0 && HC < 0)
                {
                    CC++;
                    HC++;
                    MaximumReachedMessageBox("both counters");
                    SaveCounterFunction(CC, CCFilepath);
                    SaveCounterFunction(HC, HCFilepath);
                }

                //Condition: CrossCounter is less than 0.
                else if (CC < 0)
                {
                    CC++;
                    HC++;
                    MaximumReachedMessageBox("The Cross Counter");
                    SaveCounterFunction(CC, CCFilepath);
                    SaveCounterFunction(HC, HCFilepath);
                }

                //Condition: HabitCounter is less than 0.
                else if (HC < 0)
                {
                    CC++;
                    HC++;
                    MaximumReachedMessageBox("The Habit Counter");
                    SaveCounterFunction(CC, CCFilepath);
                    SaveCounterFunction(HC, HCFilepath);
                }
                else
                {
                    this.CrossCounterTextBox.Text = Convert.ToString(CC);
                    this.HabitCounterTextBox.Text = Convert.ToString(HC);
                    SaveCounterFunction(CC, CCFilepath);
                    SaveCounterFunction(HC, HCFilepath);
                }
            }

            //Condition: "Cross" mode.
            else if (IC == 1)
            {
                CC--;

                //Condition: CrossCounter is less than 0.
                if (CC < 0)
                {
                    CC++;
                    MaximumReachedMessageBox("The Cross Counter");
                    SaveCounterFunction(CC, CCFilepath);

                }
                else
                {
                    this.CrossCounterTextBox.Text = Convert.ToString(CC);
                    SaveCounterFunction(CC, CCFilepath);
                }
            }

            //Condition: "Habit" mode.
            else if (IC == 0)
            {
                HC--;

                //Condition: HabitCounter is less than 0.
                if (HC < 0)
                {
                    HC++;
                    MaximumReachedMessageBox("The Habit Counter");
                    SaveCounterFunction(HC, HCFilepath);
                }
                else
                {
                    this.HabitCounterTextBox.Text = Convert.ToString(HC);
                    SaveCounterFunction(HC, HCFilepath);
                }
            }
        }

        //The ResetButton will hide this form and pull up the ResetProgram form.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            //The IC count will also be increased to identify the correct mode,
            //and saved in its appropriate text or .txt file.
            if (IC < 2)
            {
                IC++;
                SaveCounterFunction(IC, ICFilepath);
            }
            else if (IC == 2)
            {
                IC = 0;
                SaveCounterFunction(IC, ICFilepath);
            }
            ResetProgramForm Reset = new ResetProgramForm();
            Reset.Show();
        }

        //This function will take in a Counter and a Filepath, and save the Counter to its Filepath.
        //This function will also keep overwriting previous data with new information to remain current as well..
        private void SaveCounterFunction(int Counter, String Filepath)
        {
            string thepath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + Filepath;
            string content = Convert.ToString(Counter) + Environment.NewLine;
            File.WriteAllText(thepath, content);

        }

        //This function will take in a Counter and a Filepath, and import the Counter specfied by the Filepath.
        //The counter will also be return to the Counter in order to use the Counter later.
        private int OpenCounterFunction(int Counter, String Filepath)
        {
            string thepath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + Filepath;
            string content = File.ReadAllText(thepath);
            Counter = Convert.ToInt32(content);
            return Counter;
        }

        //This function will take in a Counter and display an error message.
        private void MaximumReachedMessageBox(String Counter)
        {
            MessageBox.Show("The Maximum Number of Undos for " + "\n" + Counter + " has been reached!", "Maximum Reached!");
        }
        
        //This function will take in the IdentifierCount and set the AddToIndentiferButton to its appropriate mode. 
        private void AddToFunction(int IdentifierCount)
        {
            //Condition: "Cross" mode.
            if (IdentifierCount == 2)
            {
                AddToIndentifierButton.BackColor = Color.Black;
                AddToIndentifierButton.ForeColor = Color.White;
                AddToIndentifierButton.Text = "Cross";

            }

            //Condition: "Habit" mode.
            else if (IdentifierCount == 1)
            {
                AddToIndentifierButton.BackColor = Color.FromArgb(219, 31, 31);
                AddToIndentifierButton.ForeColor = Color.Black;
                AddToIndentifierButton.Text = "Habit";
            }

            //Condition: "Both" mode.
            else if (IdentifierCount == 0)
            {
                AddToIndentifierButton.BackColor = Color.FromArgb(111, 3, 32);
                AddToIndentifierButton.ForeColor = Color.White;
                AddToIndentifierButton.Text = "Both";
            }
        }

        //This function will take in the IdentifierCount and either decrease it or set it to two.
        //The use of this function is to prepare for the next switch in modes when the AddToIndetifierButton is clicked.
        private int ReturnIdentifierCountFunction(int IdentifierCount)
        {
            if (this.AddToIndentifierButton.Text == "Cross" || this.AddToIndentifierButton.Text == "Habit")
            {
                IdentifierCount--;
            }
            else if (this.AddToIndentifierButton.Text == "Both")
            {
                IdentifierCount = 2;
            }
            return IdentifierCount;
        }

        private void CrossCounterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HabitCounterTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
