
namespace HackathonProject_Spring2021
{
    partial class ManagerMenu
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
            this.button_refund = new System.Windows.Forms.Button();
            this.button_receipt = new System.Windows.Forms.Button();
            this.button_clockIn = new System.Windows.Forms.Button();
            this.button_clockOut = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_hReceipt = new System.Windows.Forms.Button();
            this.button_hIn = new System.Windows.Forms.Button();
            this.button_hOut = new System.Windows.Forms.Button();
            this.button_hRefund = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_hReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_refund
            // 
            this.button_refund.Location = new System.Drawing.Point(12, 11);
            this.button_refund.Name = "button_refund";
            this.button_refund.Size = new System.Drawing.Size(239, 45);
            this.button_refund.TabIndex = 0;
            this.button_refund.Text = "Refund Transaction";
            this.button_refund.UseVisualStyleBackColor = true;
            this.button_refund.Click += new System.EventHandler(this.button_refund_Click);
            // 
            // button_receipt
            // 
            this.button_receipt.Location = new System.Drawing.Point(12, 74);
            this.button_receipt.Name = "button_receipt";
            this.button_receipt.Size = new System.Drawing.Size(239, 45);
            this.button_receipt.TabIndex = 1;
            this.button_receipt.Text = "Print Receipt";
            this.button_receipt.UseVisualStyleBackColor = true;
            this.button_receipt.Click += new System.EventHandler(this.button_receipt_Click);
            // 
            // button_clockIn
            // 
            this.button_clockIn.Location = new System.Drawing.Point(12, 142);
            this.button_clockIn.Name = "button_clockIn";
            this.button_clockIn.Size = new System.Drawing.Size(239, 45);
            this.button_clockIn.TabIndex = 2;
            this.button_clockIn.Text = "Clock In";
            this.button_clockIn.UseVisualStyleBackColor = true;
            this.button_clockIn.Click += new System.EventHandler(this.button_clockIn_Click);
            // 
            // button_clockOut
            // 
            this.button_clockOut.Location = new System.Drawing.Point(12, 209);
            this.button_clockOut.Name = "button_clockOut";
            this.button_clockOut.Size = new System.Drawing.Size(239, 45);
            this.button_clockOut.TabIndex = 3;
            this.button_clockOut.Text = "Clock Out";
            this.button_clockOut.UseVisualStyleBackColor = true;
            this.button_clockOut.Click += new System.EventHandler(this.button_clockOut_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(0, 437);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(72, 23);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_hReceipt
            // 
            this.button_hReceipt.BackColor = System.Drawing.Color.Transparent;
            this.button_hReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hReceipt.Image = global::HackathonProject_Spring2021.Properties.Resources.question1;
            this.button_hReceipt.Location = new System.Drawing.Point(243, 100);
            this.button_hReceipt.Name = "button_hReceipt";
            this.button_hReceipt.Size = new System.Drawing.Size(27, 26);
            this.button_hReceipt.TabIndex = 5;
            this.button_hReceipt.UseVisualStyleBackColor = false;
            this.button_hReceipt.Click += new System.EventHandler(this.button_help_Click);
            // 
            // button_hIn
            // 
            this.button_hIn.BackColor = System.Drawing.Color.Transparent;
            this.button_hIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hIn.Image = global::HackathonProject_Spring2021.Properties.Resources.question1;
            this.button_hIn.Location = new System.Drawing.Point(243, 171);
            this.button_hIn.Name = "button_hIn";
            this.button_hIn.Size = new System.Drawing.Size(27, 26);
            this.button_hIn.TabIndex = 6;
            this.button_hIn.UseVisualStyleBackColor = false;
            this.button_hIn.Click += new System.EventHandler(this.button_hIn_Click);
            // 
            // button_hOut
            // 
            this.button_hOut.BackColor = System.Drawing.Color.Transparent;
            this.button_hOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hOut.Image = global::HackathonProject_Spring2021.Properties.Resources.question1;
            this.button_hOut.Location = new System.Drawing.Point(243, 238);
            this.button_hOut.Name = "button_hOut";
            this.button_hOut.Size = new System.Drawing.Size(27, 26);
            this.button_hOut.TabIndex = 7;
            this.button_hOut.UseVisualStyleBackColor = false;
            this.button_hOut.Click += new System.EventHandler(this.button_hOut_Click);
            // 
            // button_hRefund
            // 
            this.button_hRefund.BackColor = System.Drawing.Color.Transparent;
            this.button_hRefund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hRefund.Image = global::HackathonProject_Spring2021.Properties.Resources.question1;
            this.button_hRefund.Location = new System.Drawing.Point(243, 42);
            this.button_hRefund.Name = "button_hRefund";
            this.button_hRefund.Size = new System.Drawing.Size(27, 26);
            this.button_hRefund.TabIndex = 8;
            this.button_hRefund.UseVisualStyleBackColor = false;
            this.button_hRefund.Click += new System.EventHandler(this.button_hRefund_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(12, 280);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(239, 45);
            this.button_reset.TabIndex = 9;
            this.button_reset.Text = "Reset Order";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_hReset
            // 
            this.button_hReset.BackColor = System.Drawing.Color.Transparent;
            this.button_hReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_hReset.Image = global::HackathonProject_Spring2021.Properties.Resources.question1;
            this.button_hReset.Location = new System.Drawing.Point(239, 309);
            this.button_hReset.Name = "button_hReset";
            this.button_hReset.Size = new System.Drawing.Size(27, 26);
            this.button_hReset.TabIndex = 10;
            this.button_hReset.UseVisualStyleBackColor = false;
            this.button_hReset.Click += new System.EventHandler(this.button_hReset_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 350);
            this.Controls.Add(this.button_hReset);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_hRefund);
            this.Controls.Add(this.button_hOut);
            this.Controls.Add(this.button_hIn);
            this.Controls.Add(this.button_hReceipt);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_clockOut);
            this.Controls.Add(this.button_clockIn);
            this.Controls.Add(this.button_receipt);
            this.Controls.Add(this.button_refund);
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_refund;
        private System.Windows.Forms.Button button_receipt;
        private System.Windows.Forms.Button button_clockIn;
        private System.Windows.Forms.Button button_clockOut;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_hReceipt;
        private System.Windows.Forms.Button button_hIn;
        private System.Windows.Forms.Button button_hOut;
        private System.Windows.Forms.Button button_hRefund;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_hReset;
    }
}