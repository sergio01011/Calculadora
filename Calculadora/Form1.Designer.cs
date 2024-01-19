namespace Calculadora
{
    partial class Calculadora
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
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnNum6 = new Button();
            btnNum5 = new Button();
            btnNum4 = new Button();
            btnNum3 = new Button();
            btnNum2 = new Button();
            btnNum1 = new Button();
            btnOpAdd = new Button();
            btnOpSubs = new Button();
            btnOpMult = new Button();
            btnEquals = new Button();
            btnNum0 = new Button();
            btnClear = new Button();
            txtValue = new TextBox();
            btnOpDiv = new Button();
            SuspendLayout();
            // 
            // btnNum7
            // 
            btnNum7.Font = new Font("Georgia", 15.75F);
            btnNum7.Location = new Point(25, 135);
            btnNum7.Margin = new Padding(4);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(103, 107);
            btnNum7.TabIndex = 0;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += NumberAction_Click;
            // 
            // btnNum8
            // 
            btnNum8.Font = new Font("Georgia", 15.75F);
            btnNum8.Location = new Point(147, 135);
            btnNum8.Margin = new Padding(4);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(103, 107);
            btnNum8.TabIndex = 1;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += NumberAction_Click;
            // 
            // btnNum9
            // 
            btnNum9.Font = new Font("Georgia", 15.75F);
            btnNum9.Location = new Point(275, 135);
            btnNum9.Margin = new Padding(4);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(103, 107);
            btnNum9.TabIndex = 2;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += NumberAction_Click;
            // 
            // btnNum6
            // 
            btnNum6.Font = new Font("Georgia", 15.75F);
            btnNum6.Location = new Point(275, 274);
            btnNum6.Margin = new Padding(4);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(103, 107);
            btnNum6.TabIndex = 5;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += NumberAction_Click;
            // 
            // btnNum5
            // 
            btnNum5.Font = new Font("Georgia", 15.75F);
            btnNum5.Location = new Point(147, 274);
            btnNum5.Margin = new Padding(4);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(103, 107);
            btnNum5.TabIndex = 4;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += NumberAction_Click;
            // 
            // btnNum4
            // 
            btnNum4.Font = new Font("Georgia", 15.75F);
            btnNum4.Location = new Point(25, 274);
            btnNum4.Margin = new Padding(4);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(103, 107);
            btnNum4.TabIndex = 3;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += NumberAction_Click;
            // 
            // btnNum3
            // 
            btnNum3.Font = new Font("Georgia", 15.75F);
            btnNum3.Location = new Point(275, 398);
            btnNum3.Margin = new Padding(4);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(103, 107);
            btnNum3.TabIndex = 8;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += NumberAction_Click;
            // 
            // btnNum2
            // 
            btnNum2.Font = new Font("Georgia", 15.75F);
            btnNum2.Location = new Point(147, 398);
            btnNum2.Margin = new Padding(4);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(103, 107);
            btnNum2.TabIndex = 7;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += NumberAction_Click;
            // 
            // btnNum1
            // 
            btnNum1.Font = new Font("Georgia", 15.75F);
            btnNum1.Location = new Point(25, 398);
            btnNum1.Margin = new Padding(4);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(103, 107);
            btnNum1.TabIndex = 6;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += NumberAction_Click;
            // 
            // btnOpAdd
            // 
            btnOpAdd.Font = new Font("Georgia", 15.75F);
            btnOpAdd.Location = new Point(403, 135);
            btnOpAdd.Margin = new Padding(4);
            btnOpAdd.Name = "btnOpAdd";
            btnOpAdd.Size = new Size(103, 107);
            btnOpAdd.TabIndex = 9;
            btnOpAdd.Text = "+";
            btnOpAdd.UseVisualStyleBackColor = true;
            btnOpAdd.Click += OperatorAction_Click;
            // 
            // btnOpSubs
            // 
            btnOpSubs.Font = new Font("Georgia", 15.75F);
            btnOpSubs.Location = new Point(403, 274);
            btnOpSubs.Margin = new Padding(4);
            btnOpSubs.Name = "btnOpSubs";
            btnOpSubs.Size = new Size(103, 107);
            btnOpSubs.TabIndex = 10;
            btnOpSubs.Text = "-";
            btnOpSubs.UseVisualStyleBackColor = true;
            btnOpSubs.Click += OperatorAction_Click;
            // 
            // btnOpMult
            // 
            btnOpMult.Font = new Font("Georgia", 15.75F);
            btnOpMult.Location = new Point(403, 398);
            btnOpMult.Margin = new Padding(4);
            btnOpMult.Name = "btnOpMult";
            btnOpMult.Size = new Size(103, 107);
            btnOpMult.TabIndex = 11;
            btnOpMult.Text = "*";
            btnOpMult.UseVisualStyleBackColor = true;
            btnOpMult.Click += OperatorAction_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Georgia", 15.75F);
            btnEquals.Location = new Point(275, 530);
            btnEquals.Margin = new Padding(4);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(103, 107);
            btnEquals.TabIndex = 14;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnNum0
            // 
            btnNum0.Font = new Font("Georgia", 15.75F);
            btnNum0.Location = new Point(147, 530);
            btnNum0.Margin = new Padding(4);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(103, 107);
            btnNum0.TabIndex = 13;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += NumberAction_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Georgia", 15.75F);
            btnClear.Location = new Point(25, 530);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 107);
            btnClear.TabIndex = 12;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Georgia", 15.75F);
            txtValue.Location = new Point(25, 54);
            txtValue.Margin = new Padding(4);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(481, 31);
            txtValue.TabIndex = 15;
            txtValue.Text = "0";
            txtValue.TextAlign = HorizontalAlignment.Right;
            // 
            // btnOpDiv
            // 
            btnOpDiv.Font = new Font("Georgia", 15.75F);
            btnOpDiv.Location = new Point(403, 530);
            btnOpDiv.Margin = new Padding(4);
            btnOpDiv.Name = "btnOpDiv";
            btnOpDiv.Size = new Size(103, 107);
            btnOpDiv.TabIndex = 16;
            btnOpDiv.Text = "/";
            btnOpDiv.UseVisualStyleBackColor = true;
            btnOpDiv.Click += OperatorAction_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 659);
            Controls.Add(btnOpDiv);
            Controls.Add(txtValue);
            Controls.Add(btnEquals);
            Controls.Add(btnNum0);
            Controls.Add(btnClear);
            Controls.Add(btnOpMult);
            Controls.Add(btnOpSubs);
            Controls.Add(btnOpAdd);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnNum6;
        private Button btnNum5;
        private Button btnNum4;
        private Button btnNum3;
        private Button btnNum2;
        private Button button9;
        private Button btnOpAdd;
        private Button btnOpSubs;
        private Button btnOpMult;
        private Button btnEquals;
        private Button btnNum0;
        private Button btnClear;
        private TextBox txtValue;
        private Button btnOpDiv;
        private Button btnNum1;
    }
}
