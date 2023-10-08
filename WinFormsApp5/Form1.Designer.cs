namespace WinFormsApp5
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
            Cal0 = new Button();
            CalDot = new Button();
            calAssign = new Button();
            calPlus = new Button();
            carNegative = new Button();
            calMultiple = new Button();
            calDivision = new Button();
            cal3 = new Button();
            cal1 = new Button();
            cal2 = new Button();
            cal6 = new Button();
            cal5 = new Button();
            cal4 = new Button();
            cal9 = new Button();
            cal8 = new Button();
            cal7 = new Button();
            calFaiz = new Button();
            calDelete = new Button();
            calAllDelete = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Cal0
            // 
            Cal0.Location = new Point(1, 225);
            Cal0.Name = "Cal0";
            Cal0.Size = new Size(155, 47);
            Cal0.TabIndex = 0;
            Cal0.Text = "0";
            Cal0.UseVisualStyleBackColor = true;
            Cal0.Click += Cal0_Click;
            // 
            // CalDot
            // 
            CalDot.Location = new Point(162, 223);
            CalDot.Name = "CalDot";
            CalDot.Size = new Size(75, 48);
            CalDot.TabIndex = 1;
            CalDot.Text = ".";
            CalDot.UseVisualStyleBackColor = true;
            // 
            // calAssign
            // 
            calAssign.BackColor = Color.Blue;
            calAssign.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calAssign.ForeColor = Color.White;
            calAssign.Location = new Point(243, 223);
            calAssign.Name = "calAssign";
            calAssign.Size = new Size(57, 49);
            calAssign.TabIndex = 3;
            calAssign.Text = "=";
            calAssign.UseVisualStyleBackColor = false;
            calAssign.Click += calAssign_Click;
            // 
            // calPlus
            // 
            calPlus.BackColor = Color.Blue;
            calPlus.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calPlus.ForeColor = Color.White;
            calPlus.Location = new Point(243, 170);
            calPlus.Name = "calPlus";
            calPlus.Size = new Size(58, 48);
            calPlus.TabIndex = 4;
            calPlus.Text = "+";
            calPlus.UseVisualStyleBackColor = false;
            calPlus.Click += calPlus_Click;
            // 
            // carNegative
            // 
            carNegative.BackColor = Color.Blue;
            carNegative.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            carNegative.ForeColor = Color.White;
            carNegative.Location = new Point(243, 117);
            carNegative.Name = "carNegative";
            carNegative.Size = new Size(58, 48);
            carNegative.TabIndex = 5;
            carNegative.Text = "-";
            carNegative.UseVisualStyleBackColor = false;
            carNegative.Click += carNegative_Click;
            // 
            // calMultiple
            // 
            calMultiple.BackColor = Color.Blue;
            calMultiple.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calMultiple.ForeColor = Color.White;
            calMultiple.Location = new Point(243, 63);
            calMultiple.Name = "calMultiple";
            calMultiple.Size = new Size(58, 48);
            calMultiple.TabIndex = 6;
            calMultiple.Text = "*";
            calMultiple.UseVisualStyleBackColor = false;
            calMultiple.Click += calMultiple_Click;
            // 
            // calDivision
            // 
            calDivision.AutoEllipsis = true;
            calDivision.BackColor = Color.Blue;
            calDivision.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calDivision.ForeColor = Color.White;
            calDivision.Location = new Point(243, 9);
            calDivision.Name = "calDivision";
            calDivision.Size = new Size(58, 48);
            calDivision.TabIndex = 7;
            calDivision.Text = "/";
            calDivision.UseVisualStyleBackColor = false;
            calDivision.Click += calDivision_Click;
            // 
            // cal3
            // 
            cal3.Location = new Point(162, 171);
            cal3.Name = "cal3";
            cal3.Size = new Size(75, 48);
            cal3.TabIndex = 9;
            cal3.Text = "3";
            cal3.UseVisualStyleBackColor = true;
            cal3.Click += cal3_Click;
            // 
            // cal1
            // 
            cal1.Location = new Point(1, 171);
            cal1.Name = "cal1";
            cal1.Size = new Size(74, 48);
            cal1.TabIndex = 10;
            cal1.Text = "1";
            cal1.UseVisualStyleBackColor = true;
            cal1.Click += cal1_Click;
            // 
            // cal2
            // 
            cal2.Location = new Point(81, 171);
            cal2.Name = "cal2";
            cal2.Size = new Size(75, 48);
            cal2.TabIndex = 11;
            cal2.Text = "2";
            cal2.UseVisualStyleBackColor = true;
            cal2.Click += cal2_Click;
            // 
            // cal6
            // 
            cal6.Location = new Point(162, 117);
            cal6.Name = "cal6";
            cal6.Size = new Size(75, 48);
            cal6.TabIndex = 12;
            cal6.Text = "6";
            cal6.UseVisualStyleBackColor = true;
            cal6.Click += cal6_Click;
            // 
            // cal5
            // 
            cal5.Location = new Point(81, 117);
            cal5.Name = "cal5";
            cal5.Size = new Size(75, 48);
            cal5.TabIndex = 13;
            cal5.Text = "5";
            cal5.UseVisualStyleBackColor = true;
            cal5.Click += cal5_Click;
            // 
            // cal4
            // 
            cal4.Location = new Point(0, 117);
            cal4.Name = "cal4";
            cal4.Size = new Size(75, 48);
            cal4.TabIndex = 14;
            cal4.Text = "4";
            cal4.UseVisualStyleBackColor = true;
            cal4.Click += cal4_Click;
            // 
            // cal9
            // 
            cal9.Location = new Point(162, 63);
            cal9.Name = "cal9";
            cal9.Size = new Size(75, 48);
            cal9.TabIndex = 15;
            cal9.Text = "9";
            cal9.UseVisualStyleBackColor = true;
            cal9.Click += cal9_Click;
            // 
            // cal8
            // 
            cal8.Location = new Point(81, 63);
            cal8.Name = "cal8";
            cal8.Size = new Size(75, 48);
            cal8.TabIndex = 16;
            cal8.Text = "8";
            cal8.UseVisualStyleBackColor = true;
            cal8.Click += cal8_Click;
            // 
            // cal7
            // 
            cal7.Location = new Point(1, 63);
            cal7.Name = "cal7";
            cal7.Size = new Size(75, 48);
            cal7.TabIndex = 17;
            cal7.Text = "7";
            cal7.UseVisualStyleBackColor = true;
            cal7.Click += cal7_Click;
            // 
            // calFaiz
            // 
            calFaiz.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calFaiz.Location = new Point(162, 9);
            calFaiz.Name = "calFaiz";
            calFaiz.Size = new Size(75, 48);
            calFaiz.TabIndex = 18;
            calFaiz.Text = "%";
            calFaiz.UseVisualStyleBackColor = true;
            calFaiz.Click += calFaiz_Click;
            // 
            // calDelete
            // 
            calDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            calDelete.Location = new Point(81, 9);
            calDelete.Name = "calDelete";
            calDelete.Size = new Size(75, 48);
            calDelete.TabIndex = 19;
            calDelete.Text = "Delete";
            calDelete.UseVisualStyleBackColor = true;
            calDelete.Click += calDelete_Click;
            // 
            // calAllDelete
            // 
            calAllDelete.BackColor = Color.DarkOrange;
            calAllDelete.Location = new Point(1, 9);
            calAllDelete.Name = "calAllDelete";
            calAllDelete.Size = new Size(75, 48);
            calAllDelete.TabIndex = 20;
            calAllDelete.Text = "C";
            calAllDelete.UseVisualStyleBackColor = false;
            calAllDelete.Click += calAllDelete_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(calAllDelete);
            panel1.Controls.Add(calDelete);
            panel1.Controls.Add(calFaiz);
            panel1.Controls.Add(cal7);
            panel1.Controls.Add(cal8);
            panel1.Controls.Add(cal9);
            panel1.Controls.Add(cal4);
            panel1.Controls.Add(cal5);
            panel1.Controls.Add(cal6);
            panel1.Controls.Add(cal2);
            panel1.Controls.Add(cal1);
            panel1.Controls.Add(cal3);
            panel1.Controls.Add(calDivision);
            panel1.Controls.Add(calMultiple);
            panel1.Controls.Add(carNegative);
            panel1.Controls.Add(calPlus);
            panel1.Controls.Add(calAssign);
            panel1.Controls.Add(CalDot);
            panel1.Controls.Add(Cal0);
            panel1.Location = new Point(2, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 277);
            panel1.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(1, -1);
            textBox1.MinimumSize = new Size(304, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 225);
            textBox1.TabIndex = 23;
            textBox1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(305, 495);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cal0;
        private Button CalDot;
        private Button calAssign;
        private Button calPlus;
        private Button carNegative;
        private Button calMultiple;
        private Button calDivision;
        private Button cal3;
        private Button cal1;
        private Button cal2;
        private Button cal6;
        private Button cal5;
        private Button cal4;
        private Button cal9;
        private Button cal8;
        private Button cal7;
        private Button calFaiz;
        private Button calDelete;
        private Button calAllDelete;
        private Panel panel1;
        private TextBox textBox1;
    }
}