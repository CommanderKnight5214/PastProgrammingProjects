
namespace Cross_and_Habit_Counter
{
    partial class CandHCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandHCounter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CrossCounterTextBox = new System.Windows.Forms.TextBox();
            this.HabitCounterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddToIndentifierButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutMenuTab = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuTab = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cross Counter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Habit Counter:";
            // 
            // CrossCounterTextBox
            // 
            this.CrossCounterTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossCounterTextBox.Location = new System.Drawing.Point(168, 85);
            this.CrossCounterTextBox.Name = "CrossCounterTextBox";
            this.CrossCounterTextBox.ReadOnly = true;
            this.CrossCounterTextBox.Size = new System.Drawing.Size(91, 33);
            this.CrossCounterTextBox.TabIndex = 2;
            this.CrossCounterTextBox.Text = "0";
            this.CrossCounterTextBox.TextChanged += new System.EventHandler(this.CrossCounterTextBox_TextChanged);
            // 
            // HabitCounterTextBox
            // 
            this.HabitCounterTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HabitCounterTextBox.Location = new System.Drawing.Point(168, 143);
            this.HabitCounterTextBox.Name = "HabitCounterTextBox";
            this.HabitCounterTextBox.ReadOnly = true;
            this.HabitCounterTextBox.Size = new System.Drawing.Size(91, 33);
            this.HabitCounterTextBox.TabIndex = 3;
            this.HabitCounterTextBox.Text = "0";
            this.HabitCounterTextBox.TextChanged += new System.EventHandler(this.HabitCounterTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adding to:";
            // 
            // AddToIndentifierButton
            // 
            this.AddToIndentifierButton.BackColor = System.Drawing.Color.Black;
            this.AddToIndentifierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToIndentifierButton.ForeColor = System.Drawing.Color.White;
            this.AddToIndentifierButton.Location = new System.Drawing.Point(118, 33);
            this.AddToIndentifierButton.Name = "AddToIndentifierButton";
            this.AddToIndentifierButton.Size = new System.Drawing.Size(141, 31);
            this.AddToIndentifierButton.TabIndex = 5;
            this.AddToIndentifierButton.Text = "Cross";
            this.AddToIndentifierButton.UseVisualStyleBackColor = false;
            this.AddToIndentifierButton.Click += new System.EventHandler(this.AddToIndentifierButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(17, 196);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(115, 48);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoButton.Location = new System.Drawing.Point(144, 196);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(115, 48);
            this.UndoButton.TabIndex = 7;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuTab,
            this.HelpMenuTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
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
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(17, 259);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(242, 48);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CandHCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 325);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddToIndentifierButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HabitCounterTextBox);
            this.Controls.Add(this.CrossCounterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CandHCounter";
            this.Text = "C&H Counter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CrossCounterTextBox;
        private System.Windows.Forms.TextBox HabitCounterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddToIndentifierButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuTab;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuTab;
        private System.Windows.Forms.Button ResetButton;
    }
}

