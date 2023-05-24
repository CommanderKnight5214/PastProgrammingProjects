using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


//The main purpose of this program is to provide a medical tool for a caretaker, to keep a daily log for a patient that suffering from dementia.
//The tool itself has the ability to track daily the patients Physical, Mental and Emmotional heath, along with what memories the patient has forgotten,
//and what memories the patient needs to be reminded of.
//The program also has the ability to for the caretaker to list off what medications the patient has been taking, along
//with the symtoms the patient has been experiencing from the medication as well.

namespace Memory_Tracker
{
    public partial class Form1 : Form
    {   
        //Intial Variables

        //Arrays for storing text in the corresponding text boxs
        String[] Question1 = new string[100];
        String[] Question2 = new string[100];
        String[] ListOfMedications = new string[100];
        String[] ResponseToMedications = new string[100];
        String[] Patient = new string[100];

        //Variables for Number Shortcut Function
        String Medication1 = "Medication 1: ";
        String Medication2 = "Medication 2: ";
        String Medication3 = "Medication 3: ";
        String Medication4 = "Medication 4: ";
        String Medication5 = "Medication 5: ";
        String Medication6 = "Medication 6: ";
        String Medication7 = "Medication 7: ";
        String Medication8 = "Medication 8: ";
        String Medication9 = "Medication 9: ";
        String Medication10 = "Medication 10: ";
        String Medication11 = "Medication 11: ";
        String Medication12 = "Medication 12: ";


        //Reset Text
        String Reset = " ";
        
        //Date variable
        String date = DateTime.Now.ToString("MM dd yy");
        
        //Temporary Array for saved text
        String[] InformationCompiled = new string[1];

        //Temporary varible for storing text when needed.
        String TempText = "";

        //The IntailizedCount will detect whether or not the clear button has been clicked on when the program was first started.
        int IntializedCount = 0;
        //The TargetCount will detect the last element in an array.
        int TargetCount = 0;
        //The count will help navigate throught an array.
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            //Sets the Cursor 
            this.ActiveControl = this.Question1TextBox;
            this.Question1TextBox.Focus();
        }

        //This function sets the clock to today's date.
        private void Clock_Tick(object sender, EventArgs e)
        {
            Todays_Date.Text = date;
        }

        //This function startes the clock.
        private void Form1_Load(object sender, EventArgs e)
        {
            Clock.Start();
        }

        //Today's Date Text Box.
        private void Todays_Date_Click(object sender, EventArgs e)
        {

        }

        //This function clears all of the text from each text box.
        private void Clear_Click(object sender, EventArgs e)
        {
            //If every text box is equal to no text, this function will execute.
            if (this.Question1TextBox.Text == "" && this.Question2TextBox.Text == "" && this.PatientTextBox.Text == "" && 
                this.ListOfMedicationsTextBox.Text == "" && this.ResponseToMedicationsTextBox.Text == "")
            {
                MessageBox.Show("You have already cleared your file.", "Already Cleared");
                count++;
            }

            //If either text box is not equal to no text, then this function will execute.
            else if (this.Question1TextBox.Text != "" || this.Question2TextBox.Text != "" || this.PatientTextBox.Text != "" || 
                this.ListOfMedicationsTextBox.Text != "" || this.ResponseToMedicationsTextBox.Text != "")
            {
                //Failsafe if count is less then zero.
                if (count < 0)
                {
                    count = 0;
                }

                //If this function is executed, the text in each text box will be saved at 'count' index to each corresponding arrary.
                Question1[count] = this.Question1TextBox.Text;
                Question2[count] = this.Question2TextBox.Text;
                ListOfMedications[count] = this.ListOfMedicationsTextBox.Text;
                ResponseToMedications[count] = this.ResponseToMedicationsTextBox.Text;
                Patient[count] = this.PatientTextBox.Text;

                //Once this is completed, each text box will be cleared.
                this.Question1TextBox.Clear();
                this.Question2TextBox.Clear();
                this.ListOfMedicationsTextBox.Clear();
                this.ResponseToMedicationsTextBox.Clear();
                this.PatientTextBox.Clear();

                //Each counter will be set
                IntializedCount = 1;
                count++;
                TargetCount = 1;
            }
        }

