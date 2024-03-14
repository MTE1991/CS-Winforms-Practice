using System.IO;

namespace WFDemo
{
    public partial class Form1 : Form
    {
        private string filePath = @"F:\Coding Practice\WFDemoApp\WFDemo\data.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please choose your department.");
                return;
            }
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Designation cannot be empty!");
                return;
            }
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"{textBox1.Text},{textBox3.Text},{comboBox1.Text},{numericUpDown1.Value},{numericUpDown2.Value}");
            }
            MessageBox.Show("Information collection successful!");
        }
    }
}
