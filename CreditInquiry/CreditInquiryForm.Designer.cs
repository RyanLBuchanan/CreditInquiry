namespace CreditInquiry
{
    partial class CreditInquiryForm
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
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.getBalancesButton = new System.Windows.Forms.Button();
            this.debitButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(24, 25);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(736, 360);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.Text = "";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(24, 408);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(130, 35);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // getBalancesButton
            // 
            this.getBalancesButton.Location = new System.Drawing.Point(176, 408);
            this.getBalancesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getBalancesButton.Name = "getBalancesButton";
            this.getBalancesButton.Size = new System.Drawing.Size(130, 35);
            this.getBalancesButton.TabIndex = 2;
            this.getBalancesButton.Text = "Credit Balances";
            this.getBalancesButton.UseVisualStyleBackColor = true;
            this.getBalancesButton.Click += new System.EventHandler(this.getBalancesButton_Click);
            // 
            // debitButton
            // 
            this.debitButton.Location = new System.Drawing.Point(328, 408);
            this.debitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(130, 35);
            this.debitButton.TabIndex = 3;
            this.debitButton.Text = "Debit Balances";
            this.debitButton.UseVisualStyleBackColor = true;
            this.debitButton.Click += new System.EventHandler(this.getBalancesButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(480, 408);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(130, 35);
            this.zeroButton.TabIndex = 4;
            this.zeroButton.Text = "Zero Balances";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.getBalancesButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(632, 408);
            this.doneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(130, 35);
            this.doneButton.TabIndex = 5;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // CreditInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.getBalancesButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.displayTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreditInquiryForm";
            this.Text = "Credit Inquiry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button getBalancesButton;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button doneButton;
    }
}