        //This function will bring back the text that was intially cleared using the clear button.
        private void Undo_Click(object sender, EventArgs e)
        {
            //If the clear button has not been pressed, this function will execute.
            if (IntializedCount == 0)
            {
                MessageBox.Show("You have no information to recover.", "No Information In File");
            }
            //If there are no more undos to clear, this function will execute.
            else if (count < 0)
            {
                MessageBox.Show("You have already recovered your entire file.", "File Recoverd");
            }
            //If the count is out of bounds, this function will execute.
            else if (TargetCount == 1)
            {
                //The count will be brought down to the last element that is in the corrosponding array.
                count--;

                //Each text box will be set to the text at 'count' index.
                this.Question1TextBox.Text = Question1[count];
                this.Question2TextBox.Text = Question2[count];
                this.ListOfMedicationsTextBox.Text = ListOfMedications[count];
                this.ResponseToMedicationsTextBox.Text = ResponseToMedications[count];
                this.PatientTextBox.Text = Patient[count];

                //Once each textbox is filled with the 'count' index. The 'count' index will be reset using the reset varaible.
                Question1[count] = Reset;
                Question2[count] = Reset;
                ListOfMedications[count] = Reset;
                ResponseToMedications[count] = Reset;
                Patient[count] = Reset;

                //The count will go down to the next potential index.
                count--;

                //TargetCount will be set to zero.
                TargetCount = 0;
            }
            
            //Same function applies, but there is only one 'count' index decrease.
            else
            {
                this.Question1TextBox.Text = Question1[count];
                this.Question2TextBox.Text = Question2[count];
                this.ListOfMedicationsTextBox.Text = ListOfMedications[count];
                this.ResponseToMedicationsTextBox.Text = ResponseToMedications[count];
                this.PatientTextBox.Text = Patient[count];

                Question1[count] = Reset;
                Question2[count] = Reset;
                ListOfMedications[count] = Reset;
                ResponseToMedications[count] = Reset;
                Patient[count] = Reset;
                count--;
            }

        }

