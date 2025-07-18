namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 + num2;
            if (result == 0)
            {
                MessageBox.Show("Zero");
            }
            else
            {
                MessageBox.Show("Your Result is :" + result);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 - num2;
            if (result == 0)
            {
                MessageBox.Show("Zero");
            }
            else
            {
                MessageBox.Show("Your Result is :" + result);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 * num2;
            if (result == 0)
            {
                MessageBox.Show("Zero");
            }
            else
            {
                MessageBox.Show("Your Result is " + result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 / num2;
            if (result == 0)
            {
                MessageBox.Show("Zero");
            }
            else
            {
                MessageBox.Show("Your Result is :" + result);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 % num2;
            if (result == 0)
            {
                MessageBox.Show("Zero");
            }
            else
            {
                MessageBox.Show("Your Result is :" + result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
