
namespace Memory_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageFromDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInfoForDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInfoToTellPatientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Question1TextBox = new System.Windows.Forms.TextBox();
            this.PatientTextBox = new System.Windows.Forms.TextBox();
            this.InformationforMedicalDoctorLabel = new System.Windows.Forms.Label();
            this.InformationToTellPatientLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Question1Label = new System.Windows.Forms.Label();
            this.Question2Label = new System.Windows.Forms.Label();
            this.Question2TextBox = new System.Windows.Forms.TextBox();
            this.Question3Label = new System.Windows.Forms.Label();
            this.Question3TextBox = new System.Windows.Forms.TextBox();
            this.Question4Label = new System.Windows.Forms.Label();
            this.Question4TextBox = new System.Windows.Forms.TextBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Date = new System.Windows.Forms.Label();
            this.Todays_Date = new System.Windows.Forms.Label();
            this.Undo = new System.Windows.Forms.Button();
            this.ListOfMedicationsLabel = new System.Windows.Forms.Label();
            this.ResponceToMedicationsLabel = new System.Windows.Forms.Label();
            this.ListOfMedicationsTextBox = new System.Windows.Forms.TextBox();
            this.Medication1Shortcut = new System.Windows.Forms.Button();
            this.Medication2Shortcut = new System.Windows.Forms.Button();
            this.Medication3Shortcut = new System.Windows.Forms.Button();
            this.Medication4Shortcut = new System.Windows.Forms.Button();
            this.Medication5Shortcut = new System.Windows.Forms.Button();
            this.Medication6Shortcut = new System.Windows.Forms.Button();
            this.ResponseToMedicationsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Medication7Shortcut = new System.Windows.Forms.Button();
            this.Medication8Shortcut = new System.Windows.Forms.Button();
            this.Medication9Shortcut = new System.Windows.Forms.Button();
            this.Medication10Shortcut = new System.Windows.Forms.Button();
            this.Medication11Shortcut = new System.Windows.Forms.Button();
            this.Medication12Shortcut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.messageFromDeveloperToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // messageFromDeveloperToolStripMenuItem
            // 
            this.messageFromDeveloperToolStripMenuItem.Name = "messageFromDeveloperToolStripMenuItem";
            this.messageFromDeveloperToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.messageFromDeveloperToolStripMenuItem.Text = "Message From Developer";
            this.messageFromDeveloperToolStripMenuItem.Click += new System.EventHandler(this.messageFromDeveloperToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllToolStripMenuItem,
            this.saveInfoForDoctorToolStripMenuItem,
            this.saveInfoToTellPatientToolStripMenuItem1});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // saveInfoForDoctorToolStripMenuItem
            // 
            this.saveInfoForDoctorToolStripMenuItem.Name = "saveInfoForDoctorToolStripMenuItem";
            this.saveInfoForDoctorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveInfoForDoctorToolStripMenuItem.Text = "Save Info for Doctor";
            this.saveInfoForDoctorToolStripMenuItem.Click += new System.EventHandler(this.saveInfoForDoctorToolStripMenuItem_Click);
            // 
            // saveInfoToTellPatientToolStripMenuItem1
            // 
            this.saveInfoToTellPatientToolStripMenuItem1.Name = "saveInfoToTellPatientToolStripMenuItem1";
            this.saveInfoToTellPatientToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.saveInfoToTellPatientToolStripMenuItem1.Text = "Save Info to Tell Patient";
            this.saveInfoToTellPatientToolStripMenuItem1.Click += new System.EventHandler(this.saveInfoToTellPatientToolStripMenuItem1_Click);
            // 
            // Question1TextBox
            // 
            this.Question1TextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1TextBox.Location = new System.Drawing.Point(12, 135);
            this.Question1TextBox.Multiline = true;
            this.Question1TextBox.Name = "Question1TextBox";
            this.Question1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Question1TextBox.Size = new System.Drawing.Size(475, 167);
            this.Question1TextBox.TabIndex = 1;
            this.Question1TextBox.TextChanged += new System.EventHandler(this.Question1TextBox_TextChanged);
            // 
            // PatientTextBox
            // 
            this.PatientTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientTextBox.Location = new System.Drawing.Point(1285, 83);
            this.PatientTextBox.Multiline = true;
            this.PatientTextBox.Name = "PatientTextBox";
            this.PatientTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PatientTextBox.Size = new System.Drawing.Size(475, 661);
            this.PatientTextBox.TabIndex = 2;
            this.PatientTextBox.TextChanged += new System.EventHandler(this.PatientTextBox_TextChanged);
            // 
            // InformationforMedicalDoctorLabel
            // 
            this.InformationforMedicalDoctorLabel.AutoSize = true;
            this.InformationforMedicalDoctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationforMedicalDoctorLabel.Location = new System.Drawing.Point(307, 35);
            this.InformationforMedicalDoctorLabel.Name = "InformationforMedicalDoctorLabel";
            this.InformationforMedicalDoctorLabel.Size = new System.Drawing.Size(406, 33);
            this.InformationforMedicalDoctorLabel.TabIndex = 3;
            this.InformationforMedicalDoctorLabel.Text = "Information for Medical Doctor";
            this.InformationforMedicalDoctorLabel.Click += new System.EventHandler(this.InformationforMedicalDoctorLabel_Click);
            // 
            // InformationToTellPatientLabel
            // 
            this.InformationToTellPatientLabel.AutoSize = true;
            this.InformationToTellPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationToTellPatientLabel.Location = new System.Drawing.Point(1357, 32);
            this.InformationToTellPatientLabel.Name = "InformationToTellPatientLabel";
            this.InformationToTellPatientLabel.Size = new System.Drawing.Size(365, 33);
            this.InformationToTellPatientLabel.TabIndex = 4;
            this.InformationToTellPatientLabel.Text = "Information To Tell Patient.";
            this.InformationToTellPatientLabel.Click += new System.EventHandler(this.InformationToTellPatientLabel_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(995, 135);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(274, 167);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Question1Label
            // 
            this.Question1Label.AutoSize = true;
            this.Question1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1Label.Location = new System.Drawing.Point(76, 96);
            this.Question1Label.Name = "Question1Label";
            this.Question1Label.Size = new System.Drawing.Size(363, 25);
            this.Question1Label.TabIndex = 8;
            this.Question1Label.Text = "How is the Patients Physical Health?";
            this.Question1Label.Click += new System.EventHandler(this.Question1Label_Click);
            // 
            // Question2Label
            // 
            this.Question2Label.AutoSize = true;
            this.Question2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2Label.Location = new System.Drawing.Point(76, 315);
            this.Question2Label.Name = "Question2Label";
            this.Question2Label.Size = new System.Drawing.Size(347, 25);
            this.Question2Label.TabIndex = 9;
            this.Question2Label.Text = "How is the Patients Mental Health?";
            this.Question2Label.Click += new System.EventHandler(this.Question2Label_Click);
            // 
            // Question2TextBox
            // 
            this.Question2TextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2TextBox.Location = new System.Drawing.Point(12, 354);
            this.Question2TextBox.Multiline = true;
            this.Question2TextBox.Name = "Question2TextBox";
            this.Question2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Question2TextBox.Size = new System.Drawing.Size(475, 167);
            this.Question2TextBox.TabIndex = 10;
            this.Question2TextBox.TextChanged += new System.EventHandler(this.Question2TextBox_TextChanged);
            // 
            // Question3Label
            // 
            this.Question3Label.AutoSize = true;
            this.Question3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3Label.Location = new System.Drawing.Point(555, 96);
            this.Question3Label.Name = "Question3Label";
            this.Question3Label.Size = new System.Drawing.Size(377, 25);
            this.Question3Label.TabIndex = 11;
            this.Question3Label.Text = "How is the Patients Emotional Health?";
            this.Question3Label.Click += new System.EventHandler(this.Question3Label_Click);
            // 
            // Question3TextBox
            // 
            this.Question3TextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3TextBox.Location = new System.Drawing.Point(507, 135);
            this.Question3TextBox.Multiline = true;
            this.Question3TextBox.Name = "Question3TextBox";
            this.Question3TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Question3TextBox.Size = new System.Drawing.Size(475, 167);
            this.Question3TextBox.TabIndex = 12;
            this.Question3TextBox.TextChanged += new System.EventHandler(this.Question3TextBox_TextChanged);
            // 
            // Question4Label
            // 
            this.Question4Label.AutoSize = true;
            this.Question4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question4Label.Location = new System.Drawing.Point(518, 316);
            this.Question4Label.Name = "Question4Label";
            this.Question4Label.Size = new System.Drawing.Size(454, 24);
            this.Question4Label.TabIndex = 13;
            this.Question4Label.Text = "Are their any Memories that the Patient has forgotten?";
            this.Question4Label.Click += new System.EventHandler(this.Question4Label_Click);
            // 
            // Question4TextBox
            // 
            this.Question4TextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question4TextBox.Location = new System.Drawing.Point(507, 354);
            this.Question4TextBox.Multiline = true;
            this.Question4TextBox.Name = "Question4TextBox";
            this.Question4TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Question4TextBox.Size = new System.Drawing.Size(475, 167);
            this.Question4TextBox.TabIndex = 14;
            this.Question4TextBox.TextChanged += new System.EventHandler(this.Question4TextBox_TextChanged);
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(49, 24);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 26);
            this.Date.TabIndex = 15;
            // 
            // Todays_Date
            // 
            this.Todays_Date.AutoSize = true;
            this.Todays_Date.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todays_Date.Location = new System.Drawing.Point(55, 32);
            this.Todays_Date.Name = "Todays_Date";
            this.Todays_Date.Size = new System.Drawing.Size(127, 39);
            this.Todays_Date.TabIndex = 16;
            this.Todays_Date.Text = "__ __ __";
            // 
            // Undo
            // 
            this.Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undo.Location = new System.Drawing.Point(995, 354);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(274, 167);
            this.Undo.TabIndex = 17;
            this.Undo.Text = "Restore File";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // ListOfMedicationsLabel
            // 
            this.ListOfMedicationsLabel.AutoSize = true;
            this.ListOfMedicationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfMedicationsLabel.Location = new System.Drawing.Point(49, 539);
            this.ListOfMedicationsLabel.Name = "ListOfMedicationsLabel";
            this.ListOfMedicationsLabel.Size = new System.Drawing.Size(400, 25);
            this.ListOfMedicationsLabel.TabIndex = 18;
            this.ListOfMedicationsLabel.Text = "List of Medications the Patient is Taking.";
            this.ListOfMedicationsLabel.Click += new System.EventHandler(this.ListOfMedicationsLabel_Click);
            // 
            // ResponceToMedicationsLabel
            // 
            this.ResponceToMedicationsLabel.AutoSize = true;
            this.ResponceToMedicationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponceToMedicationsLabel.Location = new System.Drawing.Point(540, 539);
            this.ResponceToMedicationsLabel.Name = "ResponceToMedicationsLabel";
            this.ResponceToMedicationsLabel.Size = new System.Drawing.Size(409, 25);
            this.ResponceToMedicationsLabel.TabIndex = 19;
            this.ResponceToMedicationsLabel.Text = "Symptoms and Response to Medications.";
            this.ResponceToMedicationsLabel.Click += new System.EventHandler(this.ResponceToMedicationsLabel_Click);
            // 
            // ListOfMedicationsTextBox
            // 
            this.ListOfMedicationsTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfMedicationsTextBox.Location = new System.Drawing.Point(12, 577);
            this.ListOfMedicationsTextBox.Multiline = true;
            this.ListOfMedicationsTextBox.Name = "ListOfMedicationsTextBox";
            this.ListOfMedicationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListOfMedicationsTextBox.Size = new System.Drawing.Size(475, 167);
            this.ListOfMedicationsTextBox.TabIndex = 20;
            this.ListOfMedicationsTextBox.TextChanged += new System.EventHandler(this.ListOfMedicationsTextBox_TextChanged);
            // 
            // Medication1Shortcut
            // 
            this.Medication1Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication1Shortcut.Location = new System.Drawing.Point(995, 615);
            this.Medication1Shortcut.Name = "Medication1Shortcut";
            this.Medication1Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication1Shortcut.TabIndex = 21;
            this.Medication1Shortcut.Text = "1";
            this.Medication1Shortcut.UseVisualStyleBackColor = true;
            this.Medication1Shortcut.Click += new System.EventHandler(this.Medication1Shortcut_Click);
            // 
            // Medication2Shortcut
            // 
            this.Medication2Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication2Shortcut.Location = new System.Drawing.Point(1065, 615);
            this.Medication2Shortcut.Name = "Medication2Shortcut";
            this.Medication2Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication2Shortcut.TabIndex = 22;
            this.Medication2Shortcut.Text = "2";
            this.Medication2Shortcut.UseVisualStyleBackColor = true;
            this.Medication2Shortcut.Click += new System.EventHandler(this.Medication2Shortcut_Click);
            // 
            // Medication3Shortcut
            // 
            this.Medication3Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication3Shortcut.Location = new System.Drawing.Point(1135, 615);
            this.Medication3Shortcut.Name = "Medication3Shortcut";
            this.Medication3Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication3Shortcut.TabIndex = 23;
            this.Medication3Shortcut.Text = "3";
            this.Medication3Shortcut.UseVisualStyleBackColor = true;
            this.Medication3Shortcut.Click += new System.EventHandler(this.Medication3Shortcut_Click);
            // 
            // Medication4Shortcut
            // 
            this.Medication4Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication4Shortcut.Location = new System.Drawing.Point(1205, 615);
            this.Medication4Shortcut.Name = "Medication4Shortcut";
            this.Medication4Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication4Shortcut.TabIndex = 24;
            this.Medication4Shortcut.Text = "4";
            this.Medication4Shortcut.UseVisualStyleBackColor = true;
            this.Medication4Shortcut.Click += new System.EventHandler(this.Medication4Shortcut_Click);
            // 
            // Medication5Shortcut
            // 
            this.Medication5Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication5Shortcut.Location = new System.Drawing.Point(995, 660);
            this.Medication5Shortcut.Name = "Medication5Shortcut";
            this.Medication5Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication5Shortcut.TabIndex = 25;
            this.Medication5Shortcut.Text = "5";
            this.Medication5Shortcut.UseVisualStyleBackColor = true;
            this.Medication5Shortcut.Click += new System.EventHandler(this.Medication5Shortcut_Click);
            // 
            // Medication6Shortcut
            // 
            this.Medication6Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication6Shortcut.Location = new System.Drawing.Point(1065, 660);
            this.Medication6Shortcut.Name = "Medication6Shortcut";
            this.Medication6Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication6Shortcut.TabIndex = 26;
            this.Medication6Shortcut.Text = "6";
            this.Medication6Shortcut.UseVisualStyleBackColor = true;
            this.Medication6Shortcut.Click += new System.EventHandler(this.Medication6Shortcut_Click);
            // 
            // ResponseToMedicationsTextBox
            // 
            this.ResponseToMedicationsTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseToMedicationsTextBox.Location = new System.Drawing.Point(507, 577);
            this.ResponseToMedicationsTextBox.Multiline = true;
            this.ResponseToMedicationsTextBox.Name = "ResponseToMedicationsTextBox";
            this.ResponseToMedicationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResponseToMedicationsTextBox.Size = new System.Drawing.Size(475, 167);
            this.ResponseToMedicationsTextBox.TabIndex = 27;
            this.ResponseToMedicationsTextBox.TextChanged += new System.EventHandler(this.ResponseToMedicationsTextBox_TextChanged);
            this.ResponseToMedicationsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResponseToMedicationsTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1030, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Medication Shortcut";
            // 
            // Medication7Shortcut
            // 
            this.Medication7Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication7Shortcut.Location = new System.Drawing.Point(1135, 660);
            this.Medication7Shortcut.Name = "Medication7Shortcut";
            this.Medication7Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication7Shortcut.TabIndex = 29;
            this.Medication7Shortcut.Text = "7";
            this.Medication7Shortcut.UseVisualStyleBackColor = true;
            this.Medication7Shortcut.Click += new System.EventHandler(this.Medication7Shortcut_Click);
            // 
            // Medication8Shortcut
            // 
            this.Medication8Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication8Shortcut.Location = new System.Drawing.Point(1205, 660);
            this.Medication8Shortcut.Name = "Medication8Shortcut";
            this.Medication8Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication8Shortcut.TabIndex = 30;
            this.Medication8Shortcut.Text = "8";
            this.Medication8Shortcut.UseVisualStyleBackColor = true;
            this.Medication8Shortcut.Click += new System.EventHandler(this.Medication8Shortcut_Click);
            // 
            // Medication9Shortcut
            // 
            this.Medication9Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication9Shortcut.Location = new System.Drawing.Point(995, 705);
            this.Medication9Shortcut.Name = "Medication9Shortcut";
            this.Medication9Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication9Shortcut.TabIndex = 31;
            this.Medication9Shortcut.Text = "9";
            this.Medication9Shortcut.UseVisualStyleBackColor = true;
            this.Medication9Shortcut.Click += new System.EventHandler(this.Medication9Shortcut_Click);
            // 
            // Medication10Shortcut
            // 
            this.Medication10Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication10Shortcut.Location = new System.Drawing.Point(1065, 705);
            this.Medication10Shortcut.Name = "Medication10Shortcut";
            this.Medication10Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication10Shortcut.TabIndex = 32;
            this.Medication10Shortcut.Text = "10";
            this.Medication10Shortcut.UseVisualStyleBackColor = true;
            this.Medication10Shortcut.Click += new System.EventHandler(this.Medication10Shortcut_Click);
            // 
            // Medication11Shortcut
            // 
            this.Medication11Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication11Shortcut.Location = new System.Drawing.Point(1135, 705);
            this.Medication11Shortcut.Name = "Medication11Shortcut";
            this.Medication11Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication11Shortcut.TabIndex = 33;
            this.Medication11Shortcut.Text = "11";
            this.Medication11Shortcut.UseVisualStyleBackColor = true;
            this.Medication11Shortcut.Click += new System.EventHandler(this.Medication11Shortcut_Click);
            // 
            // Medication12Shortcut
            // 
            this.Medication12Shortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medication12Shortcut.Location = new System.Drawing.Point(1205, 705);
            this.Medication12Shortcut.Name = "Medication12Shortcut";
            this.Medication12Shortcut.Size = new System.Drawing.Size(64, 39);
            this.Medication12Shortcut.TabIndex = 34;
            this.Medication12Shortcut.Text = "12";
            this.Medication12Shortcut.UseVisualStyleBackColor = true;
            this.Medication12Shortcut.Click += new System.EventHandler(this.Medication12Shortcut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 760);
            this.Controls.Add(this.Medication12Shortcut);
            this.Controls.Add(this.Medication11Shortcut);
            this.Controls.Add(this.Medication10Shortcut);
            this.Controls.Add(this.Medication9Shortcut);
            this.Controls.Add(this.Medication8Shortcut);
            this.Controls.Add(this.Medication7Shortcut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResponseToMedicationsTextBox);
            this.Controls.Add(this.Medication6Shortcut);
            this.Controls.Add(this.Medication5Shortcut);
            this.Controls.Add(this.Medication4Shortcut);
            this.Controls.Add(this.Medication3Shortcut);
            this.Controls.Add(this.Medication2Shortcut);
            this.Controls.Add(this.Medication1Shortcut);
            this.Controls.Add(this.ListOfMedicationsTextBox);
            this.Controls.Add(this.ResponceToMedicationsLabel);
            this.Controls.Add(this.ListOfMedicationsLabel);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Todays_Date);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Question4TextBox);
            this.Controls.Add(this.Question4Label);
            this.Controls.Add(this.Question3TextBox);
            this.Controls.Add(this.Question3Label);
            this.Controls.Add(this.Question2TextBox);
            this.Controls.Add(this.Question2Label);
            this.Controls.Add(this.Question1Label);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.InformationToTellPatientLabel);
            this.Controls.Add(this.InformationforMedicalDoctorLabel);
            this.Controls.Add(this.PatientTextBox);
            this.Controls.Add(this.Question1TextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Memory Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageFromDeveloperToolStripMenuItem;
        private System.Windows.Forms.TextBox Question1TextBox;
        private System.Windows.Forms.TextBox PatientTextBox;
        private System.Windows.Forms.Label InformationforMedicalDoctorLabel;
        private System.Windows.Forms.Label InformationToTellPatientLabel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.Label Question1Label;
        private System.Windows.Forms.Label Question2Label;
        private System.Windows.Forms.TextBox Question2TextBox;
        private System.Windows.Forms.Label Question3Label;
        private System.Windows.Forms.TextBox Question3TextBox;
        private System.Windows.Forms.Label Question4Label;
        private System.Windows.Forms.TextBox Question4TextBox;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Todays_Date;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ListOfMedicationsLabel;
        private System.Windows.Forms.Label ResponceToMedicationsLabel;
        private System.Windows.Forms.TextBox ListOfMedicationsTextBox;
        private System.Windows.Forms.Button Medication1Shortcut;
        private System.Windows.Forms.Button Medication2Shortcut;
        private System.Windows.Forms.Button Medication3Shortcut;
        private System.Windows.Forms.Button Medication4Shortcut;
        private System.Windows.Forms.Button Medication5Shortcut;
        private System.Windows.Forms.Button Medication6Shortcut;
        private System.Windows.Forms.TextBox ResponseToMedicationsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Medication7Shortcut;
        private System.Windows.Forms.Button Medication8Shortcut;
        private System.Windows.Forms.Button Medication9Shortcut;
        private System.Windows.Forms.Button Medication10Shortcut;
        private System.Windows.Forms.Button Medication11Shortcut;
        private System.Windows.Forms.Button Medication12Shortcut;
        private System.Windows.Forms.ToolStripMenuItem saveInfoForDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInfoToTellPatientToolStripMenuItem1;
    }
}