        //Each of these Medication Shortcut Buttons will execute there appropriate functions.
        //Lines 191-250
        private void Medication1Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication1);
        }

        private void Medication2Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication2);
        }

        private void Medication3Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication3);
        }

        private void Medication4Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication4);
        }

        private void Medication5Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication5);
        }

        private void Medication6Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication6);
        }

        private void Medication7Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication7);
        }

        private void Medication8Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication8);
        }

        private void Medication9Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication9);
        }

        private void Medication10Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication10);
        }

        private void Medication11Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication11);
        }

        private void Medication12Shortcut_Click(object sender, EventArgs e)
        {
            NumberShortcut(Medication12);
        }

        //This menu tab will pull up the Quick Start Guide or Form2.
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        //This menu tab will pull up the Message from Developer Form.
        private void messageFromDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message_from_Developer MFD = new Message_from_Developer();
            MFD.ShowDialog();
        }

        //This menu tab will pull up the About Program Form.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Program About = new About_Program();
            About.ShowDialog();
        }

        //This Menu Tab will Save all the information to a text file while executing the appropriate function.
        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompileInformation(InformationCompiled);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "Document"; // Default file name
            saveFileDialog1.DefaultExt = ".txt"; // Default file extension
            saveFileDialog1.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            
            foreach (string line in InformationCompiled)
                sw.WriteLine(line);

            sw.Close();
        }

        //This Menu Tab will Save only the Information for a medical doctor to a text file while executing the appropriate function.
        private void saveInfoForDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompileDoctorInformation(InformationCompiled);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "Document"; // Default file name
            saveFileDialog1.DefaultExt = ".txt"; // Default file extension
            saveFileDialog1.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);


            foreach (string line in InformationCompiled)
                sw.WriteLine(line);

            sw.Close();
        }

        //This Menu Tab will Save only save the information to tell patient to a text file while executing the appropriate function.
        private void saveInfoToTellPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CompilePatientInformation(InformationCompiled);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "Document"; // Default file name
            saveFileDialog1.DefaultExt = ".txt"; // Default file extension
            saveFileDialog1.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            saveFileDialog1.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);


            foreach (string line in InformationCompiled)
                sw.WriteLine(line);

            sw.Close();
        }

        //Medication Number Shortcut.
        private void NumberShortcut(String MedicationNumber)
        {
            //If the Response Textbox is empty, this function will execute.
            if (this.ResponseToMedicationsTextBox.Text == "")
            {
                //Adds the MedicationNumber text to the textbox and executes the 'moveCaretToEndAfterShortcut' function.
                this.ResponseToMedicationsTextBox.Text = MedicationNumber;
                moveCaretToEndAfterShortCut();
            }
            else
            {
                //If there is some text in the text box, a temp varible will be created combining the previous text to the MedicationNumber.
                //Once this is done, the textbox will be set to the temp varialbe and the 'moveCaretToEndAfterShortcut' function will be executed.
                TempText = this.ResponseToMedicationsTextBox.Text + MedicationNumber;
                this.ResponseToMedicationsTextBox.Text = TempText;
                moveCaretToEndAfterShortCut();
            }
        }

        //These functions will compile all the information that is needed to save.
        //Lines 353-385
        
        //This function will set the proper format for all the information for the textfile.
        private void CompileInformation(String[] InformationCompiled)
        {
            DateTime TimeStamp = DateTime.Now;
            String Information = TimeStamp + "\n\n" + this.InformationforMedicalDoctorLabel.Text + "\n\n" + this.Question1Label.Text + 
                "\n" + this.Question1TextBox.Text + "\n\n" + this.Question2Label.Text + "\n\n" + this.Question2TextBox.Text + "\n\n" + 
                this.ListOfMedicationsLabel.Text + "\n\n" + this.ListOfMedicationsTextBox.Text + "\n\n" + this.ResponceToMedicationsLabel.Text 
                + "\n\n" + this.ResponseToMedicationsTextBox.Text + "\n\n" + this.InformationToTellPatientLabel.Text + "\n\n" + this.PatientTextBox.Text;

            //Information will be sent to a 1 index array in order to get saved a text file.
            InformationCompiled[0] = Information;
        }

        //This function will set the proper format for the Doctor Information for the textfile.
        private void CompileDoctorInformation(String[] InformationCompiled)
        {
            DateTime TimeStamp = DateTime.Now;
            String Information = TimeStamp + "\n\n" + this.InformationforMedicalDoctorLabel.Text + "\n\n" + this.Question1Label.Text + "\n" 
                + this.Question1TextBox.Text + "\n\n" + this.Question2Label.Text + "\n\n" + this.Question2TextBox.Text + "\n\n" + 
                this.ListOfMedicationsLabel.Text + "\n\n" + this.ListOfMedicationsTextBox.Text + "\n\n" + this.ResponceToMedicationsLabel.Text + 
                "\n\n" + this.ResponseToMedicationsTextBox.Text;
            InformationCompiled[0] = Information;
        }

        //This function will set the proper format for the information needed to tell the patient for the text file.
        private void CompilePatientInformation(String[] InformationCompiled)
        {
            DateTime TimeStamp = DateTime.Now;
            String Information = TimeStamp + "\n\n" + this.InformationToTellPatientLabel.Text + "\n\n" + this.PatientTextBox.Text;
            InformationCompiled[0] = Information;
        }

        //This function will move the caret to the end of the text inside of the Response Text box.
        private void moveCaretToEndAfterShortCut()
        {
            this.ResponseToMedicationsTextBox.Select(this.ResponseToMedicationsTextBox.Text.Length, 0);
            this.ResponseToMedicationsTextBox.Focus();
            this.ResponseToMedicationsTextBox.ScrollToCaret();
        }

        //Textboxs used, Lines 395-474.
        private void Question1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Question2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListOfMedicationsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResponseToMedicationsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //This function is for all of the number keys that may be pressed for the medication shortcut.
        private void ResponseToMedicationsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If a key is equal to either of the number keys,
            //that number will be deleted from the text box, and the approprate function will be called.
            if (e.KeyChar == '1')
            {
                e.Handled = e.KeyChar == '1';
                NumberShortcut(Medication1);
            }

            if (e.KeyChar == '2')
            {
                e.Handled = e.KeyChar == '2';
                NumberShortcut(Medication2);
            }

            if (e.KeyChar == '3')
            {
                e.Handled = e.KeyChar == '3';
                NumberShortcut(Medication3);
            }

            if (e.KeyChar == '4')
            {
                e.Handled = e.KeyChar == '4';
                NumberShortcut(Medication4);
            }

            if (e.KeyChar == '5')
            {
                e.Handled = e.KeyChar == '5';
                NumberShortcut(Medication5);
            }

            if (e.KeyChar == '6')
            {
                e.Handled = e.KeyChar == '6';
                NumberShortcut(Medication6);
            }

            if (e.KeyChar == '7')
            {
                e.Handled = e.KeyChar == '7';
                NumberShortcut(Medication7);
            }

            if (e.KeyChar == '8')
            {
                e.Handled = e.KeyChar == '8';
                NumberShortcut(Medication8);
            }

            if (e.KeyChar == '9')
            {
                e.Handled = e.KeyChar == '9';
                NumberShortcut(Medication9);
            }
        }

        //Text box and labels used, Lines 476-510.
        private void PatientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformationforMedicalDoctorLabel_Click(object sender, EventArgs e)
        {

        }

        private void Question1Label_Click(object sender, EventArgs e)
        {

        }

        private void Question2Label_Click(object sender, EventArgs e)
        {

        }

        private void ListOfMedicationsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResponceToMedicationsLabel_Click(object sender, EventArgs e)
        {

        }

        private void InformationToTellPatientLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

        
