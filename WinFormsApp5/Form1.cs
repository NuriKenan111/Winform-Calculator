namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        double fNum;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cal1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }
        private void cal2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void cal3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void cal4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void cal5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void cal6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void cal7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";

        }

        private void cal8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void cal9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void Cal0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";

            else textBox1.Text = textBox1.Text + "0";
        }
        private void calDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || string.IsNullOrEmpty(textBox1.Text))
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
        }
        private void calAllDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void calPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";
            else
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "+";
                Operation = "+";

            }
        }

        private void carNegative_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";
            else
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "-";
                Operation = "-";
            }
        }

        private void calMultiple_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";
            else
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "*";
                Operation = "*";
            }
        }

        private void calDivision_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";
            else
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "/";
                Operation = "/";
            }
        }
        private void calFaiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";
            else
            {
                fNum = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "%";
                Operation = "%";
            }
        }
        private void calAssign_Click(object sender, EventArgs e)
        {
            try
            {
                double res;
                int operationIndex = textBox1.Text.IndexOf(Operation);
                double sNum = Convert.ToDouble(textBox1.Text.Substring(operationIndex + 1));


                if (Operation == "+")
                {
                    res = (fNum + sNum);
                    textBox1.Text = res.ToString();
                    fNum = res;
                }
                else if (Operation == "-")
                {
                    res = (fNum - sNum);
                    textBox1.Text = res.ToString();
                    fNum = res;
                }
                else if (Operation == "*")
                {
                    res = (fNum * sNum);
                    textBox1.Text = res.ToString();
                    fNum = res;
                }
                else if (Operation == "%")
                {
                    res = (fNum % sNum);
                    textBox1.Text = res.ToString();
                    fNum = res;
                }
                else if (Operation == "/")
                {
                    if (sNum == 0) MessageBox.Show("Cannot divide by zero");
                    else
                    {
                        res = (fNum / sNum);
                        textBox1.Text = res.ToString();
                        fNum = res;
                    }
                }
                Operation = null;
            }
            catch
            {
                MessageBox.Show("Wrong Choice");
            }


        }


    }
}