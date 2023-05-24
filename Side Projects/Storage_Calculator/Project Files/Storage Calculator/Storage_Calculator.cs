using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage_Calculator
{
    public partial class Form1 : Form
    {
        String Abrevation = "";
        String[] UnitListFullname = new string[5];
        String[] UnitListAbrivated = new string[5];
        String[] FilesEnteredStringStorage = new string[1000];
        Double FileAdderRunningTotal = 0;
        Double[] FilesEnteredDoubleStorage = new Double[1000];
        int UnitConversionCompleted = 0;
        int WholeUnitOption = 1;
        int StoragePercentageCompleted = 0;
        int MethodOfConversion = 1000;
        int Unit1Count = 0;
        int Unit2Count = 0;
        int ClearCount = 3;
        int Count = 0;
        int ListCount = 1;
        int IntializeCount = 0;
        int IntializeCountRichTextBox = 0;
        bool check = true;
        public Form1()
        {
            InitializeComponent();
            UnitListAbrivated[0] = "Bytes";
            UnitListAbrivated[1] = "KB";
            UnitListAbrivated[2] = "MB";
            UnitListAbrivated[3] = "GB";
            UnitListAbrivated[4] = "TB";
            UnitListFullname[0] = "Bytes";
            UnitListFullname[1] = "Kilobytes (KB)";
            UnitListFullname[2] = "Megabytes (MB)";
            UnitListFullname[3] = "Gigabytes (GB)";
            UnitListFullname[4] = "Terabytes (TB)";
        }

        private void AboutMenuTab_Click(object sender, EventArgs e)
        {
 
        }

        private void HelpMenuTab_Click(object sender, EventArgs e)
        {

        }

        private void MethodOfConversionButton_Click(object sender, EventArgs e)
        {
            if (MethodOfConversion == 1000)
            {
                MethodOfConversion = 1024;
                MethodOfConversionButton.BackColor = Color.LightSkyBlue;
                MethodOfConversionButton.Text = "Computer(1024)";
            }
            else if(MethodOfConversion == 1024)
            {
                MethodOfConversion = 1000;
                MethodOfConversionButton.BackColor = Color.Bisque;
                MethodOfConversionButton.Text = "Human(1000)";
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                String _unit1 = this.UnitDropDown1.Text;
                String _unit2 = this.UnitDropDown2.Text;
                Unit1Count = UnitFinderFunctionPlace(UnitListFullname, _unit1, Unit1Count);
                Unit2Count = UnitFinderFunctionPlace(UnitListFullname, _unit2, Unit2Count);
                Double IntialNumberBeforeConversion = Convert.ToDouble(this.UnitConversionBeforeConversionTextBox.Text);
                if(_unit1 == "" && _unit2 == "")
                    MessageBox.Show("Please select two different units before converting.", "No Units!");
                else if (_unit1 == "" || _unit2 == "")
                    MessageBox.Show("A unit is missing. Please select two " + "\n" + "different units before converting.", "Unit Missing!");
                else if(Unit1Count == Unit2Count)
                    MessageBox.Show("You cannot convert with the same unit.", "Cannot Convert!");
                else
                {
                    Double NumberToConvert = UnitConversionFunction(Unit1Count, Unit2Count, IntialNumberBeforeConversion, MethodOfConversion);
                    Abrevation = UnitAbrevationFinderFunction(Abrevation, Unit2Count);
                    String _intialNumberAfterConversion = Convert.ToString(NumberToConvert);
                    this.UnitConversionResultTextBox.Text = _intialNumberAfterConversion + " " + Abrevation;
                    this.TotalStorageBeforeFractionTextBox.Text = _intialNumberAfterConversion;
                    UnitConversionCompleted = 1;
                    WholeUnitOption = 0;
                    this.StoragePercentageUnitTextBox.ReadOnly = true;
                    this.TotalStorageBeforeFractionTextBox.ReadOnly = true;
                }
                
            }
            catch
            {
                MessageBox.Show("You must enter in a number before converting.", "No Input!");
            }
        }

        private void ResetProgramButton_Click(object sender, EventArgs e)
        {

        }

        private void FractionTotalButton_Click(object sender, EventArgs e)
        {
            if (UnitConversionCompleted == 0 && this.TotalStorageBeforeFractionTextBox.Text == ""
                && this.StoragePercentageUnitTextBox.Text == "")
                UnitConversionFractionErrorMessage();
            else
            {
                check = UnitCheckerFunction(this.StoragePercentageUnitTextBox.Text, UnitListAbrivated);
                if (check == true)
                {
                    this.StoragePercentageResultTextBox.Text = this.TotalStorageBeforeFractionTextBox.Text + " " + Abrevation;
                    this.FileAdderStorageTextBox.Text = this.TotalStorageBeforeFractionTextBox.Text;
                    FileAdderRunningTotal = Convert.ToDouble(this.FileAdderStorageTextBox.Text);
                    this.FileAdderStorageTextBox.ForeColor = Color.Green;
                    this.UnitConversionBeforeConversionTextBox.ReadOnly = true;
                    StoragePercentageCompleted = 1;
                    if (WholeUnitOption == 1)
                    {
                        Unit1Count = UnitFinderFunctionPlace(UnitListFullname, this.StoragePercentageResultTextBox.Text, Unit1Count);
                        Unit2Count = Unit1Count;
                        this.FileAdderTotalStorageLabel.Text = this.StoragePercentageUnitTextBox.Text;
                    }
                }
                else
                    InvalidUnitTypeErrorMessage();
            }
        }

        private void Fraction90Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.90);
        }

        private void Fraction80Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.80);
        }

        private void Fraction70Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.70);
        }

        private void Fraction60Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.60);
        }

        private void Fraction50Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.50);
        }

        private void Fraction40Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.40);
        }

        private void Fraction30Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.30);
        }

        private void Fraction20Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.20);
        }

        private void Fraction10Button_Click(object sender, EventArgs e)
        {
            FractionCalculationFunction(this.TotalStorageBeforeFractionTextBox.Text, 0.10);
        }

        private void ClearLockButton_Click(object sender, EventArgs e)
        {
            if(IntializeCount == 0)
            {
                IntializeCount = 1;
                ClearCount--;
            }
            if (ClearCount == 3)
            {
                ClearCount--;
                ClearLockButton.BackColor = Color.FromArgb(0, 186, 68);
                ClearLockButton.Text = "On Both";
                this.ActiveControl = this.OneFileSizeTextBox;
                this.OneFileSizeTextBox.Focus();
            }
            else if (ClearCount == 2)
            {
                ClearCount--;
                ClearLockButton.BackColor = Color.FromArgb(0,186,68);
                ClearLockButton.Text = "On Left Text Box";
                this.ActiveControl = this.OneFileSizeTextBox;
                this.OneFileSizeTextBox.Focus();
            }
            else if (ClearCount == 1)
            {
                ClearCount--;
                ClearLockButton.BackColor = Color.FromArgb(0, 186, 68);
                ClearLockButton.Text = "On Right Text Box";
                this.ActiveControl = this.OneFileSizeTextBox;
                this.OneFileSizeTextBox.Focus();
            }
            else if (ClearCount == 0)
            {
                ClearCount = 3;
                ClearLockButton.BackColor = Color.FromArgb(219, 31, 31);
                ClearLockButton.Text = "Off";
                this.ActiveControl = this.OneFileSizeTextBox;
                this.OneFileSizeTextBox.Focus();
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            EnterFunction();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (UnitConversionCompleted == 0 && StoragePercentageCompleted == 0)
                UnitConversionFractionErrorMessage();
            else if (StoragePercentageCompleted == 0)
                FractionErrorMessage();
            else if(IntializeCountRichTextBox == 0)
                MessageBox.Show("There are no File Sizes Entered to undo", "Nothing to Undo!");
            else
            {
                IntializeCountRichTextBox = 1;
                Count--;
                ListCount--;
                if(Count < 0)
                {
                    Count++;
                    ListCount++;
                    MessageBox.Show("All File Sizes have been undone.", "Maximum Reached");
                }
                else
                {
                    Double NumberToUndo = FilesEnteredDoubleStorage[Count];
                    String TextToUndo = FilesEnteredStringStorage[Count];
                    FilesEnteredDoubleStorage[Count] = 0;
                    FilesEnteredStringStorage[Count] = "";
                    FileAdderRunningTotal = FileAdderRunningTotal + NumberToUndo;
                    this.FileAdderStorageTextBox.Text = Convert.ToString(FileAdderRunningTotal);
                    FileAdderTextChangeFunction(FileAdderRunningTotal);
                    var LastListItem = this.FileSizesEnteredRichTextBox.Text.LastIndexOf(TextToUndo);
                    this.FileSizesEnteredRichTextBox.SelectionStart = LastListItem;
                    this.FileSizesEnteredRichTextBox.SelectionLength = this.FileSizesEnteredRichTextBox.TextLength - LastListItem;
                    this.FileSizesEnteredRichTextBox.ReadOnly = false;
                    this.FileSizesEnteredRichTextBox.SelectedText = "";
                    this.FileSizesEnteredRichTextBox.ReadOnly = true;
                }
            }
        }

        private int UnitFinderFunctionPlace(String[] ArrayList, String unit, int Count)
        {
            for(int i = 0; i < ArrayList.Length; i++)
            {
                if(ArrayList[i] == unit)
                    Count = i;
            }
            return Count;
        }

        private double UnitConversionFunction(int Number1, int Number2, double TotalToCalculate, int MethodOfConversion)
        {
            if (Number1 > Number2)
            {
                while (Number1 > Number2)
                {
                    TotalToCalculate = TotalToCalculate * MethodOfConversion;
                    Number1--;
                }
            }
            else if (Number1 < Number2)
            {
                while (Number1 < Number2)
                {
                    TotalToCalculate = TotalToCalculate / MethodOfConversion;
                    Number1++;
                }
            }
            return TotalToCalculate;
            
        }

        private void UnitConversionFractionErrorMessage()
        {
            MessageBox.Show("You must either complete the Unit Conversion step, or you " + "\n" + "must enter a number into the" +
                " 'Your Storage Total' Text Box.", "Must Complete Conversion Step!");
        }

        private void InvalidUnitTypeErrorMessage()
        {
            MessageBox.Show("You must type in a valid unit type in." + "\n" + "Example: TB, GB, MB, KB, or Bytes", "Invalid Unit Type!");
        }

        private string UnitAbrevationFinderFunction(String Abrevation, int Count)
        {
            Abrevation = UnitListAbrivated[Count];
            this.StoragePercentageUnitTextBox.Text = Abrevation;
            this.FileAdderTotalStorageLabel.Text = Abrevation;
            this.OneFileSizeUnitTextBox.Text = Abrevation;
            return Abrevation;
        }

        private void FractionCalculationFunction(String Total, double FractionIdentifier)
        {
            if (UnitConversionCompleted == 0 && this.TotalStorageBeforeFractionTextBox.Text == "" 
                && this.StoragePercentageUnitTextBox.Text == "")
                UnitConversionFractionErrorMessage();
            else
            {
                check = UnitCheckerFunction(this.StoragePercentageUnitTextBox.Text, UnitListAbrivated);
                if(check == true)
                {
                    Double TotalBeforeFractionCalculation = Convert.ToDouble(Total);
                    TotalBeforeFractionCalculation = TotalBeforeFractionCalculation * FractionIdentifier;
                    String _totalAfterFractionConversion = Convert.ToString(TotalBeforeFractionCalculation);
                    this.StoragePercentageResultTextBox.Text = _totalAfterFractionConversion + " " + Abrevation;
                    this.FileAdderStorageTextBox.Text = _totalAfterFractionConversion;
                    FileAdderRunningTotal = Convert.ToDouble(this.FileAdderStorageTextBox.Text);
                    this.FileAdderStorageTextBox.ForeColor = Color.Green;
                    StoragePercentageCompleted = 1;
                    this.UnitConversionBeforeConversionTextBox.ReadOnly = true;
                    if (WholeUnitOption == 1)
                    {
                        Unit1Count = UnitFinderFunctionPlace(UnitListFullname, this.StoragePercentageUnitTextBox.Text, Unit1Count);
                        Unit2Count = Unit1Count;
                        this.FileAdderTotalStorageLabel.Text = this.StoragePercentageUnitTextBox.Text;
                    }
                }
                else
                    InvalidUnitTypeErrorMessage();
                
            }
        }

        private bool UnitCheckerFunction(string TextToFindInArray, string[] ListAbreviated)
        {
            string value = TextToFindInArray;
            var check = Array.Exists(ListAbreviated, x => x == value);
            return check;
        }

        private void FractionErrorMessage()
        {
            MessageBox.Show("You must complete the 'Storage Percentage' step.", "Must Complete Storage Percentage Step!");
        }

        private void EnterFunction()
        {
            if(UnitConversionCompleted == 0 && StoragePercentageCompleted == 0)
                UnitConversionFractionErrorMessage();
            else if (StoragePercentageCompleted == 0)
                FractionErrorMessage();
            else
            {
                if(this.OneFileSizeTextBox.Text == "" && this.OneFileSizeUnitTextBox.Text == "")
                {
                    MessageBox.Show("You must have a File Size and a Unit in order " + "\n" + "to add the File Size to the " +
                        "List and Total.", "Missing Information!");
                }
                else if (this.OneFileSizeTextBox.Text == "")
                {
                    MessageBox.Show("You must have a File size in order to " + "\n" + "add the File Size to the List and Total.",
                        "Missing File Size!");
                }
                else if(this.OneFileSizeUnitTextBox.Text == "")
                {
                    MessageBox.Show("You must have a Unit in order to " + "\n" + "add the File Size to the List and Total.",
                        "Missing Unit!");
                }
                else
                {
                    Double FileToSubtract = Convert.ToDouble(this.OneFileSizeTextBox.Text);
                    if (this.OneFileSizeUnitTextBox.Text != this.FileAdderTotalStorageLabel.Text)
                    {
                        Unit1Count = UnitFinderFunctionPlace(UnitListAbrivated, this.OneFileSizeUnitTextBox.Text, Unit1Count);
                        FileToSubtract = UnitConversionFunction(Unit1Count, Unit2Count, FileToSubtract, MethodOfConversion);
                    }
                    check = UnitCheckerFunction(this.OneFileSizeUnitTextBox.Text, UnitListAbrivated);
                    if (check == true)
                    {
                        FileAdderRunningTotal = FileAdderRunningTotal - FileToSubtract;
                        String FileAdderRunningTotalString = Convert.ToString(FileAdderRunningTotal);
                        String CountConversion = Convert.ToString(ListCount);
                        String FileToSubtractPrint = Convert.ToString(FileToSubtract);
                        String TempDisplay = CountConversion + ". " + FileToSubtractPrint + " " + Abrevation + "\n";
                        FilesEnteredDoubleStorage[Count] = FileToSubtract;
                        FilesEnteredStringStorage[Count] = TempDisplay;
                        this.FileSizesEnteredRichTextBox.Text = this.FileSizesEnteredRichTextBox.Text + TempDisplay;
                        this.FileAdderStorageTextBox.Text = FileAdderRunningTotalString;
                        this.StoragePercentageUnitTextBox.ReadOnly = true;
                        this.TotalStorageBeforeFractionTextBox.ReadOnly = true;
                        FileAdderTextChangeFunction(FileAdderRunningTotal);
                        if (ClearCount == 3 && IntializeCount == 0)
                        {
                            this.OneFileSizeTextBox.Clear();
                            this.OneFileSizeUnitTextBox.Clear();
                        }
                        if (ClearCount == 2)
                        {
                            this.OneFileSizeTextBox.Clear();
                            this.OneFileSizeUnitTextBox.Clear();
                        }
                        if (ClearCount == 1)
                        {
                            this.OneFileSizeTextBox.Clear();
                        }
                        if (ClearCount == 0)
                        {
                            this.OneFileSizeUnitTextBox.Clear();
                        }
                        IntializeCountRichTextBox = 1;
                        Count++;
                        ListCount++;
                    }
                    else
                        InvalidUnitTypeErrorMessage();
                }
            }
        }

        private void FileAdderTextChangeFunction(Double RunningTotal)
        {
            if (RunningTotal > 0)
                this.FileAdderStorageTextBox.ForeColor = Color.Green;
            else if (RunningTotal < 0)
            {
                this.FileAdderStorageTextBox.Text = "-" + RunningTotal;
                this.FileAdderStorageTextBox.ForeColor = Color.Red;
            }
            else if (RunningTotal == 0)
            {
                this.FileAdderStorageTextBox.Text = "MAX STORAGE REACHED!";
                this.FileAdderStorageTextBox.ForeColor = Color.Black;
            }
        }

        private void FileAdderTotalStorageLabel_Click(object sender, EventArgs e)
        {

        }

        private void UnitDropDown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnitDropDown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnitConversionBeforeConversionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnitConversionBeforeConversionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void UnitConversionResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalStorageBeforeFractionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalStorageBeforeFractionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void StoragePercentageUnitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StoragePercentageResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StoragePercentageUnitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8 || e.KeyChar == (char)66 || e.KeyChar == (char)101 || e.KeyChar == (char)71
                || e.KeyChar == (char)75 || e.KeyChar == (char)77 || e.KeyChar == (char)115 || e.KeyChar == (char)115
                || e.KeyChar == (char)84 || e.KeyChar == (char)116 || e.KeyChar == (char)121)
            {

            }

            else
                e.Handled = true;
        }

        private void FileAdderStorageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OneFileSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OneFileSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

            if (e.KeyChar == (char)13)
            {
                e.Handled = e.KeyChar == (char)13;
                EnterFunction();
            }
        }

        private void OneFileSizeUnitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OneFileSizeUnitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = e.KeyChar == (char)13;
                EnterFunction();
            }
            if (e.KeyChar == (char)8 || e.KeyChar == (char)66 || e.KeyChar == (char)101 || e.KeyChar == (char)71
                || e.KeyChar == (char)75 || e.KeyChar == (char)77 || e.KeyChar == (char)115 || e.KeyChar == (char)84 
                || e.KeyChar == (char)116 || e.KeyChar == (char)121)
            {

            }

            else
                e.Handled = true;
        }

        private void FileSizesEnteredRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
