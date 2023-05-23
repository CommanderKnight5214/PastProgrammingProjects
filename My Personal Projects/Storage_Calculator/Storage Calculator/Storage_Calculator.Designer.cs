
namespace Storage_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.AboutMenuTab = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuTab = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MethodOfConversionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnitConversionBeforeConversionTextBox = new System.Windows.Forms.TextBox();
            this.UnitDropDown1 = new System.Windows.Forms.ComboBox();
            this.UnitDropDown2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitConversionResultTextBox = new System.Windows.Forms.TextBox();
            this.ResetProgramButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalStorageBeforeFractionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FractionTotalButton = new System.Windows.Forms.Button();
            this.Fraction90Button = new System.Windows.Forms.Button();
            this.Fraction80Button = new System.Windows.Forms.Button();
            this.Fraction70Button = new System.Windows.Forms.Button();
            this.Fraction60Button = new System.Windows.Forms.Button();
            this.Fraction50Button = new System.Windows.Forms.Button();
            this.Fraction40Button = new System.Windows.Forms.Button();
            this.Fraction30Button = new System.Windows.Forms.Button();
            this.Fraction20Button = new System.Windows.Forms.Button();
            this.Fraction10Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.StoragePercentageResultTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FileAdderStorageTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OneFileSizeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.OneFileSizeUnitTextBox = new System.Windows.Forms.TextBox();
            this.FileAdderTotalStorageLabel = new System.Windows.Forms.Label();
            this.StoragePercentageUnitTextBox = new System.Windows.Forms.TextBox();
            this.FileSizesEnteredRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ClearLockButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuTab,
            this.HelpMenuTab});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1497, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // AboutMenuTab
            // 
            this.AboutMenuTab.Name = "AboutMenuTab";
            this.AboutMenuTab.Size = new System.Drawing.Size(52, 20);
            this.AboutMenuTab.Text = "About";
            this.AboutMenuTab.Click += new System.EventHandler(this.AboutMenuTab_Click);
            // 
            // HelpMenuTab
            // 
            this.HelpMenuTab.Name = "HelpMenuTab";
            this.HelpMenuTab.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuTab.Text = "Help";
            this.HelpMenuTab.Click += new System.EventHandler(this.HelpMenuTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Method of Conversion:";
            // 
            // MethodOfConversionButton
            // 
            this.MethodOfConversionButton.BackColor = System.Drawing.Color.Bisque;
            this.MethodOfConversionButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodOfConversionButton.Location = new System.Drawing.Point(247, 82);
            this.MethodOfConversionButton.Name = "MethodOfConversionButton";
            this.MethodOfConversionButton.Size = new System.Drawing.Size(170, 35);
            this.MethodOfConversionButton.TabIndex = 3;
            this.MethodOfConversionButton.Text = "Human(1000)";
            this.MethodOfConversionButton.UseVisualStyleBackColor = false;
            this.MethodOfConversionButton.Click += new System.EventHandler(this.MethodOfConversionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unit Conversion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Storage Number to Convert:";
            // 
            // UnitConversionBeforeConversionTextBox
            // 
            this.UnitConversionBeforeConversionTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitConversionBeforeConversionTextBox.Location = new System.Drawing.Point(297, 137);
            this.UnitConversionBeforeConversionTextBox.Name = "UnitConversionBeforeConversionTextBox";
            this.UnitConversionBeforeConversionTextBox.Size = new System.Drawing.Size(120, 31);
            this.UnitConversionBeforeConversionTextBox.TabIndex = 6;
            this.UnitConversionBeforeConversionTextBox.TextChanged += new System.EventHandler(this.UnitConversionBeforeConversionTextBox_TextChanged);
            this.UnitConversionBeforeConversionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitConversionBeforeConversionTextBox_KeyPress);
            // 
            // UnitDropDown1
            // 
            this.UnitDropDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitDropDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitDropDown1.FormattingEnabled = true;
            this.UnitDropDown1.Items.AddRange(new object[] {
            "Terabytes (TB)",
            "Gigabytes (GB)",
            "Megabytes (MB)",
            "Kilobytes (KB)",
            "Bytes"});
            this.UnitDropDown1.Location = new System.Drawing.Point(17, 194);
            this.UnitDropDown1.Name = "UnitDropDown1";
            this.UnitDropDown1.Size = new System.Drawing.Size(135, 26);
            this.UnitDropDown1.TabIndex = 7;
            this.UnitDropDown1.SelectedIndexChanged += new System.EventHandler(this.UnitDropDown1_SelectedIndexChanged);
            // 
            // UnitDropDown2
            // 
            this.UnitDropDown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitDropDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitDropDown2.FormattingEnabled = true;
            this.UnitDropDown2.Items.AddRange(new object[] {
            "Terabytes (TB)",
            "Gigabytes (GB)",
            "Megabytes (MB)",
            "Kilobytes (KB)",
            "Bytes"});
            this.UnitDropDown2.Location = new System.Drawing.Point(282, 194);
            this.UnitDropDown2.Name = "UnitDropDown2";
            this.UnitDropDown2.Size = new System.Drawing.Size(135, 26);
            this.UnitDropDown2.TabIndex = 9;
            this.UnitDropDown2.SelectedIndexChanged += new System.EventHandler(this.UnitDropDown2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 26);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(17, 292);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(400, 50);
            this.ConvertButton.TabIndex = 11;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Result:";
            // 
            // UnitConversionResultTextBox
            // 
            this.UnitConversionResultTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitConversionResultTextBox.Location = new System.Drawing.Point(97, 243);
            this.UnitConversionResultTextBox.Name = "UnitConversionResultTextBox";
            this.UnitConversionResultTextBox.ReadOnly = true;
            this.UnitConversionResultTextBox.Size = new System.Drawing.Size(320, 31);
            this.UnitConversionResultTextBox.TabIndex = 13;
            this.UnitConversionResultTextBox.TextChanged += new System.EventHandler(this.UnitConversionResultTextBox_TextChanged);
            // 
            // ResetProgramButton
            // 
            this.ResetProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetProgramButton.Location = new System.Drawing.Point(17, 364);
            this.ResetProgramButton.Name = "ResetProgramButton";
            this.ResetProgramButton.Size = new System.Drawing.Size(400, 46);
            this.ResetProgramButton.TabIndex = 14;
            this.ResetProgramButton.Text = "Reset Program";
            this.ResetProgramButton.UseVisualStyleBackColor = true;
            this.ResetProgramButton.Click += new System.EventHandler(this.ResetProgramButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Storage Percentage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Your Storage Total:";
            // 
            // TotalStorageBeforeFractionTextBox
            // 
            this.TotalStorageBeforeFractionTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStorageBeforeFractionTextBox.Location = new System.Drawing.Point(690, 82);
            this.TotalStorageBeforeFractionTextBox.Name = "TotalStorageBeforeFractionTextBox";
            this.TotalStorageBeforeFractionTextBox.Size = new System.Drawing.Size(125, 33);
            this.TotalStorageBeforeFractionTextBox.TabIndex = 19;
            this.TotalStorageBeforeFractionTextBox.TextChanged += new System.EventHandler(this.TotalStorageBeforeFractionTextBox_TextChanged);
            this.TotalStorageBeforeFractionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalStorageBeforeFractionTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "Choose a Fraction";
            // 
            // FractionTotalButton
            // 
            this.FractionTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FractionTotalButton.Location = new System.Drawing.Point(515, 178);
            this.FractionTotalButton.Name = "FractionTotalButton";
            this.FractionTotalButton.Size = new System.Drawing.Size(74, 53);
            this.FractionTotalButton.TabIndex = 21;
            this.FractionTotalButton.Text = "Total";
            this.FractionTotalButton.UseVisualStyleBackColor = true;
            this.FractionTotalButton.Click += new System.EventHandler(this.FractionTotalButton_Click);
            // 
            // Fraction90Button
            // 
            this.Fraction90Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction90Button.Location = new System.Drawing.Point(595, 178);
            this.Fraction90Button.Name = "Fraction90Button";
            this.Fraction90Button.Size = new System.Drawing.Size(74, 53);
            this.Fraction90Button.TabIndex = 22;
            this.Fraction90Button.Text = "9/10";
            this.Fraction90Button.UseVisualStyleBackColor = true;
            this.Fraction90Button.Click += new System.EventHandler(this.Fraction90Button_Click);
            // 
            // Fraction80Button
            // 
            this.Fraction80Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction80Button.Location = new System.Drawing.Point(675, 178);
            this.Fraction80Button.Name = "Fraction80Button";
            this.Fraction80Button.Size = new System.Drawing.Size(74, 53);
            this.Fraction80Button.TabIndex = 23;
            this.Fraction80Button.Text = "4/5";
            this.Fraction80Button.UseVisualStyleBackColor = true;
            this.Fraction80Button.Click += new System.EventHandler(this.Fraction80Button_Click);
            // 
            // Fraction70Button
            // 
            this.Fraction70Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction70Button.Location = new System.Drawing.Point(755, 178);
            this.Fraction70Button.Name = "Fraction70Button";
            this.Fraction70Button.Size = new System.Drawing.Size(74, 53);
            this.Fraction70Button.TabIndex = 24;
            this.Fraction70Button.Text = "7/10";
            this.Fraction70Button.UseVisualStyleBackColor = true;
            this.Fraction70Button.Click += new System.EventHandler(this.Fraction70Button_Click);
            // 
            // Fraction60Button
            // 
            this.Fraction60Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction60Button.Location = new System.Drawing.Point(515, 237);
            this.Fraction60Button.Name = "Fraction60Button";
            this.Fraction60Button.Size = new System.Drawing.Size(74, 53);
            this.Fraction60Button.TabIndex = 25;
            this.Fraction60Button.Text = "3/5";
            this.Fraction60Button.UseVisualStyleBackColor = true;
            this.Fraction60Button.Click += new System.EventHandler(this.Fraction60Button_Click);
            // 
            // Fraction50Button
            // 
            this.Fraction50Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction50Button.Location = new System.Drawing.Point(595, 237);
            this.Fraction50Button.Name = "Fraction50Button";
            this.Fraction50Button.Size = new System.Drawing.Size(74, 53);
            this.Fraction50Button.TabIndex = 26;
            this.Fraction50Button.Text = "1/2";
            this.Fraction50Button.UseVisualStyleBackColor = true;
            this.Fraction50Button.Click += new System.EventHandler(this.Fraction50Button_Click);
            // 
            // Fraction40Button
            // 
            this.Fraction40Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction40Button.Location = new System.Drawing.Point(675, 237);
            this.Fraction40Button.Name = "Fraction40Button";
            this.Fraction40Button.Size = new System.Drawing.Size(74, 53);
            this.Fraction40Button.TabIndex = 27;
            this.Fraction40Button.Text = "2/5";
            this.Fraction40Button.UseVisualStyleBackColor = true;
            this.Fraction40Button.Click += new System.EventHandler(this.Fraction40Button_Click);
            // 
            // Fraction30Button
            // 
            this.Fraction30Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction30Button.Location = new System.Drawing.Point(755, 237);
            this.Fraction30Button.Name = "Fraction30Button";
            this.Fraction30Button.Size = new System.Drawing.Size(74, 53);
            this.Fraction30Button.TabIndex = 28;
            this.Fraction30Button.Text = "3/10";
            this.Fraction30Button.UseVisualStyleBackColor = true;
            this.Fraction30Button.Click += new System.EventHandler(this.Fraction30Button_Click);
            // 
            // Fraction20Button
            // 
            this.Fraction20Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction20Button.Location = new System.Drawing.Point(515, 296);
            this.Fraction20Button.Name = "Fraction20Button";
            this.Fraction20Button.Size = new System.Drawing.Size(154, 53);
            this.Fraction20Button.TabIndex = 29;
            this.Fraction20Button.Text = "1/5";
            this.Fraction20Button.UseVisualStyleBackColor = true;
            this.Fraction20Button.Click += new System.EventHandler(this.Fraction20Button_Click);
            // 
            // Fraction10Button
            // 
            this.Fraction10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction10Button.Location = new System.Drawing.Point(675, 296);
            this.Fraction10Button.Name = "Fraction10Button";
            this.Fraction10Button.Size = new System.Drawing.Size(154, 53);
            this.Fraction10Button.TabIndex = 30;
            this.Fraction10Button.Text = "1/10";
            this.Fraction10Button.UseVisualStyleBackColor = true;
            this.Fraction10Button.Click += new System.EventHandler(this.Fraction10Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Result:";
            // 
            // StoragePercentageResultTextBox
            // 
            this.StoragePercentageResultTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoragePercentageResultTextBox.Location = new System.Drawing.Point(570, 377);
            this.StoragePercentageResultTextBox.Name = "StoragePercentageResultTextBox";
            this.StoragePercentageResultTextBox.ReadOnly = true;
            this.StoragePercentageResultTextBox.Size = new System.Drawing.Size(295, 33);
            this.StoragePercentageResultTextBox.TabIndex = 32;
            this.StoragePercentageResultTextBox.TextChanged += new System.EventHandler(this.StoragePercentageResultTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1168, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 37);
            this.label9.TabIndex = 33;
            this.label9.Text = "File Adder";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(936, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Total Storage:";
            // 
            // FileAdderStorageTextBox
            // 
            this.FileAdderStorageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FileAdderStorageTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileAdderStorageTextBox.ForeColor = System.Drawing.Color.Green;
            this.FileAdderStorageTextBox.Location = new System.Drawing.Point(1089, 83);
            this.FileAdderStorageTextBox.Name = "FileAdderStorageTextBox";
            this.FileAdderStorageTextBox.ReadOnly = true;
            this.FileAdderStorageTextBox.Size = new System.Drawing.Size(336, 33);
            this.FileAdderStorageTextBox.TabIndex = 35;
            this.FileAdderStorageTextBox.TextChanged += new System.EventHandler(this.FileAdderStorageTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(979, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Enter One File Size here";
            // 
            // OneFileSizeTextBox
            // 
            this.OneFileSizeTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneFileSizeTextBox.Location = new System.Drawing.Point(941, 174);
            this.OneFileSizeTextBox.Name = "OneFileSizeTextBox";
            this.OneFileSizeTextBox.Size = new System.Drawing.Size(263, 33);
            this.OneFileSizeTextBox.TabIndex = 37;
            this.OneFileSizeTextBox.TextChanged += new System.EventHandler(this.OneFileSizeTextBox_TextChanged);
            this.OneFileSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OneFileSizeTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1291, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "File Sizes Entered";
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(941, 273);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(150, 131);
            this.EnterButton.TabIndex = 40;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoButton.Location = new System.Drawing.Point(1104, 273);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(150, 131);
            this.UndoButton.TabIndex = 41;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // OneFileSizeUnitTextBox
            // 
            this.OneFileSizeUnitTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneFileSizeUnitTextBox.Location = new System.Drawing.Point(1210, 174);
            this.OneFileSizeUnitTextBox.Name = "OneFileSizeUnitTextBox";
            this.OneFileSizeUnitTextBox.Size = new System.Drawing.Size(44, 33);
            this.OneFileSizeUnitTextBox.TabIndex = 44;
            this.OneFileSizeUnitTextBox.Text = "N/A";
            this.OneFileSizeUnitTextBox.TextChanged += new System.EventHandler(this.OneFileSizeUnitTextBox_TextChanged);
            this.OneFileSizeUnitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OneFileSizeUnitTextBox_KeyPress);
            // 
            // FileAdderTotalStorageLabel
            // 
            this.FileAdderTotalStorageLabel.AutoSize = true;
            this.FileAdderTotalStorageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileAdderTotalStorageLabel.Location = new System.Drawing.Point(1431, 86);
            this.FileAdderTotalStorageLabel.Name = "FileAdderTotalStorageLabel";
            this.FileAdderTotalStorageLabel.Size = new System.Drawing.Size(47, 25);
            this.FileAdderTotalStorageLabel.TabIndex = 46;
            this.FileAdderTotalStorageLabel.Text = "N/A";
            this.FileAdderTotalStorageLabel.Click += new System.EventHandler(this.FileAdderTotalStorageLabel_Click);
            // 
            // StoragePercentageUnitTextBox
            // 
            this.StoragePercentageUnitTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoragePercentageUnitTextBox.Location = new System.Drawing.Point(821, 82);
            this.StoragePercentageUnitTextBox.Name = "StoragePercentageUnitTextBox";
            this.StoragePercentageUnitTextBox.Size = new System.Drawing.Size(44, 33);
            this.StoragePercentageUnitTextBox.TabIndex = 47;
            this.StoragePercentageUnitTextBox.Text = "N/A";
            this.StoragePercentageUnitTextBox.TextChanged += new System.EventHandler(this.StoragePercentageUnitTextBox_TextChanged);
            this.StoragePercentageUnitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StoragePercentageUnitTextBox_KeyPress);
            // 
            // FileSizesEnteredRichTextBox
            // 
            this.FileSizesEnteredRichTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSizesEnteredRichTextBox.Location = new System.Drawing.Point(1291, 168);
            this.FileSizesEnteredRichTextBox.Name = "FileSizesEnteredRichTextBox";
            this.FileSizesEnteredRichTextBox.ReadOnly = true;
            this.FileSizesEnteredRichTextBox.Size = new System.Drawing.Size(187, 236);
            this.FileSizesEnteredRichTextBox.TabIndex = 48;
            this.FileSizesEnteredRichTextBox.Text = "";
            this.FileSizesEnteredRichTextBox.WordWrap = false;
            this.FileSizesEnteredRichTextBox.TextChanged += new System.EventHandler(this.FileSizesEnteredRichTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(936, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "Clear Lock:";
            // 
            // ClearLockButton
            // 
            this.ClearLockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.ClearLockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLockButton.Location = new System.Drawing.Point(1063, 222);
            this.ClearLockButton.Name = "ClearLockButton";
            this.ClearLockButton.Size = new System.Drawing.Size(191, 33);
            this.ClearLockButton.TabIndex = 50;
            this.ClearLockButton.Text = "On Both";
            this.ClearLockButton.UseVisualStyleBackColor = false;
            this.ClearLockButton.Click += new System.EventHandler(this.ClearLockButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 426);
            this.Controls.Add(this.ClearLockButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FileSizesEnteredRichTextBox);
            this.Controls.Add(this.StoragePercentageUnitTextBox);
            this.Controls.Add(this.FileAdderTotalStorageLabel);
            this.Controls.Add(this.OneFileSizeUnitTextBox);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.OneFileSizeTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FileAdderStorageTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StoragePercentageResultTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Fraction10Button);
            this.Controls.Add(this.Fraction20Button);
            this.Controls.Add(this.Fraction30Button);
            this.Controls.Add(this.Fraction40Button);
            this.Controls.Add(this.Fraction50Button);
            this.Controls.Add(this.Fraction60Button);
            this.Controls.Add(this.Fraction70Button);
            this.Controls.Add(this.Fraction80Button);
            this.Controls.Add(this.Fraction90Button);
            this.Controls.Add(this.FractionTotalButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalStorageBeforeFractionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResetProgramButton);
            this.Controls.Add(this.UnitConversionResultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UnitDropDown2);
            this.Controls.Add(this.UnitDropDown1);
            this.Controls.Add(this.UnitConversionBeforeConversionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MethodOfConversionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Storage Calculator";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuTab;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MethodOfConversionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnitConversionBeforeConversionTextBox;
        private System.Windows.Forms.ComboBox UnitDropDown1;
        private System.Windows.Forms.ComboBox UnitDropDown2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnitConversionResultTextBox;
        private System.Windows.Forms.Button ResetProgramButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalStorageBeforeFractionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FractionTotalButton;
        private System.Windows.Forms.Button Fraction90Button;
        private System.Windows.Forms.Button Fraction80Button;
        private System.Windows.Forms.Button Fraction70Button;
        private System.Windows.Forms.Button Fraction60Button;
        private System.Windows.Forms.Button Fraction50Button;
        private System.Windows.Forms.Button Fraction40Button;
        private System.Windows.Forms.Button Fraction30Button;
        private System.Windows.Forms.Button Fraction20Button;
        private System.Windows.Forms.Button Fraction10Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StoragePercentageResultTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FileAdderStorageTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OneFileSizeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.TextBox OneFileSizeUnitTextBox;
        private System.Windows.Forms.Label FileAdderTotalStorageLabel;
        private System.Windows.Forms.TextBox StoragePercentageUnitTextBox;
        private System.Windows.Forms.RichTextBox FileSizesEnteredRichTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ClearLockButton;
    }
}

