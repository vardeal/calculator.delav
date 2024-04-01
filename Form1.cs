using Microsoft.VisualBasic.Devices;

namespace calculator.delav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
     
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" && num2.Text != "") { string[] num1, num2; } 
            else { MessageBox.Show("can't sum one vaule");  return; }
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            Result.Text = (x + y) + "   ";

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" && num2.Text != "") { string[] num1, num2; }
            else { MessageBox.Show("can't sub one vaule"); return; }
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            
           
            Result.Text = (x - y) + "   ";
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" && num2.Text != "") { string[] num1, num2; }
            else { MessageBox.Show("can't div one vaule"); return; }
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            Result.Text = (x / y) + "   ";
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" && num2.Text != "") { string[] num1, num2; }
            else { MessageBox.Show("can't multi one vaul"); return; }
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            Result.Text = (x * y) + "   ";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" || num2.Text != "") { string[] num1, num2; }
            else { MessageBox.Show("no vaule"); return; }

            try
            {
                double inputValue = Convert.ToDouble(num1.Text);

                double result = Math.Sqrt(inputValue);

                string Results = result.ToString();
                Result.Text = Results;

            }
            catch { Console.WriteLine("error "); }
        }

        private void cube_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" || num2.Text != "") { string[] num1, num2; }
            else { MessageBox.Show("no vaule"); return; }
            try
            {
                double inputValue = Convert.ToDouble(num1.Text);

                double result = Math.Cbrt(inputValue);

                Result.Text = result.ToString();

            }
            catch { Console.WriteLine("error "); }
          
        }
    }
}
