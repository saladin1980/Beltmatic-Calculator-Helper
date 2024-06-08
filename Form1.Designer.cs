namespace Beltmatic_Calculator_Helper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTargetNumber = new TextBox();
            button1 = new Button();
            txtResult = new Label();
            txtExecutionTime = new Label();
            txtMaxBaseNumber = new NumericUpDown();
            listCheckOperations = new CheckedListBox();
            lblOperation = new Label();
            lblTargetNumber = new Label();
            lblBaseNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)txtMaxBaseNumber).BeginInit();
            SuspendLayout();
            // 
            // txtTargetNumber
            // 
            txtTargetNumber.Location = new Point(12, 30);
            txtTargetNumber.Name = "txtTargetNumber";
            txtTargetNumber.PlaceholderText = "11";
            txtTargetNumber.Size = new Size(100, 23);
            txtTargetNumber.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(15, 103);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnFindExpression_Click;
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.ForeColor = Color.Orange;
            txtResult.Location = new Point(33, 166);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(44, 15);
            txtResult.TabIndex = 4;
            txtResult.Text = "Results";
            // 
            // txtExecutionTime
            // 
            txtExecutionTime.AutoSize = true;
            txtExecutionTime.Location = new Point(15, 133);
            txtExecutionTime.Name = "txtExecutionTime";
            txtExecutionTime.Size = new Size(33, 15);
            txtExecutionTime.TabIndex = 5;
            txtExecutionTime.Text = "Time";
            // 
            // txtMaxBaseNumber
            // 
            txtMaxBaseNumber.Location = new Point(15, 74);
            txtMaxBaseNumber.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            txtMaxBaseNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtMaxBaseNumber.Name = "txtMaxBaseNumber";
            txtMaxBaseNumber.Size = new Size(120, 23);
            txtMaxBaseNumber.TabIndex = 6;
            txtMaxBaseNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listCheckOperations
            // 
            listCheckOperations.FormattingEnabled = true;
            listCheckOperations.Items.AddRange(new object[] { "Addition", "Multiplication", "Subtraction", "Division" });
            listCheckOperations.Location = new Point(161, 54);
            listCheckOperations.Name = "listCheckOperations";
            listCheckOperations.Size = new Size(120, 94);
            listCheckOperations.TabIndex = 11;
            listCheckOperations.ItemCheck += listCheckOperations_ItemCheck;
            // 
            // lblOperation
            // 
            lblOperation.AutoSize = true;
            lblOperation.Location = new Point(164, 33);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(68, 15);
            lblOperation.TabIndex = 12;
            lblOperation.Text = "Operations:";
            // 
            // lblTargetNumber
            // 
            lblTargetNumber.AutoSize = true;
            lblTargetNumber.Location = new Point(12, 9);
            lblTargetNumber.Name = "lblTargetNumber";
            lblTargetNumber.Size = new Size(86, 15);
            lblTargetNumber.TabIndex = 13;
            lblTargetNumber.Text = "Target Number";
            // 
            // lblBaseNumber
            // 
            lblBaseNumber.AutoSize = true;
            lblBaseNumber.Location = new Point(12, 56);
            lblBaseNumber.Name = "lblBaseNumber";
            lblBaseNumber.Size = new Size(83, 15);
            lblBaseNumber.TabIndex = 14;
            lblBaseNumber.Text = "Base Numbers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 203);
            Controls.Add(lblBaseNumber);
            Controls.Add(lblTargetNumber);
            Controls.Add(lblOperation);
            Controls.Add(listCheckOperations);
            Controls.Add(txtMaxBaseNumber);
            Controls.Add(txtExecutionTime);
            Controls.Add(txtResult);
            Controls.Add(button1);
            Controls.Add(txtTargetNumber);
            Name = "Form1";
            Text = "Beltmatix Calc";
            ((System.ComponentModel.ISupportInitialize)txtMaxBaseNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTargetNumber;
        private Button button1;
        private Label txtResult;
        private Label txtExecutionTime;
        private NumericUpDown txtMaxBaseNumber;
        private Label lblOperation;
        public CheckedListBox listCheckOperations;
        private Label lblTargetNumber;
        private Label lblBaseNumber;
    }
}
