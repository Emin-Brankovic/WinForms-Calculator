namespace FITCalculator2024
{
    partial class frmCalculator
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
            btnEquals = new Button();
            btnSubtraction = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            btnMultiplication = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            btnDivision = new Button();
            button14 = new Button();
            btnClearErr = new Button();
            btnClearAll = new Button();
            btnBackspace = new Button();
            txtDisplay = new TextBox();
            btnNegate = new Button();
            button19 = new Button();
            btnDecimalPoint = new Button();
            btnAddition = new Button();
            lblBuffer = new Label();
            SuspendLayout();
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(9, 368);
            btnEquals.Margin = new Padding(3, 4, 3, 4);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(286, 64);
            btnEquals.TabIndex = 21;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtraction.Location = new Point(229, 261);
            btnSubtraction.Margin = new Padding(3, 4, 3, 4);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(66, 45);
            btnSubtraction.TabIndex = 17;
            btnSubtraction.Text = "-";
            btnSubtraction.TextAlign = ContentAlignment.TopCenter;
            btnSubtraction.UseVisualStyleBackColor = true;
            btnSubtraction.Click += btnSubtraction_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(155, 261);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(66, 45);
            button3.TabIndex = 16;
            button3.Text = "3";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Clicked;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(82, 261);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(66, 45);
            button4.TabIndex = 15;
            button4.Text = "2";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton_Clicked;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(9, 261);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(66, 45);
            button5.TabIndex = 14;
            button5.Text = "1";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton_Clicked;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(9, 208);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.Yes;
            button6.Size = new Size(66, 45);
            button6.TabIndex = 10;
            button6.Text = "4";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Clicked;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(82, 208);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(66, 45);
            button7.TabIndex = 11;
            button7.Text = "5";
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumberButton_Clicked;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(155, 208);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(66, 45);
            button8.TabIndex = 12;
            button8.Text = "6";
            button8.TextAlign = ContentAlignment.TopCenter;
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumberButton_Clicked;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplication.Location = new Point(229, 208);
            btnMultiplication.Margin = new Padding(3, 4, 3, 4);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(66, 45);
            btnMultiplication.TabIndex = 13;
            btnMultiplication.Text = "*";
            btnMultiplication.TextAlign = ContentAlignment.TopCenter;
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(9, 155);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.RightToLeft = RightToLeft.Yes;
            button10.Size = new Size(66, 45);
            button10.TabIndex = 5;
            button10.Text = "7";
            button10.TextAlign = ContentAlignment.TopCenter;
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButton_Clicked;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(82, 155);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(66, 45);
            button11.TabIndex = 6;
            button11.Text = "8";
            button11.TextAlign = ContentAlignment.TopCenter;
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumberButton_Clicked;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(155, 155);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(66, 45);
            button12.TabIndex = 7;
            button12.Text = "9";
            button12.TextAlign = ContentAlignment.TopCenter;
            button12.UseVisualStyleBackColor = true;
            button12.Click += NumberButton_Clicked;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.Location = new Point(229, 155);
            btnDivision.Margin = new Padding(3, 4, 3, 4);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(66, 45);
            btnDivision.TabIndex = 8;
            btnDivision.Text = "÷";
            btnDivision.TextAlign = ContentAlignment.TopCenter;
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(9, 101);
            button14.Margin = new Padding(3, 4, 3, 4);
            button14.Name = "button14";
            button14.Size = new Size(66, 45);
            button14.TabIndex = 1;
            button14.Text = "%";
            button14.TextAlign = ContentAlignment.TopCenter;
            button14.UseVisualStyleBackColor = true;
            // 
            // btnClearErr
            // 
            btnClearErr.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearErr.Location = new Point(82, 101);
            btnClearErr.Margin = new Padding(3, 4, 3, 4);
            btnClearErr.Name = "btnClearErr";
            btnClearErr.Size = new Size(66, 45);
            btnClearErr.TabIndex = 2;
            btnClearErr.Text = "CE";
            btnClearErr.TextAlign = ContentAlignment.TopCenter;
            btnClearErr.UseVisualStyleBackColor = true;
            btnClearErr.Click += btnClearErr_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearAll.Location = new Point(155, 101);
            btnClearAll.Margin = new Padding(3, 4, 3, 4);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(66, 45);
            btnClearAll.TabIndex = 3;
            btnClearAll.Text = "C";
            btnClearAll.TextAlign = ContentAlignment.TopCenter;
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackspace.Location = new Point(229, 101);
            btnBackspace.Margin = new Padding(3, 4, 3, 4);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(66, 45);
            btnBackspace.TabIndex = 4;
            btnBackspace.Text = "<";
            btnBackspace.TextAlign = ContentAlignment.TopCenter;
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay.Location = new Point(9, 36);
            txtDisplay.Margin = new Padding(3, 4, 3, 4);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(285, 52);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.KeyPress += txtDisplay_KeyPress;
            // 
            // btnNegate
            // 
            btnNegate.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnNegate.Location = new Point(9, 315);
            btnNegate.Margin = new Padding(3, 4, 3, 4);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(66, 45);
            btnNegate.TabIndex = 18;
            btnNegate.Text = "±";
            btnNegate.TextAlign = ContentAlignment.TopCenter;
            btnNegate.UseVisualStyleBackColor = true;
            btnNegate.Click += btnNegate_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(82, 315);
            button19.Margin = new Padding(3, 4, 3, 4);
            button19.Name = "button19";
            button19.Size = new Size(66, 45);
            button19.TabIndex = 19;
            button19.Text = "0";
            button19.TextAlign = ContentAlignment.TopCenter;
            button19.UseVisualStyleBackColor = true;
            button19.Click += NumberButton_Clicked;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimalPoint.Location = new Point(155, 315);
            btnDecimalPoint.Margin = new Padding(3, 4, 3, 4);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(66, 45);
            btnDecimalPoint.TabIndex = 20;
            btnDecimalPoint.Text = ",";
            btnDecimalPoint.TextAlign = ContentAlignment.TopCenter;
            btnDecimalPoint.UseVisualStyleBackColor = true;
            btnDecimalPoint.Click += NumberButton_Clicked;
            // 
            // btnAddition
            // 
            btnAddition.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddition.Location = new Point(229, 315);
            btnAddition.Margin = new Padding(3, 4, 3, 4);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(66, 45);
            btnAddition.TabIndex = 20;
            btnAddition.Text = "+";
            btnAddition.TextAlign = ContentAlignment.TopCenter;
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // lblBuffer
            // 
            lblBuffer.AutoSize = true;
            lblBuffer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuffer.Location = new Point(14, 12);
            lblBuffer.Name = "lblBuffer";
            lblBuffer.Size = new Size(0, 20);
            lblBuffer.TabIndex = 22;
            lblBuffer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 443);
            Controls.Add(lblBuffer);
            Controls.Add(btnNegate);
            Controls.Add(button19);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btnAddition);
            Controls.Add(txtDisplay);
            Controls.Add(button14);
            Controls.Add(btnClearErr);
            Controls.Add(btnClearAll);
            Controls.Add(btnBackspace);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(btnDivision);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(btnMultiplication);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnSubtraction);
            Controls.Add(btnEquals);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmCalculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEquals;
        private Button btnSubtraction;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnMultiplication;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btnDivision;
        private Button button14;
        private Button btnClearErr;
        private Button btnClearAll;
        private Button btnBackspace;
        private TextBox txtDisplay;
        private Button btnNegate;
        private Button button19;
        private Button btnDecimalPoint;
        private Button btnAddition;
        private Label lblBuffer;
    }
}